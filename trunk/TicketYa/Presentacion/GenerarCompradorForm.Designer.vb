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
        Me.PreferenciaComboBox = New TicketYa.MyComboBox()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.DireccionTextBox = New TicketYa.MyTextBox()
        Me.MailLabel = New System.Windows.Forms.Label()
        Me.MailTextBox = New TicketYa.MyTextBox()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.GenerarCompradorButton = New TicketYa.MyButton()
        Me.QuitarPreferenciaButton = New TicketYa.MyButton()
        Me.AgregarPreferenciaButton = New TicketYa.MyButton()
        Me.FamiliaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreferenciaDataGrid = New TicketYa.MyDataGrid()
        Me.NumeroLabel = New System.Windows.Forms.Label()
        Me.NumeroTextBox = New TicketYa.MyTextBox()
        Me.PisoLabel = New System.Windows.Forms.Label()
        Me.PisoTextBox = New TicketYa.MyTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CodPostTextBox = New TicketYa.MyTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TelefonoTextBox = New TicketYa.MyTextBox()
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
        'PreferenciaComboBox
        '
        Me.PreferenciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PreferenciaComboBox.emptyItem = Nothing
        Me.PreferenciaComboBox.FormattingEnabled = True
        Me.PreferenciaComboBox.lista = Nothing
        Me.PreferenciaComboBox.Location = New System.Drawing.Point(93, 227)
        Me.PreferenciaComboBox.Name = "PreferenciaComboBox"
        Me.PreferenciaComboBox.Size = New System.Drawing.Size(140, 21)
        Me.PreferenciaComboBox.TabIndex = 26
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
        'DireccionTextBox
        '
        Me.DireccionTextBox.alfanumerico = False
        Me.DireccionTextBox.boton = Nothing
        Me.DireccionTextBox.Location = New System.Drawing.Point(93, 95)
        Me.DireccionTextBox.nada = False
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.numerico = False
        Me.DireccionTextBox.sinEspacio = False
        Me.DireccionTextBox.Size = New System.Drawing.Size(140, 20)
        Me.DireccionTextBox.TabIndex = 24
        Me.DireccionTextBox.texto = False
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
        'MailTextBox
        '
        Me.MailTextBox.alfanumerico = False
        Me.MailTextBox.boton = Nothing
        Me.MailTextBox.Location = New System.Drawing.Point(93, 69)
        Me.MailTextBox.nada = False
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.numerico = False
        Me.MailTextBox.sinEspacio = False
        Me.MailTextBox.Size = New System.Drawing.Size(140, 20)
        Me.MailTextBox.TabIndex = 22
        Me.MailTextBox.texto = False
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
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(93, 43)
        Me.ApellidoTextBox.nada = False
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.numerico = False
        Me.ApellidoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.ApellidoTextBox.TabIndex = 20
        Me.ApellidoTextBox.texto = False
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
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(93, 17)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NombreTextBox.TabIndex = 18
        Me.NombreTextBox.texto = False
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
        'NumeroTextBox
        '
        Me.NumeroTextBox.alfanumerico = False
        Me.NumeroTextBox.boton = Nothing
        Me.NumeroTextBox.Location = New System.Drawing.Point(93, 123)
        Me.NumeroTextBox.nada = False
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.numerico = False
        Me.NumeroTextBox.sinEspacio = False
        Me.NumeroTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NumeroTextBox.TabIndex = 33
        Me.NumeroTextBox.texto = False
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
        'PisoTextBox
        '
        Me.PisoTextBox.alfanumerico = False
        Me.PisoTextBox.boton = Nothing
        Me.PisoTextBox.Location = New System.Drawing.Point(93, 149)
        Me.PisoTextBox.nada = False
        Me.PisoTextBox.Name = "PisoTextBox"
        Me.PisoTextBox.numerico = False
        Me.PisoTextBox.sinEspacio = False
        Me.PisoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PisoTextBox.TabIndex = 35
        Me.PisoTextBox.texto = False
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
        'CodPostTextBox
        '
        Me.CodPostTextBox.alfanumerico = False
        Me.CodPostTextBox.boton = Nothing
        Me.CodPostTextBox.Location = New System.Drawing.Point(93, 175)
        Me.CodPostTextBox.nada = False
        Me.CodPostTextBox.Name = "CodPostTextBox"
        Me.CodPostTextBox.numerico = False
        Me.CodPostTextBox.sinEspacio = False
        Me.CodPostTextBox.Size = New System.Drawing.Size(140, 20)
        Me.CodPostTextBox.TabIndex = 37
        Me.CodPostTextBox.texto = False
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
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.alfanumerico = False
        Me.TelefonoTextBox.boton = Nothing
        Me.TelefonoTextBox.Location = New System.Drawing.Point(93, 201)
        Me.TelefonoTextBox.nada = False
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.numerico = False
        Me.TelefonoTextBox.sinEspacio = False
        Me.TelefonoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.TelefonoTextBox.TabIndex = 39
        Me.TelefonoTextBox.texto = False
        '
        'GenerarCompradorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(667, 264)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CodPostTextBox)
        Me.Controls.Add(Me.PisoLabel)
        Me.Controls.Add(Me.PisoTextBox)
        Me.Controls.Add(Me.NumeroLabel)
        Me.Controls.Add(Me.NumeroTextBox)
        Me.Controls.Add(Me.QuitarPreferenciaButton)
        Me.Controls.Add(Me.AgregarPreferenciaButton)
        Me.Controls.Add(Me.PreferenciaDataGrid)
        Me.Controls.Add(Me.PreferenciasLabel)
        Me.Controls.Add(Me.PreferenciaComboBox)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.GenerarCompradorButton)
        Me.Name = "GenerarCompradorForm"
        Me.Text = "Direccion"
        CType(Me.PreferenciaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PreferenciasLabel As System.Windows.Forms.Label
    Friend WithEvents PreferenciaComboBox As TicketYa.MyComboBox
    Friend WithEvents DireccionLabel As System.Windows.Forms.Label
    Friend WithEvents DireccionTextBox As TicketYa.MyTextBox
    Friend WithEvents MailLabel As System.Windows.Forms.Label
    Friend WithEvents MailTextBox As TicketYa.MyTextBox
    Friend WithEvents ApellidoLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents GenerarCompradorButton As TicketYa.MyButton
    Friend WithEvents QuitarPreferenciaButton As TicketYa.MyButton
    Friend WithEvents AgregarPreferenciaButton As TicketYa.MyButton
    Friend WithEvents FamiliaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreferenciaDataGrid As TicketYa.MyDataGrid
    Friend WithEvents NumeroLabel As System.Windows.Forms.Label
    Friend WithEvents NumeroTextBox As TicketYa.MyTextBox
    Friend WithEvents PisoLabel As System.Windows.Forms.Label
    Friend WithEvents PisoTextBox As TicketYa.MyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodPostTextBox As TicketYa.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TelefonoTextBox As TicketYa.MyTextBox

End Class
