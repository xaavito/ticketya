<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarShowForm
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
        Me.SedeComboBox = New TicketYa.MyComboBox()
        Me.TipoShowComboBox = New TicketYa.MyComboBox()
        Me.AltaShowButton = New TicketYa.MyButton()
        Me.SedeLabel = New System.Windows.Forms.Label()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SedeComboBox
        '
        Me.SedeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SedeComboBox.emptyItem = Nothing
        Me.SedeComboBox.FormattingEnabled = True
        Me.SedeComboBox.lista = Nothing
        Me.SedeComboBox.Location = New System.Drawing.Point(89, 64)
        Me.SedeComboBox.Name = "SedeComboBox"
        Me.SedeComboBox.Size = New System.Drawing.Size(169, 21)
        Me.SedeComboBox.TabIndex = 31
        '
        'TipoShowComboBox
        '
        Me.TipoShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoShowComboBox.emptyItem = Nothing
        Me.TipoShowComboBox.FormattingEnabled = True
        Me.TipoShowComboBox.lista = Nothing
        Me.TipoShowComboBox.Location = New System.Drawing.Point(89, 37)
        Me.TipoShowComboBox.Name = "TipoShowComboBox"
        Me.TipoShowComboBox.Size = New System.Drawing.Size(169, 21)
        Me.TipoShowComboBox.TabIndex = 30
        '
        'AltaShowButton
        '
        Me.AltaShowButton.Image = Global.TicketYa.My.Resources.Resources.save
        Me.AltaShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AltaShowButton.Location = New System.Drawing.Point(301, 10)
        Me.AltaShowButton.Name = "AltaShowButton"
        Me.AltaShowButton.Size = New System.Drawing.Size(75, 23)
        Me.AltaShowButton.TabIndex = 29
        Me.AltaShowButton.Text = "Modificar"
        Me.AltaShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AltaShowButton.UseVisualStyleBackColor = True
        '
        'SedeLabel
        '
        Me.SedeLabel.AutoSize = True
        Me.SedeLabel.Location = New System.Drawing.Point(10, 67)
        Me.SedeLabel.Name = "SedeLabel"
        Me.SedeLabel.Size = New System.Drawing.Size(32, 13)
        Me.SedeLabel.TabIndex = 28
        Me.SedeLabel.Text = "Sede"
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(10, 41)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoLabel.TabIndex = 27
        Me.TipoLabel.Text = "Tipo"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(89, 12)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(169, 20)
        Me.NombreTextBox.TabIndex = 26
        Me.NombreTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(10, 15)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 25
        Me.NombreLabel.Text = "Nombre"
        '
        'ModificarShowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(389, 107)
        Me.Controls.Add(Me.SedeComboBox)
        Me.Controls.Add(Me.TipoShowComboBox)
        Me.Controls.Add(Me.AltaShowButton)
        Me.Controls.Add(Me.SedeLabel)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Name = "ModificarShowForm"
        Me.Text = "Generar Show"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SedeComboBox As TicketYa.MyComboBox
    Friend WithEvents TipoShowComboBox As TicketYa.MyComboBox
    Friend WithEvents AltaShowButton As TicketYa.MyButton
    Friend WithEvents SedeLabel As System.Windows.Forms.Label
    Friend WithEvents TipoLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label

End Class
