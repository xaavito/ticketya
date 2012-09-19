Public Class GestorBackupBLL

    Shared Function listarBackups() As List(Of BE.BackupBE)
        Return DAL.BackupDAL.listarBackups()
    End Function

End Class