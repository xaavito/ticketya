Public Class GenerarUsuarioForm
    Dim listaFamilias As List(Of BE.FamiliaBE)

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        FamiliaDataGrid.AutoGenerateColumns = False
        
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
    End Sub

    Private Sub AgregarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarFamiliaButton.Click
        Dim familia As BE.FamiliaBE = DirectCast(FamiliaComboBox.SelectedItem, BE.FamiliaBE)
        'listaFamilias.Add(familia)
        Dim row As String() = New String() {familia.identificador, familia.descripcion}
        FamiliaDataGrid.Rows.Add(row)
    End Sub

    Private Sub AltaUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarUsuarioButton.Click
        Try
            If (BLL.GestorUsuarioBLL.altaUsuario(UsuarioTextBox.Text,
                                                PassTextBox.Text,
                                                NombreTextBox.Text,
                                                ApellidoTextBox.Text,
                                                DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE),
                                                getFamilias())) Then
                Throw New Excepciones.UsuarioCreadoExistosamente
                limpiarParametros()
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        Catch ex As Excepciones.UsuarioCreadoExistosamente
            My.Application.HandlerException(ex)
        End Try

    End Sub

    Private Sub initializeFamiliaDataGrid()
        FamiliaDataGrid.ColumnCount = 2
        FamiliaDataGrid.Columns(0).Name = "Identificador"
        FamiliaDataGrid.Columns(1).Name = "Nombre"
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
