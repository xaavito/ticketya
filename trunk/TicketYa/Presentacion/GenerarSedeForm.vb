Public Class GenerarSedeForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        NombreTextBox.texto = True
        CapacidadTexBox.numerico = True
        DireccionTextBox.texto = True
        NumeroTextBox.numerico = True
        TelefonoTextBox.numerico = True

        NombreTextBox.boton = AltaSedeButton
        CapacidadTexBox.boton = AltaSedeButton
        DireccionTextBox.boton = AltaSedeButton
        NumeroTextBox.boton = AltaSedeButton
        TelefonoTextBox.boton = AltaSedeButton
    End Sub

    Private Sub AltaSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaSedeButton.Click
        If Not NombreTextBox.esVacio And
            Not CapacidadTexBox.esVacio And
            Not DireccionTextBox.esVacio And
            Not NumeroTextBox.esVacio And
            Not TelefonoTextBox.esVacio Then

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
        End If
    End Sub
End Class
