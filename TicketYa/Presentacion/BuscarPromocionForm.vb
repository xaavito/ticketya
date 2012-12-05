Public Class BuscarPromocionForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow("")
        ShowComboBox.DisplayMember = "descripcion"
        ShowComboBox.ValueMember = "identificador"
    End Sub
    Private Sub BuscarPromocionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPromocionButton.Click
        buscarPromocion()
    End Sub

    Private Sub ModificarPromocionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarPromocionButton.Click
        Dim Promocion As BE.PromocionBE
        If PromocionesDataGrid.hasSelectedObject = True Then
            Promocion = DirectCast(PromocionesDataGrid.myObject, BE.PromocionBE)
            Dim form As ModificarPromocionForm

            If (Not Promocion Is Nothing) Then
                form = New ModificarPromocionForm
                form.addPromocion(Promocion)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarPromocionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarPromocionButton.Click
        Dim Promocion As BE.PromocionBE
        If PromocionesDataGrid.hasSelectedObject = True Then
            Promocion = DirectCast(PromocionesDataGrid.myObject, BE.PromocionBE)
            Try
                BLL.GestorPromocionBLL.eliminarPromocion(Promocion)
                buscarPromocion()
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, Promocion.descripcion, Utilitarios.Enumeradores.Bitacora.PromocionEliminada)
                Throw New Excepciones.PromocionEliminadaExistosamenteExcepcion
            Catch ex As Excepciones.PromocionEliminadaExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.PromocionTieneVentasAsociadasExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarPromocion()
        Try
            'PromocionesDataGrid.DataSource = BLL.GestorPromocionBLL.buscarPromocion("")
        Catch ex As Excepciones.PromocionesNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub ShowComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowComboBox.SelectedIndexChanged
        If TypeOf ShowComboBox.SelectedValue Is Integer Then
            Try
                FechaComboBox.DataSource = BLL.GestorFechaBLL.listarFechas(ShowComboBox.SelectedValue)
                FechaComboBox.DisplayMember = "forLista"
                FechaComboBox.ValueMember = "identificador"
            Catch ex As Excepciones.FechasNoEncontradasExcepcion
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
            End Try
        End If
    End Sub

    Private Sub SectorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectorComboBox.SelectedIndexChanged
        Dim listaPromociones As New List(Of BE.PromocionBE)
        Dim promo As BE.PromocionBE

        If TypeOf SectorComboBox.SelectedValue Is Integer Then
            Try
                promo = BLL.GestorPromocionBLL.buscarPromocion(SectorComboBox.SelectedValue, FechaComboBox.SelectedValue)
                listaPromociones.Add(promo)
                PromocionesDataGrid.DataSource = listaPromociones
                
            Catch ex As Excepciones.PromocionesNoEncontradasExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub
End Class
