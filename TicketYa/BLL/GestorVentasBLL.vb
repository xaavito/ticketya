Public Class GestorVentasBLL

    Shared Function generarVenta(ByVal venta As BE.VentaBE, ByVal listaVentas As List(Of BE.DetalleVentaBE), ByVal pago As Boolean)
        Dim result As Integer = DAL.VentaDAL.generarVenta(venta, listaVentas, pago)
        Throw New Excepciones.VentaGeneradaExitosamente
        Return result
    End Function

End Class
