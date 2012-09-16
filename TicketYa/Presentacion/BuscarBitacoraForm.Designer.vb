<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarBitacoraForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.BuscarBitacoraButton = New System.Windows.Forms.Button()
        Me.UsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoBitacoraComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(502, 157)
        Me.DataGridView1.TabIndex = 0
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(13, 13)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsuarioLabel.TabIndex = 1
        Me.UsuarioLabel.Text = "Usuario"
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(13, 35)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoLabel.TabIndex = 2
        Me.TipoLabel.Text = "Tipo"
        '
        'BuscarBitacoraButton
        '
        Me.BuscarBitacoraButton.Location = New System.Drawing.Point(439, 12)
        Me.BuscarBitacoraButton.Name = "BuscarBitacoraButton"
        Me.BuscarBitacoraButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBitacoraButton.TabIndex = 4
        Me.BuscarBitacoraButton.Text = "Buscar"
        Me.BuscarBitacoraButton.UseVisualStyleBackColor = True
        '
        'UsuarioComboBox
        '
        Me.UsuarioComboBox.FormattingEnabled = True
        Me.UsuarioComboBox.Location = New System.Drawing.Point(91, 10)
        Me.UsuarioComboBox.Name = "UsuarioComboBox"
        Me.UsuarioComboBox.Size = New System.Drawing.Size(121, 21)
        Me.UsuarioComboBox.TabIndex = 6
        '
        'TipoBitacoraComboBox
        '
        Me.TipoBitacoraComboBox.FormattingEnabled = True
        Me.TipoBitacoraComboBox.Location = New System.Drawing.Point(91, 32)
        Me.TipoBitacoraComboBox.Name = "TipoBitacoraComboBox"
        Me.TipoBitacoraComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoBitacoraComboBox.TabIndex = 7
        '
        'BuscarBitacoraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(526, 277)
        Me.Controls.Add(Me.TipoBitacoraComboBox)
        Me.Controls.Add(Me.UsuarioComboBox)
        Me.Controls.Add(Me.BuscarBitacoraButton)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BuscarBitacoraForm"
        Me.Text = "Bitacoras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents TipoLabel As System.Windows.Forms.Label
    Friend WithEvents BuscarBitacoraButton As System.Windows.Forms.Button
    Friend WithEvents UsuarioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipoBitacoraComboBox As System.Windows.Forms.ComboBox

End Class
