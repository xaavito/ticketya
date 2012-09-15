<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits TicketYa.MainForm

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
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.PassLabel = New System.Windows.Forms.Label()
        Me.CambiarIdiomaLabel = New System.Windows.Forms.Label()
        Me.IdiomaComboBox = New System.Windows.Forms.ComboBox()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(127, 27)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserTextBox.TabIndex = 0
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(127, 67)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PassTextBox.TabIndex = 1
        Me.PassTextBox.UseSystemPasswordChar = True
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(37, 27)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsuarioLabel.TabIndex = 2
        Me.UsuarioLabel.Text = "Usuario"
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Location = New System.Drawing.Point(37, 67)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(61, 13)
        Me.PassLabel.TabIndex = 3
        Me.PassLabel.Text = "Contraseña"
        '
        'CambiarIdiomaLabel
        '
        Me.CambiarIdiomaLabel.AutoSize = True
        Me.CambiarIdiomaLabel.Location = New System.Drawing.Point(12, 173)
        Me.CambiarIdiomaLabel.Name = "CambiarIdiomaLabel"
        Me.CambiarIdiomaLabel.Size = New System.Drawing.Size(79, 13)
        Me.CambiarIdiomaLabel.TabIndex = 4
        Me.CambiarIdiomaLabel.Text = "Cambiar Idioma"
        '
        'IdiomaComboBox
        '
        Me.IdiomaComboBox.FormattingEnabled = True
        Me.IdiomaComboBox.Location = New System.Drawing.Point(117, 170)
        Me.IdiomaComboBox.Name = "IdiomaComboBox"
        Me.IdiomaComboBox.Size = New System.Drawing.Size(130, 21)
        Me.IdiomaComboBox.TabIndex = 5
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(69, 105)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 6
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(213, 105)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 7
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(358, 273)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.IdiomaComboBox)
        Me.Controls.Add(Me.CambiarIdiomaLabel)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.UserTextBox)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents CambiarIdiomaLabel As System.Windows.Forms.Label
    Friend WithEvents IdiomaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AceptarButton As System.Windows.Forms.Button
    Friend WithEvents CancelarButton As System.Windows.Forms.Button

End Class
