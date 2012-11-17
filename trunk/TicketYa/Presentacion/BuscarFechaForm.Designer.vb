<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarFechaForm
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
        Me.FechasDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowTextBox = New TicketYa.MyTextBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.EliminarFechaButton = New TicketYa.MyButton()
        Me.ModificarFechaButton = New TicketYa.MyButton()
        Me.BuscarFechaButton = New TicketYa.MyButton()
        Me.FechaTextBox = New TicketYa.MyTextBox()
        Me.FechaLabel = New System.Windows.Forms.Label()
        CType(Me.FechasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechasDataGrid
        '
        Me.FechasDataGrid.AllowUserToAddRows = False
        Me.FechasDataGrid.AllowUserToDeleteRows = False
        Me.FechasDataGrid.AllowUserToResizeRows = False
        Me.FechasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.CapacidadColumn, Me.DireccionColumn, Me.NumeroColumn, Me.TelefonoColumn})
        Me.FechasDataGrid.Location = New System.Drawing.Point(29, 63)
        Me.FechasDataGrid.Name = "FechasDataGrid"
        Me.FechasDataGrid.ReadOnly = True
        Me.FechasDataGrid.RowHeadersVisible = False
        Me.FechasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FechasDataGrid.Size = New System.Drawing.Size(454, 157)
        Me.FechasDataGrid.TabIndex = 16
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
        'ShowTextBox
        '
        Me.ShowTextBox.alfanumerico = False
        Me.ShowTextBox.boton = Nothing
        Me.ShowTextBox.Location = New System.Drawing.Point(82, 18)
        Me.ShowTextBox.nada = False
        Me.ShowTextBox.Name = "ShowTextBox"
        Me.ShowTextBox.numerico = False
        Me.ShowTextBox.sinEspacio = False
        Me.ShowTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowTextBox.TabIndex = 14
        Me.ShowTextBox.texto = False
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(26, 21)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 13
        Me.ShowLabel.Text = "Show"
        '
        'EliminarFechaButton
        '
        Me.EliminarFechaButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarFechaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarFechaButton.Location = New System.Drawing.Point(513, 156)
        Me.EliminarFechaButton.Name = "EliminarFechaButton"
        Me.EliminarFechaButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarFechaButton.TabIndex = 18
        Me.EliminarFechaButton.Text = "Eliminar"
        Me.EliminarFechaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarFechaButton.UseVisualStyleBackColor = True
        '
        'ModificarFechaButton
        '
        Me.ModificarFechaButton.Image = Global.TicketYa.My.Resources.Resources.editar
        Me.ModificarFechaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarFechaButton.Location = New System.Drawing.Point(513, 80)
        Me.ModificarFechaButton.Name = "ModificarFechaButton"
        Me.ModificarFechaButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarFechaButton.TabIndex = 17
        Me.ModificarFechaButton.Text = "Modificar"
        Me.ModificarFechaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarFechaButton.UseVisualStyleBackColor = True
        '
        'BuscarFechaButton
        '
        Me.BuscarFechaButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarFechaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarFechaButton.Location = New System.Drawing.Point(513, 16)
        Me.BuscarFechaButton.Name = "BuscarFechaButton"
        Me.BuscarFechaButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarFechaButton.TabIndex = 15
        Me.BuscarFechaButton.Text = "Buscar"
        Me.BuscarFechaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarFechaButton.UseVisualStyleBackColor = True
        '
        'FechaTextBox
        '
        Me.FechaTextBox.alfanumerico = False
        Me.FechaTextBox.boton = Nothing
        Me.FechaTextBox.Location = New System.Drawing.Point(307, 18)
        Me.FechaTextBox.nada = False
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.numerico = False
        Me.FechaTextBox.sinEspacio = False
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FechaTextBox.TabIndex = 19
        Me.FechaTextBox.texto = False
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(246, 21)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(37, 13)
        Me.FechaLabel.TabIndex = 20
        Me.FechaLabel.Text = "Fecha"
        '
        'BuscarFechaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(745, 280)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(Me.EliminarFechaButton)
        Me.Controls.Add(Me.ModificarFechaButton)
        Me.Controls.Add(Me.FechasDataGrid)
        Me.Controls.Add(Me.BuscarFechaButton)
        Me.Controls.Add(Me.ShowTextBox)
        Me.Controls.Add(Me.ShowLabel)
        Me.Name = "BuscarFechaForm"
        CType(Me.FechasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarFechaButton As TicketYa.MyButton
    Friend WithEvents ModificarFechaButton As TicketYa.MyButton
    Friend WithEvents FechasDataGrid As TicketYa.MyDataGrid
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarFechaButton As TicketYa.MyButton
    Friend WithEvents ShowTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents FechaTextBox As TicketYa.MyTextBox
    Friend WithEvents FechaLabel As System.Windows.Forms.Label

End Class
