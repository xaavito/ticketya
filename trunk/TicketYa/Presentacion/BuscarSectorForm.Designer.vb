<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarSectorForm
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
        Me.SectoresDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowTextBox = New TicketYa.MyTextBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.EliminarSectorButton = New TicketYa.MyButton()
        Me.ModificarSectorButton = New TicketYa.MyButton()
        Me.BuscarSectorButton = New TicketYa.MyButton()
        Me.SectorTextBox = New TicketYa.MyTextBox()
        Me.SectorLabel = New System.Windows.Forms.Label()
        CType(Me.SectoresDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SectoresDataGrid
        '
        Me.SectoresDataGrid.AllowUserToAddRows = False
        Me.SectoresDataGrid.AllowUserToDeleteRows = False
        Me.SectoresDataGrid.AllowUserToResizeRows = False
        Me.SectoresDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SectoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SectoresDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.CapacidadColumn, Me.DireccionColumn, Me.NumeroColumn, Me.TelefonoColumn})
        Me.SectoresDataGrid.Location = New System.Drawing.Point(40, 71)
        Me.SectoresDataGrid.Name = "SectoresDataGrid"
        Me.SectoresDataGrid.ReadOnly = True
        Me.SectoresDataGrid.RowHeadersVisible = False
        Me.SectoresDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SectoresDataGrid.Size = New System.Drawing.Size(454, 157)
        Me.SectoresDataGrid.TabIndex = 16
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
        Me.ShowTextBox.Location = New System.Drawing.Point(93, 26)
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
        Me.ShowLabel.Location = New System.Drawing.Point(37, 29)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 13
        Me.ShowLabel.Text = "Show"
        '
        'EliminarSectorButton
        '
        Me.EliminarSectorButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarSectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarSectorButton.Location = New System.Drawing.Point(524, 164)
        Me.EliminarSectorButton.Name = "EliminarSectorButton"
        Me.EliminarSectorButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarSectorButton.TabIndex = 18
        Me.EliminarSectorButton.Text = "Eliminar"
        Me.EliminarSectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarSectorButton.UseVisualStyleBackColor = True
        '
        'ModificarSectorButton
        '
        Me.ModificarSectorButton.Image = Global.TicketYa.My.Resources.Resources.editar
        Me.ModificarSectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarSectorButton.Location = New System.Drawing.Point(524, 88)
        Me.ModificarSectorButton.Name = "ModificarSectorButton"
        Me.ModificarSectorButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarSectorButton.TabIndex = 17
        Me.ModificarSectorButton.Text = "Modificar"
        Me.ModificarSectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarSectorButton.UseVisualStyleBackColor = True
        '
        'BuscarSectorButton
        '
        Me.BuscarSectorButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarSectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarSectorButton.Location = New System.Drawing.Point(524, 24)
        Me.BuscarSectorButton.Name = "BuscarSectorButton"
        Me.BuscarSectorButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarSectorButton.TabIndex = 15
        Me.BuscarSectorButton.Text = "Buscar"
        Me.BuscarSectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarSectorButton.UseVisualStyleBackColor = True
        '
        'SectorTextBox
        '
        Me.SectorTextBox.alfanumerico = False
        Me.SectorTextBox.boton = Nothing
        Me.SectorTextBox.Location = New System.Drawing.Point(335, 26)
        Me.SectorTextBox.nada = False
        Me.SectorTextBox.Name = "SectorTextBox"
        Me.SectorTextBox.numerico = False
        Me.SectorTextBox.sinEspacio = False
        Me.SectorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SectorTextBox.TabIndex = 20
        Me.SectorTextBox.texto = False
        '
        'SectorLabel
        '
        Me.SectorLabel.AutoSize = True
        Me.SectorLabel.Location = New System.Drawing.Point(279, 29)
        Me.SectorLabel.Name = "SectorLabel"
        Me.SectorLabel.Size = New System.Drawing.Size(38, 13)
        Me.SectorLabel.TabIndex = 19
        Me.SectorLabel.Text = "Sector"
        '
        'BuscarSectorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(693, 277)
        Me.Controls.Add(Me.SectorTextBox)
        Me.Controls.Add(Me.SectorLabel)
        Me.Controls.Add(Me.EliminarSectorButton)
        Me.Controls.Add(Me.ModificarSectorButton)
        Me.Controls.Add(Me.SectoresDataGrid)
        Me.Controls.Add(Me.BuscarSectorButton)
        Me.Controls.Add(Me.ShowTextBox)
        Me.Controls.Add(Me.ShowLabel)
        Me.Name = "BuscarSectorForm"
        CType(Me.SectoresDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarSectorButton As TicketYa.MyButton
    Friend WithEvents ModificarSectorButton As TicketYa.MyButton
    Friend WithEvents SectoresDataGrid As TicketYa.MyDataGrid
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarSectorButton As TicketYa.MyButton
    Friend WithEvents ShowTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents SectorTextBox As TicketYa.MyTextBox
    Friend WithEvents SectorLabel As System.Windows.Forms.Label

End Class
