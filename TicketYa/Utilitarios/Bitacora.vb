Public Class Bitacora


    Function setBitacora(ByVal usr As BE.UsuarioBE,
                         ByVal mensaje As String,
                         ByVal codigo As Integer,
                         ByVal fecha As DateTime) As Boolean

        Return True
    End Function

    Function getBitacora(ByVal usr As BE.UsuarioBE,
                         ByVal mensaje As String,
                         ByVal codigo As Integer,
                         ByVal fecha As DateTime) As List(Of BE.BitacoraBE)

        Return Nothing
    End Function
End Class
