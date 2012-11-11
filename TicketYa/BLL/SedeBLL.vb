Public Class SedeBLL

    Shared Function buscarSede(ByVal p1 As String) As Object
        Return DAL.SedeDAL.buscarSede(p1)
    End Function

    Shared Function eliminarSede(ByVal sede As BE.SedeBE) As Integer
        Throw New NotImplementedException
    End Function

End Class

