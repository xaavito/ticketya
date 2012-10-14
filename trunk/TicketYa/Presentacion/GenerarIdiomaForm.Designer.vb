<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarIdiomaForm
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
        Me.IdiomaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdiomaBaseLabel = New System.Windows.Forms.Label()
        Me.GenerarIdiomaButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdiomaTextBox = New MyTextBox()
        Me.SuspendLayout()
        '
        'IdiomaComboBox
        '
        Me.IdiomaComboBox.FormattingEnabled = True
        Me.IdiomaComboBox.Location = New System.Drawing.Point(97, 43)
        Me.IdiomaComboBox.Name = "IdiomaComboBox"
        Me.IdiomaComboBox.Size = New System.Drawing.Size(130, 21)
        Me.IdiomaComboBox.TabIndex = 7
        '
        'IdiomaBaseLabel
        '
        Me.IdiomaBaseLabel.AutoSize = True
        Me.IdiomaBaseLabel.Location = New System.Drawing.Point(12, 46)
        Me.IdiomaBaseLabel.Name = "IdiomaBaseLabel"
        Me.IdiomaBaseLabel.Size = New System.Drawing.Size(65, 13)
        Me.IdiomaBaseLabel.TabIndex = 6
        Me.IdiomaBaseLabel.Text = "Idioma Base"
        '
        'GenerarIdiomaButton
        '
        Me.GenerarIdiomaButton.Location = New System.Drawing.Point(244, 12)
        Me.GenerarIdiomaButton.Name = "GenerarIdiomaButton"
        Me.GenerarIdiomaButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarIdiomaButton.TabIndex = 8
        Me.GenerarIdiomaButton.Text = "Generar"
        Me.GenerarIdiomaButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'IdiomaTextBox
        '
        Me.IdiomaTextBox.Location = New System.Drawing.Point(97, 12)
        Me.IdiomaTextBox.Name = "IdiomaTextBox"
        Me.IdiomaTextBox.Size = New System.Drawing.Size(130, 20)
        Me.IdiomaTextBox.TabIndex = 10
        '
        'GenerarIdiomaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(393, 87)
        Me.Controls.Add(Me.IdiomaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenerarIdiomaButton)
        Me.Controls.Add(Me.IdiomaComboBox)
        Me.Controls.Add(Me.IdiomaBaseLabel)
        Me.Name = "GenerarIdiomaForm"
        Me.Text = "Generar Idioma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdiomaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdiomaBaseLabel As System.Windows.Forms.Label
    Friend WithEvents GenerarIdiomaButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdiomaTextBox As MyTextBox

End Class
