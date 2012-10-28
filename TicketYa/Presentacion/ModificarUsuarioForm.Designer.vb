<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarUsuarioForm))
        Me.FamiliasDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ActivoLabel = New System.Windows.Forms.Label()
        Me.QuitarFamiliaButton = New TicketYa.MyButton()
        Me.AgregarFamiliaButton = New TicketYa.MyButton()
        Me.IdiomaLabel = New System.Windows.Forms.Label()
        Me.IdiomaComboBox = New System.Windows.Forms.ComboBox()
        Me.FamiliaDataGrid = New TicketYa.MyDataGrid()
        Me.Identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.PassTextBox = New TicketYa.MyTextBox()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New TicketYa.MyTextBox()
        Me.ModificarUsuarioButton = New TicketYa.MyButton()
        CType(Me.FamiliasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamiliaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FamiliasDataGrid
        '
        Me.FamiliasDataGrid.AllowUserToAddRows = False
        Me.FamiliasDataGrid.AllowUserToDeleteRows = False
        Me.FamiliasDataGrid.AllowUserToResizeRows = False
        Me.FamiliasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FamiliasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.UsuarioColumn})
        Me.FamiliasDataGrid.Location = New System.Drawing.Point(324, 161)
        Me.FamiliasDataGrid.Name = "FamiliasDataGrid"
        Me.FamiliasDataGrid.ReadOnly = True
        Me.FamiliasDataGrid.RowHeadersVisible = False
        Me.FamiliasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FamiliasDataGrid.Size = New System.Drawing.Size(224, 152)
        Me.FamiliasDataGrid.TabIndex = 36
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
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.AutoSize = True
        Me.ActivoCheckBox.Location = New System.Drawing.Point(96, 141)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActivoCheckBox.TabIndex = 34
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'ActivoLabel
        '
        Me.ActivoLabel.AutoSize = True
        Me.ActivoLabel.Location = New System.Drawing.Point(16, 141)
        Me.ActivoLabel.Name = "ActivoLabel"
        Me.ActivoLabel.Size = New System.Drawing.Size(37, 13)
        Me.ActivoLabel.TabIndex = 33
        Me.ActivoLabel.Text = "Activo"
        '
        'QuitarFamiliaButton
        '
        Me.QuitarFamiliaButton.Image = CType(resources.GetObject("QuitarFamiliaButton.Image"), System.Drawing.Image)
        Me.QuitarFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarFamiliaButton.Location = New System.Drawing.Point(243, 229)
        Me.QuitarFamiliaButton.Name = "QuitarFamiliaButton"
        Me.QuitarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarFamiliaButton.TabIndex = 32
        Me.QuitarFamiliaButton.Text = "Quitar"
        Me.QuitarFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarFamiliaButton.UseVisualStyleBackColor = True
        '
        'AgregarFamiliaButton
        '
        Me.AgregarFamiliaButton.Image = CType(resources.GetObject("AgregarFamiliaButton.Image"), System.Drawing.Image)
        Me.AgregarFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarFamiliaButton.Location = New System.Drawing.Point(243, 200)
        Me.AgregarFamiliaButton.Name = "AgregarFamiliaButton"
        Me.AgregarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarFamiliaButton.TabIndex = 31
        Me.AgregarFamiliaButton.Text = "Agregar"
        Me.AgregarFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarFamiliaButton.UseVisualStyleBackColor = True
        '
        'IdiomaLabel
        '
        Me.IdiomaLabel.AutoSize = True
        Me.IdiomaLabel.Location = New System.Drawing.Point(15, 118)
        Me.IdiomaLabel.Name = "IdiomaLabel"
        Me.IdiomaLabel.Size = New System.Drawing.Size(38, 13)
        Me.IdiomaLabel.TabIndex = 30
        Me.IdiomaLabel.Text = "Idioma"
        '
        'IdiomaComboBox
        '
        Me.IdiomaComboBox.FormattingEnabled = True
        Me.IdiomaComboBox.Location = New System.Drawing.Point(96, 115)
        Me.IdiomaComboBox.Name = "IdiomaComboBox"
        Me.IdiomaComboBox.Size = New System.Drawing.Size(140, 21)
        Me.IdiomaComboBox.TabIndex = 29
        '
        'FamiliaDataGrid
        '
        Me.FamiliaDataGrid.AllowUserToAddRows = False
        Me.FamiliaDataGrid.AllowUserToDeleteRows = False
        Me.FamiliaDataGrid.AllowUserToResizeRows = False
        Me.FamiliaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FamiliaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificador, Me.FamiliaColumn})
        Me.FamiliaDataGrid.Location = New System.Drawing.Point(19, 161)
        Me.FamiliaDataGrid.MultiSelect = False
        Me.FamiliaDataGrid.Name = "FamiliaDataGrid"
        Me.FamiliaDataGrid.ReadOnly = True
        Me.FamiliaDataGrid.RowHeadersVisible = False
        Me.FamiliaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FamiliaDataGrid.Size = New System.Drawing.Size(218, 152)
        Me.FamiliaDataGrid.TabIndex = 28
        '
        'Identificador
        '
        Me.Identificador.HeaderText = "Identificador"
        Me.Identificador.Name = "Identificador"
        Me.Identificador.ReadOnly = True
        Me.Identificador.Visible = False
        '
        'FamiliaColumn
        '
        Me.FamiliaColumn.DataPropertyName = "descripcion"
        Me.FamiliaColumn.HeaderText = "Familia"
        Me.FamiliaColumn.Name = "FamiliaColumn"
        Me.FamiliaColumn.ReadOnly = True
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(15, 93)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 25
        Me.ApellidoLabel.Text = "Apellido"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(96, 90)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ApellidoTextBox.TabIndex = 24
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(15, 67)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 23
        Me.NombreLabel.Text = "Nombre"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(96, 64)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NombreTextBox.TabIndex = 22
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Location = New System.Drawing.Point(15, 41)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(61, 13)
        Me.PassLabel.TabIndex = 21
        Me.PassLabel.Text = "Contraseña"
        '
        'PassTextBox
        '
        Me.PassTextBox.alfanumerico = False
        Me.PassTextBox.boton = Nothing
        Me.PassTextBox.Location = New System.Drawing.Point(96, 38)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.sinEspacio = False
        Me.PassTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PassTextBox.TabIndex = 20
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(15, 15)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsuarioLabel.TabIndex = 19
        Me.UsuarioLabel.Text = "Usuario"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.alfanumerico = False
        Me.UsuarioTextBox.boton = Nothing
        Me.UsuarioTextBox.Location = New System.Drawing.Point(96, 12)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.sinEspacio = False
        Me.UsuarioTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioTextBox.TabIndex = 18
        '
        'ModificarUsuarioButton
        '
        Me.ModificarUsuarioButton.Image = CType(resources.GetObject("ModificarUsuarioButton.Image"), System.Drawing.Image)
        Me.ModificarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarUsuarioButton.Location = New System.Drawing.Point(554, 12)
        Me.ModificarUsuarioButton.Name = "ModificarUsuarioButton"
        Me.ModificarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarUsuarioButton.TabIndex = 17
        Me.ModificarUsuarioButton.Text = "Guardar"
        Me.ModificarUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarUsuarioButton.UseVisualStyleBackColor = True
        '
        'ModificarUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(650, 345)
        Me.Controls.Add(Me.FamiliasDataGrid)
        Me.Controls.Add(Me.ActivoCheckBox)
        Me.Controls.Add(Me.ActivoLabel)
        Me.Controls.Add(Me.QuitarFamiliaButton)
        Me.Controls.Add(Me.AgregarFamiliaButton)
        Me.Controls.Add(Me.IdiomaLabel)
        Me.Controls.Add(Me.IdiomaComboBox)
        Me.Controls.Add(Me.FamiliaDataGrid)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.ModificarUsuarioButton)
        Me.Name = "ModificarUsuarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Usuario"
        CType(Me.FamiliasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamiliaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdiomaLabel As System.Windows.Forms.Label
    Friend WithEvents IdiomaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamiliaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoTextBox As MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As MyTextBox
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents PassTextBox As MyTextBox
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents UsuarioTextBox As MyTextBox
    Friend WithEvents ActivoLabel As System.Windows.Forms.Label
    Friend WithEvents ActivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents QuitarFamiliaButton As TicketYa.MyButton
    Friend WithEvents AgregarFamiliaButton As TicketYa.MyButton
    Friend WithEvents ModificarUsuarioButton As TicketYa.MyButton
    Friend WithEvents FamiliasDataGrid As TicketYa.MyDataGrid
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
