Public Class GestorSedeBLL

    Shared Function buscarSede(ByVal p1 As String) As Object
        Return DAL.SedeDAL.buscarSede(p1)
    End Function

    Shared Function eliminarSede(ByVal sede As BE.SedeBE) As Integer
        Try
            DAL.SedeDAL.checkVentasAsignadas(sede.identificador)
        Catch ex As Excepciones.SedeTieneShowsAsociadosExcepcion
            Throw New Excepciones.SedeTieneShowsAsociadosExcepcion
        End Try

        Return DAL.SedeDAL.eliminarSede(sede.identificador)
    End Function

    Shared Function altaSede(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal p5 As String) As Boolean
        Throw New NotImplementedException
    End Function

End Class

