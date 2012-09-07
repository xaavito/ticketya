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
        Me.Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPermisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPermisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bitacora = New System.Windows.Forms.ToolStripMenuItem()
        Me.Backup = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BuscarBitacora = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Permisos, Me.Bitacora, Me.Backup, Me.Usuarios})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Permisos
        '
        Me.Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPermisos, Me.GenerarPermisos})
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(61, 20)
        Me.Permisos.Tag = "Permisos"
        Me.Permisos.Text = "Permisos"
        '
        'BuscarPermisos
        '
        Me.BuscarPermisos.Name = "BuscarPermisos"
        Me.BuscarPermisos.Size = New System.Drawing.Size(169, 22)
        Me.BuscarPermisos.Tag = "Buscar"
        Me.BuscarPermisos.Text = "Buscar Permisos"
        '
        'GenerarPermisos
        '
        Me.GenerarPermisos.Name = "GenerarPermisos"
        Me.GenerarPermisos.Size = New System.Drawing.Size(169, 22)
        Me.GenerarPermisos.Tag = "Generar"
        Me.GenerarPermisos.Text = "Generar Permisos"
        '
        'Bitacora
        '
        Me.Bitacora.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBitacora})
        Me.Bitacora.Name = "Bitacora"
        Me.Bitacora.Size = New System.Drawing.Size(58, 20)
        Me.Bitacora.Tag = "Bitacora"
        Me.Bitacora.Text = "Bitacora"
        '
        'Backup
        '
        Me.Backup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBackup, Me.RealizarRestore})
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(53, 20)
        Me.Backup.Tag = "Backup"
        Me.Backup.Text = "Backup"
        '
        'Usuarios
        '
        Me.Usuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarUsuario, Me.AltaUsuario})
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(60, 20)
        Me.Usuarios.Tag = "Usuarios"
        Me.Usuarios.Text = "Usuarios"
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
        'BuscarBitacora
        '
        Me.BuscarBitacora.Name = "BuscarBitacora"
        Me.BuscarBitacora.Size = New System.Drawing.Size(159, 22)
        Me.BuscarBitacora.Text = "Buscar Bitacora"
        '
        'BuscarBackup
        '
        Me.BuscarBackup.Name = "BuscarBackup"
        Me.BuscarBackup.Size = New System.Drawing.Size(164, 22)
        Me.BuscarBackup.Text = "Buscar Backup"
        '
        'RealizarRestore
        '
        Me.RealizarRestore.Name = "RealizarRestore"
        Me.RealizarRestore.Size = New System.Drawing.Size(164, 22)
        Me.RealizarRestore.Text = "Realizar Restore"
        '
        'BuscarUsuario
        '
        Me.BuscarUsuario.Name = "BuscarUsuario"
        Me.BuscarUsuario.Size = New System.Drawing.Size(156, 22)
        Me.BuscarUsuario.Text = "Buscar Usuario"
        '
        'AltaUsuario
        '
        Me.AltaUsuario.Name = "AltaUsuario"
        Me.AltaUsuario.Size = New System.Drawing.Size(156, 22)
        Me.AltaUsuario.Text = "Alta Usuario"
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
    Friend WithEvents Permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPermisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPermisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bitacora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Backup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBitacora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaUsuario As System.Windows.Forms.ToolStripMenuItem

End Class
