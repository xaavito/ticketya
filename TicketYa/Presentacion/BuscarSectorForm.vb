Public Class BuscarSectorForm

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
            SectoresDataGrid.DataSource = BLL.GestorSectorBLL.buscarSector(SectorTextBox.Text)
        Catch ex As Excepciones.SectoresNoEncontradosExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
