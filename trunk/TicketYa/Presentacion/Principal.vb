Imports System.Windows.Forms

Public Class Principal
    Inherits BaseForm

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        Try
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, BLL.Actual.usuario.usuario, Utilitarios.Enumeradores.Bitacora.LogoutExitoso)
        Catch excep As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(excep)
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

    Private Sub BuscarFamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFamilias.Click
        Dim form As New BuscarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarFamiliasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarFamilias.Click
        Dim form As New GenerarFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PermisosUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosUsuarios.Click
        Dim form As New GenerarPermisoUsuarioForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PermisoFamiliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosFamilias.Click
        Dim form As New GenerarPermisoFamiliaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarIdiomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarIdiomas.Click
        Dim form As New BuscarIdiomaForm
        form.MdiParent = Me
        form.show()
    End Sub

    Private Sub GenerarIdiomaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarIdiomas.Click
        Dim form As New GenerarIdiomaForm
        form.MdiParent = Me
        form.show()
    End Sub

    Private Sub BuscarBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBackups.Click
        Dim form As New BuscarBackupForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub RealizarRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarRestores.Click
        Dim form As New RealizarRestoreForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bitacoras.Click
        Dim form As New BuscarBitacoraForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub MiUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiUsuario.Click
        Dim form = New ModificarUsuarioForm
        form.addUsuario(BLL.Actual.usuario)
        Form.Show()
    End Sub

    Private Sub BuscarSedeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarSedeToolStripMenuItem.Click
        Dim form As New BuscarSedeForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarSedeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarSedeToolStripMenuItem.Click
        Dim form As New GenerarSedeForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarVentaToolStripMenuItem.Click
        Dim form As New BuscarVentaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarVentaToolStripMenuItem.Click
        Dim form As New GenerarVentaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarShowToolStripMenuItem.Click
        Dim form As New BuscarShowForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarShowToolStripMenuItem.Click
        Dim form As New GenerarShowForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarSectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarSectorToolStripMenuItem.Click
        Dim form As New BuscarSectorForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarSectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarSectorToolStripMenuItem.Click
        Dim form As New GenerarSectorForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarSillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarSillaToolStripMenuItem.Click
        Dim form As New BuscarSillaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarSillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarSillaToolStripMenuItem.Click
        Dim form As New GenerarSillaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarPromocionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPromocionToolStripMenuItem.Click
        Dim form As New BuscarPromocionForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarPromocionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPromocionToolStripMenuItem.Click
        Dim form As New GenerarPromocionForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarCompradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarCompradorToolStripMenuItem.Click
        Dim form As New BuscarCompradorForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarCompradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCompradorToolStripMenuItem.Click
        Dim form As New GenerarCompradorForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BuscarFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFechaToolStripMenuItem.Click
        Dim form As New BuscarFechaForm
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub GenerarFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarFechaToolStripMenuItem.Click
        Dim form As New GenerarFechaForm
        form.MdiParent = Me
        form.Show()
    End Sub
End Class
