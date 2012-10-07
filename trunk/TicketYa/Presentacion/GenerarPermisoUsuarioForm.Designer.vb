<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarPermisoUsuarioForm
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
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.GuardarPermisoButton = New System.Windows.Forms.Button()
        Me.QuitarPermisoButton = New System.Windows.Forms.Button()
        Me.AgregarPermisoButton = New System.Windows.Forms.Button()
        Me.PermisosUsuarioDataGrid = New System.Windows.Forms.DataGridView()
        Me.IdentificadorColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosDataGrid = New System.Windows.Forms.DataGridView()
        Me.PermisoDataGrid = New System.Windows.Forms.DataGridView()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PermisosUsuarioDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(692, 229)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 13
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'GuardarPermisoButton
        '
        Me.GuardarPermisoButton.Location = New System.Drawing.Point(583, 229)
        Me.GuardarPermisoButton.Name = "GuardarPermisoButton"
        Me.GuardarPermisoButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarPermisoButton.TabIndex = 12
        Me.GuardarPermisoButton.Text = "Guardar"
        Me.GuardarPermisoButton.UseVisualStyleBackColor = True
        '
        'QuitarPermisoButton
        '
        Me.QuitarPermisoButton.Location = New System.Drawing.Point(502, 127)
        Me.QuitarPermisoButton.Name = "QuitarPermisoButton"
        Me.QuitarPermisoButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarPermisoButton.TabIndex = 11
        Me.QuitarPermisoButton.Text = "Quitar"
        Me.QuitarPermisoButton.UseVisualStyleBackColor = True
        '
        'AgregarPermisoButton
        '
        Me.AgregarPermisoButton.Location = New System.Drawing.Point(502, 46)
        Me.AgregarPermisoButton.Name = "AgregarPermisoButton"
        Me.AgregarPermisoButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarPermisoButton.TabIndex = 10
        Me.AgregarPermisoButton.Text = "Agregar"
        Me.AgregarPermisoButton.UseVisualStyleBackColor = True
        '
        'PermisosUsuarioDataGrid
        '
        Me.PermisosUsuarioDataGrid.AllowUserToAddRows = False
        Me.PermisosUsuarioDataGrid.AllowUserToDeleteRows = False
        Me.PermisosUsuarioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisosUsuarioDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn2, Me.PermisoColumn})
        Me.PermisosUsuarioDataGrid.Location = New System.Drawing.Point(583, 19)
        Me.PermisosUsuarioDataGrid.Name = "PermisosUsuarioDataGrid"
        Me.PermisosUsuarioDataGrid.RowHeadersVisible = False
        Me.PermisosUsuarioDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PermisosUsuarioDataGrid.Size = New System.Drawing.Size(184, 181)
        Me.PermisosUsuarioDataGrid.TabIndex = 9
        '
        'IdentificadorColumn2
        '
        Me.IdentificadorColumn2.DataPropertyName = "identificador"
        Me.IdentificadorColumn2.HeaderText = "Identificador"
        Me.IdentificadorColumn2.Name = "IdentificadorColumn2"
        Me.IdentificadorColumn2.Visible = False
        '
        'PermisoColumn
        '
        Me.PermisoColumn.DataPropertyName = "descripcion"
        Me.PermisoColumn.HeaderText = "Descripcion"
        Me.PermisoColumn.Name = "PermisoColumn"
        '
        'UsuariosDataGrid
        '
        Me.UsuariosDataGrid.AllowUserToAddRows = False
        Me.UsuariosDataGrid.AllowUserToDeleteRows = False
        Me.UsuariosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.UsuarioColumn})
        Me.UsuariosDataGrid.Location = New System.Drawing.Point(312, 19)
        Me.UsuariosDataGrid.Name = "UsuariosDataGrid"
        Me.UsuariosDataGrid.RowHeadersVisible = False
        Me.UsuariosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuariosDataGrid.Size = New System.Drawing.Size(184, 181)
        Me.UsuariosDataGrid.TabIndex = 8
        '
        'PermisoDataGrid
        '
        Me.PermisoDataGrid.AllowUserToAddRows = False
        Me.PermisoDataGrid.AllowUserToDeleteRows = False
        Me.PermisoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisoDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionColumn, Me.IndentificadorColumn})
        Me.PermisoDataGrid.Location = New System.Drawing.Point(29, 19)
        Me.PermisoDataGrid.Name = "PermisoDataGrid"
        Me.PermisoDataGrid.RowHeadersVisible = False
        Me.PermisoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PermisoDataGrid.Size = New System.Drawing.Size(240, 315)
        Me.PermisoDataGrid.TabIndex = 7
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "descripcion"
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        '
        'IndentificadorColumn
        '
        Me.IndentificadorColumn.DataPropertyName = "identificador"
        Me.IndentificadorColumn.HeaderText = "Identificador"
        Me.IndentificadorColumn.Name = "IndentificadorColumn"
        Me.IndentificadorColumn.Visible = False
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.Visible = False
        '
        'UsuarioColumn
        '
        Me.UsuarioColumn.DataPropertyName = "nombre"
        Me.UsuarioColumn.HeaderText = "Usuario"
        Me.UsuarioColumn.Name = "UsuarioColumn"
        '
        'GenerarPermisoUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(796, 352)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.GuardarPermisoButton)
        Me.Controls.Add(Me.QuitarPermisoButton)
        Me.Controls.Add(Me.AgregarPermisoButton)
        Me.Controls.Add(Me.PermisosUsuarioDataGrid)
        Me.Controls.Add(Me.UsuariosDataGrid)
        Me.Controls.Add(Me.PermisoDataGrid)
        Me.Name = "GenerarPermisoUsuarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos"
        CType(Me.PermisosUsuarioDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisoDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents GuardarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents QuitarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents AgregarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents PermisosUsuarioDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents IdentificadorColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermisoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuariosDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PermisoDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
