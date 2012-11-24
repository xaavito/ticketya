<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarCompradorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarCompradorForm))
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
        Me.GenerarCompradorButton = New TicketYa.MyButton()
        Me.QuitarPreferenciaButton = New TicketYa.MyButton()
        Me.AgregarPreferenciaButton = New TicketYa.MyButton()
        Me.FamiliaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreferenciaDataGrid = New TicketYa.MyDataGrid()
        Me.NumeroLabel = New System.Windows.Forms.Label()
        Me.MyTextBox1 = New TicketYa.MyTextBox()
        Me.PisoLabel = New System.Windows.Forms.Label()
        Me.MyTextBox2 = New TicketYa.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyTextBox3 = New TicketYa.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MyTextBox4 = New TicketYa.MyTextBox()
        CType(Me.PreferenciaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreferenciasLabel
        '
        Me.PreferenciasLabel.AutoSize = True
        Me.PreferenciasLabel.Location = New System.Drawing.Point(12, 230)
        Me.PreferenciasLabel.Name = "PreferenciasLabel"
        Me.PreferenciasLabel.Size = New System.Drawing.Size(66, 13)
        Me.PreferenciasLabel.TabIndex = 27
        Me.PreferenciasLabel.Text = "Preferencias"
        '
        'FamiliaComboBox
        '
        Me.FamiliaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FamiliaComboBox.emptyItem = Nothing
        Me.FamiliaComboBox.FormattingEnabled = True
        Me.FamiliaComboBox.lista = Nothing
        Me.FamiliaComboBox.Location = New System.Drawing.Point(93, 227)
        Me.FamiliaComboBox.Name = "FamiliaComboBox"
        Me.FamiliaComboBox.Size = New System.Drawing.Size(140, 21)
        Me.FamiliaComboBox.TabIndex = 26
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Location = New System.Drawing.Point(12, 98)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(52, 13)
        Me.DireccionLabel.TabIndex = 25
        Me.DireccionLabel.Text = "Direccion"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(93, 95)
        Me.ApellidoTextBox.nada = False
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.numerico = False
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ApellidoTextBox.TabIndex = 24
        Me.ApellidoTextBox.texto = False
        '
        'MailLabel
        '
        Me.MailLabel.AutoSize = True
        Me.MailLabel.Location = New System.Drawing.Point(12, 72)
        Me.MailLabel.Name = "MailLabel"
        Me.MailLabel.Size = New System.Drawing.Size(26, 13)
        Me.MailLabel.TabIndex = 23
        Me.MailLabel.Text = "Mail"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(93, 69)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NombreTextBox.TabIndex = 22
        Me.NombreTextBox.texto = False
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(12, 46)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 21
        Me.ApellidoLabel.Text = "Apellido"
        '
        'PassTextBox
        '
        Me.PassTextBox.alfanumerico = False
        Me.PassTextBox.boton = Nothing
        Me.PassTextBox.Location = New System.Drawing.Point(93, 43)
        Me.PassTextBox.nada = False
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.numerico = False
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.sinEspacio = False
        Me.PassTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PassTextBox.TabIndex = 20
        Me.PassTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(12, 20)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 19
        Me.NombreLabel.Text = "Nombre"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.alfanumerico = False
        Me.UsuarioTextBox.boton = Nothing
        Me.UsuarioTextBox.Location = New System.Drawing.Point(93, 17)
        Me.UsuarioTextBox.nada = False
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.numerico = False
        Me.UsuarioTextBox.sinEspacio = False
        Me.UsuarioTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioTextBox.TabIndex = 18
        Me.UsuarioTextBox.texto = False
        '
        'GenerarCompradorButton
        '
        Me.GenerarCompradorButton.Image = CType(resources.GetObject("GenerarCompradorButton.Image"), System.Drawing.Image)
        Me.GenerarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerarCompradorButton.Location = New System.Drawing.Point(574, 15)
        Me.GenerarCompradorButton.Name = "GenerarCompradorButton"
        Me.GenerarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarCompradorButton.TabIndex = 17
        Me.GenerarCompradorButton.Text = "Generar"
        Me.GenerarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenerarCompradorButton.UseVisualStyleBackColor = True
        '
        'QuitarPreferenciaButton
        '
        Me.QuitarPreferenciaButton.Image = CType(resources.GetObject("QuitarPreferenciaButton.Image"), System.Drawing.Image)
        Me.QuitarPreferenciaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarPreferenciaButton.Location = New System.Drawing.Point(246, 151)
        Me.QuitarPreferenciaButton.Name = "QuitarPreferenciaButton"
        Me.QuitarPreferenciaButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitarPreferenciaButton.TabIndex = 32
        Me.QuitarPreferenciaButton.Text = "Quitar"
        Me.QuitarPreferenciaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarPreferenciaButton.UseVisualStyleBackColor = True
        '
        'AgregarPreferenciaButton
        '
        Me.AgregarPreferenciaButton.Image = CType(resources.GetObject("AgregarPreferenciaButton.Image"), System.Drawing.Image)
        Me.AgregarPreferenciaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarPreferenciaButton.Location = New System.Drawing.Point(246, 121)
        Me.AgregarPreferenciaButton.Name = "AgregarPreferenciaButton"
        Me.AgregarPreferenciaButton.Size = New System.Drawing.Size(75, 23)
        Me.AgregarPreferenciaButton.TabIndex = 31
        Me.AgregarPreferenciaButton.Text = "Agregar"
        Me.AgregarPreferenciaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarPreferenciaButton.UseVisualStyleBackColor = True
        '
        'FamiliaColumn
        '
        Me.FamiliaColumn.DataPropertyName = "descripcion"
        Me.FamiliaColumn.HeaderText = "Familia"
        Me.FamiliaColumn.Name = "FamiliaColumn"
        Me.FamiliaColumn.ReadOnly = True
        '
        'Identificador
        '
        Me.Identificador.HeaderText = "Identificador"
        Me.Identificador.Name = "Identificador"
        Me.Identificador.ReadOnly = True
        Me.Identificador.Visible = False
        '
        'PreferenciaDataGrid
        '
        Me.PreferenciaDataGrid.AllowUserToAddRows = False
        Me.PreferenciaDataGrid.AllowUserToDeleteRows = False
        Me.PreferenciaDataGrid.AllowUserToResizeRows = False
        Me.PreferenciaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PreferenciaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PreferenciaDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificador, Me.FamiliaColumn})
        Me.PreferenciaDataGrid.Location = New System.Drawing.Point(327, 17)
        Me.PreferenciaDataGrid.MultiSelect = False
        Me.PreferenciaDataGrid.Name = "PreferenciaDataGrid"
        Me.PreferenciaDataGrid.ReadOnly = True
        Me.PreferenciaDataGrid.RowHeadersVisible = False
        Me.PreferenciaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PreferenciaDataGrid.Size = New System.Drawing.Size(218, 152)
        Me.PreferenciaDataGrid.TabIndex = 28
        '
        'NumeroLabel
        '
        Me.NumeroLabel.AutoSize = True
        Me.NumeroLabel.Location = New System.Drawing.Point(12, 126)
        Me.NumeroLabel.Name = "NumeroLabel"
        Me.NumeroLabel.Size = New System.Drawing.Size(44, 13)
        Me.NumeroLabel.TabIndex = 34
        Me.NumeroLabel.Text = "Numero"
        '
        'MyTextBox1
        '
        Me.MyTextBox1.alfanumerico = False
        Me.MyTextBox1.boton = Nothing
        Me.MyTextBox1.Location = New System.Drawing.Point(93, 123)
        Me.MyTextBox1.nada = False
        Me.MyTextBox1.Name = "MyTextBox1"
        Me.MyTextBox1.numerico = False
        Me.MyTextBox1.sinEspacio = False
        Me.MyTextBox1.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox1.TabIndex = 33
        Me.MyTextBox1.texto = False
        '
        'PisoLabel
        '
        Me.PisoLabel.AutoSize = True
        Me.PisoLabel.Location = New System.Drawing.Point(12, 152)
        Me.PisoLabel.Name = "PisoLabel"
        Me.PisoLabel.Size = New System.Drawing.Size(27, 13)
        Me.PisoLabel.TabIndex = 36
        Me.PisoLabel.Text = "Piso"
        '
        'MyTextBox2
        '
        Me.MyTextBox2.alfanumerico = False
        Me.MyTextBox2.boton = Nothing
        Me.MyTextBox2.Location = New System.Drawing.Point(93, 149)
        Me.MyTextBox2.nada = False
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.numerico = False
        Me.MyTextBox2.sinEspacio = False
        Me.MyTextBox2.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox2.TabIndex = 35
        Me.MyTextBox2.texto = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Codigo Postal"
        '
        'MyTextBox3
        '
        Me.MyTextBox3.alfanumerico = False
        Me.MyTextBox3.boton = Nothing
        Me.MyTextBox3.Location = New System.Drawing.Point(93, 175)
        Me.MyTextBox3.nada = False
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.numerico = False
        Me.MyTextBox3.sinEspacio = False
        Me.MyTextBox3.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox3.TabIndex = 37
        Me.MyTextBox3.texto = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Telefono"
        '
        'MyTextBox4
        '
        Me.MyTextBox4.alfanumerico = False
        Me.MyTextBox4.boton = Nothing
        Me.MyTextBox4.Location = New System.Drawing.Point(93, 201)
        Me.MyTextBox4.nada = False
        Me.MyTextBox4.Name = "MyTextBox4"
        Me.MyTextBox4.numerico = False
        Me.MyTextBox4.sinEspacio = False
        Me.MyTextBox4.Size = New System.Drawing.Size(140, 20)
        Me.MyTextBox4.TabIndex = 39
        Me.MyTextBox4.texto = False
        '
        'GenerarCompradorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(667, 264)
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
        Me.Name = "GenerarCompradorForm"
        Me.Text = "Direccion"
        CType(Me.PreferenciaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents QuitarPreferenciaButton As TicketYa.MyButton
    Friend WithEvents AgregarPreferenciaButton As TicketYa.MyButton
    Friend WithEvents FamiliaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreferenciaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents NumeroLabel As System.Windows.Forms.Label
    Friend WithEvents MyTextBox1 As TicketYa.MyTextBox
    Friend WithEvents PisoLabel As System.Windows.Forms.Label
    Friend WithEvents MyTextBox2 As TicketYa.MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox3 As TicketYa.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MyTextBox4 As TicketYa.MyTextBox

End Class
