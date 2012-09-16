Public Class BuscarUsuarioForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().



    End Sub

    Private Sub BuscarUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarUsuariosButton.Click
        UsuariosDataGrid.DataSource = BLL.GestorUsuarioBLL.buscarUsuario(UsuarioTextBox.Text)
    End Sub
End Class
