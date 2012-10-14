<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarFamiliaForm
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
        Me.FamiliaLabel = New System.Windows.Forms.Label()
        Me.FamiliaTextBox = New System.Windows.Forms.TextBox()
        Me.AltaFamiliaButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FamiliaLabel
        '
        Me.FamiliaLabel.AutoSize = True
        Me.FamiliaLabel.Location = New System.Drawing.Point(55, 29)
        Me.FamiliaLabel.Name = "FamiliaLabel"
        Me.FamiliaLabel.Size = New System.Drawing.Size(39, 13)
        Me.FamiliaLabel.TabIndex = 12
        Me.FamiliaLabel.Text = "Familia"
        '
        'FamiliaTextBox
        '
        Me.FamiliaTextBox.Location = New System.Drawing.Point(136, 26)
        Me.FamiliaTextBox.Name = "FamiliaTextBox"
        Me.FamiliaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FamiliaTextBox.TabIndex = 11
        '
        'AltaFamiliaButton
        '
        Me.AltaFamiliaButton.Location = New System.Drawing.Point(362, 29)
        Me.AltaFamiliaButton.Name = "AltaFamiliaButton"
        Me.AltaFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.AltaFamiliaButton.TabIndex = 10
        Me.AltaFamiliaButton.Text = "Alta"
        Me.AltaFamiliaButton.UseVisualStyleBackColor = True
        '
        'GenerarFamiliaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(731, 372)
        Me.Controls.Add(Me.FamiliaLabel)
        Me.Controls.Add(Me.FamiliaTextBox)
        Me.Controls.Add(Me.AltaFamiliaButton)
        Me.Name = "GenerarFamiliaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Familia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FamiliaLabel As System.Windows.Forms.Label
    Friend WithEvents FamiliaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AltaFamiliaButton As System.Windows.Forms.Button

End Class
