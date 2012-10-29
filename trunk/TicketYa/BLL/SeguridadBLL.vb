Public Class SeguridadBLL

    Public Shared Function doLogin(ByVal usr As String, ByVal pass As String) As BE.UsuarioBE
        'Dim passencriptado As String = Utilitarios.Encrypter.EncryptPasswordMD5(pass, "00000000")
        'Dim descn As String = Utilitarios.Encrypter.DecryptPasswordMD5(passencriptado, "00000000")

        Return GestorUsuarioBLL.buscarUsuario(usr, Utilitarios.Encrypter.EncryptPasswordMD5(pass))
    End Function

    Public Shared Sub backup(ByVal desc As String)
        DAL.BackupDAL.BackUp(desc)
        Throw New Excepciones.BackupRealizadoExitosamente
    End Sub

    Public Shared Sub restore(ByVal path As String)
        DAL.BackupDAL.Restore(path)
        Throw New Excepciones.RestoreRealizadoExitosamente
    End Sub
End Class
