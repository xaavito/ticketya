<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarUsuarioForm
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
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarUsuariosButton = New System.Windows.Forms.Button()
        Me.UsuariosDataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.Location = New System.Drawing.Point(28, 43)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsuarioLabel.TabIndex = 7
        Me.UsuarioLabel.Text = "Usuario"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.Location = New System.Drawing.Point(109, 40)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UsuarioTextBox.TabIndex = 6
        '
        'BuscarUsuariosButton
        '
        Me.BuscarUsuariosButton.Location = New System.Drawing.Point(573, 40)
        Me.BuscarUsuariosButton.Name = "BuscarUsuariosButton"
        Me.BuscarUsuariosButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarUsuariosButton.TabIndex = 5
        Me.BuscarUsuariosButton.Text = "Buscar"
        Me.BuscarUsuariosButton.UseVisualStyleBackColor = True
        '
        'UsuariosDataGrid
        '
        Me.UsuariosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGrid.Location = New System.Drawing.Point(28, 133)
        Me.UsuariosDataGrid.Name = "UsuariosDataGrid"
        Me.UsuariosDataGrid.Size = New System.Drawing.Size(620, 228)
        Me.UsuariosDataGrid.TabIndex = 4
        '
        'BuscarUsuarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(677, 400)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.BuscarUsuariosButton)
        Me.Controls.Add(Me.UsuariosDataGrid)
        Me.Name = "BuscarUsuarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.UsuariosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioLabel As System.Windows.Forms.Label
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuscarUsuariosButton As System.Windows.Forms.Button
    Friend WithEvents UsuariosDataGrid As System.Windows.Forms.DataGridView

End Class
