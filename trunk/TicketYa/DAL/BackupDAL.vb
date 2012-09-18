Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Public Class BackupDAL
    Public Sub BackUp(ByVal path As String, ByVal connectionString As String)

        Dim builder As New SqlConnectionStringBuilder(connectionString)
        Dim connection As New ServerConnection(builder.DataSource, builder.UserID, builder.Password)
        Dim sqlServer As New Server(connection)

        Dim bk As New Backup
        bk.Database = builder.InitialCatalog
        bk.Action = BackupActionType.Database
        bk.BackupSetDescription = "Full backup of " & bk.Database
        bk.BackupSetName = bk.Database
        bk.Devices.AddDevice(path, DeviceType.File)
        bk.Incremental = False
        bk.LogTruncation = BackupTruncateLogType.Truncate
        bk.SqlBackup(sqlServer)

    End Sub

    Public Sub Restore(ByVal path As String, ByVal connectionString As String)

        Dim builder As New SqlConnectionStringBuilder(connectionString)
        Dim connection As New ServerConnection(builder.DataSource, builder.UserID, builder.Password)
        Dim sqlServer As New Server(connection)

        Dim rs As New Restore
        rs.Database = builder.InitialCatalog
        rs.NoRecovery = False
        rs.Action = BackupActionType.Database
        rs.ReplaceDatabase = True
        rs.Devices.AddDevice(path, DeviceType.File)
        sqlServer.KillAllProcesses(builder.InitialCatalog)
        rs.Wait()
        rs.SqlRestore(sqlServer)

    End Sub
End Class
