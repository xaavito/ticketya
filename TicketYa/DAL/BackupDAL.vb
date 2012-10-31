﻿Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo

Public Class BackupDAL


    'TODO buscar path relativo
    Public Shared Sub BackUp(ByVal description As String)
        Dim path As String = "D:\\Prueba"
        Dim fecha As String = DateTime.Now.Day.ToString + "-" + DateTime.Now.Month.ToString + "-" + DateTime.Now.Year.ToString + "-" +
                DateTime.Now.Hour.ToString + "-" + DateTime.Now.Minute.ToString + "-" + DateTime.Now.Second.ToString

        'Dim connectionString As String
        Dim repo As New RepositorioSQL

        'connectionString = 
        Dim builder As New SqlConnectionStringBuilder(repo.conString)
        Dim connection As New ServerConnection(builder.DataSource)
        Dim sqlServer As New Server(connection)

        Dim bk As New Backup
        bk.Database = builder.InitialCatalog
        bk.Action = BackupActionType.Database
        bk.BackupSetDescription = "BU " & bk.Database
        bk.BackupSetName = bk.Database

        Dim fileName As String = bk.Database + fecha + ".sql"
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

            repository.addParam("@path", path + "\\" + bk.Database + fecha + ".sql")
            repository.addParam("@descripcion", description)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

    End Sub

    Public Shared Sub Restore(ByVal path As String)
        'Dim path As String = "D:\\Prueba"
        Dim repo As New RepositorioSQL

        Dim builder As New SqlConnectionStringBuilder(repo.conString)
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
                Throw New Excepciones.BackupsNoEncontrados
            End If
            For Each pepe As DataRow In table.Rows
                Dim bu As New BE.BackupBE
                bu.identificador = pepe.Item(0)
                bu.descripcion = pepe.Item(1)
                bu.fecha = pepe.Item(2)
                bu.path = pepe.Item(3)
                bu.activo = pepe.Item(4)
                backups.Add(bu)
            Next

        Catch ex As Exception
            'Throw New Excepciones.BackupsNoEncontrados
        End Try

        Return backups
    End Function

    Shared Function eliminarBackup(ByVal backup As BE.BackupBE) As Integer
        Dim resultado As Integer

        'Dim backups As New List(Of BE.BackupBE)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_BACKUP_SP")
            repository.addParam("@idBackup", backup.identificador)
            resultado = repository.executeSearchWithStatus
            If (resultado <= 0) Then
                Throw New Excepciones.FalloAlEliminarBackup
            End If

        Catch ex As Excepciones.FalloAlEliminarBackup
            Throw New Excepciones.BackupsNoEncontrados
        Catch ex As Exception
            'Throw New Excepciones.BackupsNoEncontrados
        End Try

        Return resultado
    End Function

End Class