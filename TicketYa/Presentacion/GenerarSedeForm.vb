Public Class GenerarSedeForm

    Private Sub AltaSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaSedeButton.Click
        Try
            If (BLL.GestorSedeBLL.altaSede(NombreTextBox.Text, CapacidadTexBox.Text, DireccionTextBox.Text, NumeroTextBox.Text, TelefonoTextBox.Text)) Then
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.SedeCreada)
                limpiarForm()
                Throw New Excepciones.SedeCreadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.SedeCreadaExistosamenteExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
