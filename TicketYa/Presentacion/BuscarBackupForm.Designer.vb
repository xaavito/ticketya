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
        Me.BackupDataGrid = New System.Windows.Forms.DataGridView()
        Me.RealizarBackupButton = New System.Windows.Forms.Button()
        Me.EliminarBackupButton = New System.Windows.Forms.Button()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BackupDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackupDataGrid
        '
        Me.BackupDataGrid.AllowUserToAddRows = False
        Me.BackupDataGrid.AllowUserToDeleteRows = False
        Me.BackupDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BackupDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.FechaColumn})
        Me.BackupDataGrid.Location = New System.Drawing.Point(12, 12)
        Me.BackupDataGrid.MultiSelect = False
        Me.BackupDataGrid.Name = "BackupDataGrid"
        Me.BackupDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BackupDataGrid.Size = New System.Drawing.Size(508, 150)
        Me.BackupDataGrid.TabIndex = 0
        '
        'RealizarBackupButton
        '
        Me.RealizarBackupButton.Location = New System.Drawing.Point(571, 25)
        Me.RealizarBackupButton.Name = "RealizarBackupButton"
        Me.RealizarBackupButton.Size = New System.Drawing.Size(75, 23)
        Me.RealizarBackupButton.TabIndex = 1
        Me.RealizarBackupButton.Text = "Backup"
        Me.RealizarBackupButton.UseVisualStyleBackColor = True
        '
        'EliminarBackupButton
        '
        Me.EliminarBackupButton.Location = New System.Drawing.Point(571, 98)
        Me.EliminarBackupButton.Name = "EliminarBackupButton"
        Me.EliminarBackupButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarBackupButton.TabIndex = 2
        Me.EliminarBackupButton.Text = "Eliminar"
        Me.EliminarBackupButton.UseVisualStyleBackColor = True
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.Visible = False
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "descripcion"
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        '
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "fecha"
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        '
        'BuscarBackupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(756, 277)
        Me.Controls.Add(Me.EliminarBackupButton)
        Me.Controls.Add(Me.RealizarBackupButton)
        Me.Controls.Add(Me.BackupDataGrid)
        Me.Name = "BuscarBackupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        CType(Me.BackupDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackupDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents RealizarBackupButton As System.Windows.Forms.Button
    Friend WithEvents EliminarBackupButton As System.Windows.Forms.Button
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
