Public Class ReporteSectoresForm
    Dim data As List(Of BE.SectorReporte)

    Private Sub ReporteSectoresForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SectorReporteBindingSource.DataSource = data
        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub addData(ByVal p1 As List(Of BE.SectorReporte))
        data = p1

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
