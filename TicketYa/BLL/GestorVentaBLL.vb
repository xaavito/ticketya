Public Class GestorVentaBLL

    Shared Function buscarVenta(ByVal p1 As Date, ByVal p2 As Date, ByVal p3 As Decimal, ByVal p4 As Decimal, ByVal p5 As Integer, ByVal p6 As Integer) As Object
        Return DAL.VentaDAL.buscarVenta(p1, p2, p3, p4, p5, p6)
    End Function

End Class
