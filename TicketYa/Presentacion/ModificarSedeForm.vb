Public Class ModificarSedeForm
    Dim sede As BE.SedeBE

    Sub addSede(ByVal sedeToLoad As BE.SedeBE)
        sede = sedeToLoad

        NombreTextBox.Text = sede.descripcion
        CapacidadTexBox.Text = sede.capacidad
        DireccionTextBox.Text = sede.direccion
        NumeroTextBox.Text = sede.numero
        TelefonoTextBox.Text = sede.telefono

    End Sub

    Private Sub AltaSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaSedeButton.Click
        Try
            BLL.GestorSedeBLL.ModificarSede(sede.identificador,
                                            NombreTextBox.Text,
                                            CapacidadTexBox.Text,
                                            DireccionTextBox.Text,
                                            NumeroTextBox.Text,
                                            TelefonoTextBox.Text)
        Catch ex As Excepciones.SedeModificadaExistosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.SedeModificadaExistosamente)
            limpiarForm()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub ModificarSedeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
