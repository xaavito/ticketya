<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarFamiliaForm
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
        Me.FamiliaTextBox = New MyTextBox()
        Me.ModificarFamiliaButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FamiliaLabel
        '
        Me.FamiliaLabel.AutoSize = True
        Me.FamiliaLabel.Location = New System.Drawing.Point(47, 32)
        Me.FamiliaLabel.Name = "FamiliaLabel"
        Me.FamiliaLabel.Size = New System.Drawing.Size(39, 13)
        Me.FamiliaLabel.TabIndex = 15
        Me.FamiliaLabel.Text = "Familia"
        '
        'FamiliaTextBox
        '
        Me.FamiliaTextBox.Location = New System.Drawing.Point(128, 29)
        Me.FamiliaTextBox.Name = "FamiliaTextBox"
        Me.FamiliaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FamiliaTextBox.TabIndex = 14
        '
        'ModificarFamiliaButton
        '
        Me.ModificarFamiliaButton.Location = New System.Drawing.Point(353, 26)
        Me.ModificarFamiliaButton.Name = "ModificarFamiliaButton"
        Me.ModificarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarFamiliaButton.TabIndex = 13
        Me.ModificarFamiliaButton.Text = "Modificar"
        Me.ModificarFamiliaButton.UseVisualStyleBackColor = True
        '
        'ModificarFamiliaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(666, 332)
        Me.Controls.Add(Me.FamiliaLabel)
        Me.Controls.Add(Me.FamiliaTextBox)
        Me.Controls.Add(Me.ModificarFamiliaButton)
        Me.Name = "ModificarFamiliaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Familia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FamiliaLabel As System.Windows.Forms.Label
    Friend WithEvents FamiliaTextBox As MyTextBox
    Friend WithEvents ModificarFamiliaButton As System.Windows.Forms.Button

End Class
