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
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarVentaButton = New TicketYa.MyButton()
        Me.DesdeLabel = New System.Windows.Forms.Label()
        Me.HastaLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VendedorComboBox = New TicketYa.MyComboBox()
        Me.PromocionComboBox = New TicketYa.MyComboBox()
        Me.PromocionLabel = New System.Windows.Forms.Label()
        Me.FechaGroupBox = New System.Windows.Forms.GroupBox()
        Me.MontoGroupBox = New System.Windows.Forms.GroupBox()
        Me.MontoHastaTextBox = New TicketYa.MyTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MontoDesdeTextBox = New TicketYa.MyTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FechaDesdeTextBox = New TicketYa.MyMaskedTextBox()
        Me.FechaHastaTextBox = New TicketYa.MyMaskedTextBox()
        CType(Me.VentasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FechaGroupBox.SuspendLayout()
        Me.MontoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'VentasDataGrid
        '
        Me.VentasDataGrid.AllowUserToAddRows = False
        Me.VentasDataGrid.AllowUserToDeleteRows = False
        Me.VentasDataGrid.AllowUserToResizeRows = False
        Me.VentasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VentasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.CapacidadColumn, Me.DireccionColumn, Me.NumeroColumn, Me.TelefonoColumn})
        Me.VentasDataGrid.Location = New System.Drawing.Point(12, 149)
        Me.VentasDataGrid.Name = "VentasDataGrid"
        Me.VentasDataGrid.ReadOnly = True
        Me.VentasDataGrid.RowHeadersVisible = False
        Me.VentasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentasDataGrid.Size = New System.Drawing.Size(901, 254)
        Me.VentasDataGrid.TabIndex = 10
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "descripcion"
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        '
        'CapacidadColumn
        '
        Me.CapacidadColumn.DataPropertyName = "capacidad"
        Me.CapacidadColumn.HeaderText = "Capacidad"
        Me.CapacidadColumn.Name = "CapacidadColumn"
        Me.CapacidadColumn.ReadOnly = True
        '
        'DireccionColumn
        '
        Me.DireccionColumn.DataPropertyName = "direccion"
        Me.DireccionColumn.HeaderText = "Direccion"
        Me.DireccionColumn.Name = "DireccionColumn"
        Me.DireccionColumn.ReadOnly = True
        '
        'NumeroColumn
        '
        Me.NumeroColumn.DataPropertyName = "numero"
        Me.NumeroColumn.HeaderText = "Numero"
        Me.NumeroColumn.Name = "NumeroColumn"
        Me.NumeroColumn.ReadOnly = True
        '
        'TelefonoColumn
        '
        Me.TelefonoColumn.DataPropertyName = "telefono"
        Me.TelefonoColumn.HeaderText = "Telefono"
        Me.TelefonoColumn.Name = "TelefonoColumn"
        Me.TelefonoColumn.ReadOnly = True
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
        Me.Label1.Location = New System.Drawing.Point(21, 70)
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
        Me.VendedorComboBox.Location = New System.Drawing.Point(81, 67)
        Me.VendedorComboBox.Name = "VendedorComboBox"
        Me.VendedorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VendedorComboBox.TabIndex = 16
        '
        'PromocionComboBox
        '
        Me.PromocionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PromocionComboBox.emptyItem = Nothing
        Me.PromocionComboBox.FormattingEnabled = True
        Me.PromocionComboBox.lista = Nothing
        Me.PromocionComboBox.Location = New System.Drawing.Point(266, 67)
        Me.PromocionComboBox.Name = "PromocionComboBox"
        Me.PromocionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PromocionComboBox.TabIndex = 18
        '
        'PromocionLabel
        '
        Me.PromocionLabel.AutoSize = True
        Me.PromocionLabel.Location = New System.Drawing.Point(206, 70)
        Me.PromocionLabel.Name = "PromocionLabel"
        Me.PromocionLabel.Size = New System.Drawing.Size(57, 13)
        Me.PromocionLabel.TabIndex = 17
        Me.PromocionLabel.Text = "Promocion"
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
        'MontoGroupBox
        '
        Me.MontoGroupBox.Controls.Add(Me.MontoHastaTextBox)
        Me.MontoGroupBox.Controls.Add(Me.Label4)
        Me.MontoGroupBox.Controls.Add(Me.MontoDesdeTextBox)
        Me.MontoGroupBox.Controls.Add(Me.Label5)
        Me.MontoGroupBox.Location = New System.Drawing.Point(421, 6)
        Me.MontoGroupBox.Name = "MontoGroupBox"
        Me.MontoGroupBox.Size = New System.Drawing.Size(403, 55)
        Me.MontoGroupBox.TabIndex = 24
        Me.MontoGroupBox.TabStop = False
        Me.MontoGroupBox.Text = "Monto"
        '
        'MontoHastaTextBox
        '
        Me.MontoHastaTextBox.alfanumerico = False
        Me.MontoHastaTextBox.boton = Nothing
        Me.MontoHastaTextBox.Location = New System.Drawing.Point(254, 19)
        Me.MontoHastaTextBox.nada = False
        Me.MontoHastaTextBox.Name = "MontoHastaTextBox"
        Me.MontoHastaTextBox.numerico = False
        Me.MontoHastaTextBox.sinEspacio = False
        Me.MontoHastaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MontoHastaTextBox.TabIndex = 14
        Me.MontoHastaTextBox.texto = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Hasta"
        '
        'MontoDesdeTextBox
        '
        Me.MontoDesdeTextBox.alfanumerico = False
        Me.MontoDesdeTextBox.boton = Nothing
        Me.MontoDesdeTextBox.Location = New System.Drawing.Point(69, 19)
        Me.MontoDesdeTextBox.nada = False
        Me.MontoDesdeTextBox.Name = "MontoDesdeTextBox"
        Me.MontoDesdeTextBox.numerico = False
        Me.MontoDesdeTextBox.sinEspacio = False
        Me.MontoDesdeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MontoDesdeTextBox.TabIndex = 8
        Me.MontoDesdeTextBox.texto = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Desde"
        '
        'FechaDesdeTextBox
        '
        Me.FechaDesdeTextBox.Location = New System.Drawing.Point(69, 20)
        Me.FechaDesdeTextBox.Mask = "00/00/0000"
        Me.FechaDesdeTextBox.Name = "FechaDesdeTextBox"
        Me.FechaDesdeTextBox.Size = New System.Drawing.Size(66, 20)
        Me.FechaDesdeTextBox.TabIndex = 14
        '
        'FechaHastaTextBox
        '
        Me.FechaHastaTextBox.Location = New System.Drawing.Point(243, 19)
        Me.FechaHastaTextBox.Mask = "00/00/0000"
        Me.FechaHastaTextBox.Name = "FechaHastaTextBox"
        Me.FechaHastaTextBox.Size = New System.Drawing.Size(66, 20)
        Me.FechaHastaTextBox.TabIndex = 15
        '
        'BuscarVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(925, 415)
        Me.Controls.Add(Me.MontoGroupBox)
        Me.Controls.Add(Me.FechaGroupBox)
        Me.Controls.Add(Me.PromocionComboBox)
        Me.Controls.Add(Me.PromocionLabel)
        Me.Controls.Add(Me.VendedorComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VentasDataGrid)
        Me.Controls.Add(Me.BuscarVentaButton)
        Me.Name = "BuscarVentaForm"
        Me.Text = "Buscar Venta"
        CType(Me.VentasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FechaGroupBox.ResumeLayout(False)
        Me.FechaGroupBox.PerformLayout()
        Me.MontoGroupBox.ResumeLayout(False)
        Me.MontoGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VentasDataGrid As TicketYa.MyDataGrid
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarVentaButton As TicketYa.MyButton
    Friend WithEvents DesdeLabel As System.Windows.Forms.Label
    Friend WithEvents HastaLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VendedorComboBox As TicketYa.MyComboBox
    Friend WithEvents PromocionComboBox As TicketYa.MyComboBox
    Friend WithEvents PromocionLabel As System.Windows.Forms.Label
    Friend WithEvents FechaGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MontoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MontoHastaTextBox As TicketYa.MyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MontoDesdeTextBox As TicketYa.MyTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FechaHastaTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents FechaDesdeTextBox As TicketYa.MyMaskedTextBox

End Class
