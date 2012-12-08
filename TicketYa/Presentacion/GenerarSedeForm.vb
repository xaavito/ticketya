Public Class GenerarSedeForm

    Private Sub AltaSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaSedeButton.Click
        Try
            BLL.GestorSedeBLL.altaSede(NombreTextBox.Text,
                                       CapacidadTexBox.Text,
                                       DireccionTextBox.Text,
                                       NumeroTextBox.Text,
                                       TelefonoTextBox.Text)
        Catch ex As Excepciones.SedeCreadaExistosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.SedeCreada)
            limpiarForm()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
