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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
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
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Administracion, Me.ConfiguracionToolStripMenuItem, Me.MiUsuarioToolStripMenuItem, Me.Logout})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Administracion
        '
        Me.Administracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usuarios, Me.Familias, Me.Permisos})
        Me.Administracion.Image = CType(resources.GetObject("Administracion.Image"), System.Drawing.Image)
        Me.Administracion.Name = "Administracion"
        Me.Administracion.Size = New System.Drawing.Size(104, 20)
        Me.Administracion.Text = "Administracion"
        '
        'Usuarios
        '
        Me.Usuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarUsuarios, Me.GenerarUsuarios})
        Me.Usuarios.Image = CType(resources.GetObject("Usuarios.Image"), System.Drawing.Image)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(127, 22)
        Me.Usuarios.Text = "Usuarios"
        '
        'BuscarUsuarios
        '
        Me.BuscarUsuarios.Image = CType(resources.GetObject("BuscarUsuarios.Image"), System.Drawing.Image)
        Me.BuscarUsuarios.Name = "BuscarUsuarios"
        Me.BuscarUsuarios.Size = New System.Drawing.Size(168, 22)
        Me.BuscarUsuarios.Text = "Buscar Usuarios"
        '
        'GenerarUsuarios
        '
        Me.GenerarUsuarios.Image = CType(resources.GetObject("GenerarUsuarios.Image"), System.Drawing.Image)
        Me.GenerarUsuarios.Name = "GenerarUsuarios"
        Me.GenerarUsuarios.Size = New System.Drawing.Size(168, 22)
        Me.GenerarUsuarios.Text = "Generar Usuarios"
        '
        'Familias
        '
        Me.Familias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFamilia, Me.GenerarFamilia})
        Me.Familias.Image = CType(resources.GetObject("Familias.Image"), System.Drawing.Image)
        Me.Familias.Name = "Familias"
        Me.Familias.Size = New System.Drawing.Size(127, 22)
        Me.Familias.Text = "Familia"
        '
        'BuscarFamilia
        '
        Me.BuscarFamilia.Image = CType(resources.GetObject("BuscarFamilia.Image"), System.Drawing.Image)
        Me.BuscarFamilia.Name = "BuscarFamilia"
        Me.BuscarFamilia.Size = New System.Drawing.Size(164, 22)
        Me.BuscarFamilia.Text = "Buscar Familias"
        '
        'GenerarFamilia
        '
        Me.GenerarFamilia.Image = CType(resources.GetObject("GenerarFamilia.Image"), System.Drawing.Image)
        Me.GenerarFamilia.Name = "GenerarFamilia"
        Me.GenerarFamilia.Size = New System.Drawing.Size(164, 22)
        Me.GenerarFamilia.Text = "Generar Familias"
        '
        'Permisos
        '
        Me.Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosUsuario, Me.PermisoFamilia})
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(127, 22)
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
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdiomaToolStripMenuItem1, Me.BackupToolStripMenuItem, Me.BitacoraToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Image = CType(resources.GetObject("ConfiguracionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'IdiomaToolStripMenuItem1
        '
        Me.IdiomaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarIdiomaToolStripMenuItem, Me.GenerarIdiomaToolStripMenuItem})
        Me.IdiomaToolStripMenuItem1.Image = CType(resources.GetObject("IdiomaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.IdiomaToolStripMenuItem1.Name = "IdiomaToolStripMenuItem1"
        Me.IdiomaToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.IdiomaToolStripMenuItem1.Text = "Idioma"
        '
        'BuscarIdiomaToolStripMenuItem
        '
        Me.BuscarIdiomaToolStripMenuItem.Image = CType(resources.GetObject("BuscarIdiomaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarIdiomaToolStripMenuItem.Name = "BuscarIdiomaToolStripMenuItem"
        Me.BuscarIdiomaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BuscarIdiomaToolStripMenuItem.Text = "Buscar Idioma"
        '
        'GenerarIdiomaToolStripMenuItem
        '
        Me.GenerarIdiomaToolStripMenuItem.Image = CType(resources.GetObject("GenerarIdiomaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerarIdiomaToolStripMenuItem.Name = "GenerarIdiomaToolStripMenuItem"
        Me.GenerarIdiomaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerarIdiomaToolStripMenuItem.Text = "Generar Idioma"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBackupToolStripMenuItem, Me.RealizarRestoreToolStripMenuItem})
        Me.BackupToolStripMenuItem.Image = CType(resources.GetObject("BackupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
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
        'BitacoraToolStripMenuItem
        '
        Me.BitacoraToolStripMenuItem.Image = CType(resources.GetObject("BitacoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem"
        Me.BitacoraToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BitacoraToolStripMenuItem.Text = "Bitacora"
        '
        'MiUsuarioToolStripMenuItem
        '
        Me.MiUsuarioToolStripMenuItem.Image = CType(resources.GetObject("MiUsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MiUsuarioToolStripMenuItem.Name = "MiUsuarioToolStripMenuItem"
        Me.MiUsuarioToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.MiUsuarioToolStripMenuItem.Text = "Mi Usuario"
        '
        'Logout
        '
        Me.Logout.Image = CType(resources.GetObject("Logout.Image"), System.Drawing.Image)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(68, 20)
        Me.Logout.Text = "Logout"
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
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarIdiomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarIdiomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
