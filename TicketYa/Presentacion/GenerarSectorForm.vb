Public Class GenerarSectorForm

    Private Sub AltaSectorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaSectorButton.Click
        Try
            If (BLL.GestorSectorBLL.altaSector(NombreTextBox.Text, ShowComboBox.SelectedIndex, TipoSectorComboBox.SelectedIndex, FechaComboBox.SelectedIndex, FilasTextBox.Text, ColumnasTextBox.Text, PrecioTextBox.Text)) Then
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.SectorCreadoExitosamente)
                limpiarForm()
                Throw New Excepciones.SectorCreadoExistosamenteExcepcion
            End If
        Catch ex As Excepciones.SectorCreadoExistosamenteExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
