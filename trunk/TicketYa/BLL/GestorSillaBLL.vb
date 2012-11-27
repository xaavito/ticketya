Public Class GestorSillaBLL

    Shared Function getSillas(ByVal p1 As Integer, ByVal p2 As Integer) As List(Of BE.SillaBE)
        Return DAL.SillaDAL.getSillas(p1, p2)
    End Function

End Class
