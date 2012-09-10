Public Class SeguridadBLL
    Public Shared Function doLogin(ByVal usr As String, ByVal pass As String) As BE.UsuarioBE
        'Dim passencriptado As String = Utilitarios.Encrypter.EncryptPasswordMD5(pass, "00000000")
        'Dim descn As String = Utilitarios.Encrypter.DecryptPasswordMD5(passencriptado, "00000000")

        Return GestorUsuarioBLL.buscarUsuario(usr, Utilitarios.Encrypter.EncryptPasswordMD5(pass, "00000000"))
    End Function
End Class
