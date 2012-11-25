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

    Shared Function altaSede(ByVal nombre As String, ByVal capacidad As String, ByVal direccion As String, ByVal numero As String, ByVal telefono As String) As Boolean
        Return DAL.SedeDAL.altaSede(nombre, capacidad, direccion, numero, telefono)
    End Function

End Class

