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
                If (BLL.SedeBLL.eliminarSede(sede) = 1) Then
                    buscarSede()
                    BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, sede.descripcion, Utilitarios.Enumeradores.Bitacora.SedeEliminada)
                    Throw New Excepciones.SedeEliminadaExistosamenteExcepcion
                Else
                    Throw New Excepciones.SedeTieneShowsAsociadosExcepcion
                End If
            Catch ex As Excepciones.SedeEliminadaExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.SedeTieneShowsAsociadosExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarSede()
        SedesDataGrid.DataSource = BLL.SedeBLL.buscarSede(SedeTextBox.Text)
    End Sub
End Class
