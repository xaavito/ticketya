<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarFechaForm
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
        Me.FechaTextBox = New TicketYa.MyMaskedTextBox()
        Me.ShowComboBox = New TicketYa.MyComboBox()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.AltaFechaButton = New TicketYa.MyButton()
        Me.SuspendLayout()
        '
        'FechaTextBox
        '
        Me.FechaTextBox.Location = New System.Drawing.Point(91, 61)
        Me.FechaTextBox.Mask = "00/00/0000"
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(66, 20)
        Me.FechaTextBox.TabIndex = 38
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.emptyItem = Nothing
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.lista = Nothing
        Me.ShowComboBox.Location = New System.Drawing.Point(91, 31)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(169, 21)
        Me.ShowComboBox.TabIndex = 37
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(12, 61)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(37, 13)
        Me.FechaLabel.TabIndex = 35
        Me.FechaLabel.Text = "Fecha"
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(12, 35)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 34
        Me.ShowLabel.Text = "Show"
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
        Me.NombreTextBox.Size = New System.Drawing.Size(169, 20)
        Me.NombreTextBox.TabIndex = 33
        Me.NombreTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(12, 9)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 32
        Me.NombreLabel.Text = "Nombre"
        '
        'AltaFechaButton
        '
        Me.AltaFechaButton.Image = Global.TicketYa.My.Resources.Resources.save
        Me.AltaFechaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AltaFechaButton.Location = New System.Drawing.Point(303, 4)
        Me.AltaFechaButton.Name = "AltaFechaButton"
        Me.AltaFechaButton.Size = New System.Drawing.Size(75, 23)
        Me.AltaFechaButton.TabIndex = 36
        Me.AltaFechaButton.Text = "Modificar"
        Me.AltaFechaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AltaFechaButton.UseVisualStyleBackColor = True
        '
        'ModificarFechaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(393, 109)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(Me.ShowComboBox)
        Me.Controls.Add(Me.AltaFechaButton)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.ShowLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Name = "ModificarFechaForm"
        Me.Text = "Modificar fecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FechaTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents ShowComboBox As TicketYa.MyComboBox
    Friend WithEvents AltaFechaButton As TicketYa.MyButton
    Friend WithEvents FechaLabel As System.Windows.Forms.Label
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label

End Class
