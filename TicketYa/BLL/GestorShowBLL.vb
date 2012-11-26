Public Class GestorShowBLL

    Shared Function eliminarShow(ByVal Show As BE.ShowBE)
        Return DAL.ShowDAL.eliminarShow(Show.identificador)
    End Function

    Shared Function buscarShow(ByVal p1 As String) As Object
        Return DAL.ShowDAL.buscarShow(p1)
    End Function

    Shared Function altaShow(ByVal p1 As String, ByVal p2 As Integer, ByVal p3 As Integer) As Boolean
        Return DAL.ShowDAL.altaShow(p1,
                                    p2,
                                    p3)
    End Function

    Shared Function buscarTipoShow(ByVal p1 As String) As Object
        Return DAL.ShowDAL.buscarTipoShow(p1)
    End Function

    Shared Function modificarShow(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As Integer, ByVal p4 As Integer)
        Return DAL.ShowDAL.modificarShow(p1, p2, p3, p4)
    End Function

    Shared Function modificarFecha(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As Integer, ByVal p4 As Date)
        Return DAL.ShowDAL.modificarFecha(p1, p2, p3, p4)
    End Function

End Class
