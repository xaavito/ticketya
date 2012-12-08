<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarSectorForm
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
        Me.ReportesButton = New TicketYa.MyButton()
        Me.EliminarSectorButton = New TicketYa.MyButton()
        Me.ModificarSectorButton = New TicketYa.MyButton()
        Me.SectoresDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilasColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnasColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarSectorButton = New TicketYa.MyButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.FechaComboBox = New TicketYa.MyComboBox()
        Me.ShowComboBox = New TicketYa.MyComboBox()
        CType(Me.SectoresDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportesButton
        '
        Me.ReportesButton.Image = Global.TicketYa.My.Resources.Resources.Graphics_icon
        Me.ReportesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportesButton.Location = New System.Drawing.Point(524, 190)
        Me.ReportesButton.Name = "ReportesButton"
        Me.ReportesButton.Size = New System.Drawing.Size(75, 23)
        Me.ReportesButton.TabIndex = 21
        Me.ReportesButton.Text = "Reportes"
        Me.ReportesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReportesButton.UseVisualStyleBackColor = True
        '
        'EliminarSectorButton
        '
        Me.EliminarSectorButton.Image = Global.TicketYa.My.Resources.Resources.basura
        Me.EliminarSectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarSectorButton.Location = New System.Drawing.Point(524, 137)
        Me.EliminarSectorButton.Name = "EliminarSectorButton"
        Me.EliminarSectorButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarSectorButton.TabIndex = 18
        Me.EliminarSectorButton.Text = "Eliminar"
        Me.EliminarSectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarSectorButton.UseVisualStyleBackColor = True
        '
        'ModificarSectorButton
        '
        Me.ModificarSectorButton.Image = Global.TicketYa.My.Resources.Resources.editar
        Me.ModificarSectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModificarSectorButton.Location = New System.Drawing.Point(524, 88)
        Me.ModificarSectorButton.Name = "ModificarSectorButton"
        Me.ModificarSectorButton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarSectorButton.TabIndex = 17
        Me.ModificarSectorButton.Text = "Modificar"
        Me.ModificarSectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModificarSectorButton.UseVisualStyleBackColor = True
        '
        'SectoresDataGrid
        '
        Me.SectoresDataGrid.AllowUserToAddRows = False
        Me.SectoresDataGrid.AllowUserToDeleteRows = False
        Me.SectoresDataGrid.AllowUserToResizeRows = False
        Me.SectoresDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SectoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SectoresDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.FilasColumn, Me.ColumnasColumn, Me.ValorColumn})
        Me.SectoresDataGrid.Location = New System.Drawing.Point(44, 88)
        Me.SectoresDataGrid.Name = "SectoresDataGrid"
        Me.SectoresDataGrid.ReadOnly = True
        Me.SectoresDataGrid.RowHeadersVisible = False
        Me.SectoresDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SectoresDataGrid.Size = New System.Drawing.Size(454, 157)
        Me.SectoresDataGrid.TabIndex = 16
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
        'FilasColumn
        '
        Me.FilasColumn.DataPropertyName = "filas"
        Me.FilasColumn.HeaderText = "Filas"
        Me.FilasColumn.Name = "FilasColumn"
        Me.FilasColumn.ReadOnly = True
        '
        'ColumnasColumn
        '
        Me.ColumnasColumn.DataPropertyName = "columnas"
        Me.ColumnasColumn.HeaderText = "Columnas"
        Me.ColumnasColumn.Name = "ColumnasColumn"
        Me.ColumnasColumn.ReadOnly = True
        '
        'ValorColumn
        '
        Me.ValorColumn.DataPropertyName = "valor"
        Me.ValorColumn.HeaderText = "Valor"
        Me.ValorColumn.Name = "ValorColumn"
        Me.ValorColumn.ReadOnly = True
        '
        'BuscarSectorButton
        '
        Me.BuscarSectorButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarSectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarSectorButton.Location = New System.Drawing.Point(524, 24)
        Me.BuscarSectorButton.Name = "BuscarSectorButton"
        Me.BuscarSectorButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarSectorButton.TabIndex = 15
        Me.BuscarSectorButton.Text = "Buscar"
        Me.BuscarSectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarSectorButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Fecha"
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(41, 15)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 41
        Me.ShowLabel.Text = "Show"
        '
        'FechaComboBox
        '
        Me.FechaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FechaComboBox.emptyItem = Nothing
        Me.FechaComboBox.FormattingEnabled = True
        Me.FechaComboBox.lista = Nothing
        Me.FechaComboBox.Location = New System.Drawing.Point(108, 37)
        Me.FechaComboBox.Name = "FechaComboBox"
        Me.FechaComboBox.Size = New System.Drawing.Size(205, 21)
        Me.FechaComboBox.TabIndex = 40
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.emptyItem = Nothing
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.lista = Nothing
        Me.ShowComboBox.Location = New System.Drawing.Point(108, 12)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(205, 21)
        Me.ShowComboBox.TabIndex = 39
        '
        'BuscarSectorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(630, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShowLabel)
        Me.Controls.Add(Me.FechaComboBox)
        Me.Controls.Add(Me.ShowComboBox)
        Me.Controls.Add(Me.ReportesButton)
        Me.Controls.Add(Me.EliminarSectorButton)
        Me.Controls.Add(Me.ModificarSectorButton)
        Me.Controls.Add(Me.SectoresDataGrid)
        Me.Controls.Add(Me.BuscarSectorButton)
        Me.Name = "BuscarSectorForm"
        Me.Text = "Buscar Sector"
        CType(Me.SectoresDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarSectorButton As TicketYa.MyButton
    Friend WithEvents ModificarSectorButton As TicketYa.MyButton
    Friend WithEvents SectoresDataGrid As TicketYa.MyDataGrid
    Friend WithEvents BuscarSectorButton As TicketYa.MyButton
    Friend WithEvents ReportesButton As TicketYa.MyButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents FechaComboBox As TicketYa.MyComboBox
    Friend WithEvents ShowComboBox As TicketYa.MyComboBox
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilasColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnasColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
