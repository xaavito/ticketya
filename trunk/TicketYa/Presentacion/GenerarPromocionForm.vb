Public Class GenerarPromocionForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow("")
            ShowComboBox.DisplayMember = "descripcion"
            ShowComboBox.ValueMember = "identificador"

            Dim listaTipos As New List(Of BE.TipoDescuentoBE)
            Dim tipo As New BE.TipoDescuentoBE
            tipo.identificador = 1
            tipo.descripcion = "Porcentaje"
            listaTipos.Add(tipo)
            tipo = New BE.TipoDescuentoBE
            tipo.identificador = 2
            tipo.descripcion = "Valor"
            listaTipos.Add(tipo)

            TipoDescuentoComboBox.DataSource = listaTipos
            TipoDescuentoComboBox.DisplayMember = "descripcion"
            TipoDescuentoComboBox.ValueMember = "identificador"
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

        DescripcionTextBox.alfanumerico = True
        DescripcionTextBox.boton = GenerarPromocionButton
        DescuentoTextBox.numerico = True
        DescuentoTextBox.boton = GenerarPromocionButton
    End Sub

    Private Sub ShowComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowComboBox.SelectedIndexChanged
        If TypeOf ShowComboBox.SelectedValue Is Integer Then
            Try
                FechaComboBox.DataSource = BLL.GestorFechaBLL.listarFechas(ShowComboBox.SelectedValue)
                FechaComboBox.DisplayMember = "forLista"
                FechaComboBox.ValueMember = "identificador"
            Catch ex As Excepciones.FechasNoEncontradasExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try

        End If
    End Sub

    Private Sub FechaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaComboBox.SelectedIndexChanged
        If TypeOf FechaComboBox.SelectedValue Is Integer Then
            Try
                SectorComboBox.DataSource = BLL.GestorSectorBLL.buscarSectorPorFecha(FechaComboBox.SelectedValue)
                SectorComboBox.DisplayMember = "descripcion"
                SectorComboBox.ValueMember = "identificador"
            Catch ex As Excepciones.SectorNoEncontradoExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Private Sub GenerarPromocionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPromocionButton.Click
        Try
            BLL.GestorPromocionBLL.generarPromocion(DescripcionTextBox.Text,
                                                    DesdeTextBox.getDateTime,
                                                    HastaTextBox.getDateTime,
                                                    TipoDescuentoComboBox.SelectedValue,
                                                    DescuentoTextBox.Text,
                                                    FechaComboBox.SelectedValue,
                                                    SectorComboBox.SelectedValue)
        Catch ex As Excepciones.PromocionNoGeneradaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.PromocionCreadaExistosamenteExcepcion
            limpiarForm()
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
