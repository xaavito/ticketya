<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarBackupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarBackupForm))
        Me.BackupDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RealizarBackupButton = New TicketYa.MyButton()
        Me.EliminarBackupButton = New TicketYa.MyButton()
        Me.DescripcionBackupTextBox = New TicketYa.MyTextBox()
        CType(Me.BackupDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackupDataGrid
        '
        Me.BackupDataGrid.AllowUserToAddRows = False
        Me.BackupDataGrid.AllowUserToDeleteRows = False
        Me.BackupDataGrid.AllowUserToResizeRows = False
        Me.BackupDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BackupDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BackupDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.FechaColumn})
        Me.BackupDataGrid.Location = New System.Drawing.Point(12, 25)
        Me.BackupDataGrid.MultiSelect = False
        Me.BackupDataGrid.Name = "BackupDataGrid"
        Me.BackupDataGrid.ReadOnly = True
        Me.BackupDataGrid.RowHeadersVisible = False
        Me.BackupDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BackupDataGrid.Size = New System.Drawing.Size(508, 150)
        Me.BackupDataGrid.TabIndex = 0
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
        'RealizarBackupButton
        '
        Me.RealizarBackupButton.Image = CType(resources.GetObject("RealizarBackupButton.Image"), System.Drawing.Image)
        Me.RealizarBackupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RealizarBackupButton.Location = New System.Drawing.Point(526, 26)
        Me.RealizarBackupButton.Name = "RealizarBackupButton"
        Me.RealizarBackupButton.Size = New System.Drawing.Size(75, 23)
        Me.RealizarBackupButton.TabIndex = 1
        Me.RealizarBackupButton.Text = "Backup"
        Me.RealizarBackupButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RealizarBackupButton.UseVisualStyleBackColor = True
        '
        'EliminarBackupButton
        '
        Me.EliminarBackupButton.Image = CType(resources.GetObject("EliminarBackupButton.Image"), System.Drawing.Image)
        Me.EliminarBackupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EliminarBackupButton.Location = New System.Drawing.Point(526, 152)
        Me.EliminarBackupButton.Name = "EliminarBackupButton"
        Me.EliminarBackupButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarBackupButton.TabIndex = 2
        Me.EliminarBackupButton.Text = "Eliminar"
        Me.EliminarBackupButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EliminarBackupButton.UseVisualStyleBackColor = True
        '
        'DescripcionBackupTextBox
        '
        Me.DescripcionBackupTextBox.alfanumerico = False
        Me.DescripcionBackupTextBox.boton = Nothing
        Me.DescripcionBackupTextBox.Location = New System.Drawing.Point(607, 28)
        Me.DescripcionBackupTextBox.Name = "DescripcionBackupTextBox"
        Me.DescripcionBackupTextBox.numerico = False
        Me.DescripcionBackupTextBox.sinEspacio = False
        Me.DescripcionBackupTextBox.Size = New System.Drawing.Size(137, 20)
        Me.DescripcionBackupTextBox.TabIndex = 3
        Me.DescripcionBackupTextBox.texto = False
        '
        'BuscarBackupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(756, 277)
        Me.Controls.Add(Me.DescripcionBackupTextBox)
        Me.Controls.Add(Me.EliminarBackupButton)
        Me.Controls.Add(Me.RealizarBackupButton)
        Me.Controls.Add(Me.BackupDataGrid)
        Me.Name = "BuscarBackupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        CType(Me.BackupDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackupDataGrid As TicketYa.MyDataGrid
    Friend WithEvents RealizarBackupButton As TicketYa.MyButton
    Friend WithEvents EliminarBackupButton As TicketYa.MyButton
    Friend WithEvents DescripcionBackupTextBox As TicketYa.MyTextBox

End Class
