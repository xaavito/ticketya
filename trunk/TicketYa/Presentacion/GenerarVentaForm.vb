Public Class GenerarVentaForm
    Dim selectedSector As New BE.SectorBE
    
    Private Sub BuscarCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarCompradorButton.Click
        CompradoresComboBox.DataSource = BLL.GestorUsuarioBLL.buscarCompradorCombo(ApellidoTextBox.Text)
        CompradoresComboBox.DisplayMember = "nombre"
        CompradoresComboBox.ValueMember = "identificador"
    End Sub

    Private Sub BuscarShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarShowButton.Click
        ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow(ShowTextBox.Text)
        ShowComboBox.DisplayMember = "descripcion"
        ShowComboBox.ValueMember = "identificador"
    End Sub

    Private Sub NuevoCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoCompradorButton.Click

    End Sub

    Private Sub ShowComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowComboBox.SelectedIndexChanged
        If TypeOf ShowComboBox.SelectedValue Is Integer Then
            FechaComboBox.DataSource = BLL.GestorFechaBLL.listarFechas(ShowComboBox.SelectedValue)
            FechaComboBox.DisplayMember = "descripcion"
            FechaComboBox.ValueMember = "identificador"
        End If
        
    End Sub

    Private Sub FechaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaComboBox.SelectedIndexChanged
        If TypeOf FechaComboBox.SelectedValue Is Integer Then
            SectorComboBox.DataSource = BLL.GestorSectorBLL.buscarSectorPorFecha(FechaComboBox.SelectedValue)
            SectorComboBox.DisplayMember = "descripcion"
            SectorComboBox.ValueMember = "identificador"
            selectedSector = DirectCast(SectorComboBox.SelectedItem, BE.SectorBE)
        End If
    End Sub

    Private Sub SectorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectorComboBox.SelectedIndexChanged
        If selectedSector.filas <> 0 Then
            Dim listaSillas As List(Of BE.SillaBE)
            Try
                listaSillas = BLL.GestorSillaBLL.getSillas(SectorComboBox.SelectedValue, FechaComboBox.SelectedValue)
            Catch ex As Exception

            End Try

            Dim sillasPanel As New MyTableLayoutPanel(selectedSector.filas, selectedSector.columnas)

            Dim check As CheckBox

            For fila = 0 To sillasPanel.RowCount - 1
                For col = 0 To sillasPanel.ColumnCount - 1
                    check = New CheckBox
                    sillasPanel.Controls.Add(check, col, fila)
                Next
            Next

            Panel.Controls.Add(sillasPanel)
        End If
    End Sub
End Class
