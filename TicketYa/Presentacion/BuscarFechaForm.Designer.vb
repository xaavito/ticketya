<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarFechaForm
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
        Me.FechasDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowTextBox = New TicketYa.MyTextBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.EliminarFechaButton = New TicketYa.MyButton()
        Me.ModificarFechaButton = New TicketYa.MyButton()
        Me.BuscarFechaButton = New TicketYa.MyButton()
        Me.FechaDesdeLabel = New System.Windows.Forms.Label()
        Me.FechaDesdeTextBox = New TicketYa.MyMaskedTextBox()
        Me.FechaHastaTextBox = New TicketYa.MyMaskedTextBox()
        Me.FechaHastaLabel = New System.Windows.Forms.Label()
        Me.ReportesButton = New TicketYa.MyButton()
        CType(Me.FechasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechasDataGrid
        '
        Me.FechasDataGrid.AllowUserToAddRows = False
        Me.FechasDataGrid.AllowUserToDeleteRows = False
        Me.FechasDataGrid.AllowUserToResizeRows = False
        Me.FechasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechasDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.FechaColumn})
        Me.FechasDataGrid.Location = New System.Drawing.Point(29, 63)
        Me.FechasDataGrid.Name = "FechasDataGrid"
        Me.FechasDataGrid.ReadOnly = True
        Me.FechasDataGrid.RowHeadersVisible = False
        Me.FechasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FechasDataGrid.Size = New System.Drawing.Size(454, 157)
        Me.FechasDataGrid.TabIndex = 16
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "descripcion"
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        '
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "fecha"
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        '
        'ShowTextBox
        '
        Me.ShowTextBox.alfanumerico = False
        Me.ShowTextBox.boton = Nothing
        Me.ShowTextBox.Location = New System.Drawing.Point(66, 18)
        Me.ShowTextBox.nada = False
        Me.ShowTextBox.Name = "ShowTextBox"
        Me.ShowTextBox.numerico = False
        Me.ShowTextBox.sinEspacio = False
        Me.ShowTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ShowTextBox.TabIndex = 14
        Me.ShowTextBox.texto = False
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(26, 21)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 13
        Me.ShowLabel.Text = "Show"
        '
        'EliminarFechaButton
        '
        Me.EliminarFechaButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarFechaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarFechaButton.Location = New System.Drawing.Point(513, 136)
        Me.EliminarFechaButton.Name = "EliminarFechaButton"
        Me.EliminarFechaButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarFechaButton.TabIndex = 18
        Me.EliminarFechaButton.Text = "Eliminar"
        Me.EliminarFechaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarFechaButton.UseVisualStyleBackColor = True
        '
        'ModificarFechaButton
        '
        Me.ModificarFechaButton.Image = Global.TicketYa.My.Resources.Resources.editar
        Me.ModificarFechaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarFechaButton.Location = New System.Drawing.Point(513, 80)
        Me.ModificarFechaButton.Name = "ModificarFechaButton"
        Me.ModificarFechaButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarFechaButton.TabIndex = 17
        Me.ModificarFechaButton.Text = "Modificar"
        Me.ModificarFechaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarFechaButton.UseVisualStyleBackColor = True
        '
        'BuscarFechaButton
        '
        Me.BuscarFechaButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarFechaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarFechaButton.Location = New System.Drawing.Point(513, 16)
        Me.BuscarFechaButton.Name = "BuscarFechaButton"
        Me.BuscarFechaButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarFechaButton.TabIndex = 15
        Me.BuscarFechaButton.Text = "Buscar"
        Me.BuscarFechaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarFechaButton.UseVisualStyleBackColor = True
        '
        'FechaDesdeLabel
        '
        Me.FechaDesdeLabel.AutoSize = True
        Me.FechaDesdeLabel.Location = New System.Drawing.Point(177, 21)
        Me.FechaDesdeLabel.Name = "FechaDesdeLabel"
        Me.FechaDesdeLabel.Size = New System.Drawing.Size(71, 13)
        Me.FechaDesdeLabel.TabIndex = 20
        Me.FechaDesdeLabel.Text = "Fecha Desde"
        '
        'FechaDesdeTextBox
        '
        Me.FechaDesdeTextBox.Location = New System.Drawing.Point(249, 18)
        Me.FechaDesdeTextBox.Mask = "00/00/0000"
        Me.FechaDesdeTextBox.Name = "FechaDesdeTextBox"
        Me.FechaDesdeTextBox.Size = New System.Drawing.Size(68, 20)
        Me.FechaDesdeTextBox.TabIndex = 21
        Me.FechaDesdeTextBox.ValidatingType = GetType(Date)
        '
        'FechaHastaTextBox
        '
        Me.FechaHastaTextBox.Location = New System.Drawing.Point(402, 19)
        Me.FechaHastaTextBox.Mask = "00/00/0000"
        Me.FechaHastaTextBox.Name = "FechaHastaTextBox"
        Me.FechaHastaTextBox.Size = New System.Drawing.Size(68, 20)
        Me.FechaHastaTextBox.TabIndex = 23
        Me.FechaHastaTextBox.ValidatingType = GetType(Date)
        '
        'FechaHastaLabel
        '
        Me.FechaHastaLabel.AutoSize = True
        Me.FechaHastaLabel.Location = New System.Drawing.Point(330, 22)
        Me.FechaHastaLabel.Name = "FechaHastaLabel"
        Me.FechaHastaLabel.Size = New System.Drawing.Size(68, 13)
        Me.FechaHastaLabel.TabIndex = 22
        Me.FechaHastaLabel.Text = "Fecha Hasta"
        '
        'ReportesButton
        '
        Me.ReportesButton.Image = Global.TicketYa.My.Resources.Resources.Graphics_icon
        Me.ReportesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportesButton.Location = New System.Drawing.Point(513, 197)
        Me.ReportesButton.Name = "ReportesButton"
        Me.ReportesButton.Size = New System.Drawing.Size(75, 23)
        Me.ReportesButton.TabIndex = 24
        Me.ReportesButton.Text = "Reportes"
        Me.ReportesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReportesButton.UseVisualStyleBackColor = True
        '
        'BuscarFechaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(645, 280)
        Me.Controls.Add(Me.ReportesButton)
        Me.Controls.Add(Me.FechaHastaTextBox)
        Me.Controls.Add(Me.FechaHastaLabel)
        Me.Controls.Add(Me.FechaDesdeTextBox)
        Me.Controls.Add(Me.FechaDesdeLabel)
        Me.Controls.Add(Me.EliminarFechaButton)
        Me.Controls.Add(Me.ModificarFechaButton)
        Me.Controls.Add(Me.FechasDataGrid)
        Me.Controls.Add(Me.BuscarFechaButton)
        Me.Controls.Add(Me.ShowTextBox)
        Me.Controls.Add(Me.ShowLabel)
        Me.Name = "BuscarFechaForm"
        Me.Text = "Buscar Fecha"
        CType(Me.FechasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarFechaButton As TicketYa.MyButton
    Friend WithEvents ModificarFechaButton As TicketYa.MyButton
    Friend WithEvents FechasDataGrid As TicketYa.MyDataGrid
    Friend WithEvents BuscarFechaButton As TicketYa.MyButton
    Friend WithEvents ShowTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents FechaDesdeLabel As System.Windows.Forms.Label
    Friend WithEvents FechaDesdeTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents FechaHastaTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents FechaHastaLabel As System.Windows.Forms.Label
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportesButton As TicketYa.MyButton

End Class
