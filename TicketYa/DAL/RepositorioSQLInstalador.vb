Imports System.Data.SqlClient
Imports System.IO

Public Class RepositorioSQLInstalador

    Public Sub CreateDataBase(dbname As String, FileScript As String, connectionString As String)

        Dim builder As New SqlConnectionStringBuilder(connectionString)
        builder.InitialCatalog = ""

        'LEO EL ARCHIVO SQL
        Dim thefile As New FileInfo(FileScript)
        Dim script As String = thefile.OpenText().ReadToEnd()


        Dim db As String = String.Format("CREATE DATABASE [{0}] ", dbname)
        Dim use As String = String.Format("USE [{0}] " + vbNewLine + "GO" + vbNewLine, dbname)
        script = use + script
        script = script.Replace(vbNewLine & "GO", vbNewLine)

        Dim conn As SqlConnection = New SqlConnection(builder.ConnectionString)
        'CREA LA BASE DE DATOS
        Try
            conn.Open()
            Try
                Dim cmd As New SqlCommand(db, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                conn.Close()
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try

        'EJECUTA EL SCRIPT
        Try
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()
            Try
                Dim cmd As New SqlCommand(script, conn)
                cmd.Transaction = transaction
                cmd.ExecuteNonQuery()
                transaction.Commit()
                conn.Close()
            Catch ex As Exception
                transaction.Rollback()
                conn.Close()
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
