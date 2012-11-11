<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarSedeForm
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
        Me.SedeLabel = New System.Windows.Forms.Label()
        Me.SedeTextBox = New TicketYa.MyTextBox()
        Me.BuscarSedeButton = New TicketYa.MyButton()
        Me.SedesDataGrid = New TicketYa.MyDataGrid()
        Me.ModificarSedeButton = New TicketYa.MyButton()
        Me.EliminarSedeButton = New TicketYa.MyButton()
        CType(Me.SedesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SedeLabel
        '
        Me.SedeLabel.AutoSize = True
        Me.SedeLabel.Location = New System.Drawing.Point(12, 29)
        Me.SedeLabel.Name = "SedeLabel"
        Me.SedeLabel.Size = New System.Drawing.Size(32, 13)
        Me.SedeLabel.TabIndex = 1
        Me.SedeLabel.Text = "Sede"
        '
        'SedeTextBox
        '
        Me.SedeTextBox.alfanumerico = False
        Me.SedeTextBox.boton = Nothing
        Me.SedeTextBox.Location = New System.Drawing.Point(68, 26)
        Me.SedeTextBox.nada = False
        Me.SedeTextBox.Name = "SedeTextBox"
        Me.SedeTextBox.numerico = False
        Me.SedeTextBox.sinEspacio = False
        Me.SedeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SedeTextBox.TabIndex = 2
        Me.SedeTextBox.texto = False
        '
        'BuscarSedeButton
        '
        Me.BuscarSedeButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarSedeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarSedeButton.Location = New System.Drawing.Point(499, 24)
        Me.BuscarSedeButton.Name = "BuscarSedeButton"
        Me.BuscarSedeButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarSedeButton.TabIndex = 3
        Me.BuscarSedeButton.Text = "Buscar"
        Me.BuscarSedeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarSedeButton.UseVisualStyleBackColor = True
        '
        'SedesDataGrid
        '
        Me.SedesDataGrid.AllowUserToAddRows = False
        Me.SedesDataGrid.AllowUserToDeleteRows = False
        Me.SedesDataGrid.AllowUserToResizeRows = False
        Me.SedesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SedesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SedesDataGrid.Location = New System.Drawing.Point(15, 71)
        Me.SedesDataGrid.Name = "SedesDataGrid"
        Me.SedesDataGrid.ReadOnly = True
        Me.SedesDataGrid.RowHeadersVisible = False
        Me.SedesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SedesDataGrid.Size = New System.Drawing.Size(454, 157)
        Me.SedesDataGrid.TabIndex = 4
        '
        'ModificarSedeButton
        '
        Me.ModificarSedeButton.Image = Global.TicketYa.My.Resources.Resources.editar
        Me.ModificarSedeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarSedeButton.Location = New System.Drawing.Point(499, 88)
        Me.ModificarSedeButton.Name = "ModificarSedeButton"
        Me.ModificarSedeButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarSedeButton.TabIndex = 5
        Me.ModificarSedeButton.Text = "Modificar"
        Me.ModificarSedeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarSedeButton.UseVisualStyleBackColor = True
        '
        'EliminarSedeButton
        '
        Me.EliminarSedeButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarSedeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarSedeButton.Location = New System.Drawing.Point(499, 164)
        Me.EliminarSedeButton.Name = "EliminarSedeButton"
        Me.EliminarSedeButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarSedeButton.TabIndex = 6
        Me.EliminarSedeButton.Text = "Eliminar"
        Me.EliminarSedeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarSedeButton.UseVisualStyleBackColor = True
        '
        'BuscarSedeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(616, 301)
        Me.Controls.Add(Me.EliminarSedeButton)
        Me.Controls.Add(Me.ModificarSedeButton)
        Me.Controls.Add(Me.SedesDataGrid)
        Me.Controls.Add(Me.BuscarSedeButton)
        Me.Controls.Add(Me.SedeTextBox)
        Me.Controls.Add(Me.SedeLabel)
        Me.Name = "BuscarSedeForm"
        Me.Text = "Buscar Sede"
        CType(Me.SedesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SedeLabel As System.Windows.Forms.Label
    Friend WithEvents SedeTextBox As TicketYa.MyTextBox
    Friend WithEvents BuscarSedeButton As TicketYa.MyButton
    Friend WithEvents SedesDataGrid As TicketYa.MyDataGrid
    Friend WithEvents ModificarSedeButton As TicketYa.MyButton
    Friend WithEvents EliminarSedeButton As TicketYa.MyButton

End Class
