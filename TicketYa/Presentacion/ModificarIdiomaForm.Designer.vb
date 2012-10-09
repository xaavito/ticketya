<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarIdiomaForm
    Inherits TicketYa.BaseForm

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ExcepcionLabel = New System.Windows.Forms.Label()
        Me.MensajeBitacoraLabel = New System.Windows.Forms.Label()
        Me.ControlesLabel = New System.Windows.Forms.Label()
        Me.ExcepcionesDataGrid = New System.Windows.Forms.DataGridView()
        Me.MensajesDataGrid = New System.Windows.Forms.DataGridView()
        Me.ControlesDataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.ExcepcionesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensajesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExcepcionLabel
        '
        Me.ExcepcionLabel.AutoSize = True
        Me.ExcepcionLabel.Location = New System.Drawing.Point(91, 20)
        Me.ExcepcionLabel.Name = "ExcepcionLabel"
        Me.ExcepcionLabel.Size = New System.Drawing.Size(68, 13)
        Me.ExcepcionLabel.TabIndex = 0
        Me.ExcepcionLabel.Text = "Excepciones"
        '
        'MensajeBitacoraLabel
        '
        Me.MensajeBitacoraLabel.AutoSize = True
        Me.MensajeBitacoraLabel.Location = New System.Drawing.Point(369, 20)
        Me.MensajeBitacoraLabel.Name = "MensajeBitacoraLabel"
        Me.MensajeBitacoraLabel.Size = New System.Drawing.Size(89, 13)
        Me.MensajeBitacoraLabel.TabIndex = 1
        Me.MensajeBitacoraLabel.Text = "Mensaje Bitacora"
        '
        'ControlesLabel
        '
        Me.ControlesLabel.AutoSize = True
        Me.ControlesLabel.Location = New System.Drawing.Point(706, 20)
        Me.ControlesLabel.Name = "ControlesLabel"
        Me.ControlesLabel.Size = New System.Drawing.Size(51, 13)
        Me.ControlesLabel.TabIndex = 2
        Me.ControlesLabel.Text = "Controles"
        '
        'ExcepcionesDataGrid
        '
        Me.ExcepcionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExcepcionesDataGrid.Location = New System.Drawing.Point(12, 36)
        Me.ExcepcionesDataGrid.Name = "ExcepcionesDataGrid"
        Me.ExcepcionesDataGrid.Size = New System.Drawing.Size(239, 150)
        Me.ExcepcionesDataGrid.TabIndex = 3
        '
        'MensajesDataGrid
        '
        Me.MensajesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MensajesDataGrid.Location = New System.Drawing.Point(296, 36)
        Me.MensajesDataGrid.Name = "MensajesDataGrid"
        Me.MensajesDataGrid.Size = New System.Drawing.Size(246, 150)
        Me.MensajesDataGrid.TabIndex = 4
        '
        'ControlesDataGrid
        '
        Me.ControlesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ControlesDataGrid.Location = New System.Drawing.Point(608, 36)
        Me.ControlesDataGrid.Name = "ControlesDataGrid"
        Me.ControlesDataGrid.Size = New System.Drawing.Size(247, 150)
        Me.ControlesDataGrid.TabIndex = 5
        '
        'ModificarIdiomaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(879, 346)
        Me.Controls.Add(Me.ControlesDataGrid)
        Me.Controls.Add(Me.MensajesDataGrid)
        Me.Controls.Add(Me.ExcepcionesDataGrid)
        Me.Controls.Add(Me.ControlesLabel)
        Me.Controls.Add(Me.MensajeBitacoraLabel)
        Me.Controls.Add(Me.ExcepcionLabel)
        Me.Name = "ModificarIdiomaForm"
        Me.Text = "ModificarIdioma"
        CType(Me.ExcepcionesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MensajesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExcepcionLabel As System.Windows.Forms.Label
    Friend WithEvents MensajeBitacoraLabel As System.Windows.Forms.Label
    Friend WithEvents ControlesLabel As System.Windows.Forms.Label
    Friend WithEvents ExcepcionesDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MensajesDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ControlesDataGrid As System.Windows.Forms.DataGridView

End Class
