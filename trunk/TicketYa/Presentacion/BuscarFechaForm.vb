Public Class BuscarFechaForm
    Private Sub BuscarFechaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFechaButton.Click
        buscarFecha()
    End Sub

    Private Sub ModificarFechaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFechaButton.Click
        Dim Fecha As BE.FechaBE
        If FechasDataGrid.hasSelectedObject = True Then
            Fecha = DirectCast(FechasDataGrid.myObject, BE.FechaBE)
            Dim form As ModificarFechaForm

            If (Not Fecha Is Nothing) Then
                form = New ModificarFechaForm
                form.addFecha(Fecha)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarFechaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarFechaButton.Click
        Dim Fecha As BE.FechaBE
        If FechasDataGrid.hasSelectedObject = True Then
            Fecha = DirectCast(FechasDataGrid.myObject, BE.FechaBE)
            Try
                BLL.GestorFechaBLL.eliminarFecha(Fecha)
                buscarFecha()
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, Fecha.descripcion, Utilitarios.Enumeradores.Bitacora.FechaEliminada)
                Throw New Excepciones.FechaEliminadaExistosamenteExcepcion
            Catch ex As Excepciones.FechaEliminadaExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.FechaTieneVentasAsociadasExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarFecha()
        Try
            FechasDataGrid.DataSource = BLL.GestorFechaBLL.buscarFecha(ShowTextBox.Text)
        Catch ex As Excepciones.FechasNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
