Public Class GenerarShowForm
    Private Sub AltaShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaShowButton.Click
        Try
            If (BLL.GestorShowBLL.altaShow(NombreTextBox.Text, TipoShowComboBox.SelectedIndex, SedeComboBox.SelectedIndex)) Then
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.ShowCreadoExistosamente)
                limpiarForm()
                Throw New Excepciones.ShowCreadoExistosamenteExcepcion
            End If
        Catch ex As Excepciones.ShowCreadoExistosamenteExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
