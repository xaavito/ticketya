﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarFamiliaForm))
        Me.FamiliaLabel = New System.Windows.Forms.Label()
        Me.FamiliaTextBox = New TicketYa.MyTextBox()
        Me.ModificarFamiliaButton = New TicketYa.MyButton()
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
        Me.FamiliaTextBox.alfanumerico = False
        Me.FamiliaTextBox.boton = Nothing
        Me.FamiliaTextBox.Location = New System.Drawing.Point(128, 29)
        Me.FamiliaTextBox.nada = False
        Me.FamiliaTextBox.Name = "FamiliaTextBox"
        Me.FamiliaTextBox.numerico = False
        Me.FamiliaTextBox.sinEspacio = False
        Me.FamiliaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FamiliaTextBox.TabIndex = 14
        Me.FamiliaTextBox.texto = False
        '
        'ModificarFamiliaButton
        '
        Me.ModificarFamiliaButton.Image = CType(resources.GetObject("ModificarFamiliaButton.Image"), System.Drawing.Image)
        Me.ModificarFamiliaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarFamiliaButton.Location = New System.Drawing.Point(353, 26)
        Me.ModificarFamiliaButton.Name = "ModificarFamiliaButton"
        Me.ModificarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarFamiliaButton.TabIndex = 13
        Me.ModificarFamiliaButton.Text = "Guardar"
        Me.ModificarFamiliaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarFamiliaButton.UseVisualStyleBackColor = True
        '
        'ModificarFamiliaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(481, 93)
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
    Friend WithEvents ModificarFamiliaButton As TicketYa.MyButton

End Class
