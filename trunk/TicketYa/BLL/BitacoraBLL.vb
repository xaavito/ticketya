Public Class BitacoraBLL


    Function setBitacora(ByVal usr As BE.UsuarioBE,
                         ByVal mensaje As String,
                         ByVal codigo As Integer) As Boolean

        DAL.BitacoraDAL.agregarBitacora(usr,
                                        mensaje,
                                        codigo)
        Return True
    End Function

    Function getBitacora(ByVal usr As BE.UsuarioBE,
                         ByVal mensaje As String,
                         ByVal codigo As Integer,
                         ByVal fecha As DateTime) As List(Of BE.BitacoraBE)

        Return Nothing
    End Function
End Class
