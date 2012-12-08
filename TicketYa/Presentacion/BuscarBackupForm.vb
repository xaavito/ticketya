Public Class BuscarBackupForm
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        buscarBackups()

    End Sub
    Private Sub RealizarBackupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarBackupButton.Click
        If Not DescripcionBackupTextBox.esVacio Then
            Try
                BLL.SeguridadBLL.backup(DescripcionBackupTextBox.Text)
            Catch ex As Excepciones.BackupRealizadoExitosamente
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, DescripcionBackupTextBox.Text, Utilitarios.Enumeradores.Bitacora.BackupGenerado)
                buscarBackups()
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.FalloAlCrearBackup
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Private Sub EliminarBackupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBackupButton.Click
        If BackupDataGrid.hasSelectedObject = True Then
            Dim backup As BE.BackupBE
            backup = DirectCast(BackupDataGrid.myObject, BE.BackupBE)
            Try
                BLL.GestorBackupBLL.eliminarBackup(backup)
            Catch ex As Excepciones.BackupEliminadoExitosamente
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, backup.path, Utilitarios.Enumeradores.Bitacora.BackupEliminado)
                buscarBackups()
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.FalloAlEliminarBackup
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Private Sub buscarBackups()
        Try
            BackupDataGrid.DataSource = BLL.GestorBackupBLL.listarBackups()
        Catch ex As Excepciones.BackupsNoEncontrados
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
