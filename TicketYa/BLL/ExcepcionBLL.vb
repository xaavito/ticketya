Public Class ExcepcionBLL
    Public Shared Function buscarExcepcion(ByVal idIdioma As Integer, ByVal codigoExcepcion As Integer) As String
        Return DAL.ExcepcionDAL.buscarExcepcion(idIdioma, codigoExcepcion)
    End Function

    Shared Function buscarExcepciones(ByVal idioma As Integer) As List(Of BE.ExcepcionBE)
        Return DAL.ExcepcionDAL.buscarExcepciones(idioma)
    End Function

    Shared Function buscarExcepcion(ByVal p1 As Integer) As String
        If Not BLL.Actual.idioma Is Nothing Then
            For Each excep As BE.ExcepcionBE In BLL.Actual.idioma.listaExcepciones
                If (excep.codigo = p1) Then
                    Return excep.mensaje
                End If
            Next
        Else
            Return "Error Trayendo error!"
        End If

        Throw New Excepciones.ExcepcionNoEncontradaExcepcion
    End Function

End Class
