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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarPermisoFamiliaForm))
        Me.PermisoDataGrid = New TicketYa.MyDataGrid()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisosFamiliaDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgregarPermisoFamiliaButton = New TicketYa.MyButton()
        Me.QuitarPermisoFamiliaButton = New TicketYa.MyButton()
        Me.GuardarPermisoFamiliaButton = New TicketYa.MyButton()
        Me.CancelarPermisoFamiliaButton = New TicketYa.MyButton()
        CType(Me.PermisoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosFamiliaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PermisoDataGrid
        '
        Me.PermisoDataGrid.AllowUserToAddRows = False
        Me.PermisoDataGrid.AllowUserToDeleteRows = False
        Me.PermisoDataGrid.AllowUserToResizeRows = False
        Me.PermisoDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PermisoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisoDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionColumn, Me.IndentificadorColumn})
        Me.PermisoDataGrid.Location = New System.Drawing.Point(12, 54)
        Me.PermisoDataGrid.Name = "PermisoDataGrid"
        Me.PermisoDataGrid.ReadOnly = True
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
        'FamiliaDataGrid
        '
        Me.FamiliaDataGrid.AllowUserToAddRows = False
        Me.FamiliaDataGrid.AllowUserToDeleteRows = False
        Me.FamiliaDataGrid.AllowUserToResizeRows = False
        Me.FamiliaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FamiliaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.UsuarioColumn})
        Me.FamiliaDataGrid.Location = New System.Drawing.Point(295, 54)
        Me.FamiliaDataGrid.Name = "FamiliaDataGrid"
        Me.FamiliaDataGrid.ReadOnly = True
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
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'UsuarioColumn
        '
        Me.UsuarioColumn.DataPropertyName = "descripcion"
        Me.UsuarioColumn.HeaderText = "Familia"
        Me.UsuarioColumn.Name = "UsuarioColumn"
        Me.UsuarioColumn.ReadOnly = True
        '
        'PermisosFamiliaDataGrid
        '
        Me.PermisosFamiliaDataGrid.AllowUserToAddRows = False
        Me.PermisosFamiliaDataGrid.AllowUserToDeleteRows = False
        Me.PermisosFamiliaDataGrid.AllowUserToResizeRows = False
        Me.PermisosFamiliaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PermisosFamiliaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisosFamiliaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn2, Me.PermisoColumn})
        Me.PermisosFamiliaDataGrid.Location = New System.Drawing.Point(566, 54)
        Me.PermisosFamiliaDataGrid.Name = "PermisosFamiliaDataGrid"
        Me.PermisosFamiliaDataGrid.ReadOnly = True
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
        'AgregarPermisoFamiliaButton
        '
        Me.AgregarPermisoFamiliaButton.Image = CType(resources.GetObject("AgregarPermisoFamiliaButton.Image"), System.Drawing.Image)
        Me.AgregarPermisoFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarPermisoFamiliaButton.Location = New System.Drawing.Point(485, 81)
        Me.AgregarPermisoFamiliaButton.Name = "AgregarPermisoFamiliaButton"
        Me.AgregarPermisoFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarPermisoFamiliaButton.TabIndex = 3
        Me.AgregarPermisoFamiliaButton.Text = "Agregar"
        Me.AgregarPermisoFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarPermisoFamiliaButton.UseVisualStyleBackColor = True
        '
        'QuitarPermisoFamiliaButton
        '
        Me.QuitarPermisoFamiliaButton.Image = CType(resources.GetObject("QuitarPermisoFamiliaButton.Image"), System.Drawing.Image)
        Me.QuitarPermisoFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarPermisoFamiliaButton.Location = New System.Drawing.Point(485, 162)
        Me.QuitarPermisoFamiliaButton.Name = "QuitarPermisoFamiliaButton"
        Me.QuitarPermisoFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarPermisoFamiliaButton.TabIndex = 4
        Me.QuitarPermisoFamiliaButton.Text = "Quitar"
        Me.QuitarPermisoFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarPermisoFamiliaButton.UseVisualStyleBackColor = True
        '
        'GuardarPermisoFamiliaButton
        '
        Me.GuardarPermisoFamiliaButton.Image = CType(resources.GetObject("GuardarPermisoFamiliaButton.Image"), System.Drawing.Image)
        Me.GuardarPermisoFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarPermisoFamiliaButton.Location = New System.Drawing.Point(566, 264)
        Me.GuardarPermisoFamiliaButton.Name = "GuardarPermisoFamiliaButton"
        Me.GuardarPermisoFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarPermisoFamiliaButton.TabIndex = 5
        Me.GuardarPermisoFamiliaButton.Text = "Guardar"
        Me.GuardarPermisoFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GuardarPermisoFamiliaButton.UseVisualStyleBackColor = True
        '
        'CancelarPermisoFamiliaButton
        '
        Me.CancelarPermisoFamiliaButton.Image = CType(resources.GetObject("CancelarPermisoFamiliaButton.Image"), System.Drawing.Image)
        Me.CancelarPermisoFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarPermisoFamiliaButton.Location = New System.Drawing.Point(675, 264)
        Me.CancelarPermisoFamiliaButton.Name = "CancelarPermisoFamiliaButton"
        Me.CancelarPermisoFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarPermisoFamiliaButton.TabIndex = 6
        Me.CancelarPermisoFamiliaButton.Text = "Cancelar"
        Me.CancelarPermisoFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelarPermisoFamiliaButton.UseVisualStyleBackColor = True
        '
        'GenerarPermisoFamiliaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(769, 381)
        Me.Controls.Add(Me.CancelarPermisoFamiliaButton)
        Me.Controls.Add(Me.GuardarPermisoFamiliaButton)
        Me.Controls.Add(Me.QuitarPermisoFamiliaButton)
        Me.Controls.Add(Me.AgregarPermisoFamiliaButton)
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
    Friend WithEvents AgregarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents QuitarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents GuardarPermisoButton As System.Windows.Forms.Button
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermisoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgregarPermisoFamiliaButton As TicketYa.MyButton
    Friend WithEvents QuitarPermisoFamiliaButton As TicketYa.MyButton
    Friend WithEvents GuardarPermisoFamiliaButton As TicketYa.MyButton
    Friend WithEvents PermisoDataGrid As TicketYa.MyDataGrid
    Friend WithEvents FamiliaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents PermisosFamiliaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents CancelarPermisoFamiliaButton As TicketYa.MyButton

End Class
