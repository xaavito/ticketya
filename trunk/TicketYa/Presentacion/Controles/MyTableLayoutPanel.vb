Public Class MyTableLayoutPanel
    Inherits TableLayoutPanel

    Dim controlSize As Integer = 32

    Public Sub New(ByVal filas As Integer, ByVal col As Integer)
        Me.Size = New System.Drawing.Size((controlSize * col) + 10, (controlSize * filas) + 10)
        Me.RowCount = filas
        Me.ColumnCount = col

        For index = 0 To filas - 1
            Me.RowStyles.Add(New RowStyle(SizeType.Absolute, controlSize))
        Next

        For index = 0 To col - 1
            Me.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, controlSize))
        Next

        Me.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single
        'Me.Dock = DockStyle.Fill
    End Sub
End Class
