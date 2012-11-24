Public Class BuscarVentaForm

    Private Sub BuscarSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarVentaButton.Click
        buscarVentas()
    End Sub

    Public Sub buscarVentas()
        Try
            VentasDataGrid.DataSource = BLL.GestorVentaBLL.buscarVenta(FechaDesdeTextBox.Text,
                                                                       FechaHastaTextBox.Text,
                                                                       MontoDesdeTextBox.Text,
                                                                       MontoHastaTextBox.Text,
                                                                       VendedorComboBox.SelectedIndex,
                                                                       PromocionComboBox.SelectedIndex)
        Catch ex As Excepciones.VentasNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
