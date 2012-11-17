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
        Me.DesdeTextBox = New TicketYa.MyTextBox()
        Me.DesdeLabel = New System.Windows.Forms.Label()
        Me.EliminarPromocionButton = New TicketYa.MyButton()
        Me.ModificarPromocionButton = New TicketYa.MyButton()
        Me.PromocionesDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarPromocionButton = New TicketYa.MyButton()
        Me.ShowTextBox = New TicketYa.MyTextBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.HastaTextBox = New TicketYa.MyTextBox()
        Me.HastaLabel = New System.Windows.Forms.Label()
        CType(Me.PromocionesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DesdeTextBox
        '
        Me.DesdeTextBox.alfanumerico = False
        Me.DesdeTextBox.boton = Nothing
        Me.DesdeTextBox.Location = New System.Drawing.Point(223, 31)
        Me.DesdeTextBox.nada = False
        Me.DesdeTextBox.Name = "DesdeTextBox"
        Me.DesdeTextBox.numerico = False
        Me.DesdeTextBox.sinEspacio = False
        Me.DesdeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DesdeTextBox.TabIndex = 28
        Me.DesdeTextBox.texto = False
        '
        'DesdeLabel
        '
        Me.DesdeLabel.AutoSize = True
        Me.DesdeLabel.Location = New System.Drawing.Point(179, 34)
        Me.DesdeLabel.Name = "DesdeLabel"
        Me.DesdeLabel.Size = New System.Drawing.Size(38, 13)
        Me.DesdeLabel.TabIndex = 27
        Me.DesdeLabel.Text = "Desde"
        '
        'EliminarPromocionButton
        '
        Me.EliminarPromocionButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarPromocionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarPromocionButton.Location = New System.Drawing.Point(520, 169)
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
        Me.ModificarPromocionButton.Location = New System.Drawing.Point(520, 93)
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
        Me.PromocionesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.CapacidadColumn, Me.DireccionColumn, Me.NumeroColumn, Me.TelefonoColumn})
        Me.PromocionesDataGrid.Location = New System.Drawing.Point(36, 76)
        Me.PromocionesDataGrid.Name = "PromocionesDataGrid"
        Me.PromocionesDataGrid.ReadOnly = True
        Me.PromocionesDataGrid.RowHeadersVisible = False
        Me.PromocionesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PromocionesDataGrid.Size = New System.Drawing.Size(454, 157)
        Me.PromocionesDataGrid.TabIndex = 24
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
        'BuscarPromocionButton
        '
        Me.BuscarPromocionButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarPromocionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarPromocionButton.Location = New System.Drawing.Point(520, 29)
        Me.BuscarPromocionButton.Name = "BuscarPromocionButton"
        Me.BuscarPromocionButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarPromocionButton.TabIndex = 23
        Me.BuscarPromocionButton.Text = "Buscar"
        Me.BuscarPromocionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarPromocionButton.UseVisualStyleBackColor = True
        '
        'ShowTextBox
        '
        Me.ShowTextBox.alfanumerico = False
        Me.ShowTextBox.boton = Nothing
        Me.ShowTextBox.Location = New System.Drawing.Point(73, 32)
        Me.ShowTextBox.nada = False
        Me.ShowTextBox.Name = "ShowTextBox"
        Me.ShowTextBox.numerico = False
        Me.ShowTextBox.sinEspacio = False
        Me.ShowTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowTextBox.TabIndex = 22
        Me.ShowTextBox.texto = False
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(33, 34)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 21
        Me.ShowLabel.Text = "Show"
        '
        'HastaTextBox
        '
        Me.HastaTextBox.alfanumerico = False
        Me.HastaTextBox.boton = Nothing
        Me.HastaTextBox.Location = New System.Drawing.Point(373, 31)
        Me.HastaTextBox.nada = False
        Me.HastaTextBox.Name = "HastaTextBox"
        Me.HastaTextBox.numerico = False
        Me.HastaTextBox.sinEspacio = False
        Me.HastaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HastaTextBox.TabIndex = 30
        Me.HastaTextBox.texto = False
        '
        'HastaLabel
        '
        Me.HastaLabel.AutoSize = True
        Me.HastaLabel.Location = New System.Drawing.Point(329, 34)
        Me.HastaLabel.Name = "HastaLabel"
        Me.HastaLabel.Size = New System.Drawing.Size(35, 13)
        Me.HastaLabel.TabIndex = 29
        Me.HastaLabel.Text = "Hasta"
        '
        'BuscarPromocionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(672, 277)
        Me.Controls.Add(Me.HastaTextBox)
        Me.Controls.Add(Me.HastaLabel)
        Me.Controls.Add(Me.DesdeTextBox)
        Me.Controls.Add(Me.DesdeLabel)
        Me.Controls.Add(Me.EliminarPromocionButton)
        Me.Controls.Add(Me.ModificarPromocionButton)
        Me.Controls.Add(Me.PromocionesDataGrid)
        Me.Controls.Add(Me.BuscarPromocionButton)
        Me.Controls.Add(Me.ShowTextBox)
        Me.Controls.Add(Me.ShowLabel)
        Me.Name = "BuscarPromocionForm"
        CType(Me.PromocionesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DesdeTextBox As TicketYa.MyTextBox
    Friend WithEvents DesdeLabel As System.Windows.Forms.Label
    Friend WithEvents EliminarPromocionButton As TicketYa.MyButton
    Friend WithEvents ModificarPromocionButton As TicketYa.MyButton
    Friend WithEvents PromocionesDataGrid As TicketYa.MyDataGrid
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarPromocionButton As TicketYa.MyButton
    Friend WithEvents ShowTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents HastaTextBox As TicketYa.MyTextBox
    Friend WithEvents HastaLabel As System.Windows.Forms.Label

End Class
