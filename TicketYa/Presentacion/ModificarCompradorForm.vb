Public Class ModificarCompradorForm

    Dim listaPreferencias As List(Of BE.PreferenciaBE)
    Dim usuario As BE.UsuarioBE

    Sub addComprador(ByVal usr As BE.UsuarioBE)
        usuario = usr
        NombreTextBox.Text = usr.nombre
        ApellidoTextBox.Text = usr.apellido
        MailTextBox.Text = usr.mail
        DireccionTextBox.Text = usr.direccion
        NumeroTextBox.Text = usr.numero
        PisoTextBox.Text = usr.piso
        DptoTextBox.Text = usr.dpto
        CodPostTextBox.Text = usr.codPost
        TelefonoTextBox.Text = usr.telefono
        setPreferencias()
    End Sub

    Private Sub AgregarPreferenciaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim familia As BE.FamiliaBE = DirectCast(PreferenciaDataGrid.CurrentRow.DataBoundItem, BE.FamiliaBE)
        Dim row As String() = New String() {familia.identificador, familia.descripcion}
        PreferenciaDataGrid.Rows.Add(row)
    End Sub

    Private Sub QuitarPreferenciaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (PreferenciaDataGrid.SelectedRows.Count > 0) Then
            PreferenciaDataGrid.Rows.Remove(PreferenciaDataGrid.SelectedRows(0))
        End If
    End Sub

    Private Sub GenerarCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            BLL.GestorUsuarioBLL.modificarComprador(NombreTextBox.Text,
                                                   ApellidoTextBox.Text,
                                                   MailTextBox.Text,
                                                   DireccionTextBox.Text,
                                                   NumeroTextBox.Text,
                                                   PisoTextBox.Text,
                                                   DptoTextBox.Text,
                                                   CodPostTextBox.Text,
                                                   TelefonoTextBox.Text,
                                                   getPreferencias())

        Catch ex As Excepciones.UsuarioModificadoExitosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.ModificacionDeUsuario)
            Me.limpiarForm()
            Me.Close()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub setPreferencias()
        Try
            listaPreferencias = BLL.GestorPreferenciaBLL.buscarPreferencias(usuario.identificador)

            For Each pref As BE.PreferenciaBE In listaPreferencias
                Dim row As String() = New String() {pref.identificador, pref.descripcion}
                PreferenciaDataGrid.Rows.Add(row)
            Next
        Catch ex As Excepciones.PreferenciasNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try

    End Sub
    Private Function getPreferencias() As List(Of BE.PreferenciaBE)
        listaPreferencias = New List(Of BE.PreferenciaBE)
        Dim fam As BE.PreferenciaBE
        For Each row As DataGridViewRow In PreferenciaDataGrid.Rows
            fam = New BE.PreferenciaBE
            fam.identificador = row.Cells(0).Value
            fam.descripcion = row.Cells(1).Value
            listaPreferencias.Add(fam)
        Next
        Return listaPreferencias
    End Function
End Class
