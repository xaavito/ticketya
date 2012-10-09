Imports System.Windows.Forms

Public Class Principal
    Inherits BaseForm

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        Try
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, BLL.Actual.usuario.usuario, Utilitarios.Enumeradores.Bitacora.LogoutExitoso)
        Catch excep As Excepciones.InsertExcepcion
            My.Application.HandlerException(excep)
        End Try
        Me.Close()
    End Sub

    Private Sub BuscarUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarUsuarios.Click
        Dim form As New BuscarUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarUsusariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarUsuarios.Click
        Dim form As New GenerarUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarFamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFamilia.Click
        Dim form As New BuscarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarFamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarFamilia.Click
        Dim form As New GenerarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PermisosUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosUsuario.Click
        Dim form As New GenerarPermisoUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PermisoFamiliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisoFamilia.Click
        Dim form As New GenerarPermisoFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarIdiomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarIdiomaToolStripMenuItem.Click
        Dim form As New BuscarIdiomaForm
        form.MdiParent = Me
        form.show()
    End Sub

    Private Sub GenerarIdiomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarIdiomaToolStripMenuItem.Click
        Dim form As New GenerarIdiomaForm
        form.MdiParent = Me
        form.show()
    End Sub

    Private Sub BuscarBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBackupToolStripMenuItem.Click
        Dim form As New BuscarBackupForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub RealizarRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarRestoreToolStripMenuItem.Click
        Dim form As New RealizarRestoreForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitacoraToolStripMenuItem.Click
        Dim form As New BuscarBitacoraForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub MiUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiUsuarioToolStripMenuItem.Click

    End Sub
End Class
