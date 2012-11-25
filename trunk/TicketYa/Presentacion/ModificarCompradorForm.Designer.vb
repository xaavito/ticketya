<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCompradorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarCompradorForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MyTextBox4 = New TicketYa.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyTextBox3 = New TicketYa.MyTextBox()
        Me.PisoLabel = New System.Windows.Forms.Label()
        Me.MyTextBox2 = New TicketYa.MyTextBox()
        Me.NumeroLabel = New System.Windows.Forms.Label()
        Me.MyTextBox1 = New TicketYa.MyTextBox()
        Me.PreferenciaDataGrid = New TicketYa.MyDataGrid()
        Me.Identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamiliaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreferenciasLabel = New System.Windows.Forms.Label()
        Me.FamiliaComboBox = New TicketYa.MyComboBox()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New TicketYa.MyTextBox()
        Me.MailLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.PassTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New TicketYa.MyTextBox()
        Me.QuitarPreferenciaButton = New TicketYa.MyButton()
        Me.AgregarPreferenciaButton = New TicketYa.MyButton()
        Me.GenerarCompradorButton = New TicketYa.MyButton()
        CType(Me.PreferenciaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Telefono"
        '
        'MyTextBox4
        '
        Me.MyTextBox4.alfanumerico = False
        Me.MyTextBox4.boton = Nothing
        Me.MyTextBox4.Location = New System.Drawing.Point(106, 206)
        Me.MyTextBox4.nada = False
        Me.MyTextBox4.Name = "MyTextBox4"
        Me.MyTextBox4.numerico = False
        Me.MyTextBox4.sinEspacio = False
        Me.MyTextBox4.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox4.TabIndex = 61
        Me.MyTextBox4.texto = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Codigo Postal"
        '
        'MyTextBox3
        '
        Me.MyTextBox3.alfanumerico = False
        Me.MyTextBox3.boton = Nothing
        Me.MyTextBox3.Location = New System.Drawing.Point(106, 180)
        Me.MyTextBox3.nada = False
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.numerico = False
        Me.MyTextBox3.sinEspacio = False
        Me.MyTextBox3.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox3.TabIndex = 59
        Me.MyTextBox3.texto = False
        '
        'PisoLabel
        '
        Me.PisoLabel.AutoSize = True
        Me.PisoLabel.Location = New System.Drawing.Point(25, 157)
        Me.PisoLabel.Name = "PisoLabel"
        Me.PisoLabel.Size = New System.Drawing.Size(27, 13)
        Me.PisoLabel.TabIndex = 58
        Me.PisoLabel.Text = "Piso"
        '
        'MyTextBox2
        '
        Me.MyTextBox2.alfanumerico = False
        Me.MyTextBox2.boton = Nothing
        Me.MyTextBox2.Location = New System.Drawing.Point(106, 154)
        Me.MyTextBox2.nada = False
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.numerico = False
        Me.MyTextBox2.sinEspacio = False
        Me.MyTextBox2.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox2.TabIndex = 57
        Me.MyTextBox2.texto = False
        '
        'NumeroLabel
        '
        Me.NumeroLabel.AutoSize = True
        Me.NumeroLabel.Location = New System.Drawing.Point(25, 131)
        Me.NumeroLabel.Name = "NumeroLabel"
        Me.NumeroLabel.Size = New System.Drawing.Size(44, 13)
        Me.NumeroLabel.TabIndex = 56
        Me.NumeroLabel.Text = "Numero"
        '
        'MyTextBox1
        '
        Me.MyTextBox1.alfanumerico = False
        Me.MyTextBox1.boton = Nothing
        Me.MyTextBox1.Location = New System.Drawing.Point(106, 128)
        Me.MyTextBox1.nada = False
        Me.MyTextBox1.Name = "MyTextBox1"
        Me.MyTextBox1.numerico = False
        Me.MyTextBox1.sinEspacio = False
        Me.MyTextBox1.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox1.TabIndex = 55
        Me.MyTextBox1.texto = False
        '
        'PreferenciaDataGrid
        '
        Me.PreferenciaDataGrid.AllowUserToAddRows = False
        Me.PreferenciaDataGrid.AllowUserToDeleteRows = False
        Me.PreferenciaDataGrid.AllowUserToResizeRows = False
        Me.PreferenciaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PreferenciaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PreferenciaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificador, Me.FamiliaColumn})
        Me.PreferenciaDataGrid.Location = New System.Drawing.Point(340, 22)
        Me.PreferenciaDataGrid.MultiSelect = False
        Me.PreferenciaDataGrid.Name = "PreferenciaDataGrid"
        Me.PreferenciaDataGrid.ReadOnly = True
        Me.PreferenciaDataGrid.RowHeadersVisible = False
        Me.PreferenciaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PreferenciaDataGrid.Size = New System.Drawing.Size(218, 152)
        Me.PreferenciaDataGrid.TabIndex = 52
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
        'PreferenciasLabel
        '
        Me.PreferenciasLabel.AutoSize = True
        Me.PreferenciasLabel.Location = New System.Drawing.Point(25, 235)
        Me.PreferenciasLabel.Name = "PreferenciasLabel"
        Me.PreferenciasLabel.Size = New System.Drawing.Size(66, 13)
        Me.PreferenciasLabel.TabIndex = 51
        Me.PreferenciasLabel.Text = "Preferencias"
        '
        'FamiliaComboBox
        '
        Me.FamiliaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FamiliaComboBox.emptyItem = Nothing
        Me.FamiliaComboBox.FormattingEnabled = True
        Me.FamiliaComboBox.lista = Nothing
        Me.FamiliaComboBox.Location = New System.Drawing.Point(106, 232)
        Me.FamiliaComboBox.Name = "FamiliaComboBox"
        Me.FamiliaComboBox.Size = New System.Drawing.Size(140, 21)
        Me.FamiliaComboBox.TabIndex = 50
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Location = New System.Drawing.Point(25, 103)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(52, 13)
        Me.DireccionLabel.TabIndex = 49
        Me.DireccionLabel.Text = "Direccion"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(106, 100)
        Me.ApellidoTextBox.nada = False
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.numerico = False
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ApellidoTextBox.TabIndex = 48
        Me.ApellidoTextBox.texto = False
        '
        'MailLabel
        '
        Me.MailLabel.AutoSize = True
        Me.MailLabel.Location = New System.Drawing.Point(25, 77)
        Me.MailLabel.Name = "MailLabel"
        Me.MailLabel.Size = New System.Drawing.Size(26, 13)
        Me.MailLabel.TabIndex = 47
        Me.MailLabel.Text = "Mail"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(106, 74)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NombreTextBox.TabIndex = 46
        Me.NombreTextBox.texto = False
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(25, 51)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 45
        Me.ApellidoLabel.Text = "Apellido"
        '
        'PassTextBox
        '
        Me.PassTextBox.alfanumerico = False
        Me.PassTextBox.boton = Nothing
        Me.PassTextBox.Location = New System.Drawing.Point(106, 48)
        Me.PassTextBox.nada = False
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.numerico = False
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.sinEspacio = False
        Me.PassTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PassTextBox.TabIndex = 44
        Me.PassTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(25, 25)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 43
        Me.NombreLabel.Text = "Nombre"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.alfanumerico = False
        Me.UsuarioTextBox.boton = Nothing
        Me.UsuarioTextBox.Location = New System.Drawing.Point(106, 22)
        Me.UsuarioTextBox.nada = False
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.numerico = False
        Me.UsuarioTextBox.sinEspacio = False
        Me.UsuarioTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioTextBox.TabIndex = 42
        Me.UsuarioTextBox.texto = False
        '
        'QuitarPreferenciaButton
        '
        Me.QuitarPreferenciaButton.Image = CType(resources.GetObject("QuitarPreferenciaButton.Image"), System.Drawing.Image)
        Me.QuitarPreferenciaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarPreferenciaButton.Location = New System.Drawing.Point(259, 156)
        Me.QuitarPreferenciaButton.Name = "QuitarPreferenciaButton"
        Me.QuitarPreferenciaButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarPreferenciaButton.TabIndex = 54
        Me.QuitarPreferenciaButton.Text = "Quitar"
        Me.QuitarPreferenciaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarPreferenciaButton.UseVisualStyleBackColor = True
        '
        'AgregarPreferenciaButton
        '
        Me.AgregarPreferenciaButton.Image = CType(resources.GetObject("AgregarPreferenciaButton.Image"), System.Drawing.Image)
        Me.AgregarPreferenciaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarPreferenciaButton.Location = New System.Drawing.Point(259, 126)
        Me.AgregarPreferenciaButton.Name = "AgregarPreferenciaButton"
        Me.AgregarPreferenciaButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarPreferenciaButton.TabIndex = 53
        Me.AgregarPreferenciaButton.Text = "Agregar"
        Me.AgregarPreferenciaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarPreferenciaButton.UseVisualStyleBackColor = True
        '
        'GenerarCompradorButton
        '
        Me.GenerarCompradorButton.Image = CType(resources.GetObject("GenerarCompradorButton.Image"), System.Drawing.Image)
        Me.GenerarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerarCompradorButton.Location = New System.Drawing.Point(587, 20)
        Me.GenerarCompradorButton.Name = "GenerarCompradorButton"
        Me.GenerarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarCompradorButton.TabIndex = 41
        Me.GenerarCompradorButton.Text = "Generar"
        Me.GenerarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenerarCompradorButton.UseVisualStyleBackColor = True
        '
        'ModificarCompradorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(686, 280)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MyTextBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MyTextBox3)
        Me.Controls.Add(Me.PisoLabel)
        Me.Controls.Add(Me.MyTextBox2)
        Me.Controls.Add(Me.NumeroLabel)
        Me.Controls.Add(Me.MyTextBox1)
        Me.Controls.Add(Me.QuitarPreferenciaButton)
        Me.Controls.Add(Me.AgregarPreferenciaButton)
        Me.Controls.Add(Me.PreferenciaDataGrid)
        Me.Controls.Add(Me.PreferenciasLabel)
        Me.Controls.Add(Me.FamiliaComboBox)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Me.MailLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.GenerarCompradorButton)
        Me.Name = "ModificarCompradorForm"
        Me.Text = "Modificar Comprador"
        CType(Me.PreferenciaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox4 As TicketYa.MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox3 As TicketYa.MyTextBox
    Friend WithEvents PisoLabel As System.Windows.Forms.Label
    Friend WithEvents MyTextBox2 As TicketYa.MyTextBox
    Friend WithEvents NumeroLabel As System.Windows.Forms.Label
    Friend WithEvents MyTextBox1 As TicketYa.MyTextBox
    Friend WithEvents QuitarPreferenciaButton As TicketYa.MyButton
    Friend WithEvents AgregarPreferenciaButton As TicketYa.MyButton
    Friend WithEvents PreferenciaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents Identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamiliaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreferenciasLabel As System.Windows.Forms.Label
    Friend WithEvents FamiliaComboBox As TicketYa.MyComboBox
    Friend WithEvents DireccionLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoTextBox As TicketYa.MyTextBox
    Friend WithEvents MailLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents ApellidoLabel As System.Windows.Forms.Label
    Friend WithEvents PassTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents UsuarioTextBox As TicketYa.MyTextBox
    Friend WithEvents GenerarCompradorButton As TicketYa.MyButton

End Class
