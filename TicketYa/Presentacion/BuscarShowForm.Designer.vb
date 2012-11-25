<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarShowForm
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
        Me.EliminarShowButton = New TicketYa.MyButton()
        Me.ModificarShowButton = New TicketYa.MyButton()
        Me.ShowsDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarShowButton = New TicketYa.MyButton()
        Me.ShowTextBox = New TicketYa.MyTextBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        CType(Me.ShowsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EliminarShowButton
        '
        Me.EliminarShowButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarShowButton.Location = New System.Drawing.Point(528, 162)
        Me.EliminarShowButton.Name = "EliminarShowButton"
        Me.EliminarShowButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarShowButton.TabIndex = 12
        Me.EliminarShowButton.Text = "Eliminar"
        Me.EliminarShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarShowButton.UseVisualStyleBackColor = True
        '
        'ModificarShowButton
        '
        Me.ModificarShowButton.Image = Global.TicketYa.My.Resources.Resources.editar
        Me.ModificarShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarShowButton.Location = New System.Drawing.Point(528, 86)
        Me.ModificarShowButton.Name = "ModificarShowButton"
        Me.ModificarShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarShowButton.TabIndex = 11
        Me.ModificarShowButton.Text = "Modificar"
        Me.ModificarShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarShowButton.UseVisualStyleBackColor = True
        '
        'ShowsDataGrid
        '
        Me.ShowsDataGrid.AllowUserToAddRows = False
        Me.ShowsDataGrid.AllowUserToDeleteRows = False
        Me.ShowsDataGrid.AllowUserToResizeRows = False
        Me.ShowsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ShowsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShowsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.CapacidadColumn, Me.DireccionColumn, Me.NumeroColumn, Me.TelefonoColumn})
        Me.ShowsDataGrid.Location = New System.Drawing.Point(44, 69)
        Me.ShowsDataGrid.Name = "ShowsDataGrid"
        Me.ShowsDataGrid.ReadOnly = True
        Me.ShowsDataGrid.RowHeadersVisible = False
        Me.ShowsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ShowsDataGrid.Size = New System.Drawing.Size(454, 157)
        Me.ShowsDataGrid.TabIndex = 10
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
        'BuscarShowButton
        '
        Me.BuscarShowButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarShowButton.Location = New System.Drawing.Point(528, 22)
        Me.BuscarShowButton.Name = "BuscarShowButton"
        Me.BuscarShowButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarShowButton.TabIndex = 9
        Me.BuscarShowButton.Text = "Buscar"
        Me.BuscarShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarShowButton.UseVisualStyleBackColor = True
        '
        'ShowTextBox
        '
        Me.ShowTextBox.alfanumerico = False
        Me.ShowTextBox.boton = Nothing
        Me.ShowTextBox.Location = New System.Drawing.Point(97, 24)
        Me.ShowTextBox.nada = False
        Me.ShowTextBox.Name = "ShowTextBox"
        Me.ShowTextBox.numerico = False
        Me.ShowTextBox.sinEspacio = False
        Me.ShowTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowTextBox.TabIndex = 8
        Me.ShowTextBox.texto = False
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(41, 27)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 7
        Me.ShowLabel.Text = "Show"
        '
        'BuscarShowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(648, 281)
        Me.Controls.Add(Me.EliminarShowButton)
        Me.Controls.Add(Me.ModificarShowButton)
        Me.Controls.Add(Me.ShowsDataGrid)
        Me.Controls.Add(Me.BuscarShowButton)
        Me.Controls.Add(Me.ShowTextBox)
        Me.Controls.Add(Me.ShowLabel)
        Me.Name = "BuscarShowForm"
        CType(Me.ShowsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarShowButton As TicketYa.MyButton
    Friend WithEvents ModificarShowButton As TicketYa.MyButton
    Friend WithEvents ShowsDataGrid As TicketYa.MyDataGrid
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarShowButton As TicketYa.MyButton
    Friend WithEvents ShowTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowLabel As System.Windows.Forms.Label

End Class
