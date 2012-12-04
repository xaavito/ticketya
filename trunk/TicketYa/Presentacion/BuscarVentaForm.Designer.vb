<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarVentaForm
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
        Me.VentasDataGrid = New TicketYa.MyDataGrid()
        Me.BuscarVentaButton = New TicketYa.MyButton()
        Me.DesdeLabel = New System.Windows.Forms.Label()
        Me.HastaLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VendedorComboBox = New TicketYa.MyComboBox()
        Me.FechaGroupBox = New System.Windows.Forms.GroupBox()
        Me.FechaHastaTextBox = New TicketYa.MyMaskedTextBox()
        Me.FechaDesdeTextBox = New TicketYa.MyMaskedTextBox()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompradorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.VentasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FechaGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'VentasDataGrid
        '
        Me.VentasDataGrid.AllowUserToAddRows = False
        Me.VentasDataGrid.AllowUserToDeleteRows = False
        Me.VentasDataGrid.AllowUserToResizeRows = False
        Me.VentasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VentasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.FechaColumn, Me.TotalColumn, Me.VendedorColumn, Me.CompradorColumn})
        Me.VentasDataGrid.Location = New System.Drawing.Point(12, 149)
        Me.VentasDataGrid.Name = "VentasDataGrid"
        Me.VentasDataGrid.ReadOnly = True
        Me.VentasDataGrid.RowHeadersVisible = False
        Me.VentasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentasDataGrid.Size = New System.Drawing.Size(901, 254)
        Me.VentasDataGrid.TabIndex = 10
        '
        'BuscarVentaButton
        '
        Me.BuscarVentaButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarVentaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarVentaButton.Location = New System.Drawing.Point(830, 23)
        Me.BuscarVentaButton.Name = "BuscarVentaButton"
        Me.BuscarVentaButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarVentaButton.TabIndex = 9
        Me.BuscarVentaButton.Text = "Buscar"
        Me.BuscarVentaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarVentaButton.UseVisualStyleBackColor = True
        '
        'DesdeLabel
        '
        Me.DesdeLabel.AutoSize = True
        Me.DesdeLabel.Location = New System.Drawing.Point(9, 22)
        Me.DesdeLabel.Name = "DesdeLabel"
        Me.DesdeLabel.Size = New System.Drawing.Size(38, 13)
        Me.DesdeLabel.TabIndex = 7
        Me.DesdeLabel.Text = "Desde"
        '
        'HastaLabel
        '
        Me.HastaLabel.AutoSize = True
        Me.HastaLabel.Location = New System.Drawing.Point(202, 22)
        Me.HastaLabel.Name = "HastaLabel"
        Me.HastaLabel.Size = New System.Drawing.Size(35, 13)
        Me.HastaLabel.TabIndex = 13
        Me.HastaLabel.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Vendedor"
        '
        'VendedorComboBox
        '
        Me.VendedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VendedorComboBox.emptyItem = Nothing
        Me.VendedorComboBox.FormattingEnabled = True
        Me.VendedorComboBox.lista = Nothing
        Me.VendedorComboBox.Location = New System.Drawing.Point(537, 23)
        Me.VendedorComboBox.Name = "VendedorComboBox"
        Me.VendedorComboBox.Size = New System.Drawing.Size(158, 21)
        Me.VendedorComboBox.TabIndex = 16
        '
        'FechaGroupBox
        '
        Me.FechaGroupBox.Controls.Add(Me.FechaHastaTextBox)
        Me.FechaGroupBox.Controls.Add(Me.FechaDesdeTextBox)
        Me.FechaGroupBox.Controls.Add(Me.HastaLabel)
        Me.FechaGroupBox.Controls.Add(Me.DesdeLabel)
        Me.FechaGroupBox.Location = New System.Drawing.Point(12, 6)
        Me.FechaGroupBox.Name = "FechaGroupBox"
        Me.FechaGroupBox.Size = New System.Drawing.Size(403, 55)
        Me.FechaGroupBox.TabIndex = 23
        Me.FechaGroupBox.TabStop = False
        Me.FechaGroupBox.Text = "Fecha"
        '
        'FechaHastaTextBox
        '
        Me.FechaHastaTextBox.Location = New System.Drawing.Point(243, 19)
        Me.FechaHastaTextBox.Mask = "00/00/0000"
        Me.FechaHastaTextBox.Name = "FechaHastaTextBox"
        Me.FechaHastaTextBox.Size = New System.Drawing.Size(66, 20)
        Me.FechaHastaTextBox.TabIndex = 15
        '
        'FechaDesdeTextBox
        '
        Me.FechaDesdeTextBox.Location = New System.Drawing.Point(69, 20)
        Me.FechaDesdeTextBox.Mask = "00/00/0000"
        Me.FechaDesdeTextBox.Name = "FechaDesdeTextBox"
        Me.FechaDesdeTextBox.Size = New System.Drawing.Size(66, 20)
        Me.FechaDesdeTextBox.TabIndex = 14
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "fecha"
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        '
        'TotalColumn
        '
        Me.TotalColumn.DataPropertyName = "total"
        Me.TotalColumn.HeaderText = "Total"
        Me.TotalColumn.Name = "TotalColumn"
        Me.TotalColumn.ReadOnly = True
        '
        'VendedorColumn
        '
        Me.VendedorColumn.DataPropertyName = "vendedorNombre"
        Me.VendedorColumn.HeaderText = "Vendedor"
        Me.VendedorColumn.Name = "VendedorColumn"
        Me.VendedorColumn.ReadOnly = True
        '
        'CompradorColumn
        '
        Me.CompradorColumn.DataPropertyName = "compradorNombre"
        Me.CompradorColumn.HeaderText = "Comprador"
        Me.CompradorColumn.Name = "CompradorColumn"
        Me.CompradorColumn.ReadOnly = True
        '
        'BuscarVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(925, 415)
        Me.Controls.Add(Me.FechaGroupBox)
        Me.Controls.Add(Me.VendedorComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VentasDataGrid)
        Me.Controls.Add(Me.BuscarVentaButton)
        Me.Name = "BuscarVentaForm"
        Me.Text = "Buscar Venta"
        CType(Me.VentasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FechaGroupBox.ResumeLayout(False)
        Me.FechaGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VentasDataGrid As TicketYa.MyDataGrid
    Friend WithEvents BuscarVentaButton As TicketYa.MyButton
    Friend WithEvents DesdeLabel As System.Windows.Forms.Label
    Friend WithEvents HastaLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VendedorComboBox As TicketYa.MyComboBox
    Friend WithEvents FechaGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FechaHastaTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents FechaDesdeTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendedorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompradorColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
