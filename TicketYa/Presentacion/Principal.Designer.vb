<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits TicketYa.BaseForm

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
        Me.Bitacora = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBitacora = New System.Windows.Forms.ToolStripMenuItem()
        Me.Backup = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Administracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.Familias = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarFamilia = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFamilia = New System.Windows.Forms.ToolStripMenuItem()
        Me.Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisoFamilia = New System.Windows.Forms.ToolStripMenuItem()
        Me.Idioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarIdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarIdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarIdioma3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarIdioma3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bitacora, Me.Backup, Me.Logout, Me.Administracion, Me.IdiomaToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Bitacora
        '
        Me.Bitacora.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBitacora})
        Me.Bitacora.Name = "Bitacora"
        Me.Bitacora.Size = New System.Drawing.Size(58, 20)
        Me.Bitacora.Tag = "Bitacora"
        Me.Bitacora.Text = "Bitacora"
        '
        'BuscarBitacora
        '
        Me.BuscarBitacora.Name = "BuscarBitacora"
        Me.BuscarBitacora.Size = New System.Drawing.Size(159, 22)
        Me.BuscarBitacora.Text = "Buscar Bitacora"
        '
        'Backup
        '
        Me.Backup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBackup, Me.RealizarRestore})
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(53, 20)
        Me.Backup.Tag = "Backup"
        Me.Backup.Text = "Backup"
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
        'Logout
        '
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(52, 20)
        Me.Logout.Text = "Logout"
        '
        'Administracion
        '
        Me.Administracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usuarios, Me.Familias, Me.Permisos, Me.Idioma})
        Me.Administracion.Name = "Administracion"
        Me.Administracion.Size = New System.Drawing.Size(88, 20)
        Me.Administracion.Text = "Administracion"
        '
        'Usuarios
        '
        Me.Usuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarUsuarios, Me.GenerarUsuarios})
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(152, 22)
        Me.Usuarios.Text = "Usuarios"
        '
        'BuscarUsuarios
        '
        Me.BuscarUsuarios.Name = "BuscarUsuarios"
        Me.BuscarUsuarios.Size = New System.Drawing.Size(168, 22)
        Me.BuscarUsuarios.Text = "Buscar Usuarios"
        '
        'GenerarUsuarios
        '
        Me.GenerarUsuarios.Name = "GenerarUsuarios"
        Me.GenerarUsuarios.Size = New System.Drawing.Size(168, 22)
        Me.GenerarUsuarios.Text = "Generar Usuarios"
        '
        'Familias
        '
        Me.Familias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFamilia, Me.GenerarFamilia})
        Me.Familias.Name = "Familias"
        Me.Familias.Size = New System.Drawing.Size(152, 22)
        Me.Familias.Text = "Familia"
        '
        'BuscarFamilia
        '
        Me.BuscarFamilia.Name = "BuscarFamilia"
        Me.BuscarFamilia.Size = New System.Drawing.Size(164, 22)
        Me.BuscarFamilia.Text = "Buscar Familias"
        '
        'GenerarFamilia
        '
        Me.GenerarFamilia.Name = "GenerarFamilia"
        Me.GenerarFamilia.Size = New System.Drawing.Size(164, 22)
        Me.GenerarFamilia.Text = "Generar Familias"
        '
        'Permisos
        '
        Me.Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosUsuario, Me.PermisoFamilia})
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(152, 22)
        Me.Permisos.Text = "Permisos"
        '
        'PermisosUsuario
        '
        Me.PermisosUsuario.Name = "PermisosUsuario"
        Me.PermisosUsuario.Size = New System.Drawing.Size(166, 22)
        Me.PermisosUsuario.Text = "Permisos Usuario"
        '
        'PermisoFamilia
        '
        Me.PermisoFamilia.Name = "PermisoFamilia"
        Me.PermisoFamilia.Size = New System.Drawing.Size(166, 22)
        Me.PermisoFamilia.Text = "Permiso Familia"
        '
        'Idioma
        '
        Me.Idioma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarIdioma, Me.GenerarIdioma})
        Me.Idioma.Name = "Idioma"
        Me.Idioma.Size = New System.Drawing.Size(152, 22)
        Me.Idioma.Text = "Idioma"
        '
        'BuscarIdioma
        '
        Me.BuscarIdioma.Name = "BuscarIdioma"
        Me.BuscarIdioma.Size = New System.Drawing.Size(159, 22)
        Me.BuscarIdioma.Text = "Buscar Idioma"
        '
        'GenerarIdioma
        '
        Me.GenerarIdioma.Name = "GenerarIdioma"
        Me.GenerarIdioma.Size = New System.Drawing.Size(159, 22)
        Me.GenerarIdioma.Text = "Generar Idioma"
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarIdioma3, Me.GenerarIdioma3})
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        Me.IdiomaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.IdiomaToolStripMenuItem.Text = "Idioma"
        '
        'BuscarIdioma3
        '
        Me.BuscarIdioma3.Name = "BuscarIdioma3"
        Me.BuscarIdioma3.Size = New System.Drawing.Size(159, 22)
        Me.BuscarIdioma3.Text = "Buscar Idioma"
        '
        'GenerarIdioma3
        '
        Me.GenerarIdioma3.Name = "GenerarIdioma3"
        Me.GenerarIdioma3.Size = New System.Drawing.Size(159, 22)
        Me.GenerarIdioma3.Text = "Generar Idioma"
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
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdiomaToolStripMenuItem1, Me.BackupToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'IdiomaToolStripMenuItem1
        '
        Me.IdiomaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarIdiomaToolStripMenuItem, Me.GenerarIdiomaToolStripMenuItem})
        Me.IdiomaToolStripMenuItem1.Name = "IdiomaToolStripMenuItem1"
        Me.IdiomaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.IdiomaToolStripMenuItem1.Text = "Idioma"
        '
        'BuscarIdiomaToolStripMenuItem
        '
        Me.BuscarIdiomaToolStripMenuItem.Name = "BuscarIdiomaToolStripMenuItem"
        Me.BuscarIdiomaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BuscarIdiomaToolStripMenuItem.Text = "Buscar Idioma"
        '
        'GenerarIdiomaToolStripMenuItem
        '
        Me.GenerarIdiomaToolStripMenuItem.Name = "GenerarIdiomaToolStripMenuItem"
        Me.GenerarIdiomaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerarIdiomaToolStripMenuItem.Text = "Generar Idioma"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBackupToolStripMenuItem, Me.RealizarRestoreToolStripMenuItem})
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'BuscarBackupToolStripMenuItem
        '
        Me.BuscarBackupToolStripMenuItem.Name = "BuscarBackupToolStripMenuItem"
        Me.BuscarBackupToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BuscarBackupToolStripMenuItem.Text = "Buscar Backup"
        '
        'RealizarRestoreToolStripMenuItem
        '
        Me.RealizarRestoreToolStripMenuItem.Name = "RealizarRestoreToolStripMenuItem"
        Me.RealizarRestoreToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RealizarRestoreToolStripMenuItem.Text = "Realizar Restore"
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Bitacora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Backup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBitacora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Administracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Familias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarFamilia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarFamilia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisoFamilia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarIdioma3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarIdioma3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Idioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarIdioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarIdioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarIdiomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarIdiomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
