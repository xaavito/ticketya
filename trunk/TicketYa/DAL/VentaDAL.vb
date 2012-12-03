﻿Public Class VentaDAL

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

    Shared Function buscarVenta(ByVal p1 As Date, ByVal p2 As Date, ByVal p3 As Decimal, ByVal p4 As Decimal, ByVal p5 As Integer, ByVal p6 As Integer) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.VentaBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_VENTAS_SP")

            repository.addParam("@fechaDesde", p1)
            repository.addParam("@fechaHasta", p2)
            repository.addParam("@montoDesde", p3)
            repository.addParam("@montoHasta", p4)
            repository.addParam("@vendedor", p5)
            repository.addParam("@promocion", p6)
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
                'venta.promocion = row.Item(0)
                lista.Add(venta)
            Next

        Catch ex As Excepciones.VentasNoEncontradasExcepcion
            Throw New Excepciones.VentasNoEncontradasExcepcion
        End Try

        Return lista
    End Function

End Class
