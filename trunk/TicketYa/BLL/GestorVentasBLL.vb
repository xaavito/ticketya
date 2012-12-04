Public Class GestorVentasBLL

    Shared Function generarVenta(ByVal venta As BE.VentaBE, ByVal listaVentas As List(Of BE.DetalleVentaBE), ByVal pago As Boolean)
        Dim result As Integer = DAL.VentaDAL.generarVenta(venta, listaVentas, pago)
        Throw New Excepciones.VentaGeneradaExitosamente
        Return result
    End Function


    Shared Function buscarVenta(ByVal p1 As Date, ByVal p2 As Date, ByVal p5 As Integer) As Object
        Return DAL.VentaDAL.buscarVenta(p1, p2, p5)
    End Function

    Shared Function buscarPromociones() As Object
        Return DAL.VentaDAL.buscarPromociones()
    End Function

End Class
