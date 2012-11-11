Public Class BuscarSedeForm

    Private Sub BuscarSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarSedeButton.Click
        buscarSede()
    End Sub

    Private Sub ModificarSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarSedeButton.Click
        Dim sede As BE.SedeBE
        If SedesDataGrid.hasSelectedObject = True Then
            sede = DirectCast(SedesDataGrid.myObject, BE.SedeBE)
            Dim form As ModificarSedeForm

            If (Not sede Is Nothing) Then
                form = New ModificarSedeForm
                form.addSede(sede)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarSedeButton.Click
        Dim sede As BE.SedeBE
        If SedesDataGrid.hasSelectedObject = True Then
            sede = DirectCast(SedesDataGrid.myObject, BE.SedeBE)
            Try
                BLL.GestorSedeBLL.eliminarSede(sede)
                buscarSede()
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, sede.descripcion, Utilitarios.Enumeradores.Bitacora.SedeEliminada)
                Throw New Excepciones.SedeEliminadaExistosamenteExcepcion
            Catch ex As Excepciones.SedeEliminadaExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.SedeTieneShowsAsociadosExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarSede()
        Try
            SedesDataGrid.DataSource = BLL.GestorSedeBLL.buscarSede(SedeTextBox.Text)
        Catch ex As Excepciones.SedesNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
