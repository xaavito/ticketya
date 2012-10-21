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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarIdiomaForm))
        Me.IdiomaTextBox = New TicketYa.MyTextBox()
        Me.IdiomaLabel = New System.Windows.Forms.Label()
        Me.BuscarIdiomaButton = New TicketYa.MyButton()
        Me.IdiomasDataGrid = New TicketYa.MyDataGrid()
        Me.Identifcador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarIdiomaButton = New TicketYa.MyButton()
        Me.ModificarIdiomaButton = New TicketYa.MyButton()
        CType(Me.IdiomasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdiomaTextBox
        '
        Me.IdiomaTextBox.alfanumerico = False
        Me.IdiomaTextBox.boton = Nothing
        Me.IdiomaTextBox.Location = New System.Drawing.Point(81, 12)
        Me.IdiomaTextBox.Name = "IdiomaTextBox"
        Me.IdiomaTextBox.sinEspacio = False
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
        Me.BuscarIdiomaButton.Image = CType(resources.GetObject("BuscarIdiomaButton.Image"), System.Drawing.Image)
        Me.BuscarIdiomaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarIdiomaButton.Location = New System.Drawing.Point(238, 8)
        Me.BuscarIdiomaButton.Name = "BuscarIdiomaButton"
        Me.BuscarIdiomaButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarIdiomaButton.TabIndex = 2
        Me.BuscarIdiomaButton.Text = "Buscar"
        Me.BuscarIdiomaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarIdiomaButton.UseVisualStyleBackColor = True
        '
        'IdiomasDataGrid
        '
        Me.IdiomasDataGrid.AllowUserToAddRows = False
        Me.IdiomasDataGrid.AllowUserToDeleteRows = False
        Me.IdiomasDataGrid.AllowUserToResizeRows = False
        Me.IdiomasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IdiomasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IdiomasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identifcador, Me.Descripcion})
        Me.IdiomasDataGrid.Location = New System.Drawing.Point(16, 56)
        Me.IdiomasDataGrid.Name = "IdiomasDataGrid"
        Me.IdiomasDataGrid.ReadOnly = True
        Me.IdiomasDataGrid.RowHeadersVisible = False
        Me.IdiomasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.IdiomasDataGrid.Size = New System.Drawing.Size(297, 150)
        Me.IdiomasDataGrid.TabIndex = 3
        '
        'Identifcador
        '
        Me.Identifcador.DataPropertyName = "identificador"
        Me.Identifcador.HeaderText = "Identificador"
        Me.Identifcador.Name = "Identifcador"
        Me.Identifcador.ReadOnly = True
        Me.Identifcador.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'EliminarIdiomaButton
        '
        Me.EliminarIdiomaButton.Image = CType(resources.GetObject("EliminarIdiomaButton.Image"), System.Drawing.Image)
        Me.EliminarIdiomaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarIdiomaButton.Location = New System.Drawing.Point(336, 160)
        Me.EliminarIdiomaButton.Name = "EliminarIdiomaButton"
        Me.EliminarIdiomaButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarIdiomaButton.TabIndex = 4
        Me.EliminarIdiomaButton.Text = "Eliminar"
        Me.EliminarIdiomaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarIdiomaButton.UseVisualStyleBackColor = True
        '
        'ModificarIdiomaButton
        '
        Me.ModificarIdiomaButton.Image = CType(resources.GetObject("ModificarIdiomaButton.Image"), System.Drawing.Image)
        Me.ModificarIdiomaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarIdiomaButton.Location = New System.Drawing.Point(336, 74)
        Me.ModificarIdiomaButton.Name = "ModificarIdiomaButton"
        Me.ModificarIdiomaButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarIdiomaButton.TabIndex = 5
        Me.ModificarIdiomaButton.Text = "Modificar"
        Me.ModificarIdiomaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
    Friend WithEvents Identifcador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuscarIdiomaButton As TicketYa.MyButton
    Friend WithEvents IdiomasDataGrid As TicketYa.MyDataGrid
    Friend WithEvents EliminarIdiomaButton As TicketYa.MyButton
    Friend WithEvents ModificarIdiomaButton As TicketYa.MyButton

End Class
