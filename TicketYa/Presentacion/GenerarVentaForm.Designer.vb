<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarVentaForm
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
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New TicketYa.MyTextBox()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.CompradoresComboBox = New TicketYa.MyComboBox()
        Me.CompradorGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumeroCompradorTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.NuevoCompradorButton = New TicketYa.MyButton()
        Me.BuscarCompradorButton = New TicketYa.MyButton()
        Me.ShowGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FechaComboBox = New TicketYa.MyComboBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BuscarShowButton = New TicketYa.MyButton()
        Me.ShowComboBox = New TicketYa.MyComboBox()
        Me.ShowTextBox = New TicketYa.MyTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.SectorComboBox = New TicketYa.MyComboBox()
        Me.SectorLabel = New System.Windows.Forms.Label()
        Me.VentaDataGrid = New TicketYa.MyDataGrid()
        Me.idSilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idShow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AceptarButton = New TicketYa.MyButton()
        Me.CancelarButton = New TicketYa.MyButton()
        Me.SubTotalTextBox = New TicketYa.MyTextBox()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.DescuentoLabel = New System.Windows.Forms.Label()
        Me.DescuentoTextBox = New TicketYa.MyTextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.TotalTextBox = New TicketYa.MyTextBox()
        Me.PromocionLabel = New System.Windows.Forms.Label()
        Me.PromocionComboBox = New TicketYa.MyComboBox()
        Me.EfectivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompradorGroupBox.SuspendLayout()
        Me.ShowGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VentaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(8, 18)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 1
        Me.ApellidoLabel.Text = "Apellido"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(81, 15)
        Me.ApellidoTextBox.nada = False
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.numerico = False
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 2
        Me.ApellidoTextBox.texto = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(81, 45)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 3
        Me.NombreTextBox.texto = False
        '
        'CompradoresComboBox
        '
        Me.CompradoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompradoresComboBox.emptyItem = Nothing
        Me.CompradoresComboBox.FormattingEnabled = True
        Me.CompradoresComboBox.lista = Nothing
        Me.CompradoresComboBox.Location = New System.Drawing.Point(428, 15)
        Me.CompradoresComboBox.Name = "CompradoresComboBox"
        Me.CompradoresComboBox.Size = New System.Drawing.Size(205, 21)
        Me.CompradoresComboBox.TabIndex = 4
        '
        'CompradorGroupBox
        '
        Me.CompradorGroupBox.Controls.Add(Me.Label1)
        Me.CompradorGroupBox.Controls.Add(Me.NumeroCompradorTextBox)
        Me.CompradorGroupBox.Controls.Add(Me.NombreLabel)
        Me.CompradorGroupBox.Controls.Add(Me.NuevoCompradorButton)
        Me.CompradorGroupBox.Controls.Add(Me.BuscarCompradorButton)
        Me.CompradorGroupBox.Controls.Add(Me.ApellidoLabel)
        Me.CompradorGroupBox.Controls.Add(Me.CompradoresComboBox)
        Me.CompradorGroupBox.Controls.Add(Me.ApellidoTextBox)
        Me.CompradorGroupBox.Controls.Add(Me.NombreTextBox)
        Me.CompradorGroupBox.Location = New System.Drawing.Point(4, 12)
        Me.CompradorGroupBox.Name = "CompradorGroupBox"
        Me.CompradorGroupBox.Size = New System.Drawing.Size(861, 70)
        Me.CompradorGroupBox.TabIndex = 6
        Me.CompradorGroupBox.TabStop = False
        Me.CompradorGroupBox.Text = "Comprador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "N° Comprador"
        '
        'NumeroCompradorTextBox
        '
        Me.NumeroCompradorTextBox.alfanumerico = False
        Me.NumeroCompradorTextBox.boton = Nothing
        Me.NumeroCompradorTextBox.Location = New System.Drawing.Point(267, 15)
        Me.NumeroCompradorTextBox.nada = False
        Me.NumeroCompradorTextBox.Name = "NumeroCompradorTextBox"
        Me.NumeroCompradorTextBox.numerico = False
        Me.NumeroCompradorTextBox.sinEspacio = False
        Me.NumeroCompradorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroCompradorTextBox.TabIndex = 8
        Me.NumeroCompradorTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(8, 48)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 6
        Me.NombreLabel.Text = "Nombre"
        '
        'NuevoCompradorButton
        '
        Me.NuevoCompradorButton.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.NuevoCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NuevoCompradorButton.Location = New System.Drawing.Point(675, 10)
        Me.NuevoCompradorButton.Name = "NuevoCompradorButton"
        Me.NuevoCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoCompradorButton.TabIndex = 0
        Me.NuevoCompradorButton.Text = "Nuevo"
        Me.NuevoCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NuevoCompradorButton.UseVisualStyleBackColor = True
        '
        'BuscarCompradorButton
        '
        Me.BuscarCompradorButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarCompradorButton.Location = New System.Drawing.Point(276, 43)
        Me.BuscarCompradorButton.Name = "BuscarCompradorButton"
        Me.BuscarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarCompradorButton.TabIndex = 5
        Me.BuscarCompradorButton.Text = "Buscar"
        Me.BuscarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarCompradorButton.UseVisualStyleBackColor = True
        '
        'ShowGroupBox
        '
        Me.ShowGroupBox.Controls.Add(Me.Label4)
        Me.ShowGroupBox.Controls.Add(Me.Label2)
        Me.ShowGroupBox.Controls.Add(Me.FechaComboBox)
        Me.ShowGroupBox.Controls.Add(Me.ShowLabel)
        Me.ShowGroupBox.Controls.Add(Me.Label3)
        Me.ShowGroupBox.Controls.Add(Me.BuscarShowButton)
        Me.ShowGroupBox.Controls.Add(Me.ShowComboBox)
        Me.ShowGroupBox.Controls.Add(Me.ShowTextBox)
        Me.ShowGroupBox.Location = New System.Drawing.Point(4, 88)
        Me.ShowGroupBox.Name = "ShowGroupBox"
        Me.ShowGroupBox.Size = New System.Drawing.Size(861, 104)
        Me.ShowGroupBox.TabIndex = 9
        Me.ShowGroupBox.TabStop = False
        Me.ShowGroupBox.Text = "Show"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(372, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 9
        '
        'FechaComboBox
        '
        Me.FechaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FechaComboBox.emptyItem = Nothing
        Me.FechaComboBox.FormattingEnabled = True
        Me.FechaComboBox.lista = Nothing
        Me.FechaComboBox.Location = New System.Drawing.Point(428, 57)
        Me.FechaComboBox.Name = "FechaComboBox"
        Me.FechaComboBox.Size = New System.Drawing.Size(205, 21)
        Me.FechaComboBox.TabIndex = 8
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(372, 22)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 7
        Me.ShowLabel.Text = "Show"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre"
        '
        'BuscarShowButton
        '
        Me.BuscarShowButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarShowButton.Location = New System.Drawing.Point(276, 19)
        Me.BuscarShowButton.Name = "BuscarShowButton"
        Me.BuscarShowButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarShowButton.TabIndex = 5
        Me.BuscarShowButton.Text = "Buscar"
        Me.BuscarShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarShowButton.UseVisualStyleBackColor = True
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.emptyItem = Nothing
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.lista = Nothing
        Me.ShowComboBox.Location = New System.Drawing.Point(428, 19)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(205, 21)
        Me.ShowComboBox.TabIndex = 4
        '
        'ShowTextBox
        '
        Me.ShowTextBox.alfanumerico = False
        Me.ShowTextBox.boton = Nothing
        Me.ShowTextBox.Location = New System.Drawing.Point(81, 20)
        Me.ShowTextBox.nada = False
        Me.ShowTextBox.Name = "ShowTextBox"
        Me.ShowTextBox.numerico = False
        Me.ShowTextBox.sinEspacio = False
        Me.ShowTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowTextBox.TabIndex = 3
        Me.ShowTextBox.texto = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel)
        Me.GroupBox1.Controls.Add(Me.SectorComboBox)
        Me.GroupBox1.Controls.Add(Me.SectorLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(861, 236)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sector"
        '
        'Panel
        '
        Me.Panel.Location = New System.Drawing.Point(301, 17)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(554, 213)
        Me.Panel.TabIndex = 2
        '
        'SectorComboBox
        '
        Me.SectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectorComboBox.emptyItem = Nothing
        Me.SectorComboBox.FormattingEnabled = True
        Me.SectorComboBox.lista = Nothing
        Me.SectorComboBox.Location = New System.Drawing.Point(81, 17)
        Me.SectorComboBox.Name = "SectorComboBox"
        Me.SectorComboBox.Size = New System.Drawing.Size(175, 21)
        Me.SectorComboBox.TabIndex = 1
        '
        'SectorLabel
        '
        Me.SectorLabel.AutoSize = True
        Me.SectorLabel.Location = New System.Drawing.Point(8, 20)
        Me.SectorLabel.Name = "SectorLabel"
        Me.SectorLabel.Size = New System.Drawing.Size(38, 13)
        Me.SectorLabel.TabIndex = 0
        Me.SectorLabel.Text = "Sector"
        '
        'VentaDataGrid
        '
        Me.VentaDataGrid.AllowUserToAddRows = False
        Me.VentaDataGrid.AllowUserToDeleteRows = False
        Me.VentaDataGrid.AllowUserToResizeRows = False
        Me.VentaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VentaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSilla, Me.idSector, Me.idShow, Me.idFecha, Me.ShowColumn, Me.FechaColumn, Me.SectorColumn, Me.FilaColumn, Me.ColumnaColumn, Me.PrecioColumn})
        Me.VentaDataGrid.Location = New System.Drawing.Point(4, 440)
        Me.VentaDataGrid.Name = "VentaDataGrid"
        Me.VentaDataGrid.ReadOnly = True
        Me.VentaDataGrid.RowHeadersVisible = False
        Me.VentaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentaDataGrid.Size = New System.Drawing.Size(861, 211)
        Me.VentaDataGrid.TabIndex = 11
        '
        'idSilla
        '
        Me.idSilla.HeaderText = "idSilla"
        Me.idSilla.Name = "idSilla"
        Me.idSilla.ReadOnly = True
        Me.idSilla.Visible = False
        '
        'idSector
        '
        Me.idSector.HeaderText = "idSector"
        Me.idSector.Name = "idSector"
        Me.idSector.ReadOnly = True
        Me.idSector.Visible = False
        '
        'idShow
        '
        Me.idShow.HeaderText = "idShow"
        Me.idShow.Name = "idShow"
        Me.idShow.ReadOnly = True
        Me.idShow.Visible = False
        '
        'idFecha
        '
        Me.idFecha.HeaderText = "idFecha"
        Me.idFecha.Name = "idFecha"
        Me.idFecha.ReadOnly = True
        Me.idFecha.Visible = False
        '
        'ShowColumn
        '
        Me.ShowColumn.HeaderText = "Show"
        Me.ShowColumn.Name = "ShowColumn"
        Me.ShowColumn.ReadOnly = True
        '
        'FechaColumn
        '
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        '
        'SectorColumn
        '
        Me.SectorColumn.HeaderText = "Sector"
        Me.SectorColumn.Name = "SectorColumn"
        Me.SectorColumn.ReadOnly = True
        '
        'FilaColumn
        '
        Me.FilaColumn.HeaderText = "Fila"
        Me.FilaColumn.Name = "FilaColumn"
        Me.FilaColumn.ReadOnly = True
        '
        'ColumnaColumn
        '
        Me.ColumnaColumn.HeaderText = "Columna"
        Me.ColumnaColumn.Name = "ColumnaColumn"
        Me.ColumnaColumn.ReadOnly = True
        '
        'PrecioColumn
        '
        Me.PrecioColumn.HeaderText = "Precio"
        Me.PrecioColumn.Name = "PrecioColumn"
        Me.PrecioColumn.ReadOnly = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Image = Global.TicketYa.My.Resources.Resources.aceptar
        Me.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AceptarButton.Location = New System.Drawing.Point(305, 750)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 12
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Image = Global.TicketYa.My.Resources.Resources.cancelar
        Me.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarButton.Location = New System.Drawing.Point(495, 750)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 13
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.alfanumerico = False
        Me.SubTotalTextBox.boton = Nothing
        Me.SubTotalTextBox.Location = New System.Drawing.Point(774, 658)
        Me.SubTotalTextBox.nada = False
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.numerico = False
        Me.SubTotalTextBox.sinEspacio = False
        Me.SubTotalTextBox.Size = New System.Drawing.Size(91, 20)
        Me.SubTotalTextBox.TabIndex = 14
        Me.SubTotalTextBox.texto = False
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Location = New System.Drawing.Point(706, 661)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(50, 13)
        Me.SubTotalLabel.TabIndex = 15
        Me.SubTotalLabel.Text = "SubTotal"
        '
        'DescuentoLabel
        '
        Me.DescuentoLabel.AutoSize = True
        Me.DescuentoLabel.Location = New System.Drawing.Point(706, 687)
        Me.DescuentoLabel.Name = "DescuentoLabel"
        Me.DescuentoLabel.Size = New System.Drawing.Size(59, 13)
        Me.DescuentoLabel.TabIndex = 17
        Me.DescuentoLabel.Text = "Descuento"
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.alfanumerico = False
        Me.DescuentoTextBox.boton = Nothing
        Me.DescuentoTextBox.Location = New System.Drawing.Point(774, 684)
        Me.DescuentoTextBox.nada = False
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.numerico = False
        Me.DescuentoTextBox.sinEspacio = False
        Me.DescuentoTextBox.Size = New System.Drawing.Size(91, 20)
        Me.DescuentoTextBox.TabIndex = 16
        Me.DescuentoTextBox.texto = False
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(706, 713)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.TotalLabel.TabIndex = 19
        Me.TotalLabel.Text = "Total"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.alfanumerico = False
        Me.TotalTextBox.boton = Nothing
        Me.TotalTextBox.Location = New System.Drawing.Point(774, 710)
        Me.TotalTextBox.nada = False
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.numerico = False
        Me.TotalTextBox.sinEspacio = False
        Me.TotalTextBox.Size = New System.Drawing.Size(91, 20)
        Me.TotalTextBox.TabIndex = 18
        Me.TotalTextBox.texto = False
        '
        'PromocionLabel
        '
        Me.PromocionLabel.AutoSize = True
        Me.PromocionLabel.Location = New System.Drawing.Point(439, 687)
        Me.PromocionLabel.Name = "PromocionLabel"
        Me.PromocionLabel.Size = New System.Drawing.Size(57, 13)
        Me.PromocionLabel.TabIndex = 20
        Me.PromocionLabel.Text = "Promocion"
        '
        'PromocionComboBox
        '
        Me.PromocionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PromocionComboBox.emptyItem = Nothing
        Me.PromocionComboBox.FormattingEnabled = True
        Me.PromocionComboBox.lista = Nothing
        Me.PromocionComboBox.Location = New System.Drawing.Point(516, 684)
        Me.PromocionComboBox.Name = "PromocionComboBox"
        Me.PromocionComboBox.Size = New System.Drawing.Size(184, 21)
        Me.PromocionComboBox.TabIndex = 21
        '
        'EfectivoCheckBox
        '
        Me.EfectivoCheckBox.AutoSize = True
        Me.EfectivoCheckBox.Location = New System.Drawing.Point(774, 736)
        Me.EfectivoCheckBox.Name = "EfectivoCheckBox"
        Me.EfectivoCheckBox.Size = New System.Drawing.Size(65, 17)
        Me.EfectivoCheckBox.TabIndex = 22
        Me.EfectivoCheckBox.Text = "Efectivo"
        Me.EfectivoCheckBox.UseVisualStyleBackColor = True
        '
        'GenerarVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(871, 785)
        Me.Controls.Add(Me.EfectivoCheckBox)
        Me.Controls.Add(Me.PromocionComboBox)
        Me.Controls.Add(Me.PromocionLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.DescuentoLabel)
        Me.Controls.Add(Me.DescuentoTextBox)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.VentaDataGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShowGroupBox)
        Me.Controls.Add(Me.CompradorGroupBox)
        Me.Name = "GenerarVentaForm"
        Me.Text = "Generar Venta"
        Me.CompradorGroupBox.ResumeLayout(False)
        Me.CompradorGroupBox.PerformLayout()
        Me.ShowGroupBox.ResumeLayout(False)
        Me.ShowGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VentaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NuevoCompradorButton As TicketYa.MyButton
    Friend WithEvents ApellidoLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents CompradoresComboBox As TicketYa.MyComboBox
    Friend WithEvents BuscarCompradorButton As TicketYa.MyButton
    Friend WithEvents CompradorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumeroCompradorTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BuscarShowButton As TicketYa.MyButton
    Friend WithEvents ShowComboBox As TicketYa.MyComboBox
    Friend WithEvents ShowTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SectorComboBox As TicketYa.MyComboBox
    Friend WithEvents SectorLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FechaComboBox As TicketYa.MyComboBox
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents VentaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents AceptarButton As TicketYa.MyButton
    Friend WithEvents CancelarButton As TicketYa.MyButton
    Friend WithEvents idSilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idSector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idShow As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalTextBox As TicketYa.MyTextBox
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents DescuentoLabel As System.Windows.Forms.Label
    Friend WithEvents DescuentoTextBox As TicketYa.MyTextBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As TicketYa.MyTextBox
    Friend WithEvents PromocionLabel As System.Windows.Forms.Label
    Friend WithEvents PromocionComboBox As TicketYa.MyComboBox
    Friend WithEvents EfectivoCheckBox As System.Windows.Forms.CheckBox

End Class
