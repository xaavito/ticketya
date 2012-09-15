Public Class ExcepcionBLL
    Public Shared Function buscarExcepcion(ByVal idIdioma As Integer, ByVal codigoExcepcion As Integer) As String
        Return DAL.ExcepcionDAL.buscarExcepcion(idIdioma, codigoExcepcion)
    End Function
End Class
