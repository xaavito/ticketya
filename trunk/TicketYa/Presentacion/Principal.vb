Imports System.Windows.Forms

Public Class Principal
    Inherits BaseForm

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

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        Try
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, BLL.Actual.usuario.usuario, Utilitarios.Enumeradores.Bitacora.LogoutExitoso)
        Catch excep As Excepciones.InsertExcepcion
            My.Application.HandlerException(excep)
        End Try
        Me.Close()
    End Sub

    Private Sub BuscarFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFamilia.Click
        Dim form As New BuscarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarFamilia.Click
        Dim form As New GenerarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarPermisosUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosUsuario.Click
        Dim form As New GenerarPermisoUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarPermisosFamilia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosFamilia.Click
        Dim form As New GenerarPermisoFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

End Class
