Public Class GestorVentasBLL

    Shared Function generarVenta(ByVal venta As BE.VentaBE, ByVal listaVentas As List(Of BE.DetalleVentaBE), ByVal pago As Boolean)
        Dim result As Integer = Nothing
        Try
            DAL.VentaDAL.checkearReservaPrevia(listaVentas)
        Catch ex As Excepciones.ReservasCaidasExcepcion
            If pago = False Then
                DAL.VentaDAL.notificarMasDeUnaReserva(listaVentas)
            Else
                DAL.VentaDAL.notificarReservaCaida(listaVentas)
            End If
        Catch ex As Excepciones.SinReservasExcepcion
            result = DAL.VentaDAL.generarVenta(venta, listaVentas, pago)
            Throw New Excepciones.VentaGeneradaExitosamente
        End Try
        
        Return result
    End Function


    Shared Function buscarVenta(ByVal p1 As Date, ByVal p2 As Date, ByVal p5 As Integer) As Object
        Return DAL.VentaDAL.buscarVenta(p1, p2, p5)
    End Function
End Class
