Public Class GenerarUsuarioForm
    Dim listaFamilias As List(Of BE.FamiliaBE)

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'FamiliaDataGrid.AutoGenerateColumns = False
        
        Dim idiomas As List(Of BE.IdiomaBE)
        idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
        IdiomaComboBox.DataSource = idiomas
        IdiomaComboBox.DisplayMember = "descripcion"
        IdiomaComboBox.ValueMember = "identificador"

        Dim familias As List(Of BE.FamiliaBE)
        familias = BLL.GestorFamiliaBLL.listarFamilias()
        FamiliaComboBox.DataSource = familias
        FamiliaComboBox.DisplayMember = "descripcion"
        FamiliaComboBox.ValueMember = "identificador"

        UsuarioTextBox.sinEspacio = True
        UsuarioTextBox.boton = GenerarUsuarioButton
        PassTextBox.sinEspacio = True
        PassTextBox.boton = GenerarUsuarioButton
        NombreTextBox.texto = True
        NombreTextBox.boton = GenerarUsuarioButton
        ApellidoTextBox.texto = True
        ApellidoTextBox.boton = GenerarUsuarioButton
    End Sub

    Private Sub AgregarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarFamiliaButton.Click
        Dim familia As BE.FamiliaBE = DirectCast(FamiliaComboBox.SelectedItem, BE.FamiliaBE)

        Dim row As String() = New String() {familia.identificador, familia.descripcion}
        FamiliaDataGrid.Rows.Add(row)
    End Sub

    Private Sub AltaUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarUsuarioButton.Click
        If (Not String.IsNullOrEmpty(UsuarioTextBox.Text) And Not String.IsNullOrEmpty(PassTextBox.Text) And
            Not String.IsNullOrEmpty(NombreTextBox.Text) And Not String.IsNullOrEmpty(ApellidoTextBox.Text)) Then

        End If
        Try
            If (BLL.GestorUsuarioBLL.altaUsuario(UsuarioTextBox.Text,
                                                PassTextBox.Text,
                                                NombreTextBox.Text,
                                                ApellidoTextBox.Text,
                                                DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE),
                                                getFamilias())) Then
                Throw New Excepciones.UsuarioCreadoExistosamente
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, UsuarioTextBox.Text, Utilitarios.Enumeradores.Bitacora.CreacionDeUsuario)
                limpiarParametros()
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.UsuarioCreadoExistosamente
            My.Application.manejarExcepcion(ex)
        End Try

    End Sub

    Private Function getFamilias() As List(Of BE.FamiliaBE)
        listaFamilias = New List(Of BE.FamiliaBE)
        Dim fam As BE.FamiliaBE
        For Each row As DataGridViewRow In FamiliaDataGrid.Rows
            fam = New BE.FamiliaBE
            fam.identificador = row.Cells(0).Value
            fam.descripcion = row.Cells(1).Value
            listaFamilias.Add(fam)
        Next
        Return listaFamilias
    End Function

    Private Sub limpiarParametros()
        UsuarioTextBox.Text = ""
        PassTextBox.Text = ""
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        FamiliaDataGrid.Rows.Clear()
    End Sub

    Private Sub QuitarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarFamiliaButton.Click
        If (FamiliaDataGrid.SelectedRows.Count > 0) Then
            FamiliaDataGrid.Rows.Remove(FamiliaDataGrid.SelectedRows(0))
        End If
    End Sub
End Class
