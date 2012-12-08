Public Class GenerarSectorForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Try
            ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow("")
            ShowComboBox.ValueMember = "identificador"
            ShowComboBox.DisplayMember = "descripcion"

            FechaComboBox.DataSource = BLL.GestorFechaBLL.listarFechas(ShowComboBox.SelectedValue)
            FechaComboBox.ValueMember = "identificador"
            FechaComboBox.DisplayMember = "descripcion"

            TipoSectorComboBox.DataSource = BLL.GestorSectorBLL.listarTipoSector()
            TipoSectorComboBox.ValueMember = "identificador"
            TipoSectorComboBox.DisplayMember = "descripcion"
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        
    End Sub

    Private Sub AltaSectorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaSectorButton.Click
        Try
            If (BLL.GestorSectorBLL.altaSector(NombreTextBox.Text,
                                               ShowComboBox.SelectedValue,
                                               TipoSectorComboBox.SelectedValue,
                                               FechaComboBox.SelectedIndex,
                                               FilasTextBox.Text,
                                               ColumnasTextBox.Text,
                                               PrecioTextBox.Text)) Then
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.SectorCreadoExitosamente)
                limpiarForm()
                Throw New Excepciones.SectorCreadoExistosamenteExcepcion
            End If
        Catch ex As Excepciones.SectorCreadoExistosamenteExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub ShowComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowComboBox.SelectedIndexChanged
        Try
            If TypeOf ShowComboBox.SelectedValue Is Integer Then
                FechaComboBox.DataSource = BLL.GestorFechaBLL.listarFechas(ShowComboBox.SelectedValue)
                FechaComboBox.ValueMember = "identificador"
                FechaComboBox.DisplayMember = "descripcion"
            End If
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
        
    End Sub
End Class
