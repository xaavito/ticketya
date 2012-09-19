Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo

Public Class BackupDAL

    'TODO buscar path relativo
    Public Shared Sub BackUp(ByVal path As String)

        Dim connectionString As String
        connectionString = "Data Source=localhost;Initial Catalog=TicketYa;Integrated Security=SSPI;"
        Dim builder As New SqlConnectionStringBuilder(connectionString)
        Dim connection As New ServerConnection(builder.DataSource)
        Dim sqlServer As New Server(connection)

        Dim bk As New Backup
        bk.Database = builder.InitialCatalog
        bk.Action = BackupActionType.Database
        bk.BackupSetDescription = "BU " & bk.Database
        bk.BackupSetName = bk.Database
        Dim fileName As String = bk.Database + ".sql"
        bk.Devices.AddDevice(path + "\\" + fileName, DeviceType.File)
        bk.Incremental = False
        bk.LogTruncation = BackupTruncateLogType.Truncate
        Try
            bk.SqlBackup(sqlServer)
        Catch ex As FailedOperationException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_BACKUP_SP")
            repository.addParam("@path", path + "\\" + bk.Database + DateTime.Now + ".sql")
            repository.addParam("@descripcion", "lolo")
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

    End Sub

    Public Shared Sub Restore(ByVal path As String, ByVal connectionString As String)

        Dim builder As New SqlConnectionStringBuilder(connectionString)
        Dim connection As New ServerConnection(builder.DataSource)
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

    Shared Function listarBackups() As List(Of BE.BackupBE)
        Dim table As DataTable

        Dim backups As New List(Of BE.BackupBE)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_BACKUPS_SP")
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                'Throw New Excepciones.BackupsNoEncontrados
            End If
            For Each pepe As DataRow In table.Rows
                Dim bu As New BE.BackupBE
                bu.identificador = pepe.Item(0)
                bu.descripcion = pepe.Item(1)
                bu.fecha = pepe.Item(2)
               
                backups.Add(bu)
            Next

        Catch ex As Exception
            'Throw New Excepciones.BackupsNoEncontrados
        End Try

        Return backups
    End Function

End Class
