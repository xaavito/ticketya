Public Class GenerarFechaForm

    Private Sub AltaFechaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaFechaButton.Click
        Try
            If (BLL.GestorFechaBLL.altaFecha(NombreTextBox.Text, FechaTextBox.Text, ShowComboBox.SelectedIndex)) Then
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.FechaCreada)
                limpiarForm()
                Throw New Excepciones.FechaCreadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.FechaCreadaExistosamenteExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
