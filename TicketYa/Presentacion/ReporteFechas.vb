Public Class ReporteFechas
    Dim data As List(Of BE.FechaReporte)

    Private Sub ReporteFechasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me..DataSource = data
        Me.FechaReporteBindingSource.DataSource = data
        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub addData(ByVal p1 As List(Of BE.FechaReporte))
        data = p1
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class
