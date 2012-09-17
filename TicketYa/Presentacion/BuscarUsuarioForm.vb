Public Class BuscarUsuarioForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub BuscarUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarUsuariosButton.Click
        UsuariosDataGrid.AutoGenerateColumns = False
        UsuariosDataGrid.DataSource = BLL.GestorUsuarioBLL.buscarUsuario(UsuarioTextBox.Text)
    End Sub

    Private Sub ModificarUsuarioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarUsuarioButton.Click
        Dim pepe As String = UsuariosDataGrid.SelectedRows.Item(0).Cells.Item(0).Value
        coco()
    End Sub

    Private Sub EliminarUsuarioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarUsuarioButton.Click

    End Sub
End Class
