Public Class SeguridadBLL

    Public Shared Function doLogin(ByVal usr As String, ByVal pass As String) As BE.UsuarioBE
        Return GestorUsuarioBLL.buscarUsuario(usr, Utilitarios.Encrypter.EncryptPasswordMD5(pass))
    End Function

    Public Shared Sub backup(ByVal desc As String)
        DAL.BackupDAL.BackUp(desc)
    End Sub

    Public Shared Sub restore(ByVal path As String)
        DAL.BackupDAL.Restore(path)
    End Sub
End Class
