Public Class GestorFechaBLL

    Shared Function eliminarFecha(ByVal Fecha As BE.FechaBE)
        Return DAL.ShowDAL.eliminarFecha(Fecha.identificador)
    End Function

    Shared Function altaFecha(ByVal p1 As String, ByVal p2 As Date, ByVal p3 As Integer) As Boolean
        Return DAL.ShowDAL.altaFecha(p1, p2, p3)
    End Function

    Shared Function buscarFecha(ByVal p1 As String, ByVal p2 As Date, ByVal p3 As Date) As Object
        Return DAL.ShowDAL.buscarFecha(p1, p2, p3)
    End Function

    Shared Function listarFechas(ByVal p1 As Integer) As Object
        Return DAL.ShowDAL.buscarFecha(p1)
    End Function

End Class
