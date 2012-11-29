Imports System.Data.SqlClient
'Imports DataLayer
Imports DAL

Public Class frmSQLConnectionDialogNewDB
    Dim conn As String = ""
    Public RootPath As String = ""

    Sub New(connectionString As String)
        InitializeComponent()
        conn = connectionString
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

        If Not String.IsNullOrEmpty(txtBase.Text) Then
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim slqman As New RepositorioSQLInstalador()
                slqman.CreateDataBase(txtBase.Text, RootPath + "sql\ticketya.sql", conn)
                MessageBox.Show(String.Format("La base de datos '{0}' fue creada satisfactoriamente", txtBase.Text))
                Me.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error en la creación de la base. " + Environment.NewLine + ex.Message)
            End Try
            Cursor.Current = Cursors.Default
        Else
            MessageBox.Show("Debe completar el nombre de la base de datos.")
        End If

    End Sub
End Class