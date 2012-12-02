Public Class GestorVentasBLL

    Shared Function generarVenta(ByVal venta As BE.VentaBE, ByVal listaVentas As List(Of BE.DetalleVentaBE), ByVal pago As Boolean)
        Return DAL.VentaDAL.generarVenta(venta, listaVentas, pago)
    End Function

End Class
