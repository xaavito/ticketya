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
        Me.BuscarFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.Configuracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Idiomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarIdiomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarIdiomas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Backups = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBackups = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarRestores = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bitacoras = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiUsuario = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Administracion, Me.Configuracion, Me.MiUsuario, Me.Logout})
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
        Me.Usuarios.Size = New System.Drawing.Size(152, 22)
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
        Me.Familias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFamilias, Me.GenerarFamilias})
        Me.Familias.Image = CType(resources.GetObject("Familias.Image"), System.Drawing.Image)
        Me.Familias.Name = "Familias"
        Me.Familias.Size = New System.Drawing.Size(152, 22)
        Me.Familias.Text = "Familia"
        '
        'BuscarFamilias
        '
        Me.BuscarFamilias.Image = CType(resources.GetObject("BuscarFamilias.Image"), System.Drawing.Image)
        Me.BuscarFamilias.Name = "BuscarFamilias"
        Me.BuscarFamilias.Size = New System.Drawing.Size(164, 22)
        Me.BuscarFamilias.Text = "Buscar Familias"
        '
        'GenerarFamilias
        '
        Me.GenerarFamilias.Image = CType(resources.GetObject("GenerarFamilias.Image"), System.Drawing.Image)
        Me.GenerarFamilias.Name = "GenerarFamilias"
        Me.GenerarFamilias.Size = New System.Drawing.Size(164, 22)
        Me.GenerarFamilias.Text = "Generar Familias"
        '
        'Permisos
        '
        Me.Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosUsuarios, Me.PermisosFamilias})
        Me.Permisos.Image = CType(resources.GetObject("Permisos.Image"), System.Drawing.Image)
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(152, 22)
        Me.Permisos.Text = "Permisos"
        '
        'PermisosUsuarios
        '
        Me.PermisosUsuarios.Image = CType(resources.GetObject("PermisosUsuarios.Image"), System.Drawing.Image)
        Me.PermisosUsuarios.Name = "PermisosUsuarios"
        Me.PermisosUsuarios.Size = New System.Drawing.Size(166, 22)
        Me.PermisosUsuarios.Text = "Permisos Usuario"
        '
        'PermisosFamilias
        '
        Me.PermisosFamilias.Image = CType(resources.GetObject("PermisosFamilias.Image"), System.Drawing.Image)
        Me.PermisosFamilias.Name = "PermisosFamilias"
        Me.PermisosFamilias.Size = New System.Drawing.Size(166, 22)
        Me.PermisosFamilias.Text = "Permiso Familia"
        '
        'Configuracion
        '
        Me.Configuracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Idiomas, Me.Backups, Me.Bitacoras})
        Me.Configuracion.Image = CType(resources.GetObject("Configuracion.Image"), System.Drawing.Image)
        Me.Configuracion.Name = "Configuracion"
        Me.Configuracion.Size = New System.Drawing.Size(101, 20)
        Me.Configuracion.Text = "Configuracion"
        '
        'Idiomas
        '
        Me.Idiomas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarIdiomas, Me.GenerarIdiomas})
        Me.Idiomas.Image = CType(resources.GetObject("Idiomas.Image"), System.Drawing.Image)
        Me.Idiomas.Name = "Idiomas"
        Me.Idiomas.Size = New System.Drawing.Size(152, 22)
        Me.Idiomas.Text = "Idioma"
        '
        'BuscarIdiomas
        '
        Me.BuscarIdiomas.Image = CType(resources.GetObject("BuscarIdiomas.Image"), System.Drawing.Image)
        Me.BuscarIdiomas.Name = "BuscarIdiomas"
        Me.BuscarIdiomas.Size = New System.Drawing.Size(159, 22)
        Me.BuscarIdiomas.Text = "Buscar Idioma"
        '
        'GenerarIdiomas
        '
        Me.GenerarIdiomas.Image = CType(resources.GetObject("GenerarIdiomas.Image"), System.Drawing.Image)
        Me.GenerarIdiomas.Name = "GenerarIdiomas"
        Me.GenerarIdiomas.Size = New System.Drawing.Size(159, 22)
        Me.GenerarIdiomas.Text = "Generar Idioma"
        '
        'Backups
        '
        Me.Backups.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBackups, Me.RealizarRestores})
        Me.Backups.Image = CType(resources.GetObject("Backups.Image"), System.Drawing.Image)
        Me.Backups.Name = "Backups"
        Me.Backups.Size = New System.Drawing.Size(152, 22)
        Me.Backups.Text = "Backup"
        '
        'BuscarBackups
        '
        Me.BuscarBackups.Image = CType(resources.GetObject("BuscarBackups.Image"), System.Drawing.Image)
        Me.BuscarBackups.Name = "BuscarBackups"
        Me.BuscarBackups.Size = New System.Drawing.Size(164, 22)
        Me.BuscarBackups.Text = "Buscar Backup"
        '
        'RealizarRestores
        '
        Me.RealizarRestores.Image = CType(resources.GetObject("RealizarRestores.Image"), System.Drawing.Image)
        Me.RealizarRestores.Name = "RealizarRestores"
        Me.RealizarRestores.Size = New System.Drawing.Size(164, 22)
        Me.RealizarRestores.Text = "Realizar Restore"
        '
        'Bitacoras
        '
        Me.Bitacoras.Image = CType(resources.GetObject("Bitacoras.Image"), System.Drawing.Image)
        Me.Bitacoras.Name = "Bitacoras"
        Me.Bitacoras.Size = New System.Drawing.Size(152, 22)
        Me.Bitacoras.Text = "Bitacora"
        '
        'MiUsuario
        '
        Me.MiUsuario.Image = CType(resources.GetObject("MiUsuario.Image"), System.Drawing.Image)
        Me.MiUsuario.Name = "MiUsuario"
        Me.MiUsuario.Size = New System.Drawing.Size(84, 20)
        Me.MiUsuario.Text = "Mi Usuario"
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
    Friend WithEvents BuscarFamilias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarFamilias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosFamilias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Configuracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Idiomas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarIdiomas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarIdiomas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Backups As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarBackups As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarRestores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bitacoras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiUsuario As System.Windows.Forms.ToolStripMenuItem

End Class
