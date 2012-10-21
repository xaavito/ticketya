<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarPermisoFamiliaForm
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
        Me.PermisoDataGrid = New MyDataGrid()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaDataGrid = New MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisosFamiliaDataGrid = New MyDataGrid()
        Me.IdentificadorColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgregarPermisoButton = New MyButton()
        Me.QuitarPermisoButton = New MyButton()
        Me.GuardarPermisoButton = New MyButton()
        Me.CancelarButton = New MyButton()
        CType(Me.PermisoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosFamiliaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PermisoDataGrid
        '
        Me.PermisoDataGrid.AllowUserToAddRows = False
        Me.PermisoDataGrid.AllowUserToDeleteRows = False
        Me.PermisoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisoDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionColumn, Me.IndentificadorColumn})
        Me.PermisoDataGrid.Location = New System.Drawing.Point(12, 54)
        Me.PermisoDataGrid.Name = "PermisoDataGrid"
        Me.PermisoDataGrid.RowHeadersVisible = False
        Me.PermisoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PermisoDataGrid.Size = New System.Drawing.Size(240, 315)
        Me.PermisoDataGrid.TabIndex = 0
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
        'FamiliaDataGrid
        '
        Me.FamiliaDataGrid.AllowUserToAddRows = False
        Me.FamiliaDataGrid.AllowUserToDeleteRows = False
        Me.FamiliaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.UsuarioColumn})
        Me.FamiliaDataGrid.Location = New System.Drawing.Point(295, 54)
        Me.FamiliaDataGrid.Name = "FamiliaDataGrid"
        Me.FamiliaDataGrid.RowHeadersVisible = False
        Me.FamiliaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FamiliaDataGrid.Size = New System.Drawing.Size(184, 181)
        Me.FamiliaDataGrid.TabIndex = 1
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
        Me.UsuarioColumn.DataPropertyName = "descripcion"
        Me.UsuarioColumn.HeaderText = "Familia"
        Me.UsuarioColumn.Name = "UsuarioColumn"
        '
        'PermisosFamiliaDataGrid
        '
        Me.PermisosFamiliaDataGrid.AllowUserToAddRows = False
        Me.PermisosFamiliaDataGrid.AllowUserToDeleteRows = False
        Me.PermisosFamiliaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisosFamiliaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn2, Me.PermisoColumn})
        Me.PermisosFamiliaDataGrid.Location = New System.Drawing.Point(566, 54)
        Me.PermisosFamiliaDataGrid.Name = "PermisosFamiliaDataGrid"
        Me.PermisosFamiliaDataGrid.RowHeadersVisible = False
        Me.PermisosFamiliaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PermisosFamiliaDataGrid.Size = New System.Drawing.Size(184, 181)
        Me.PermisosFamiliaDataGrid.TabIndex = 2
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
        'AgregarPermisoButton
        '
        Me.AgregarPermisoButton.Location = New System.Drawing.Point(485, 81)
        Me.AgregarPermisoButton.Name = "AgregarPermisoButton"
        Me.AgregarPermisoButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarPermisoButton.TabIndex = 3
        Me.AgregarPermisoButton.Text = "Agregar"
        Me.AgregarPermisoButton.UseVisualStyleBackColor = True
        '
        'QuitarPermisoButton
        '
        Me.QuitarPermisoButton.Location = New System.Drawing.Point(485, 162)
        Me.QuitarPermisoButton.Name = "QuitarPermisoButton"
        Me.QuitarPermisoButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarPermisoButton.TabIndex = 4
        Me.QuitarPermisoButton.Text = "Quitar"
        Me.QuitarPermisoButton.UseVisualStyleBackColor = True
        '
        'GuardarPermisoButton
        '
        Me.GuardarPermisoButton.Location = New System.Drawing.Point(566, 264)
        Me.GuardarPermisoButton.Name = "GuardarPermisoButton"
        Me.GuardarPermisoButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarPermisoButton.TabIndex = 5
        Me.GuardarPermisoButton.Text = "Guardar"
        Me.GuardarPermisoButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(675, 264)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 6
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'GenerarPermisoFamiliaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(769, 381)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.GuardarPermisoButton)
        Me.Controls.Add(Me.QuitarPermisoButton)
        Me.Controls.Add(Me.AgregarPermisoButton)
        Me.Controls.Add(Me.PermisosFamiliaDataGrid)
        Me.Controls.Add(Me.FamiliaDataGrid)
        Me.Controls.Add(Me.PermisoDataGrid)
        Me.Name = "GenerarPermisoFamiliaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso"
        CType(Me.PermisoDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosFamiliaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PermisoDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents FamiliaDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PermisosFamiliaDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AgregarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents QuitarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents GuardarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermisoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
