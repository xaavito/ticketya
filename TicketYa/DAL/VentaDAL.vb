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

End Class
