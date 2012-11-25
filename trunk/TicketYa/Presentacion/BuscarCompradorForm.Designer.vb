<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCompradorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarCompradorForm))
        Me.EliminarCompradorButton = New TicketYa.MyButton()
        Me.ModificarCompradorButton = New TicketYa.MyButton()
        Me.CompradorLabel = New System.Windows.Forms.Label()
        Me.CompradorTextBox = New TicketYa.MyTextBox()
        Me.BuscarCompradorButton = New TicketYa.MyButton()
        Me.CompradoresDataGrid = New TicketYa.MyDataGrid()
        Me.identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaBajaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CompradoresDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EliminarCompradorButton
        '
        Me.EliminarCompradorButton.Image = CType(resources.GetObject("EliminarCompradorButton.Image"), System.Drawing.Image)
        Me.EliminarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarCompradorButton.Location = New System.Drawing.Point(726, 252)
        Me.EliminarCompradorButton.Name = "EliminarCompradorButton"
        Me.EliminarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarCompradorButton.TabIndex = 15
        Me.EliminarCompradorButton.Text = "Eliminar"
        Me.EliminarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarCompradorButton.UseVisualStyleBackColor = True
        '
        'ModificarCompradorButton
        '
        Me.ModificarCompradorButton.Image = CType(resources.GetObject("ModificarCompradorButton.Image"), System.Drawing.Image)
        Me.ModificarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarCompradorButton.Location = New System.Drawing.Point(726, 167)
        Me.ModificarCompradorButton.Name = "ModificarCompradorButton"
        Me.ModificarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarCompradorButton.TabIndex = 14
        Me.ModificarCompradorButton.Text = "Modificar"
        Me.ModificarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarCompradorButton.UseVisualStyleBackColor = True
        '
        'CompradorLabel
        '
        Me.CompradorLabel.AutoSize = True
        Me.CompradorLabel.Location = New System.Drawing.Point(26, 24)
        Me.CompradorLabel.Name = "CompradorLabel"
        Me.CompradorLabel.Size = New System.Drawing.Size(58, 13)
        Me.CompradorLabel.TabIndex = 13
        Me.CompradorLabel.Text = "Comprador"
        '
        'CompradorTextBox
        '
        Me.CompradorTextBox.alfanumerico = False
        Me.CompradorTextBox.boton = Nothing
        Me.CompradorTextBox.Location = New System.Drawing.Point(107, 21)
        Me.CompradorTextBox.nada = False
        Me.CompradorTextBox.Name = "CompradorTextBox"
        Me.CompradorTextBox.numerico = False
        Me.CompradorTextBox.sinEspacio = False
        Me.CompradorTextBox.Size = New System.Drawing.Size(140, 20)
        Me.CompradorTextBox.TabIndex = 12
        Me.CompradorTextBox.texto = False
        '
        'BuscarCompradorButton
        '
        Me.BuscarCompradorButton.Image = CType(resources.GetObject("BuscarCompradorButton.Image"), System.Drawing.Image)
        Me.BuscarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarCompradorButton.Location = New System.Drawing.Point(726, 24)
        Me.BuscarCompradorButton.Name = "BuscarCompradorButton"
        Me.BuscarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarCompradorButton.TabIndex = 11
        Me.BuscarCompradorButton.Text = "Buscar"
        Me.BuscarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarCompradorButton.UseVisualStyleBackColor = True
        '
        'CompradoresDataGrid
        '
        Me.CompradoresDataGrid.AllowUserToAddRows = False
        Me.CompradoresDataGrid.AllowUserToDeleteRows = False
        Me.CompradoresDataGrid.AllowUserToResizeRows = False
        Me.CompradoresDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CompradoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompradoresDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identificador, Me.ActivoColumn, Me.NombreColumn, Me.ApellidoColumn, Me.UsuarioColumn, Me.FechaAltaColumn, Me.FechaBajaColumn})
        Me.CompradoresDataGrid.Location = New System.Drawing.Point(26, 105)
        Me.CompradoresDataGrid.Name = "CompradoresDataGrid"
        Me.CompradoresDataGrid.ReadOnly = True
        Me.CompradoresDataGrid.RowHeadersVisible = False
        Me.CompradoresDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompradoresDataGrid.Size = New System.Drawing.Size(644, 228)
        Me.CompradoresDataGrid.TabIndex = 10
        '
        'identificador
        '
        Me.identificador.DataPropertyName = "identificador"
        Me.identificador.HeaderText = "identificador"
        Me.identificador.Name = "identificador"
        Me.identificador.ReadOnly = True
        Me.identificador.Visible = False
        '
        'ActivoColumn
        '
        Me.ActivoColumn.DataPropertyName = "activo"
        Me.ActivoColumn.HeaderText = "Activo"
        Me.ActivoColumn.Name = "ActivoColumn"
        Me.ActivoColumn.ReadOnly = True
        '
        'NombreColumn
        '
        Me.NombreColumn.DataPropertyName = "nombre"
        Me.NombreColumn.HeaderText = "Nombre"
        Me.NombreColumn.Name = "NombreColumn"
        Me.NombreColumn.ReadOnly = True
        '
        'ApellidoColumn
        '
        Me.ApellidoColumn.DataPropertyName = "apellido"
        Me.ApellidoColumn.HeaderText = "Apellido"
        Me.ApellidoColumn.Name = "ApellidoColumn"
        Me.ApellidoColumn.ReadOnly = True
        '
        'UsuarioColumn
        '
        Me.UsuarioColumn.DataPropertyName = "usuario"
        Me.UsuarioColumn.HeaderText = "Usuario"
        Me.UsuarioColumn.Name = "UsuarioColumn"
        Me.UsuarioColumn.ReadOnly = True
        '
        'FechaAltaColumn
        '
        Me.FechaAltaColumn.DataPropertyName = "fechaAlta"
        Me.FechaAltaColumn.HeaderText = "Fecha Alta"
        Me.FechaAltaColumn.Name = "FechaAltaColumn"
        Me.FechaAltaColumn.ReadOnly = True
        '
        'FechaBajaColumn
        '
        Me.FechaBajaColumn.DataPropertyName = "fechaBaja"
        Me.FechaBajaColumn.HeaderText = "Fecha Baja"
        Me.FechaBajaColumn.Name = "FechaBajaColumn"
        Me.FechaBajaColumn.ReadOnly = True
        '
        'BuscarCompradorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(823, 424)
        Me.Controls.Add(Me.EliminarCompradorButton)
        Me.Controls.Add(Me.ModificarCompradorButton)
        Me.Controls.Add(Me.CompradorLabel)
        Me.Controls.Add(Me.CompradorTextBox)
        Me.Controls.Add(Me.BuscarCompradorButton)
        Me.Controls.Add(Me.CompradoresDataGrid)
        Me.Name = "BuscarCompradorForm"
        Me.Text = "Buscar Comprador"
        CType(Me.CompradoresDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarCompradorButton As TicketYa.MyButton
    Friend WithEvents ModificarCompradorButton As TicketYa.MyButton
    Friend WithEvents CompradorLabel As System.Windows.Forms.Label
    Friend WithEvents CompradorTextBox As TicketYa.MyTextBox
    Friend WithEvents BuscarCompradorButton As TicketYa.MyButton
    Friend WithEvents CompradoresDataGrid As TicketYa.MyDataGrid
    Friend WithEvents identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaBajaColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
