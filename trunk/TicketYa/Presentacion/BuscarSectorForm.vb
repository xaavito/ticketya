Public Class BuscarSectorForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow("")
        ShowComboBox.DisplayMember = "descripcion"
        ShowComboBox.ValueMember = "identificador"
    End Sub
    Private Sub BuscarSectorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarSectorButton.Click
        buscarSector()
    End Sub

    Private Sub ModificarSectorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarSectorButton.Click
        Dim Sector As BE.SectorBE
        If SectoresDataGrid.hasSelectedObject = True Then
            Sector = DirectCast(SectoresDataGrid.myObject, BE.SectorBE)
            Dim form As ModificarSectorForm

            If (Not Sector Is Nothing) Then
                form = New ModificarSectorForm
                form.addSector(Sector)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarSectorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarSectorButton.Click
        Dim Sector As BE.SectorBE
        If SectoresDataGrid.hasSelectedObject = True Then
            Sector = DirectCast(SectoresDataGrid.myObject, BE.SectorBE)
            Try
                BLL.GestorSectorBLL.eliminarSector(Sector)
                buscarSector()
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, Sector.descripcion, Utilitarios.Enumeradores.Bitacora.SectorEliminado)
                Throw New Excepciones.SectorEliminadoExistosamenteExcepcion
            Catch ex As Excepciones.SectorEliminadoExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.SectorTieneVentasAsociadasExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarSector()
        Try
            'SectoresDataGrid.DataSource = BLL.GestorSectorBLL.buscarSector(SectorTextBox.Text)
        Catch ex As Excepciones.SectoresNoEncontradosExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub ReportesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesButton.Click
        Dim sector As BE.SectorBE
        If SectoresDataGrid.hasSelectedObject = True Then
            sector = DirectCast(SectoresDataGrid.myObject, BE.SectorBE)
            Try
                Dim report As New ReporteSectoresForm
                report.addData(BLL.GestorReportesBLL.buscarSectorReporte(sector))
                report.ShowDialog()
                'buscarFecha()
                'BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, Fecha.descripcion, Utilitarios.Enumeradores.Bitacora.FechaEliminada)
                'Throw New Excepciones.FechaEliminadaExistosamenteExcepcion
            Catch ex As Excepciones.FechaEliminadaExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.FechaTieneVentasAsociadasExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
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
                SectoresDataGrid.DataSource = BLL.GestorSectorBLL.buscarSectorPorFecha(FechaComboBox.SelectedValue)
            Catch ex As Excepciones.SectorNoEncontradoExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub
End Class
