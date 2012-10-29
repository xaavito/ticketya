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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarBitacoraForm))
        Me.TipoBitacoraComboBox = New TicketYa.MyComboBox()
        Me.UsuarioComboBox = New TicketYa.MyComboBox()
        Me.BuscarBitacoraButton = New TicketYa.MyButton()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.BitacorasDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BitacorasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoBitacoraComboBox
        '
        Me.TipoBitacoraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoBitacoraComboBox.FormattingEnabled = True
        Me.TipoBitacoraComboBox.Location = New System.Drawing.Point(91, 32)
        Me.TipoBitacoraComboBox.Name = "TipoBitacoraComboBox"
        Me.TipoBitacoraComboBox.Size = New System.Drawing.Size(183, 21)
        Me.TipoBitacoraComboBox.TabIndex = 7
        '
        'UsuarioComboBox
        '
        Me.UsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsuarioComboBox.FormattingEnabled = True
        Me.UsuarioComboBox.Location = New System.Drawing.Point(91, 10)
        Me.UsuarioComboBox.Name = "UsuarioComboBox"
        Me.UsuarioComboBox.Size = New System.Drawing.Size(183, 21)
        Me.UsuarioComboBox.TabIndex = 6
        '
        'BuscarBitacoraButton
        '
        Me.BuscarBitacoraButton.Image = CType(resources.GetObject("BuscarBitacoraButton.Image"), System.Drawing.Image)
        Me.BuscarBitacoraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarBitacoraButton.Location = New System.Drawing.Point(696, 8)
        Me.BuscarBitacoraButton.Name = "BuscarBitacoraButton"
        Me.BuscarBitacoraButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBitacoraButton.TabIndex = 4
        Me.BuscarBitacoraButton.Text = "Buscar"
        Me.BuscarBitacoraButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarBitacoraButton.UseVisualStyleBackColor = True
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
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(13, 13)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsuarioLabel.TabIndex = 1
        Me.UsuarioLabel.Text = "Usuario"
        '
        'BitacorasDataGrid
        '
        Me.BitacorasDataGrid.AllowUserToAddRows = False
        Me.BitacorasDataGrid.AllowUserToDeleteRows = False
        Me.BitacorasDataGrid.AllowUserToResizeRows = False
        Me.BitacorasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BitacorasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BitacorasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.FechaColumn, Me.TipoColumn})
        Me.BitacorasDataGrid.Location = New System.Drawing.Point(12, 108)
        Me.BitacorasDataGrid.Name = "BitacorasDataGrid"
        Me.BitacorasDataGrid.ReadOnly = True
        Me.BitacorasDataGrid.RowHeadersVisible = False
        Me.BitacorasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.BitacorasDataGrid.Size = New System.Drawing.Size(759, 157)
        Me.BitacorasDataGrid.TabIndex = 0
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Indentificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "mensaje"
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        '
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "fecha"
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        '
        'TipoColumn
        '
        Me.TipoColumn.DataPropertyName = "tipo"
        Me.TipoColumn.HeaderText = "Tipo"
        Me.TipoColumn.Name = "TipoColumn"
        Me.TipoColumn.ReadOnly = True
        '
        'BuscarBitacoraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(783, 334)
        Me.Controls.Add(Me.TipoBitacoraComboBox)
        Me.Controls.Add(Me.UsuarioComboBox)
        Me.Controls.Add(Me.BuscarBitacoraButton)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.BitacorasDataGrid)
        Me.Name = "BuscarBitacoraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bitacoras"
        CType(Me.BitacorasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents TipoLabel As System.Windows.Forms.Label
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BitacorasDataGrid As TicketYa.MyDataGrid
    Friend WithEvents BuscarBitacoraButton As TicketYa.MyButton
    Friend WithEvents UsuarioComboBox As TicketYa.MyComboBox
    Friend WithEvents TipoBitacoraComboBox As TicketYa.MyComboBox

End Class
