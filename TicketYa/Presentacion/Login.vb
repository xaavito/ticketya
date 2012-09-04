﻿Public Class Login
    Inherits MainForm

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub Init()
        Dim idiomas As List(Of BE.IdiomaBE)
        idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
        IdiomaComboBox.DataSource = idiomas
        IdiomaComboBox.DisplayMember = "descripcion"
        IdiomaComboBox.ValueMember = "identificador"
    End Sub
    
    Private Sub AceptarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarButton.Click
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub IdiomaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdiomaComboBox.SelectedIndexChanged

    End Sub


End Class
