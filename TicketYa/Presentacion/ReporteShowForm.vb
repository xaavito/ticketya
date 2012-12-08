Public Class ReporteShowForm
    Dim data As List(Of BE.ShowReporte)

    Private Sub ReporteShowForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ShowReporteBindingSource.DataSource = data
        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub addData(ByVal p1 As List(Of BE.ShowReporte))
        data = p1
    End Sub

End Class
