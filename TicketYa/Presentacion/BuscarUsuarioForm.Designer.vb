<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarUsuarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarUsuarioForm))
        Me.EliminarUsuarioButton = New TicketYa.MyButton()
        Me.ModificarUsuarioButton = New TicketYa.MyButton()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New TicketYa.MyTextBox()
        Me.BuscarUsuariosButton = New TicketYa.MyButton()
        Me.UsuariosDataGrid = New TicketYa.MyDataGrid()
        Me.identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaBajaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EliminarUsuarioButton
        '
        Me.EliminarUsuarioButton.Image = CType(resources.GetObject("EliminarUsuarioButton.Image"), System.Drawing.Image)
        Me.EliminarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarUsuarioButton.Location = New System.Drawing.Point(728, 271)
        Me.EliminarUsuarioButton.Name = "EliminarUsuarioButton"
        Me.EliminarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarUsuarioButton.TabIndex = 9
        Me.EliminarUsuarioButton.Text = "Eliminar"
        Me.EliminarUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarUsuarioButton.UseVisualStyleBackColor = True
        '
        'ModificarUsuarioButton
        '
        Me.ModificarUsuarioButton.Image = CType(resources.GetObject("ModificarUsuarioButton.Image"), System.Drawing.Image)
        Me.ModificarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarUsuarioButton.Location = New System.Drawing.Point(728, 186)
        Me.ModificarUsuarioButton.Name = "ModificarUsuarioButton"
        Me.ModificarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarUsuarioButton.TabIndex = 8
        Me.ModificarUsuarioButton.Text = "Modificar"
        Me.ModificarUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarUsuarioButton.UseVisualStyleBackColor = True
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(28, 43)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsuarioLabel.TabIndex = 7
        Me.UsuarioLabel.Text = "Usuario"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.alfanumerico = False
        Me.UsuarioTextBox.boton = Nothing
        Me.UsuarioTextBox.Location = New System.Drawing.Point(109, 40)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.sinEspacio = False
        Me.UsuarioTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioTextBox.TabIndex = 6
        '
        'BuscarUsuariosButton
        '
        Me.BuscarUsuariosButton.Image = CType(resources.GetObject("BuscarUsuariosButton.Image"), System.Drawing.Image)
        Me.BuscarUsuariosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarUsuariosButton.Location = New System.Drawing.Point(728, 43)
        Me.BuscarUsuariosButton.Name = "BuscarUsuariosButton"
        Me.BuscarUsuariosButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarUsuariosButton.TabIndex = 5
        Me.BuscarUsuariosButton.Text = "Buscar"
        Me.BuscarUsuariosButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarUsuariosButton.UseVisualStyleBackColor = True
        '
        'UsuariosDataGrid
        '
        Me.UsuariosDataGrid.AllowUserToAddRows = False
        Me.UsuariosDataGrid.AllowUserToDeleteRows = False
        Me.UsuariosDataGrid.AllowUserToResizeRows = False
        Me.UsuariosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsuariosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identificador, Me.ActivoColumn, Me.NombreColumn, Me.ApellidoColumn, Me.UsuarioColumn, Me.FechaAltaColumn, Me.FechaBajaColumn})
        Me.UsuariosDataGrid.Location = New System.Drawing.Point(28, 124)
        Me.UsuariosDataGrid.Name = "UsuariosDataGrid"
        Me.UsuariosDataGrid.ReadOnly = True
        Me.UsuariosDataGrid.RowHeadersVisible = False
        Me.UsuariosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuariosDataGrid.Size = New System.Drawing.Size(644, 228)
        Me.UsuariosDataGrid.TabIndex = 4
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
        'BuscarUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(815, 400)
        Me.Controls.Add(Me.EliminarUsuarioButton)
        Me.Controls.Add(Me.ModificarUsuarioButton)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.BuscarUsuariosButton)
        Me.Controls.Add(Me.UsuariosDataGrid)
        Me.Name = "BuscarUsuarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents UsuarioTextBox As MyTextBox
    Friend WithEvents identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaBajaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarUsuariosButton As TicketYa.MyButton
    Friend WithEvents UsuariosDataGrid As TicketYa.MyDataGrid
    Friend WithEvents ModificarUsuarioButton As TicketYa.MyButton
    Friend WithEvents EliminarUsuarioButton As TicketYa.MyButton

End Class
