Public Class GenerarUsuarioForm
    Dim listaFamilias As List(Of BE.FamiliaBE)

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        initializeFamiliaDataGrid()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'listaFamilias = New List(Of BE.FamiliaBE)

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

    Private Sub AltaUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaUsuariosButton.Click
        Try
            BLL.GestorUsuarioBLL.altaUsuario(UsuarioTextBox.Text,
                                             PassTextBox.Text,
                                             NombreTextBox.Text,
                                             ApellidoTextBox.Text,
                                             DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE),
                                             getFamilias())

        Catch ex As Excepciones.InsertExcepcion
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

End Class
