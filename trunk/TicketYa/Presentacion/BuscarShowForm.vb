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
            Catch ex As Excepciones.ShowEliminadoExistosamenteExcepcion
                buscarShow()
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, Show.descripcion, Utilitarios.Enumeradores.Bitacora.ShowEliminado)
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.ShowTieneFechasAsociadosExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarShow()
        Try
            ShowsDataGrid.DataSource = BLL.GestorShowBLL.buscarShow(ShowTextBox.Text)
        Catch ex As Excepciones.ShowsNoEncontradosExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub ReportesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesButton.Click
        Dim show As BE.ShowBE
        If ShowsDataGrid.hasSelectedObject = True Then
            show = DirectCast(ShowsDataGrid.myObject, BE.ShowBE)
            Try
                Dim report As New ReporteShowForm
                report.addData(BLL.GestorReportesBLL.buscarShowReporte(show))
                report.ShowDialog()
            Catch ex As Excepciones.ShowsNoEncontradosExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.FechaTieneVentasAsociadasExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub
End Class
