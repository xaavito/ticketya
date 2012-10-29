Public Class RealizarRestoreForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        buscarBackups()
    End Sub

    Private Sub RealizarRestoreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarRestoreButton.Click
        If Not BackupDataGrid.CurrentRow Is Nothing Then
            Dim backup As BE.BackupBE
            backup = DirectCast(BackupDataGrid.CurrentRow.DataBoundItem, BE.BackupBE)
            Try
                BLL.SeguridadBLL.restore(backup.path)
            Catch ex As Excepciones.RestoreRealizadoExitosamente
                My.Application.HandlerException(ex)
            Catch ex As Exception
                My.Application.HandlerException(ex)
            End Try

            buscarBackups()
        End If
    End Sub

    Private Sub buscarBackups()
        BackupDataGrid.DataSource = BLL.GestorBackupBLL.listarBackups()
    End Sub
End Class
