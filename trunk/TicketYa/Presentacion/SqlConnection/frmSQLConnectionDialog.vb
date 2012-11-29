Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmSQLConnectionDialog

    Dim conn As New SqlConnectionStringBuilder()
    Public RootPath As String = ""

    Private Sub frmSQLConnectionDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cbServidor.Text = conn.DataSource
        cbBase.Text = conn.InitialCatalog

        If conn.IntegratedSecurity = False Then
            txtUsuario.Enabled = True
            txtClave.Enabled = True
            rbAutenticacionWin.Checked = False
            rbAutenticacionSql.Checked = True
            txtUsuario.Text = conn.UserID
            txtClave.Text = conn.Password
        End If

    End Sub

    Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click
        SqlInstances()
    End Sub

    Sub ContructConnection()
        conn.DataSource = cbServidor.Text
        conn.IntegratedSecurity = True
        conn.UserID = ""
        conn.Password = ""
        conn.InitialCatalog = ""

        If rbAutenticacionSql.Checked Then
            conn.IntegratedSecurity = False
            conn.UserID = txtUsuario.Text
            conn.Password = txtClave.Text
        End If
        If cbBase.Text <> "" Then
            conn.InitialCatalog = cbBase.Text
        End If
    End Sub

    Sub SqlInstances()
        Cursor.Current = Cursors.WaitCursor
        Try
            cbServidor.Items.Clear()
            Dim sqlSources As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources
            For Each datarow As DataRow In sqlSources.Rows
                Dim datasource As String = datarow("ServerName").ToString
                If Not datarow("InstanceName") Is DBNull.Value Then
                    datasource &= String.Format("\{0}", datarow("InstanceName"))
                End If
                cbServidor.Items.Add(datasource)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Sub SqlDatabaseNames()

        ContructConnection()
        Cursor.Current = Cursors.WaitCursor
        Dim connString As String
        Dim databaseNames As New List(Of String)
        connString = conn.ConnectionString
        cbBase.Items.Clear()
        Try
            Using cn As SqlConnection = New SqlConnection(connString)
                cn.Open()
                Using cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_databases"

                    Using myReader As SqlDataReader = cmd.ExecuteReader()
                        While (myReader.Read())
                            cbBase.Items.Add(myReader.GetString(0))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub


    Sub TestDB()
        ContructConnection()
        Try
            Dim objConn As SqlConnection = New SqlConnection(conn.ConnectionString)
            objConn.Open()
            objConn.Close()
            MsgBox("Conexión satisfactoria!!!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cbServidor_DropDown(sender As System.Object, e As System.EventArgs) Handles cbServidor.DropDown
        If cbServidor.Items.Count = 0 Then
            SqlInstances()
        End If
    End Sub

    Private Sub cbBase_DropDown(sender As System.Object, e As System.EventArgs) Handles cbBase.DropDown
        SqlDatabaseNames()
    End Sub

    Private Sub rbAutenticacionWin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbAutenticacionWin.CheckedChanged
        txtUsuario.Enabled = False
        txtClave.Enabled = False
    End Sub

    Private Sub rbAutenticacionSql_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbAutenticacionSql.CheckedChanged
        txtUsuario.Enabled = True
        txtClave.Enabled = True
    End Sub


    Private Sub btnProbar_Click(sender As System.Object, e As System.EventArgs) Handles btnProbar.Click
        TestDB()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        ContructConnection()        
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Property ConnectionString() As String
        Get
            Return conn.ConnectionString
        End Get
        Set(ByVal value As String)
            conn.ConnectionString = value
        End Set
    End Property


    Private Sub btnNueva_Click(sender As System.Object, e As System.EventArgs) Handles btnNueva.Click
        ContructConnection()
        Dim nuevadb As New frmSQLConnectionDialogNewDB(conn.ConnectionString)
        nuevadb.RootPath = RootPath
        If nuevadb.ShowDialog = Windows.Forms.DialogResult.OK Then
            cbBase.Text = nuevadb.txtBase.Text
            SqlDatabaseNames()
        End If
    End Sub
End Class