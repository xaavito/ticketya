Public Class ModificarShowForm
    Dim baseShow As BE.ShowBE = Nothing

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

    Sub addShow(ByVal ShowToLoad As BE.ShowBE)
        baseShow = ShowToLoad
        NombreTextBox.Text = baseShow.descripcion
        TipoShowComboBox.SelectedValue = baseShow.tipoShow.identificador
        SedeComboBox.SelectedValue = baseShow.sede.identificador
    End Sub

    Private Sub ModificarShowForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub AltaShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaShowButton.Click
        Try
            BLL.GestorShowBLL.modificarShow(baseShow.identificador, NombreTextBox.Text, TipoShowComboBox.SelectedValue, SedeComboBox.SelectedValue)
        Catch ex As Excepciones.ShowModificadoExistosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.ShowModificadoExistosamente)
            limpiarForm()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
