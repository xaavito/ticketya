Public Class SeguridadBLL
    Public Shared Function doLogin(ByVal usr As String, ByVal pass As String) As BE.UsuarioBE
        Return GestorUsuarioBLL.buscarUsuario(usr, pass)
    End Function
End Class
