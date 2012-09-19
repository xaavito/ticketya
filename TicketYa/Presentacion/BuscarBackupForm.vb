Public Class BuscarBackupForm
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        buscarBackups()

    End Sub
    Private Sub RealizarBackupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarBackupButton.Click
        BLL.SeguridadBLL.backup("D:\\Prueba")
        buscarBackups()
    End Sub

    Private Sub EliminarBackupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBackupButton.Click

    End Sub

    Private Sub buscarBackups()
        BackupDataGrid.DataSource = BLL.GestorBackupBLL.listarBackups()
    End Sub

End Class
