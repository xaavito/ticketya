﻿Imports System.Windows.Forms

Public Class Principal
    Inherits BaseForm

    Private Sub BuscarPermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPermisos.Click
        Dim form As New BuscarPermisoForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPermisos.Click
        Dim form As New GenerarPermisosForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBitacora.Click
        Dim form As New BuscarBitacoraForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBackup.Click
        Dim form As New BuscarBackupForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub RealizarRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarRestore.Click
        Dim form As New RealizarRestoreForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarUsuario.Click
        Dim form As New BuscarUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub AltaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaUsuario.Click
        Dim form As New GenerarUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Try
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, BLL.Actual.usuario.usuario, Utilitarios.Enumeradores.Bitacora.LogoutExitoso)
        Catch excep As Excepciones.InsertExcepcion
            My.Application.HandlerException(excep)
        End Try
        Me.Close()
    End Sub
End Class
