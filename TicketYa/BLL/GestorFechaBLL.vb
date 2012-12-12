Public Class GestorFechaBLL

    Shared Function eliminarFecha(ByVal fecha As BE.FechaBE)
        Try
            DAL.ShowDAL.checkVentasAsociadasFecha(fecha)
        Catch ex As Excepciones.FechaTieneSectoresAsociadasExcepcion
            'Excepciones.FechaTieneVentasAsociadasExcepcion
            Throw New Excepciones.FechaTieneSectoresAsociadasExcepcion
        End Try
        Return DAL.ShowDAL.eliminarFecha(fecha.identificador)
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
