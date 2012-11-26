Public Class GenerarShowForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            TipoShowComboBox.DataSource = BLL.GestorShowBLL.buscarTipoShow("")
            TipoShowComboBox.ValueMember = "identificador"
            TipoShowComboBox.DisplayMember = "descripcion"
        Catch ex As Excepciones.TipoShowsNoEncontradosExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
        
        Try
            SedeComboBox.DataSource = BLL.GestorSedeBLL.buscarSede("")
            SedeComboBox.ValueMember = "identificador"
            SedeComboBox.DisplayMember = "descripcion"
        Catch ex As Excepciones.SedesNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
        
    End Sub
    Private Sub AltaShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaShowButton.Click
        Try
            BLL.GestorShowBLL.altaShow(NombreTextBox.Text, TipoShowComboBox.SelectedValue, SedeComboBox.SelectedValue)
        Catch ex As Excepciones.ShowCreadoExistosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.ShowCreadoExistosamente)
            limpiarForm()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
