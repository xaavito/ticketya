Public Class GenerarCompradorForm
    Dim listaPreferencias As List(Of BE.PreferenciaBE)
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        NombreTextBox.sinEspacio = True
        NombreTextBox.boton = GenerarCompradorButton
        ApellidoTextBox.sinEspacio = True
        ApellidoTextBox.boton = GenerarCompradorButton
        MailTextBox.texto = True
        MailTextBox.boton = GenerarCompradorButton
        DireccionTextBox.texto = True
        DireccionTextBox.boton = GenerarCompradorButton
    End Sub
    Private Sub GenerarUsuarioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCompradorButton.Click
        If (Not String.IsNullOrEmpty(NombreTextBox.Text) And Not String.IsNullOrEmpty(ApellidoTextBox.Text) And
            Not String.IsNullOrEmpty(MailTextBox.Text) And Not String.IsNullOrEmpty(DireccionTextBox.Text)) Then

        End If
        Try
            If (BLL.GestorUsuarioBLL.altaComprador(NombreTextBox.Text,
                                                   ApellidoTextBox.Text,
                                                   MailTextBox.Text,
                                                   DireccionTextBox.Text,
                                                   NumeroTextBox.Text,
                                                   PisoTextBox.Text,
                                                   TelefonoTextBox.Text,
                                                   getPreferencias())) Then
                Throw New Excepciones.UsuarioCreadoExistosamente
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.CreacionDeUsuario)
                Me.limpiarForm()
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.UsuarioCreadoExistosamente
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub AgregarPreferenciaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPreferenciaButton.Click
        Dim familia As BE.FamiliaBE = DirectCast(PreferenciaComboBox.SelectedItem, BE.FamiliaBE)

        Dim row As String() = New String() {familia.identificador, familia.descripcion}
        PreferenciaDataGrid.Rows.Add(row)
    End Sub

    Private Sub QuitarPreferenciaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarPreferenciaButton.Click
        If (PreferenciaDataGrid.SelectedRows.Count > 0) Then
            PreferenciaDataGrid.Rows.Remove(PreferenciaDataGrid.SelectedRows(0))
        End If
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
