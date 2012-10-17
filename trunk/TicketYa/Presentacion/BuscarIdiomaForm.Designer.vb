<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarIdiomaForm
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
        Me.IdiomaTextBox = New MyTextBox()
        Me.IdiomaLabel = New System.Windows.Forms.Label()
        Me.BuscarIdiomaButton = New System.Windows.Forms.Button()
        Me.IdiomasDataGrid = New MyDataGrid()
        Me.Identifcador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarIdiomaButton = New System.Windows.Forms.Button()
        Me.ModificarIdiomaButton = New System.Windows.Forms.Button()
        CType(Me.IdiomasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdiomaTextBox
        '
        Me.IdiomaTextBox.Location = New System.Drawing.Point(81, 12)
        Me.IdiomaTextBox.Name = "IdiomaTextBox"
        Me.IdiomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdiomaTextBox.TabIndex = 0
        '
        'IdiomaLabel
        '
        Me.IdiomaLabel.AutoSize = True
        Me.IdiomaLabel.Location = New System.Drawing.Point(13, 13)
        Me.IdiomaLabel.Name = "IdiomaLabel"
        Me.IdiomaLabel.Size = New System.Drawing.Size(44, 13)
        Me.IdiomaLabel.TabIndex = 1
        Me.IdiomaLabel.Text = "Nombre"
        '
        'BuscarIdiomaButton
        '
        Me.BuscarIdiomaButton.Location = New System.Drawing.Point(238, 8)
        Me.BuscarIdiomaButton.Name = "BuscarIdiomaButton"
        Me.BuscarIdiomaButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarIdiomaButton.TabIndex = 2
        Me.BuscarIdiomaButton.Text = "Buscar"
        Me.BuscarIdiomaButton.UseVisualStyleBackColor = True
        '
        'IdiomasDataGrid
        '
        Me.IdiomasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IdiomasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identifcador, Me.Descripcion})
        Me.IdiomasDataGrid.Location = New System.Drawing.Point(16, 56)
        Me.IdiomasDataGrid.Name = "IdiomasDataGrid"
        Me.IdiomasDataGrid.Size = New System.Drawing.Size(297, 150)
        Me.IdiomasDataGrid.TabIndex = 3
        '
        'Identifcador
        '
        Me.Identifcador.DataPropertyName = "identificador"
        Me.Identifcador.HeaderText = "Identificador"
        Me.Identifcador.Name = "Identifcador"
        Me.Identifcador.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'EliminarIdiomaButton
        '
        Me.EliminarIdiomaButton.Location = New System.Drawing.Point(336, 160)
        Me.EliminarIdiomaButton.Name = "EliminarIdiomaButton"
        Me.EliminarIdiomaButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarIdiomaButton.TabIndex = 4
        Me.EliminarIdiomaButton.Text = "Eliminar"
        Me.EliminarIdiomaButton.UseVisualStyleBackColor = True
        '
        'ModificarIdiomaButton
        '
        Me.ModificarIdiomaButton.Location = New System.Drawing.Point(336, 74)
        Me.ModificarIdiomaButton.Name = "ModificarIdiomaButton"
        Me.ModificarIdiomaButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarIdiomaButton.TabIndex = 5
        Me.ModificarIdiomaButton.Text = "Modificar"
        Me.ModificarIdiomaButton.UseVisualStyleBackColor = True
        '
        'BuscarIdiomaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(431, 260)
        Me.Controls.Add(Me.ModificarIdiomaButton)
        Me.Controls.Add(Me.EliminarIdiomaButton)
        Me.Controls.Add(Me.IdiomasDataGrid)
        Me.Controls.Add(Me.BuscarIdiomaButton)
        Me.Controls.Add(Me.IdiomaLabel)
        Me.Controls.Add(Me.IdiomaTextBox)
        Me.Name = "BuscarIdiomaForm"
        Me.Text = "Buscar Idioma"
        CType(Me.IdiomasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdiomaTextBox As MyTextBox
    Friend WithEvents IdiomaLabel As System.Windows.Forms.Label
    Friend WithEvents BuscarIdiomaButton As System.Windows.Forms.Button
    Friend WithEvents IdiomasDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EliminarIdiomaButton As System.Windows.Forms.Button
    Friend WithEvents ModificarIdiomaButton As System.Windows.Forms.Button
    Friend WithEvents Identifcador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
