Public Class BuscarBackupForm
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        buscarBackups()

    End Sub
    Private Sub RealizarBackupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarBackupButton.Click
        If Not String.IsNullOrWhiteSpace(DescripcionBackupTextBox.Text) Then
            Try
                BLL.SeguridadBLL.backup(DescripcionBackupTextBox.Text)
            Catch ex As Excepciones.BackupRealizadoExitosamente
                My.Application.HandlerException(ex)
            End Try

            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, DescripcionBackupTextBox.Text, Utilitarios.Enumeradores.Bitacora.BackupGenerado)
            buscarBackups()
        End If
        
    End Sub

    Private Sub EliminarBackupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBackupButton.Click
        If Not BackupDataGrid.CurrentRow Is Nothing Then
            Dim backup As BE.BackupBE
            backup = DirectCast(BackupDataGrid.CurrentRow.DataBoundItem, BE.BackupBE)
            If (BLL.GestorBackupBLL.eliminarBackup(backup) > 0) Then
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, backup.path, Utilitarios.Enumeradores.Bitacora.BackupEliminado)
                buscarBackups()
            End If
        End If
    End Sub

    Private Sub buscarBackups()
        BackupDataGrid.DataSource = BLL.GestorBackupBLL.listarBackups()
    End Sub

End Class
