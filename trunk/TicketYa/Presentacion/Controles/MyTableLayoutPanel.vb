Public Class MyTableLayoutPanel
    Inherits TableLayoutPanel

    Public Sub New(ByVal filas As Integer, ByVal col As Integer)
        Me.Size = New System.Drawing.Size((20 * col) + 10, (20 * filas) + 10)
        Me.RowCount = filas
        Me.ColumnCount = col

        For index = 0 To filas - 1
            Me.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))
        Next

        For index = 0 To col - 1
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20))
        Next

        Me.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single
        'Me.Dock = DockStyle.Fill
    End Sub
End Class
