﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarRestoreForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealizarRestoreForm))
        Me.RealizarRestoreButton = New TicketYa.MyButton()
        Me.BackupDataGrid = New TicketYa.MyDataGrid()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BackupDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RealizarRestoreButton
        '
        Me.RealizarRestoreButton.Image = CType(resources.GetObject("RealizarRestoreButton.Image"), System.Drawing.Image)
        Me.RealizarRestoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RealizarRestoreButton.Location = New System.Drawing.Point(568, 21)
        Me.RealizarRestoreButton.Name = "RealizarRestoreButton"
        Me.RealizarRestoreButton.Size = New System.Drawing.Size(75, 23)
        Me.RealizarRestoreButton.TabIndex = 4
        Me.RealizarRestoreButton.Text = "Restore"
        Me.RealizarRestoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RealizarRestoreButton.UseVisualStyleBackColor = True
        '
        'BackupDataGrid
        '
        Me.BackupDataGrid.AllowUserToAddRows = False
        Me.BackupDataGrid.AllowUserToDeleteRows = False
        Me.BackupDataGrid.AllowUserToResizeRows = False
        Me.BackupDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BackupDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BackupDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificadorColumn, Me.DescripcionColumn, Me.FechaColumn})
        Me.BackupDataGrid.Location = New System.Drawing.Point(12, 21)
        Me.BackupDataGrid.MultiSelect = False
        Me.BackupDataGrid.Name = "BackupDataGrid"
        Me.BackupDataGrid.ReadOnly = True
        Me.BackupDataGrid.RowHeadersVisible = False
        Me.BackupDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BackupDataGrid.Size = New System.Drawing.Size(508, 150)
        Me.BackupDataGrid.TabIndex = 5
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
        'RealizarRestoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(688, 267)
        Me.Controls.Add(Me.BackupDataGrid)
        Me.Controls.Add(Me.RealizarRestoreButton)
        Me.Name = "RealizarRestoreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore"
        CType(Me.BackupDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RealizarRestoreButton As TicketYa.MyButton
    Friend WithEvents BackupDataGrid As TicketYa.MyDataGrid
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
