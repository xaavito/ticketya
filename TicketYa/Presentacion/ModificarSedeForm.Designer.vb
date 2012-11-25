<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarSedeForm
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
        Me.AltaSedeButton = New TicketYa.MyButton()
        Me.TelefonoTextBox = New TicketYa.MyTextBox()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.NumeroTextBox = New TicketYa.MyTextBox()
        Me.NumeroLabel = New System.Windows.Forms.Label()
        Me.DireccionTextBox = New TicketYa.MyTextBox()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.CapacidadTexBox = New TicketYa.MyTextBox()
        Me.CapacidadLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AltaSedeButton
        '
        Me.AltaSedeButton.Image = Global.TicketYa.My.Resources.Resources.save
        Me.AltaSedeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AltaSedeButton.Location = New System.Drawing.Point(244, 4)
        Me.AltaSedeButton.Name = "AltaSedeButton"
        Me.AltaSedeButton.Size = New System.Drawing.Size(75, 23)
        Me.AltaSedeButton.TabIndex = 22
        Me.AltaSedeButton.Text = "Modificar"
        Me.AltaSedeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AltaSedeButton.UseVisualStyleBackColor = True
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.alfanumerico = False
        Me.TelefonoTextBox.boton = Nothing
        Me.TelefonoTextBox.Location = New System.Drawing.Point(91, 110)
        Me.TelefonoTextBox.nada = False
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.numerico = False
        Me.TelefonoTextBox.sinEspacio = False
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 21
        Me.TelefonoTextBox.texto = False
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Location = New System.Drawing.Point(12, 113)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(49, 13)
        Me.TelefonoLabel.TabIndex = 20
        Me.TelefonoLabel.Text = "Telefono"
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.alfanumerico = False
        Me.NumeroTextBox.boton = Nothing
        Me.NumeroTextBox.Location = New System.Drawing.Point(91, 84)
        Me.NumeroTextBox.nada = False
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.numerico = False
        Me.NumeroTextBox.sinEspacio = False
        Me.NumeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroTextBox.TabIndex = 19
        Me.NumeroTextBox.texto = False
        '
        'NumeroLabel
        '
        Me.NumeroLabel.AutoSize = True
        Me.NumeroLabel.Location = New System.Drawing.Point(12, 87)
        Me.NumeroLabel.Name = "NumeroLabel"
        Me.NumeroLabel.Size = New System.Drawing.Size(44, 13)
        Me.NumeroLabel.TabIndex = 18
        Me.NumeroLabel.Text = "Numero"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.alfanumerico = False
        Me.DireccionTextBox.boton = Nothing
        Me.DireccionTextBox.Location = New System.Drawing.Point(91, 58)
        Me.DireccionTextBox.nada = False
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.numerico = False
        Me.DireccionTextBox.sinEspacio = False
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 17
        Me.DireccionTextBox.texto = False
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Location = New System.Drawing.Point(12, 61)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(52, 13)
        Me.DireccionLabel.TabIndex = 16
        Me.DireccionLabel.Text = "Direccion"
        '
        'CapacidadTexBox
        '
        Me.CapacidadTexBox.alfanumerico = False
        Me.CapacidadTexBox.boton = Nothing
        Me.CapacidadTexBox.Location = New System.Drawing.Point(91, 32)
        Me.CapacidadTexBox.nada = False
        Me.CapacidadTexBox.Name = "CapacidadTexBox"
        Me.CapacidadTexBox.numerico = False
        Me.CapacidadTexBox.sinEspacio = False
        Me.CapacidadTexBox.Size = New System.Drawing.Size(100, 20)
        Me.CapacidadTexBox.TabIndex = 15
        Me.CapacidadTexBox.texto = False
        '
        'CapacidadLabel
        '
        Me.CapacidadLabel.AutoSize = True
        Me.CapacidadLabel.Location = New System.Drawing.Point(12, 35)
        Me.CapacidadLabel.Name = "CapacidadLabel"
        Me.CapacidadLabel.Size = New System.Drawing.Size(58, 13)
        Me.CapacidadLabel.TabIndex = 14
        Me.CapacidadLabel.Text = "Capacidad"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(91, 6)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 13
        Me.NombreTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(12, 9)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 12
        Me.NombreLabel.Text = "Nombre"
        '
        'ModificarSedeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(340, 147)
        Me.Controls.Add(Me.AltaSedeButton)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.NumeroTextBox)
        Me.Controls.Add(Me.NumeroLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.CapacidadTexBox)
        Me.Controls.Add(Me.CapacidadLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Name = "ModificarSedeForm"
        Me.Text = "Modificar Sede"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AltaSedeButton As TicketYa.MyButton
    Friend WithEvents TelefonoTextBox As TicketYa.MyTextBox
    Friend WithEvents TelefonoLabel As System.Windows.Forms.Label
    Friend WithEvents NumeroTextBox As TicketYa.MyTextBox
    Friend WithEvents NumeroLabel As System.Windows.Forms.Label
    Friend WithEvents DireccionTextBox As TicketYa.MyTextBox
    Friend WithEvents DireccionLabel As System.Windows.Forms.Label
    Friend WithEvents CapacidadTexBox As TicketYa.MyTextBox
    Friend WithEvents CapacidadLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label

End Class
