<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarPromocionForm
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
        Me.EliminarPromocionButton = New TicketYa.MyButton()
        Me.ModificarPromocionButton = New TicketYa.MyButton()
        Me.PromocionesDataGrid = New TicketYa.MyDataGrid()
        Me.BuscarPromocionButton = New TicketYa.MyButton()
        Me.FechaComboBox = New TicketYa.MyComboBox()
        Me.ShowComboBox = New TicketYa.MyComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.SectorLabel = New System.Windows.Forms.Label()
        Me.SectorComboBox = New TicketYa.MyComboBox()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HastaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PromocionesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EliminarPromocionButton
        '
        Me.EliminarPromocionButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarPromocionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarPromocionButton.Location = New System.Drawing.Point(692, 155)
        Me.EliminarPromocionButton.Name = "EliminarPromocionButton"
        Me.EliminarPromocionButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarPromocionButton.TabIndex = 26
        Me.EliminarPromocionButton.Text = "Eliminar"
        Me.EliminarPromocionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarPromocionButton.UseVisualStyleBackColor = True
        '
        'ModificarPromocionButton
        '
        Me.ModificarPromocionButton.Image = Global.TicketYa.My.Resources.Resources.editar
        Me.ModificarPromocionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarPromocionButton.Location = New System.Drawing.Point(692, 79)
        Me.ModificarPromocionButton.Name = "ModificarPromocionButton"
        Me.ModificarPromocionButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarPromocionButton.TabIndex = 25
        Me.ModificarPromocionButton.Text = "Modificar"
        Me.ModificarPromocionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarPromocionButton.UseVisualStyleBackColor = True
        '
        'PromocionesDataGrid
        '
        Me.PromocionesDataGrid.AllowUserToAddRows = False
        Me.PromocionesDataGrid.AllowUserToDeleteRows = False
        Me.PromocionesDataGrid.AllowUserToResizeRows = False
        Me.PromocionesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PromocionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PromocionesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.DescuentoColumn, Me.DesdeColumn, Me.HastaColumn, Me.TipoColumn, Me.FechaColumn, Me.SectorColumn})
        Me.PromocionesDataGrid.Location = New System.Drawing.Point(12, 104)
        Me.PromocionesDataGrid.Name = "PromocionesDataGrid"
        Me.PromocionesDataGrid.ReadOnly = True
        Me.PromocionesDataGrid.RowHeadersVisible = False
        Me.PromocionesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PromocionesDataGrid.Size = New System.Drawing.Size(650, 157)
        Me.PromocionesDataGrid.TabIndex = 24
        '
        'BuscarPromocionButton
        '
        Me.BuscarPromocionButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarPromocionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarPromocionButton.Location = New System.Drawing.Point(692, 15)
        Me.BuscarPromocionButton.Name = "BuscarPromocionButton"
        Me.BuscarPromocionButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarPromocionButton.TabIndex = 23
        Me.BuscarPromocionButton.Text = "Buscar"
        Me.BuscarPromocionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarPromocionButton.UseVisualStyleBackColor = True
        '
        'FechaComboBox
        '
        Me.FechaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FechaComboBox.emptyItem = Nothing
        Me.FechaComboBox.FormattingEnabled = True
        Me.FechaComboBox.lista = Nothing
        Me.FechaComboBox.Location = New System.Drawing.Point(56, 36)
        Me.FechaComboBox.Name = "FechaComboBox"
        Me.FechaComboBox.Size = New System.Drawing.Size(205, 21)
        Me.FechaComboBox.TabIndex = 28
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.emptyItem = Nothing
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.lista = Nothing
        Me.ShowComboBox.Location = New System.Drawing.Point(56, 11)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(205, 21)
        Me.ShowComboBox.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Fecha"
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(12, 14)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 29
        Me.ShowLabel.Text = "Show"
        '
        'SectorLabel
        '
        Me.SectorLabel.AutoSize = True
        Me.SectorLabel.Location = New System.Drawing.Point(12, 66)
        Me.SectorLabel.Name = "SectorLabel"
        Me.SectorLabel.Size = New System.Drawing.Size(38, 13)
        Me.SectorLabel.TabIndex = 32
        Me.SectorLabel.Text = "Sector"
        '
        'SectorComboBox
        '
        Me.SectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectorComboBox.emptyItem = Nothing
        Me.SectorComboBox.FormattingEnabled = True
        Me.SectorComboBox.lista = Nothing
        Me.SectorComboBox.Location = New System.Drawing.Point(56, 63)
        Me.SectorComboBox.Name = "SectorComboBox"
        Me.SectorComboBox.Size = New System.Drawing.Size(205, 21)
        Me.SectorComboBox.TabIndex = 31
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
        'DescuentoColumn
        '
        Me.DescuentoColumn.DataPropertyName = "descuento"
        Me.DescuentoColumn.HeaderText = "Descuento"
        Me.DescuentoColumn.Name = "DescuentoColumn"
        Me.DescuentoColumn.ReadOnly = True
        '
        'DesdeColumn
        '
        Me.DesdeColumn.DataPropertyName = "desde"
        Me.DesdeColumn.HeaderText = "Desde"
        Me.DesdeColumn.Name = "DesdeColumn"
        Me.DesdeColumn.ReadOnly = True
        '
        'HastaColumn
        '
        Me.HastaColumn.DataPropertyName = "hasta"
        Me.HastaColumn.HeaderText = "Hasta"
        Me.HastaColumn.Name = "HastaColumn"
        Me.HastaColumn.ReadOnly = True
        '
        'TipoColumn
        '
        Me.TipoColumn.DataPropertyName = "tipo"
        Me.TipoColumn.HeaderText = "Tipo"
        Me.TipoColumn.Name = "TipoColumn"
        Me.TipoColumn.ReadOnly = True
        '
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "fechaNombre"
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        '
        'SectorColumn
        '
        Me.SectorColumn.DataPropertyName = "sectorNombre"
        Me.SectorColumn.HeaderText = "Sector"
        Me.SectorColumn.Name = "SectorColumn"
        Me.SectorColumn.ReadOnly = True
        '
        'BuscarPromocionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(779, 282)
        Me.Controls.Add(Me.SectorLabel)
        Me.Controls.Add(Me.SectorComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShowLabel)
        Me.Controls.Add(Me.FechaComboBox)
        Me.Controls.Add(Me.ShowComboBox)
        Me.Controls.Add(Me.EliminarPromocionButton)
        Me.Controls.Add(Me.ModificarPromocionButton)
        Me.Controls.Add(Me.PromocionesDataGrid)
        Me.Controls.Add(Me.BuscarPromocionButton)
        Me.Name = "BuscarPromocionForm"
        Me.Text = "Buscar Promocion"
        CType(Me.PromocionesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarPromocionButton As TicketYa.MyButton
    Friend WithEvents ModificarPromocionButton As TicketYa.MyButton
    Friend WithEvents PromocionesDataGrid As TicketYa.MyDataGrid
    Friend WithEvents BuscarPromocionButton As TicketYa.MyButton
    Friend WithEvents FechaComboBox As TicketYa.MyComboBox
    Friend WithEvents ShowComboBox As TicketYa.MyComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents SectorLabel As System.Windows.Forms.Label
    Friend WithEvents SectorComboBox As TicketYa.MyComboBox
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesdeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HastaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectorColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
