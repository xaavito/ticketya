Public Class BitacoraBLL


    Public Shared Function setBitacora(ByVal usr As BE.UsuarioBE,
                                       ByVal mensaje As String,
                                       ByVal codigo As Integer) As Boolean

        DAL.BitacoraDAL.agregarBitacora(usr,
                                        mensaje,
                                        codigo)
        Return True
    End Function

    Public Shared Function getBitacora(ByVal usr As BE.UsuarioBE,
                                       ByVal mensaje As String,
                                       ByVal codigo As Integer,
                                       ByVal fecha As DateTime) As List(Of BE.BitacoraBE)


        Return DAL.BitacoraDAL.buscarBitacora(usr,
                                              codigo,
                                              fecha,
                                              Actual.idioma)

    End Function
End Class
