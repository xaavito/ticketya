Public Class GenerarVentaForm
    Dim selectedSector As New BE.SectorBE
    Dim selectedFecha As New BE.FechaBE
    Dim selectedShow As New BE.ShowBE
    Dim selectedComprador As New BE.UsuarioBE

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Try
            PromocionComboBox.DataSource = BLL.GestorVentasBLL.buscarPromociones()
            PromocionComboBox.DisplayMember = "descripcion"
            PromocionComboBox.ValueMember = "identificador"
        Catch ex As Excepciones.PromocionesNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        
    End Sub
    
    Private Sub BuscarCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarCompradorButton.Click
        Try
            CompradoresComboBox.DataSource = BLL.GestorUsuarioBLL.buscarCompradorCombo(ApellidoTextBox.Text)
            CompradoresComboBox.DisplayMember = "nombre"
            CompradoresComboBox.ValueMember = "identificador"

        Catch ex As Excepciones.CompradorNoEncontradoExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
        
    End Sub

    Private Sub BuscarShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarShowButton.Click
        ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow(ShowTextBox.Text)
        ShowComboBox.DisplayMember = "descripcion"
        ShowComboBox.ValueMember = "identificador"
    End Sub

    Private Sub NuevoCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoCompradorButton.Click
        Dim nuevoUsr As New GenerarCompradorForm
        nuevoUsr.ShowDialog()
    End Sub

    Private Sub ShowComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowComboBox.SelectedIndexChanged
        If TypeOf ShowComboBox.SelectedValue Is Integer Then
            Try
                selectedShow = DirectCast(ShowComboBox.SelectedItem, BE.ShowBE)
                FechaComboBox.DataSource = BLL.GestorFechaBLL.listarFechas(ShowComboBox.SelectedValue)
            Catch ex As Excepciones.FechasNoEncontradasExcepcion
                My.Application.manejarExcepcion(ex)
            End Try

            FechaComboBox.DisplayMember = "forLista"
            FechaComboBox.ValueMember = "identificador"
        End If
        
    End Sub

    Private Sub FechaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaComboBox.SelectedIndexChanged
        If TypeOf FechaComboBox.SelectedValue Is Integer Then
            Try
                selectedFecha = DirectCast(FechaComboBox.SelectedItem, BE.FechaBE)
                selectedFecha.show = selectedShow
                SectorComboBox.DataSource = BLL.GestorSectorBLL.buscarSectorPorFecha(FechaComboBox.SelectedValue)
                SectorComboBox.DisplayMember = "descripcion"
                SectorComboBox.ValueMember = "identificador"

                selectedSector = DirectCast(SectorComboBox.SelectedItem, BE.SectorBE)
                selectedSector.fecha = selectedFecha
            Catch ex As Excepciones.SectorNoEncontradoExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Private Sub SectorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectorComboBox.SelectedIndexChanged
        If selectedSector IsNot Nothing And selectedSector.filas <> 0 Then
            selectedSector = DirectCast(SectorComboBox.SelectedItem, BE.SectorBE)
            selectedSector.fecha = selectedFecha

            Dim listaSillas As List(Of BE.SillaBE) = Nothing
            Try
                selectedSector.fecha = selectedFecha
                listaSillas = BLL.GestorSillaBLL.getSillas(SectorComboBox.SelectedValue, FechaComboBox.SelectedValue)
            Catch ex As Excepciones.SillasNoEncontradasExcepcion
                SectorComboBox.DataSource = Nothing
                SectorComboBox.Enabled = False
                Panel.Controls.Clear()
                My.Application.manejarExcepcion(ex)
            End Try

            Dim sillasPanel As New MyTableLayoutPanel(selectedSector.filas, selectedSector.columnas)

            Dim check As MyChairButton = Nothing

            For fila = 0 To sillasPanel.RowCount - 1
                For col = 0 To sillasPanel.ColumnCount - 1
                    For Each silla As BE.SillaBE In listaSillas
                        If silla.fila = fila And silla.columna = col Then
                            silla.sector = selectedSector
                            check = New MyChairButton(silla)
                            check.addParent(VentaDataGrid)
                        End If
                    Next
                    sillasPanel.Controls.Add(check, col, fila)
                Next
            Next
            Panel.Controls.Clear()
            Panel.Controls.Add(sillasPanel)
            Panel.AutoScroll = True

        End If
    End Sub

    Private Sub AceptarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarButton.Click
        Dim detalleVenta As BE.DetalleVentaBE
        Dim listaVentas As New List(Of BE.DetalleVentaBE)
        For Each detVenta As DataGridViewRow In VentaDataGrid.Rows
            detalleVenta = New BE.DetalleVentaBE

            detalleVenta.idSilla = detVenta.Cells.Item("idSilla").Value
            detalleVenta.idSector = detVenta.Cells.Item("idSector").Value
            detalleVenta.idShow = detVenta.Cells.Item("idShow").Value
            detalleVenta.idFecha = detVenta.Cells.Item("idFecha").Value
            detalleVenta.show = detVenta.Cells.Item("ShowColumn").Value
            detalleVenta.fecha = detVenta.Cells.Item("FechaColumn").Value
            detalleVenta.sector = detVenta.Cells.Item("SectorColumn").Value
            detalleVenta.fila = detVenta.Cells.Item("FilaColumn").Value
            detalleVenta.columna = detVenta.Cells.Item("ColumnaColumn").Value
            detalleVenta.valor = detVenta.Cells.Item("PrecioColumn").Value

            listaVentas.Add(detalleVenta)
        Next

        Dim venta As New BE.VentaBE
        venta.comprador = selectedComprador
        venta.vendedor = BLL.Actual.usuario
        venta.promocion = DirectCast(PromocionComboBox.SelectedItem, BE.PromocionBE)
        venta.total = TotalTextBox.Text

        Try
            If EfectivoCheckBox.Checked = True Then
                BLL.GestorVentasBLL.generarVenta(venta, listaVentas, True)
            Else
                BLL.GestorVentasBLL.generarVenta(venta, listaVentas, False)
            End If
        Catch ex As Excepciones.VentaGeneradaExitosamente
            Me.Close()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.GenerarDetalleVentaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.GenerarPagoVentaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.GenerarVentaExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub VentaDataGrid_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles VentaDataGrid.RowsAdded
        Dim valor As Decimal
        For Each pepe As DataGridViewRow In VentaDataGrid.Rows
            valor += pepe.Cells.Item(9).Value
        Next

        SubTotalTextBox.Text = valor
        DescuentoTextBox.Text = "0"
        TotalTextBox.Text = Decimal.Parse(valor) - Decimal.Parse(DescuentoTextBox.Text)
    End Sub

    Private Sub CompradoresComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompradoresComboBox.SelectedIndexChanged
        selectedComprador = DirectCast(CompradoresComboBox.SelectedItem, BE.UsuarioBE)
    End Sub
End Class
