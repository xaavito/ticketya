Public Class VentaDAL

    Shared Function generarVenta(ByVal venta As BE.VentaBE, ByVal listaVentas As List(Of BE.DetalleVentaBE), ByVal pago As Boolean) As Object
        Dim result As Integer
        Dim idVenta As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim tranRepo As New RepositorioTransaccional(repository)
        Try
            tranRepo.crearComando("GENERAR_VENTA_SP")
            tranRepo.addParam("@comp", venta.comprador.identificador)
            tranRepo.addParam("@vend", venta.vendedor.identificador)
            If venta.promocion Is Nothing Then
                tranRepo.addParam("@promo", 0)
            Else
                tranRepo.addParam("@promo", venta.promocion.identificador)
            End If

            tranRepo.addParam("@total", venta.total)
            idVenta = tranRepo.executeSearch
            If (idVenta <= 0) Then
                Throw New Excepciones.GenerarVentaExcepcion
            End If
        Catch ex As Excepciones.ConexionImposibleExcepcion
            Throw New Excepciones.ConexionImposibleExcepcion
        Catch ex As Excepciones.InsertExcepcion
            Throw New Excepciones.InsertExcepcion
        End Try

        If idVenta > 0 Then
            Try
                For Each det As BE.DetalleVentaBE In listaVentas
                    tranRepo.crearComando("GENERAR_DETALLE_VENTA_SP")
                    tranRepo.addParam("@idVenta", idVenta)
                    tranRepo.addParam("@idFecha", det.idFecha)
                    tranRepo.addParam("@idSector", det.idSector)
                    tranRepo.addParam("@idShow", det.idShow)
                    tranRepo.addParam("@idSilla", det.idSilla)
                    result = tranRepo.executeSearchWithStatus
                    If (result <= 0) Then
                        Throw New Excepciones.GenerarDetalleVentaExcepcion
                    End If
                Next
            Catch ex As Excepciones.ConexionImposibleExcepcion
                Throw New Excepciones.ConexionImposibleExcepcion
            Catch ex As Excepciones.InsertExcepcion
                Throw New Excepciones.InsertExcepcion
            End Try
        End If

        If pago = True Then
            Try
                For Each det As BE.DetalleVentaBE In listaVentas
                    tranRepo.crearComando("GENERAR_PAGO_VENTA_SP")
                    tranRepo.addParam("@idVenta", idVenta)
                    tranRepo.addParam("@idFecha", det.idFecha)
                    tranRepo.addParam("@idSector", det.idSector)
                    tranRepo.addParam("@idShow", det.idShow)
                    tranRepo.addParam("@idSilla", det.idSilla)
                    result = tranRepo.executeSearchWithStatus
                    If (result <= 0) Then
                        Throw New Excepciones.GenerarPagoVentaExcepcion
                    End If
                Next
            Catch ex As Excepciones.ConexionImposibleExcepcion
                Throw New Excepciones.ConexionImposibleExcepcion
            Catch ex As Excepciones.InsertExcepcion
                Throw New Excepciones.InsertExcepcion
            End Try
        End If

        tranRepo.transactionOK()
        Return result
    End Function

    Shared Function buscarVenta(ByVal p1 As Date, ByVal p2 As Date, ByVal p5 As Integer) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.VentaBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_VENTAS_SP")

            repository.addParam("@fechaDesde", p1)
            repository.addParam("@fechaHasta", p2)
            repository.addParam("@vendedor", p5)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.VentasNoEncontradasExcepcion
            End If
            For Each row As DataRow In table.Rows
                Dim venta As New BE.VentaBE
                venta.identificador = row.Item(0)
                venta.total = row.Item(1)
                venta.comprador = DAL.UsuarioDAL.buscarUsuarioPorId(row.Item(2))
                venta.vendedor = DAL.UsuarioDAL.buscarUsuarioPorId(row.Item(3))
                venta.fecha = row.Item(4)
                lista.Add(venta)
            Next

        Catch ex As Excepciones.VentasNoEncontradasExcepcion
            Throw New Excepciones.VentasNoEncontradasExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarPromociones() As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.PromocionBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_PROMOCIONES_SP")

            'repository.addParam("@fechaDesde", p1)
            'repository.addParam("@fechaHasta", p2)
            'repository.addParam("@vendedor", p5)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.PromocionesNoEncontradasExcepcion
            End If
            For Each row As DataRow In table.Rows
                Dim promo As New BE.PromocionBE
                'SELECT p.identificador,p.descripcion,p.tipoDescuento,p.descuento,p.desde,p.hasta
                promo.identificador = row.Item(0)
                promo.descripcion = row.Item(1)
                promo.tipoDescuento = row.Item(2)
                promo.descuento = row.Item(3)
                promo.desde = row.Item(4)
                promo.hasta = row.Item(5)
                lista.Add(promo)
            Next

        Catch ex As Excepciones.PromocionesNoEncontradasExcepcion
            Throw New Excepciones.PromocionesNoEncontradasExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarPromocion(ByVal sector As Integer, ByVal fecha As Integer) As BE.PromocionBE
        Dim table As DataTable
        Dim result As BE.PromocionBE = Nothing
        Dim lista As New List(Of BE.PromocionBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_PROMOCION_SP")
            repository.addParam("@idSector", sector)
            repository.addParam("@idFecha", fecha)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.PromocionesNoEncontradasExcepcion
            End If
            For Each row As DataRow In table.Rows
                result = New BE.PromocionBE
                'SELECT p.identificador,p.descripcion,p.tipoDescuento,p.descuento,p.desde,p.hasta
                result.identificador = row.Item(0)
                result.descripcion = row.Item(1)
                result.tipoDescuento = row.Item(2)
                result.descuento = row.Item(3)
                result.desde = row.Item(4)
                result.hasta = row.Item(5)
                Dim fech As New BE.FechaBE
                fech.identificador = row.Item(6)
                result.fecha = fech
                Dim sect As New BE.SectorBE
                sect.identificador = row.Item(7)
                result.sector = sect
            Next

        Catch ex As Excepciones.PromocionesNoEncontradasExcepcion
            Throw New Excepciones.PromocionesNoEncontradasExcepcion
        End Try

        Return result
    End Function

    Shared Function generarPromocion(ByVal p1 As String, ByVal p2 As Date, ByVal p3 As Date, ByVal p4 As Integer, ByVal p5 As Decimal, ByVal p6 As Integer, ByVal p7 As Integer) As Object
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            'DescripcionTextBox.Text,
            'DesdeTextBox.getDateTime,
            'HastaTextBox.getDateTime,
            'TipoDescuentoComboBox.SelectedValue,
            'FechaComboBox.SelectedValue,
            'SectorComboBox.SelectedValue
            repository.crearComando("GENERAR_PROMOCION_SP")
            repository.addParam("@desc", p1)
            repository.addParam("@desde", p2)
            repository.addParam("@hasta", p3)
            repository.addParam("@tipo", p4)
            repository.addParam("@descuento", p5)
            repository.addParam("@fecha", p6)
            repository.addParam("@sector", p7)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.GenerarPromocionExcepcion
            Else
                Throw New Excepciones.PromocionCreadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.GenerarPromocionExcepcion
            Throw New Excepciones.GenerarPromocionExcepcion
        End Try

        Return result
    End Function

    Shared Sub checkearReservaPrevia(ByVal listaVentas As List(Of BE.DetalleVentaBE))
        Dim result As Integer
        Dim repository As IRepositorio = RepositorioFactory.Create()
        'Dim tranRepo As New RepositorioTransaccional(repository)

        For Each det As BE.DetalleVentaBE In listaVentas
            repository.crearComando("CHECKEAR_RESERVA_PREVIA_SP")
            repository.addParam("@idFecha", det.idFecha)
            repository.addParam("@idSector", det.idSector)
            repository.addParam("@idShow", det.idShow)
            repository.addParam("@idSilla", det.idSilla)
            result = repository.executeSearch
            If (result > 0) Then
                Throw New Excepciones.ReservasPreviaExcepcion
            End If
        Next

        Throw New Excepciones.SinReservasExcepcion
    End Sub

    Shared Function notificarMasDeUnaReserva(ByVal listaVentas As List(Of BE.DetalleVentaBE))
        Dim result As New List(Of BE.InforReservacion)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim table As DataTable

        'SELECT u.nombre,u.apellido,u.mail,sh.descripcion, fe.descripcion,fe.fecha,se.descripcion,si.columna,si.fila
        For Each det As BE.DetalleVentaBE In listaVentas
            repository.crearComando("BUSCAR_COMPRADOR_RESERVAS_SP")
            repository.addParam("@idFecha", det.idFecha)
            repository.addParam("@idSector", det.idSector)
            repository.addParam("@idShow", det.idShow)
            repository.addParam("@idSilla", det.idSilla)
            table = repository.executeSearchWithAdapter
            If (table.Rows.Count > 0) Then
                For Each row As DataRow In table.Rows
                    Dim info As New BE.InforReservacion
                    info.nombre = row.Item(0)
                    info.apellido = row.Item(1)
                    info.mail = row.Item(2)
                    info.show = row.Item(3)
                    info.fecha = row.Item(4)
                    info.fechaFecha = row.Item(5)
                    info.sector = row.Item(6)
                    info.columna = row.Item(7)
                    info.fila = row.Item(8)
                    result.Add(info)
                Next
            Else
                Throw New Excepciones.ReservasPreviaExcepcion
            End If
        Next

        Return result
    End Function

    Shared Function notificarReservaCaida(ByVal listaVentas As List(Of BE.DetalleVentaBE))
        Dim result As New List(Of BE.InforReservacion)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim table As DataTable

        For Each det As BE.DetalleVentaBE In listaVentas
            repository.crearComando("BUSCAR_COMPRADOR_RESERVAS_SP")
            repository.addParam("@idFecha", det.idFecha)
            repository.addParam("@idSector", det.idSector)
            repository.addParam("@idShow", det.idShow)
            repository.addParam("@idSilla", det.idSilla)
            table = repository.executeSearchWithAdapter
            If (table.Rows.Count > 0) Then
                For Each row As DataRow In table.Rows
                    Dim info As New BE.InforReservacion
                    info.nombre = row.Item(0)
                    info.apellido = row.Item(1)
                    info.mail = row.Item(2)
                    info.show = row.Item(3)
                    info.fecha = row.Item(4)
                    info.fechaFecha = row.Item(5)
                    info.sector = row.Item(6)
                    info.columna = row.Item(7)
                    info.fila = row.Item(8)
                    result.Add(info)
                Next
            Else
                Throw New Excepciones.ReservasPreviaExcepcion
            End If
        Next

        Throw New Excepciones.SinReservasExcepcion
    End Function

End Class
