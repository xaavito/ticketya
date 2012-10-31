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

    Function myObject() As Object
        Return Me.CurrentRow.DataBoundItem
    End Function

    Function hasSelectedObject() As Boolean
        If Me.CurrentRow Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
