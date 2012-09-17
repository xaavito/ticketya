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
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarUsuariosButton = New System.Windows.Forms.Button()
        Me.UsuariosDataGrid = New System.Windows.Forms.DataGridView()
        Me.ModificarUsuarioButton = New System.Windows.Forms.Button()
        Me.EliminarUsuarioButton = New System.Windows.Forms.Button()
        Me.identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.UsuarioTextBox.Location = New System.Drawing.Point(109, 40)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioTextBox.TabIndex = 6
        '
        'BuscarUsuariosButton
        '
        Me.BuscarUsuariosButton.Location = New System.Drawing.Point(573, 40)
        Me.BuscarUsuariosButton.Name = "BuscarUsuariosButton"
        Me.BuscarUsuariosButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarUsuariosButton.TabIndex = 5
        Me.BuscarUsuariosButton.Text = "Buscar"
        Me.BuscarUsuariosButton.UseVisualStyleBackColor = True
        '
        'UsuariosDataGrid
        '
        Me.UsuariosDataGrid.AllowUserToAddRows = False
        Me.UsuariosDataGrid.AllowUserToDeleteRows = False
        Me.UsuariosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identificador, Me.NombreColumn, Me.ApellidoColumn, Me.UsuarioColumn, Me.FechaColumn})
        Me.UsuariosDataGrid.Location = New System.Drawing.Point(28, 133)
        Me.UsuariosDataGrid.Name = "UsuariosDataGrid"
        Me.UsuariosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuariosDataGrid.Size = New System.Drawing.Size(445, 228)
        Me.UsuariosDataGrid.TabIndex = 4
        '
        'ModificarUsuarioButton
        '
        Me.ModificarUsuarioButton.Location = New System.Drawing.Point(507, 183)
        Me.ModificarUsuarioButton.Name = "ModificarUsuarioButton"
        Me.ModificarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarUsuarioButton.TabIndex = 8
        Me.ModificarUsuarioButton.Text = "Modificar"
        Me.ModificarUsuarioButton.UseVisualStyleBackColor = True
        '
        'EliminarUsuarioButton
        '
        Me.EliminarUsuarioButton.Location = New System.Drawing.Point(507, 268)
        Me.EliminarUsuarioButton.Name = "EliminarUsuarioButton"
        Me.EliminarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarUsuarioButton.TabIndex = 9
        Me.EliminarUsuarioButton.Text = "Eliminar"
        Me.EliminarUsuarioButton.UseVisualStyleBackColor = True
        '
        'identificador
        '
        Me.identificador.DataPropertyName = "identificador"
        Me.identificador.HeaderText = "identificador"
        Me.identificador.Name = "identificador"
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
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "fecha"
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        '
        'BuscarUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(677, 400)
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
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuscarUsuariosButton As System.Windows.Forms.Button
    Friend WithEvents UsuariosDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ModificarUsuarioButton As System.Windows.Forms.Button
    Friend WithEvents EliminarUsuarioButton As System.Windows.Forms.Button
    Friend WithEvents identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
