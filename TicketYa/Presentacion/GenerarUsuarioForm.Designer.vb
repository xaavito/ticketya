<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarUsuarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarUsuarioForm))
        Me.GenerarUsuarioButton = New TicketYa.MyButton()
        Me.UsuarioTextBox = New TicketYa.MyTextBox()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.PassTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New TicketYa.MyTextBox()
        Me.FamiliaComboBox = New MyComboBox()
        Me.FamiliaLabel = New System.Windows.Forms.Label()
        Me.FamiliaDataGrid = New TicketYa.MyDataGrid()
        Me.Identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdiomaLabel = New System.Windows.Forms.Label()
        Me.IdiomaComboBox = New MyComboBox()
        Me.AgregarFamiliaButton = New TicketYa.MyButton()
        Me.QuitarFamiliaButton = New TicketYa.MyButton()
        CType(Me.FamiliaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenerarUsuarioButton
        '
        Me.GenerarUsuarioButton.Image = CType(resources.GetObject("GenerarUsuarioButton.Image"), System.Drawing.Image)
        Me.GenerarUsuarioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerarUsuarioButton.Location = New System.Drawing.Point(551, 12)
        Me.GenerarUsuarioButton.Name = "GenerarUsuarioButton"
        Me.GenerarUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarUsuarioButton.TabIndex = 1
        Me.GenerarUsuarioButton.Text = "Generar"
        Me.GenerarUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenerarUsuarioButton.UseVisualStyleBackColor = True
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.alfanumerico = False
        Me.UsuarioTextBox.boton = Nothing
        Me.UsuarioTextBox.Location = New System.Drawing.Point(93, 12)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.sinEspacio = False
        Me.UsuarioTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioTextBox.TabIndex = 2
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(12, 15)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsuarioLabel.TabIndex = 3
        Me.UsuarioLabel.Text = "Usuario"
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Location = New System.Drawing.Point(12, 41)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(61, 13)
        Me.PassLabel.TabIndex = 5
        Me.PassLabel.Text = "Contraseña"
        '
        'PassTextBox
        '
        Me.PassTextBox.alfanumerico = False
        Me.PassTextBox.boton = Nothing
        Me.PassTextBox.Location = New System.Drawing.Point(93, 38)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.sinEspacio = False
        Me.PassTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PassTextBox.TabIndex = 4
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(12, 67)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 7
        Me.NombreLabel.Text = "Nombre"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(93, 64)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(12, 93)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 9
        Me.ApellidoLabel.Text = "Apellido"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(93, 90)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ApellidoTextBox.TabIndex = 8
        '
        'FamiliaComboBox
        '
        Me.FamiliaComboBox.FormattingEnabled = True
        Me.FamiliaComboBox.Location = New System.Drawing.Point(93, 116)
        Me.FamiliaComboBox.Name = "FamiliaComboBox"
        Me.FamiliaComboBox.Size = New System.Drawing.Size(140, 21)
        Me.FamiliaComboBox.TabIndex = 10
        '
        'FamiliaLabel
        '
        Me.FamiliaLabel.AutoSize = True
        Me.FamiliaLabel.Location = New System.Drawing.Point(12, 119)
        Me.FamiliaLabel.Name = "FamiliaLabel"
        Me.FamiliaLabel.Size = New System.Drawing.Size(39, 13)
        Me.FamiliaLabel.TabIndex = 11
        Me.FamiliaLabel.Text = "Familia"
        '
        'FamiliaDataGrid
        '
        Me.FamiliaDataGrid.AllowUserToAddRows = False
        Me.FamiliaDataGrid.AllowUserToDeleteRows = False
        Me.FamiliaDataGrid.AllowUserToResizeRows = False
        Me.FamiliaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FamiliaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificador, Me.FamiliaColumn})
        Me.FamiliaDataGrid.Location = New System.Drawing.Point(327, 12)
        Me.FamiliaDataGrid.MultiSelect = False
        Me.FamiliaDataGrid.Name = "FamiliaDataGrid"
        Me.FamiliaDataGrid.ReadOnly = True
        Me.FamiliaDataGrid.RowHeadersVisible = False
        Me.FamiliaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FamiliaDataGrid.Size = New System.Drawing.Size(218, 152)
        Me.FamiliaDataGrid.TabIndex = 12
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
        'IdiomaLabel
        '
        Me.IdiomaLabel.AutoSize = True
        Me.IdiomaLabel.Location = New System.Drawing.Point(12, 146)
        Me.IdiomaLabel.Name = "IdiomaLabel"
        Me.IdiomaLabel.Size = New System.Drawing.Size(38, 13)
        Me.IdiomaLabel.TabIndex = 14
        Me.IdiomaLabel.Text = "Idioma"
        '
        'IdiomaComboBox
        '
        Me.IdiomaComboBox.FormattingEnabled = True
        Me.IdiomaComboBox.Location = New System.Drawing.Point(93, 143)
        Me.IdiomaComboBox.Name = "IdiomaComboBox"
        Me.IdiomaComboBox.Size = New System.Drawing.Size(140, 21)
        Me.IdiomaComboBox.TabIndex = 13
        '
        'AgregarFamiliaButton
        '
        Me.AgregarFamiliaButton.Image = CType(resources.GetObject("AgregarFamiliaButton.Image"), System.Drawing.Image)
        Me.AgregarFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarFamiliaButton.Location = New System.Drawing.Point(246, 116)
        Me.AgregarFamiliaButton.Name = "AgregarFamiliaButton"
        Me.AgregarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarFamiliaButton.TabIndex = 15
        Me.AgregarFamiliaButton.Text = "Agregar"
        Me.AgregarFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarFamiliaButton.UseVisualStyleBackColor = True
        '
        'QuitarFamiliaButton
        '
        Me.QuitarFamiliaButton.Image = CType(resources.GetObject("QuitarFamiliaButton.Image"), System.Drawing.Image)
        Me.QuitarFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarFamiliaButton.Location = New System.Drawing.Point(246, 146)
        Me.QuitarFamiliaButton.Name = "QuitarFamiliaButton"
        Me.QuitarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarFamiliaButton.TabIndex = 16
        Me.QuitarFamiliaButton.Text = "Quitar"
        Me.QuitarFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarFamiliaButton.UseVisualStyleBackColor = True
        '
        'GenerarUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(638, 199)
        Me.Controls.Add(Me.QuitarFamiliaButton)
        Me.Controls.Add(Me.AgregarFamiliaButton)
        Me.Controls.Add(Me.IdiomaLabel)
        Me.Controls.Add(Me.IdiomaComboBox)
        Me.Controls.Add(Me.FamiliaDataGrid)
        Me.Controls.Add(Me.FamiliaLabel)
        Me.Controls.Add(Me.FamiliaComboBox)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.GenerarUsuarioButton)
        Me.Name = "GenerarUsuarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.FamiliaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioTextBox As MyTextBox
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents PassTextBox As MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As MyTextBox
    Friend WithEvents ApellidoLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoTextBox As MyTextBox
    Friend WithEvents FamiliaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FamiliaLabel As System.Windows.Forms.Label
    Friend WithEvents IdiomaLabel As System.Windows.Forms.Label
    Friend WithEvents IdiomaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamiliaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenerarUsuarioButton As TicketYa.MyButton
    Friend WithEvents FamiliaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents AgregarFamiliaButton As TicketYa.MyButton
    Friend WithEvents QuitarFamiliaButton As TicketYa.MyButton

End Class
