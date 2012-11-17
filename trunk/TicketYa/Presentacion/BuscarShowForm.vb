Public Class BuscarShowForm

    Private Sub BuscarShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarShowButton.Click
        buscarShow()
    End Sub

    Private Sub ModificarShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarShowButton.Click
        Dim Show As BE.ShowBE
        If ShowsDataGrid.hasSelectedObject = True Then
            Show = DirectCast(ShowsDataGrid.myObject, BE.ShowBE)
            Dim form As ModificarShowForm

            If (Not Show Is Nothing) Then
                form = New ModificarShowForm
                form.addShow(Show)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarShowButton.Click
        Dim Show As BE.ShowBE
        If ShowsDataGrid.hasSelectedObject = True Then
            Show = DirectCast(ShowsDataGrid.myObject, BE.ShowBE)
            Try
                BLL.GestorShowBLL.eliminarShow(Show)
                buscarShow()
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, Show.descripcion, Utilitarios.Enumeradores.Bitacora.ShowEliminado)
                Throw New Excepciones.ShowEliminadoExistosamenteExcepcion
            Catch ex As Excepciones.ShowEliminadoExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.ShowTieneVentasAsociadosExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarShow()
        Try
            ShowsDataGrid.DataSource = BLL.GestorShowBLL.buscarShow(ShowTextBox.Text)
        Catch ex As Excepciones.ShowsNoEncontradosExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
