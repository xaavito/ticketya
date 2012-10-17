Public Class MyDataGrid
    Inherits DataGridView

    Sub New()
        Me.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AutoGenerateColumns = False
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.AllowUserToResizeRows = False
        Me.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RowHeadersVisible = False
        Me.ReadOnly = True
    End Sub

End Class
