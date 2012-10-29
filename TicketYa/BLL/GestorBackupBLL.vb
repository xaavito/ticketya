Public Class GestorBackupBLL

    Shared Function listarBackups() As List(Of BE.BackupBE)
        Return DAL.BackupDAL.listarBackups()
    End Function

    Shared Function eliminarBackup(ByVal backup As BE.BackupBE) As Integer
        Return DAL.BackupDAL.eliminarBackup(backup)
    End Function

End Class