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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarPermisoUsuarioForm))
        Me.CancelarButton = New TicketYa.MyButton()
        Me.GuardarPermisoUsuarioButton = New TicketYa.MyButton()
        Me.QuitarPermisoUsuarioButton = New TicketYa.MyButton()
        Me.AgregarPermisoUsuarioButton = New TicketYa.MyButton()
        Me.PermisosUsuarioDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisoDataGrid = New TicketYa.MyDataGrid()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PermisosUsuarioDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelarButton
        '
        Me.CancelarButton.Image = CType(resources.GetObject("CancelarButton.Image"), System.Drawing.Image)
        Me.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarButton.Location = New System.Drawing.Point(692, 229)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 13
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'GuardarPermisoUsuarioButton
        '
        Me.GuardarPermisoUsuarioButton.Image = CType(resources.GetObject("GuardarPermisoUsuarioButton.Image"), System.Drawing.Image)
        Me.GuardarPermisoUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarPermisoUsuarioButton.Location = New System.Drawing.Point(583, 229)
        Me.GuardarPermisoUsuarioButton.Name = "GuardarPermisoUsuarioButton"
        Me.GuardarPermisoUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarPermisoUsuarioButton.TabIndex = 12
        Me.GuardarPermisoUsuarioButton.Text = "Guardar"
        Me.GuardarPermisoUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GuardarPermisoUsuarioButton.UseVisualStyleBackColor = True
        '
        'QuitarPermisoUsuarioButton
        '
        Me.QuitarPermisoUsuarioButton.Image = CType(resources.GetObject("QuitarPermisoUsuarioButton.Image"), System.Drawing.Image)
        Me.QuitarPermisoUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarPermisoUsuarioButton.Location = New System.Drawing.Point(502, 127)
        Me.QuitarPermisoUsuarioButton.Name = "QuitarPermisoUsuarioButton"
        Me.QuitarPermisoUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarPermisoUsuarioButton.TabIndex = 11
        Me.QuitarPermisoUsuarioButton.Text = "Quitar"
        Me.QuitarPermisoUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarPermisoUsuarioButton.UseVisualStyleBackColor = True
        '
        'AgregarPermisoUsuarioButton
        '
        Me.AgregarPermisoUsuarioButton.Image = CType(resources.GetObject("AgregarPermisoUsuarioButton.Image"), System.Drawing.Image)
        Me.AgregarPermisoUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarPermisoUsuarioButton.Location = New System.Drawing.Point(502, 46)
        Me.AgregarPermisoUsuarioButton.Name = "AgregarPermisoUsuarioButton"
        Me.AgregarPermisoUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarPermisoUsuarioButton.TabIndex = 10
        Me.AgregarPermisoUsuarioButton.Text = "Agregar"
        Me.AgregarPermisoUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarPermisoUsuarioButton.UseVisualStyleBackColor = True
        '
        'PermisosUsuarioDataGrid
        '
        Me.PermisosUsuarioDataGrid.AllowUserToAddRows = False
        Me.PermisosUsuarioDataGrid.AllowUserToDeleteRows = False
        Me.PermisosUsuarioDataGrid.AllowUserToResizeRows = False
        Me.PermisosUsuarioDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PermisosUsuarioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisosUsuarioDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn2, Me.PermisoColumn})
        Me.PermisosUsuarioDataGrid.Location = New System.Drawing.Point(583, 19)
        Me.PermisosUsuarioDataGrid.Name = "PermisosUsuarioDataGrid"
        Me.PermisosUsuarioDataGrid.ReadOnly = True
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
        Me.IdentificadorColumn2.ReadOnly = True
        Me.IdentificadorColumn2.Visible = False
        '
        'PermisoColumn
        '
        Me.PermisoColumn.DataPropertyName = "descripcion"
        Me.PermisoColumn.HeaderText = "Descripcion"
        Me.PermisoColumn.Name = "PermisoColumn"
        Me.PermisoColumn.ReadOnly = True
        '
        'UsuariosDataGrid
        '
        Me.UsuariosDataGrid.AllowUserToAddRows = False
        Me.UsuariosDataGrid.AllowUserToDeleteRows = False
        Me.UsuariosDataGrid.AllowUserToResizeRows = False
        Me.UsuariosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsuariosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.UsuarioColumn})
        Me.UsuariosDataGrid.Location = New System.Drawing.Point(312, 19)
        Me.UsuariosDataGrid.Name = "UsuariosDataGrid"
        Me.UsuariosDataGrid.ReadOnly = True
        Me.UsuariosDataGrid.RowHeadersVisible = False
        Me.UsuariosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuariosDataGrid.Size = New System.Drawing.Size(184, 181)
        Me.UsuariosDataGrid.TabIndex = 8
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'UsuarioColumn
        '
        Me.UsuarioColumn.DataPropertyName = "nombre"
        Me.UsuarioColumn.HeaderText = "Usuario"
        Me.UsuarioColumn.Name = "UsuarioColumn"
        Me.UsuarioColumn.ReadOnly = True
        '
        'PermisoDataGrid
        '
        Me.PermisoDataGrid.AllowUserToAddRows = False
        Me.PermisoDataGrid.AllowUserToDeleteRows = False
        Me.PermisoDataGrid.AllowUserToResizeRows = False
        Me.PermisoDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PermisoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisoDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionColumn, Me.IndentificadorColumn})
        Me.PermisoDataGrid.Location = New System.Drawing.Point(29, 19)
        Me.PermisoDataGrid.Name = "PermisoDataGrid"
        Me.PermisoDataGrid.ReadOnly = True
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
        Me.DescripcionColumn.ReadOnly = True
        '
        'IndentificadorColumn
        '
        Me.IndentificadorColumn.DataPropertyName = "identificador"
        Me.IndentificadorColumn.HeaderText = "Identificador"
        Me.IndentificadorColumn.Name = "IndentificadorColumn"
        Me.IndentificadorColumn.ReadOnly = True
        Me.IndentificadorColumn.Visible = False
        '
        'GenerarPermisoUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(796, 352)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.GuardarPermisoUsuarioButton)
        Me.Controls.Add(Me.QuitarPermisoUsuarioButton)
        Me.Controls.Add(Me.AgregarPermisoUsuarioButton)
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
    Friend WithEvents GuardarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents QuitarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents AgregarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents IdentificadorColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermisoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardarPermisoUsuarioButton As TicketYa.MyButton
    Friend WithEvents QuitarPermisoUsuarioButton As TicketYa.MyButton
    Friend WithEvents AgregarPermisoUsuarioButton As TicketYa.MyButton
    Friend WithEvents CancelarButton As TicketYa.MyButton
    Friend WithEvents PermisosUsuarioDataGrid As TicketYa.MyDataGrid
    Friend WithEvents UsuariosDataGrid As TicketYa.MyDataGrid
    Friend WithEvents PermisoDataGrid As TicketYa.MyDataGrid

End Class
