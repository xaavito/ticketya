Public Class GenerarVentaForm
    Dim selectedSector As New BE.SectorBE
    Dim selectedFecha As New BE.FechaBE
    Dim selectedShow As New BE.ShowBE
    
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

            FechaComboBox.DisplayMember = "descripcion"
            FechaComboBox.ValueMember = "identificador"
        End If
        
    End Sub

    Private Sub FechaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaComboBox.SelectedIndexChanged
        If TypeOf FechaComboBox.SelectedValue Is Integer Then
            Try
                selectedFecha = DirectCast(FechaComboBox.SelectedItem, BE.FechaBE)
                selectedFecha.show = selectedShow
                SectorComboBox.DataSource = BLL.GestorSectorBLL.buscarSectorPorFecha(FechaComboBox.SelectedValue)
            Catch ex As Excepciones.SectorNoEncontradoExcepcion
                My.Application.manejarExcepcion(ex)
            End Try

            SectorComboBox.DisplayMember = "descripcion"
            SectorComboBox.ValueMember = "identificador"
            selectedSector = DirectCast(SectorComboBox.SelectedItem, BE.SectorBE)
            selectedSector.fecha = DirectCast(FechaComboBox.SelectedItem, BE.FechaBE)
        End If
    End Sub

    Private Sub SectorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectorComboBox.SelectedIndexChanged
        If selectedSector IsNot Nothing And selectedSector.filas <> 0 Then
            Dim listaSillas As List(Of BE.SillaBE) = Nothing
            Try
                selectedSector.fecha = selectedFecha
                listaSillas = BLL.GestorSillaBLL.getSillas(SectorComboBox.SelectedValue, FechaComboBox.SelectedValue)
            Catch ex As Excepciones.SillasNoEncontradasExcepcion
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

            Panel.Controls.Add(sillasPanel)
            Panel.AutoScroll = True

        End If
    End Sub

    Private Sub AceptarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarButton.Click

    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
End Class
