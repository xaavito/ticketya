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
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSedeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarSedeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarSectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPromocionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPromocionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarCompradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarCompradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.NegocioToolStripMenuItem, Me.Administracion, Me.Configuracion, Me.MiUsuario, Me.Logout})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarVentaToolStripMenuItem, Me.GenerarVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.monedas
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'BuscarVentaToolStripMenuItem
        '
        Me.BuscarVentaToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarVentaToolStripMenuItem.Name = "BuscarVentaToolStripMenuItem"
        Me.BuscarVentaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BuscarVentaToolStripMenuItem.Text = "Buscar Venta"
        '
        'GenerarVentaToolStripMenuItem
        '
        Me.GenerarVentaToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarVentaToolStripMenuItem.Name = "GenerarVentaToolStripMenuItem"
        Me.GenerarVentaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GenerarVentaToolStripMenuItem.Text = "Generar Venta"
        '
        'NegocioToolStripMenuItem
        '
        Me.NegocioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadioToolStripMenuItem, Me.ShowToolStripMenuItem, Me.FechaToolStripMenuItem, Me.SectorToolStripMenuItem, Me.PromocionesToolStripMenuItem, Me.CompradoresToolStripMenuItem, Me.TipoShowToolStripMenuItem})
        Me.NegocioToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.negocios
        Me.NegocioToolStripMenuItem.Name = "NegocioToolStripMenuItem"
        Me.NegocioToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NegocioToolStripMenuItem.Text = "Negocio"
        '
        'EstadioToolStripMenuItem
        '
        Me.EstadioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarSedeToolStripMenuItem, Me.GenerarSedeToolStripMenuItem})
        Me.EstadioToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.stadium
        Me.EstadioToolStripMenuItem.Name = "EstadioToolStripMenuItem"
        Me.EstadioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstadioToolStripMenuItem.Text = "Sedes"
        '
        'BuscarSedeToolStripMenuItem
        '
        Me.BuscarSedeToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarSedeToolStripMenuItem.Name = "BuscarSedeToolStripMenuItem"
        Me.BuscarSedeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BuscarSedeToolStripMenuItem.Text = "Buscar Sede"
        '
        'GenerarSedeToolStripMenuItem
        '
        Me.GenerarSedeToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarSedeToolStripMenuItem.Name = "GenerarSedeToolStripMenuItem"
        Me.GenerarSedeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.GenerarSedeToolStripMenuItem.Text = "Generar Sede"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarShowToolStripMenuItem, Me.GenerarShowToolStripMenuItem})
        Me.ShowToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.show
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowToolStripMenuItem.Text = "Shows"
        '
        'BuscarShowToolStripMenuItem
        '
        Me.BuscarShowToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarShowToolStripMenuItem.Name = "BuscarShowToolStripMenuItem"
        Me.BuscarShowToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BuscarShowToolStripMenuItem.Text = "Buscar Show"
        '
        'GenerarShowToolStripMenuItem
        '
        Me.GenerarShowToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarShowToolStripMenuItem.Name = "GenerarShowToolStripMenuItem"
        Me.GenerarShowToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GenerarShowToolStripMenuItem.Text = "Generar Show"
        '
        'FechaToolStripMenuItem
        '
        Me.FechaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFechaToolStripMenuItem, Me.GenerarFechaToolStripMenuItem})
        Me.FechaToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.fecha
        Me.FechaToolStripMenuItem.Name = "FechaToolStripMenuItem"
        Me.FechaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FechaToolStripMenuItem.Text = "Fecha"
        '
        'BuscarFechaToolStripMenuItem
        '
        Me.BuscarFechaToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarFechaToolStripMenuItem.Name = "BuscarFechaToolStripMenuItem"
        Me.BuscarFechaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BuscarFechaToolStripMenuItem.Text = "Buscar Fecha"
        '
        'GenerarFechaToolStripMenuItem
        '
        Me.GenerarFechaToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarFechaToolStripMenuItem.Name = "GenerarFechaToolStripMenuItem"
        Me.GenerarFechaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GenerarFechaToolStripMenuItem.Text = "Generar Fecha"
        '
        'SectorToolStripMenuItem
        '
        Me.SectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarSectorToolStripMenuItem, Me.GenerarSectorToolStripMenuItem})
        Me.SectorToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.section
        Me.SectorToolStripMenuItem.Name = "SectorToolStripMenuItem"
        Me.SectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SectorToolStripMenuItem.Text = "Sectores"
        '
        'BuscarSectorToolStripMenuItem
        '
        Me.BuscarSectorToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarSectorToolStripMenuItem.Name = "BuscarSectorToolStripMenuItem"
        Me.BuscarSectorToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BuscarSectorToolStripMenuItem.Text = "Buscar Sector"
        '
        'GenerarSectorToolStripMenuItem
        '
        Me.GenerarSectorToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarSectorToolStripMenuItem.Name = "GenerarSectorToolStripMenuItem"
        Me.GenerarSectorToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GenerarSectorToolStripMenuItem.Text = "Generar Sector"
        '
        'PromocionesToolStripMenuItem
        '
        Me.PromocionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPromocionToolStripMenuItem, Me.GenerarPromocionToolStripMenuItem})
        Me.PromocionesToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.promocion
        Me.PromocionesToolStripMenuItem.Name = "PromocionesToolStripMenuItem"
        Me.PromocionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PromocionesToolStripMenuItem.Text = "Promociones"
        '
        'BuscarPromocionToolStripMenuItem
        '
        Me.BuscarPromocionToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarPromocionToolStripMenuItem.Name = "BuscarPromocionToolStripMenuItem"
        Me.BuscarPromocionToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.BuscarPromocionToolStripMenuItem.Text = "Buscar Promocion"
        '
        'GenerarPromocionToolStripMenuItem
        '
        Me.GenerarPromocionToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarPromocionToolStripMenuItem.Name = "GenerarPromocionToolStripMenuItem"
        Me.GenerarPromocionToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GenerarPromocionToolStripMenuItem.Text = "Generar Promocion"
        '
        'CompradoresToolStripMenuItem
        '
        Me.CompradoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarCompradorToolStripMenuItem, Me.GenerarCompradorToolStripMenuItem})
        Me.CompradoresToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.personas
        Me.CompradoresToolStripMenuItem.Name = "CompradoresToolStripMenuItem"
        Me.CompradoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CompradoresToolStripMenuItem.Text = "Compradores"
        '
        'BuscarCompradorToolStripMenuItem
        '
        Me.BuscarCompradorToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarCompradorToolStripMenuItem.Name = "BuscarCompradorToolStripMenuItem"
        Me.BuscarCompradorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuscarCompradorToolStripMenuItem.Text = "Buscar Comprador"
        '
        'GenerarCompradorToolStripMenuItem
        '
        Me.GenerarCompradorToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarCompradorToolStripMenuItem.Name = "GenerarCompradorToolStripMenuItem"
        Me.GenerarCompradorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GenerarCompradorToolStripMenuItem.Text = "Generar Comprador"
        '
        'TipoShowToolStripMenuItem
        '
        Me.TipoShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarTipoToolStripMenuItem, Me.GenerarTipoToolStripMenuItem})
        Me.TipoShowToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.Slide_Show_icon
        Me.TipoShowToolStripMenuItem.Name = "TipoShowToolStripMenuItem"
        Me.TipoShowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TipoShowToolStripMenuItem.Text = "Tipo Show"
        '
        'BuscarTipoToolStripMenuItem
        '
        Me.BuscarTipoToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarTipoToolStripMenuItem.Name = "BuscarTipoToolStripMenuItem"
        Me.BuscarTipoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BuscarTipoToolStripMenuItem.Text = "Buscar Tipo"
        '
        'GenerarTipoToolStripMenuItem
        '
        Me.GenerarTipoToolStripMenuItem.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarTipoToolStripMenuItem.Name = "GenerarTipoToolStripMenuItem"
        Me.GenerarTipoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GenerarTipoToolStripMenuItem.Text = "Generar Tipo"
        '
        'Administracion
        '
        Me.Administracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usuarios, Me.Familias, Me.Permisos})
        Me.Administracion.Image = Global.TicketYa.My.Resources.Resources.administracion
        Me.Administracion.Name = "Administracion"
        Me.Administracion.Size = New System.Drawing.Size(104, 20)
        Me.Administracion.Text = "Administracion"
        '
        'Usuarios
        '
        Me.Usuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarUsuarios, Me.GenerarUsuarios})
        Me.Usuarios.Image = Global.TicketYa.My.Resources.Resources.persona
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(152, 22)
        Me.Usuarios.Text = "Usuarios"
        '
        'BuscarUsuarios
        '
        Me.BuscarUsuarios.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarUsuarios.Name = "BuscarUsuarios"
        Me.BuscarUsuarios.Size = New System.Drawing.Size(168, 22)
        Me.BuscarUsuarios.Text = "Buscar Usuarios"
        '
        'GenerarUsuarios
        '
        Me.GenerarUsuarios.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarUsuarios.Name = "GenerarUsuarios"
        Me.GenerarUsuarios.Size = New System.Drawing.Size(168, 22)
        Me.GenerarUsuarios.Text = "Generar Usuarios"
        '
        'Familias
        '
        Me.Familias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFamilias, Me.GenerarFamilias})
        Me.Familias.Image = Global.TicketYa.My.Resources.Resources.personas
        Me.Familias.Name = "Familias"
        Me.Familias.Size = New System.Drawing.Size(152, 22)
        Me.Familias.Text = "Familia"
        '
        'BuscarFamilias
        '
        Me.BuscarFamilias.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarFamilias.Name = "BuscarFamilias"
        Me.BuscarFamilias.Size = New System.Drawing.Size(164, 22)
        Me.BuscarFamilias.Text = "Buscar Familias"
        '
        'GenerarFamilias
        '
        Me.GenerarFamilias.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarFamilias.Name = "GenerarFamilias"
        Me.GenerarFamilias.Size = New System.Drawing.Size(164, 22)
        Me.GenerarFamilias.Text = "Generar Familias"
        '
        'Permisos
        '
        Me.Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosUsuarios, Me.PermisosFamilias})
        Me.Permisos.Image = Global.TicketYa.My.Resources.Resources.permission
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(152, 22)
        Me.Permisos.Text = "Permisos"
        '
        'PermisosUsuarios
        '
        Me.PermisosUsuarios.Image = Global.TicketYa.My.Resources.Resources.persona
        Me.PermisosUsuarios.Name = "PermisosUsuarios"
        Me.PermisosUsuarios.Size = New System.Drawing.Size(166, 22)
        Me.PermisosUsuarios.Text = "Permisos Usuario"
        '
        'PermisosFamilias
        '
        Me.PermisosFamilias.Image = Global.TicketYa.My.Resources.Resources.personas
        Me.PermisosFamilias.Name = "PermisosFamilias"
        Me.PermisosFamilias.Size = New System.Drawing.Size(166, 22)
        Me.PermisosFamilias.Text = "Permiso Familia"
        '
        'Configuracion
        '
        Me.Configuracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Idiomas, Me.Backups, Me.Bitacoras})
        Me.Configuracion.Image = Global.TicketYa.My.Resources.Resources.configuracion
        Me.Configuracion.Name = "Configuracion"
        Me.Configuracion.Size = New System.Drawing.Size(101, 20)
        Me.Configuracion.Text = "Configuracion"
        '
        'Idiomas
        '
        Me.Idiomas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarIdiomas, Me.GenerarIdiomas})
        Me.Idiomas.Image = Global.TicketYa.My.Resources.Resources._1350172460_system_config_language1
        Me.Idiomas.Name = "Idiomas"
        Me.Idiomas.Size = New System.Drawing.Size(152, 22)
        Me.Idiomas.Text = "Idioma"
        '
        'BuscarIdiomas
        '
        Me.BuscarIdiomas.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarIdiomas.Name = "BuscarIdiomas"
        Me.BuscarIdiomas.Size = New System.Drawing.Size(159, 22)
        Me.BuscarIdiomas.Text = "Buscar Idioma"
        '
        'GenerarIdiomas
        '
        Me.GenerarIdiomas.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarIdiomas.Name = "GenerarIdiomas"
        Me.GenerarIdiomas.Size = New System.Drawing.Size(159, 22)
        Me.GenerarIdiomas.Text = "Generar Idioma"
        '
        'Backups
        '
        Me.Backups.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarBackups, Me.RealizarRestores})
        Me.Backups.Image = Global.TicketYa.My.Resources.Resources.backup
        Me.Backups.Name = "Backups"
        Me.Backups.Size = New System.Drawing.Size(152, 22)
        Me.Backups.Text = "Backup"
        '
        'BuscarBackups
        '
        Me.BuscarBackups.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarBackups.Name = "BuscarBackups"
        Me.BuscarBackups.Size = New System.Drawing.Size(164, 22)
        Me.BuscarBackups.Text = "Buscar Backup"
        '
        'RealizarRestores
        '
        Me.RealizarRestores.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.RealizarRestores.Name = "RealizarRestores"
        Me.RealizarRestores.Size = New System.Drawing.Size(164, 22)
        Me.RealizarRestores.Text = "Realizar Restore"
        '
        'Bitacoras
        '
        Me.Bitacoras.Image = Global.TicketYa.My.Resources.Resources.log
        Me.Bitacoras.Name = "Bitacoras"
        Me.Bitacoras.Size = New System.Drawing.Size(152, 22)
        Me.Bitacoras.Text = "Bitacora"
        '
        'MiUsuario
        '
        Me.MiUsuario.Image = Global.TicketYa.My.Resources.Resources.persona
        Me.MiUsuario.Name = "MiUsuario"
        Me.MiUsuario.Size = New System.Drawing.Size(84, 20)
        Me.MiUsuario.Text = "Mi Usuario"
        '
        'Logout
        '
        Me.Logout.Image = Global.TicketYa.My.Resources.Resources.logout
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
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NegocioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PromocionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSedeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarSedeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarSectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPromocionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPromocionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompradoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarCompradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarCompradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarTipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarTipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
