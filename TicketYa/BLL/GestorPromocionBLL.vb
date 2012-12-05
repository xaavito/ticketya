Public Class GestorPromocionBLL

    Shared Sub eliminarPromocion(ByVal Promocion As BE.PromocionBE)
        Throw New NotImplementedException
    End Sub

    Shared Function buscarPromociones() As Object
        Return DAL.VentaDAL.buscarPromociones()
    End Function

    Shared Function buscarPromocion(ByVal sector As Integer, ByVal fecha As Integer) As BE.PromocionBE
        Return DAL.VentaDAL.buscarPromocion(sector, fecha)
    End Function

    Shared Function generarPromocion(ByVal p1 As String, ByVal p2 As Date, ByVal p3 As Date, ByVal p4 As Integer, ByVal p5 As Decimal, ByVal p6 As Integer, ByVal p7 As Integer)
        Return DAL.VentaDAL.generarPromocion(p1, p2, p3, p4, p5, p6, p7)
    End Function

End Class
