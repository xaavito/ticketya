<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarFamiliaForm
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
        Me.EliminarFamiliaButton = New System.Windows.Forms.Button()
        Me.ModificarFamiliaButton = New System.Windows.Forms.Button()
        Me.FamiliaLabel = New System.Windows.Forms.Label()
        Me.FamiliaTextBox = New System.Windows.Forms.TextBox()
        Me.BuscarFamiliasButton = New System.Windows.Forms.Button()
        Me.FamiliasDataGrid = New System.Windows.Forms.DataGridView()
        Me.identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FamiliasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EliminarFamiliaButton
        '
        Me.EliminarFamiliaButton.Location = New System.Drawing.Point(488, 267)
        Me.EliminarFamiliaButton.Name = "EliminarFamiliaButton"
        Me.EliminarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarFamiliaButton.TabIndex = 20
        Me.EliminarFamiliaButton.Text = "Eliminar"
        Me.EliminarFamiliaButton.UseVisualStyleBackColor = True
        '
        'ModificarFamiliaButton
        '
        Me.ModificarFamiliaButton.Location = New System.Drawing.Point(488, 183)
        Me.ModificarFamiliaButton.Name = "ModificarFamiliaButton"
        Me.ModificarFamiliaButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarFamiliaButton.TabIndex = 19
        Me.ModificarFamiliaButton.Text = "Modificar"
        Me.ModificarFamiliaButton.UseVisualStyleBackColor = True
        '
        'FamiliaLabel
        '
        Me.FamiliaLabel.AutoSize = True
        Me.FamiliaLabel.Location = New System.Drawing.Point(9, 43)
        Me.FamiliaLabel.Name = "FamiliaLabel"
        Me.FamiliaLabel.Size = New System.Drawing.Size(39, 13)
        Me.FamiliaLabel.TabIndex = 18
        Me.FamiliaLabel.Text = "Familia"
        '
        'FamiliaTextBox
        '
        Me.FamiliaTextBox.Location = New System.Drawing.Point(90, 40)
        Me.FamiliaTextBox.Name = "FamiliaTextBox"
        Me.FamiliaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FamiliaTextBox.TabIndex = 17
        '
        'BuscarFamiliasButton
        '
        Me.BuscarFamiliasButton.Location = New System.Drawing.Point(554, 40)
        Me.BuscarFamiliasButton.Name = "BuscarFamiliasButton"
        Me.BuscarFamiliasButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarFamiliasButton.TabIndex = 16
        Me.BuscarFamiliasButton.Text = "Buscar"
        Me.BuscarFamiliasButton.UseVisualStyleBackColor = True
        '
        'FamiliasDataGrid
        '
        Me.FamiliasDataGrid.AllowUserToAddRows = False
        Me.FamiliasDataGrid.AllowUserToDeleteRows = False
        Me.FamiliasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identificador, Me.NombreColumn})
        Me.FamiliasDataGrid.Location = New System.Drawing.Point(9, 133)
        Me.FamiliasDataGrid.Name = "FamiliasDataGrid"
        Me.FamiliasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FamiliasDataGrid.Size = New System.Drawing.Size(461, 228)
        Me.FamiliasDataGrid.TabIndex = 15
        '
        'identificador
        '
        Me.identificador.DataPropertyName = "identificador"
        Me.identificador.HeaderText = "identificador"
        Me.identificador.Name = "identificador"
        Me.identificador.Visible = False
        '
        'NombreColumn
        '
        Me.NombreColumn.DataPropertyName = "descripcion"
        Me.NombreColumn.HeaderText = "Nombre"
        Me.NombreColumn.Name = "NombreColumn"
        Me.NombreColumn.ReadOnly = True
        '
        'BuscarFamiliaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(639, 400)
        Me.Controls.Add(Me.EliminarFamiliaButton)
        Me.Controls.Add(Me.ModificarFamiliaButton)
        Me.Controls.Add(Me.FamiliaLabel)
        Me.Controls.Add(Me.FamiliaTextBox)
        Me.Controls.Add(Me.BuscarFamiliasButton)
        Me.Controls.Add(Me.FamiliasDataGrid)
        Me.Name = "BuscarFamiliaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Familia"
        CType(Me.FamiliasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarFamiliaButton As System.Windows.Forms.Button
    Friend WithEvents ModificarFamiliaButton As System.Windows.Forms.Button
    Friend WithEvents FamiliaLabel As System.Windows.Forms.Label
    Friend WithEvents FamiliaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuscarFamiliasButton As System.Windows.Forms.Button
    Friend WithEvents FamiliasDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
