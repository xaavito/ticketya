<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits TicketYa.MainForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosToolStripMenuItem, Me.BitacoraToolStripMenuItem, Me.BackupToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPermisosToolStripMenuItem, Me.EliminarPermisosToolStripMenuItem, Me.GenerarPermisosToolStripMenuItem})
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PermisosToolStripMenuItem.Tag = "Permisos"
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'BuscarPermisosToolStripMenuItem
        '
        Me.BuscarPermisosToolStripMenuItem.Name = "BuscarPermisosToolStripMenuItem"
        Me.BuscarPermisosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BuscarPermisosToolStripMenuItem.Tag = "Buscar"
        Me.BuscarPermisosToolStripMenuItem.Text = "Buscar Permisos"
        '
        'EliminarPermisosToolStripMenuItem
        '
        Me.EliminarPermisosToolStripMenuItem.Name = "EliminarPermisosToolStripMenuItem"
        Me.EliminarPermisosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EliminarPermisosToolStripMenuItem.Tag = "Permisos_Eliminar"
        Me.EliminarPermisosToolStripMenuItem.Text = "Eliminar Permisos"
        '
        'GenerarPermisosToolStripMenuItem
        '
        Me.GenerarPermisosToolStripMenuItem.Name = "GenerarPermisosToolStripMenuItem"
        Me.GenerarPermisosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.GenerarPermisosToolStripMenuItem.Tag = "Generar"
        Me.GenerarPermisosToolStripMenuItem.Text = "Generar Permisos"
        '
        'BitacoraToolStripMenuItem
        '
        Me.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem"
        Me.BitacoraToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.BitacoraToolStripMenuItem.Tag = "Bitacora"
        Me.BitacoraToolStripMenuItem.Text = "Bitacora"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.BackupToolStripMenuItem.Tag = "Backup"
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.UsuariosToolStripMenuItem.Tag = "Usuarios"
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Principal"
        Me.Text = "TicketYa"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
