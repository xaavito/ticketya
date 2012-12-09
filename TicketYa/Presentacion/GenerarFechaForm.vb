Public Class GenerarFechaForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow("")
            ShowComboBox.ValueMember = "identificador"
            ShowComboBox.DisplayMember = "descripcion"
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
        

    End Sub
    Private Sub AltaFechaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaFechaButton.Click
        Try
            BLL.GestorFechaBLL.altaFecha(NombreTextBox.Text, FechaTextBox.getDateTime, ShowComboBox.SelectedValue)
        Catch ex As Excepciones.FechaCreadaExistosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.FechaCreada)
            limpiarForm()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
