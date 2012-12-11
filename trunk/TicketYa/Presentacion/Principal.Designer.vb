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
        Me.Ventas = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Negocio = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sedes = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSede = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarSede = New System.Windows.Forms.ToolStripMenuItem()
        Me.Show = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fecha = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarFecha = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFecha = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sector = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarSector = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarSector = New System.Windows.Forms.ToolStripMenuItem()
        Me.Promociones = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPromocion = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPromocion = New System.Windows.Forms.ToolStripMenuItem()
        Me.Compradores = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarComprador = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarComprador = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarTipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarTipo = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ventas, Me.Negocio, Me.Administracion, Me.Configuracion, Me.MiUsuario, Me.Logout})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Ventas
        '
        Me.Ventas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarVenta, Me.GenerarVenta})
        Me.Ventas.Image = Global.TicketYa.My.Resources.Resources.monedas
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(68, 20)
        Me.Ventas.Text = "Ventas"
        '
        'BuscarVenta
        '
        Me.BuscarVenta.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarVenta.Name = "BuscarVenta"
        Me.BuscarVenta.Size = New System.Drawing.Size(155, 22)
        Me.BuscarVenta.Text = "Buscar Venta"
        '
        'GenerarVenta
        '
        Me.GenerarVenta.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarVenta.Name = "GenerarVenta"
        Me.GenerarVenta.Size = New System.Drawing.Size(155, 22)
        Me.GenerarVenta.Text = "Generar Venta"
        '
        'Negocio
        '
        Me.Negocio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Sedes, Me.Show, Me.Fecha, Me.Sector, Me.Promociones, Me.Compradores, Me.TipoShow})
        Me.Negocio.Image = Global.TicketYa.My.Resources.Resources.negocios
        Me.Negocio.Name = "Negocio"
        Me.Negocio.Size = New System.Drawing.Size(73, 20)
        Me.Negocio.Text = "Negocio"
        '
        'Sedes
        '
        Me.Sedes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarSede, Me.GenerarSede})
        Me.Sedes.Image = Global.TicketYa.My.Resources.Resources.stadium
        Me.Sedes.Name = "Sedes"
        Me.Sedes.Size = New System.Drawing.Size(152, 22)
        Me.Sedes.Text = "Sedes"
        '
        'BuscarSede
        '
        Me.BuscarSede.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarSede.Name = "BuscarSede"
        Me.BuscarSede.Size = New System.Drawing.Size(152, 22)
        Me.BuscarSede.Text = "Buscar Sede"
        '
        'GenerarSede
        '
        Me.GenerarSede.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarSede.Name = "GenerarSede"
        Me.GenerarSede.Size = New System.Drawing.Size(152, 22)
        Me.GenerarSede.Text = "Generar Sede"
        '
        'Show
        '
        Me.Show.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarShow, Me.GenerarShow})
        Me.Show.Image = Global.TicketYa.My.Resources.Resources.show
        Me.Show.Name = "Show"
        Me.Show.Size = New System.Drawing.Size(152, 22)
        Me.Show.Text = "Shows"
        '
        'BuscarShow
        '
        Me.BuscarShow.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarShow.Name = "BuscarShow"
        Me.BuscarShow.Size = New System.Drawing.Size(153, 22)
        Me.BuscarShow.Text = "Buscar Show"
        '
        'GenerarShow
        '
        Me.GenerarShow.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarShow.Name = "GenerarShow"
        Me.GenerarShow.Size = New System.Drawing.Size(153, 22)
        Me.GenerarShow.Text = "Generar Show"
        '
        'Fecha
        '
        Me.Fecha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarFecha, Me.GenerarFecha})
        Me.Fecha.Image = Global.TicketYa.My.Resources.Resources.fecha
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(152, 22)
        Me.Fecha.Text = "Fecha"
        '
        'BuscarFecha
        '
        Me.BuscarFecha.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarFecha.Name = "BuscarFecha"
        Me.BuscarFecha.Size = New System.Drawing.Size(156, 22)
        Me.BuscarFecha.Text = "Buscar Fecha"
        '
        'GenerarFecha
        '
        Me.GenerarFecha.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarFecha.Name = "GenerarFecha"
        Me.GenerarFecha.Size = New System.Drawing.Size(156, 22)
        Me.GenerarFecha.Text = "Generar Fecha"
        '
        'Sector
        '
        Me.Sector.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarSector, Me.GenerarSector})
        Me.Sector.Image = Global.TicketYa.My.Resources.Resources.section
        Me.Sector.Name = "Sector"
        Me.Sector.Size = New System.Drawing.Size(152, 22)
        Me.Sector.Text = "Sectores"
        '
        'BuscarSector
        '
        Me.BuscarSector.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarSector.Name = "BuscarSector"
        Me.BuscarSector.Size = New System.Drawing.Size(158, 22)
        Me.BuscarSector.Text = "Buscar Sector"
        '
        'GenerarSector
        '
        Me.GenerarSector.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarSector.Name = "GenerarSector"
        Me.GenerarSector.Size = New System.Drawing.Size(158, 22)
        Me.GenerarSector.Text = "Generar Sector"
        '
        'Promociones
        '
        Me.Promociones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPromocion, Me.GenerarPromocion})
        Me.Promociones.Image = Global.TicketYa.My.Resources.Resources.promocion
        Me.Promociones.Name = "Promociones"
        Me.Promociones.Size = New System.Drawing.Size(152, 22)
        Me.Promociones.Text = "Promociones"
        '
        'BuscarPromocion
        '
        Me.BuscarPromocion.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarPromocion.Name = "BuscarPromocion"
        Me.BuscarPromocion.Size = New System.Drawing.Size(176, 22)
        Me.BuscarPromocion.Text = "Buscar Promocion"
        '
        'GenerarPromocion
        '
        Me.GenerarPromocion.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarPromocion.Name = "GenerarPromocion"
        Me.GenerarPromocion.Size = New System.Drawing.Size(176, 22)
        Me.GenerarPromocion.Text = "Generar Promocion"
        '
        'Compradores
        '
        Me.Compradores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarComprador, Me.GenerarComprador})
        Me.Compradores.Image = Global.TicketYa.My.Resources.Resources.personas
        Me.Compradores.Name = "Compradores"
        Me.Compradores.Size = New System.Drawing.Size(152, 22)
        Me.Compradores.Text = "Compradores"
        '
        'BuscarComprador
        '
        Me.BuscarComprador.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarComprador.Name = "BuscarComprador"
        Me.BuscarComprador.Size = New System.Drawing.Size(180, 22)
        Me.BuscarComprador.Text = "Buscar Comprador"
        '
        'GenerarComprador
        '
        Me.GenerarComprador.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarComprador.Name = "GenerarComprador"
        Me.GenerarComprador.Size = New System.Drawing.Size(180, 22)
        Me.GenerarComprador.Text = "Generar Comprador"
        '
        'TipoShow
        '
        Me.TipoShow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarTipo, Me.GenerarTipo})
        Me.TipoShow.Image = Global.TicketYa.My.Resources.Resources.Slide_Show_icon
        Me.TipoShow.Name = "TipoShow"
        Me.TipoShow.Size = New System.Drawing.Size(152, 22)
        Me.TipoShow.Text = "Tipo Show"
        '
        'BuscarTipo
        '
        Me.BuscarTipo.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarTipo.Name = "BuscarTipo"
        Me.BuscarTipo.Size = New System.Drawing.Size(147, 22)
        Me.BuscarTipo.Text = "Buscar Tipo"
        '
        'GenerarTipo
        '
        Me.GenerarTipo.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.GenerarTipo.Name = "GenerarTipo"
        Me.GenerarTipo.Size = New System.Drawing.Size(147, 22)
        Me.GenerarTipo.Text = "Generar Tipo"
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
        Me.Usuarios.Size = New System.Drawing.Size(127, 22)
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
        Me.Familias.Size = New System.Drawing.Size(127, 22)
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
        Me.Permisos.Size = New System.Drawing.Size(127, 22)
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
        Me.Idiomas.Size = New System.Drawing.Size(124, 22)
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
        Me.Backups.Size = New System.Drawing.Size(124, 22)
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
        Me.Bitacoras.Size = New System.Drawing.Size(124, 22)
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
    Friend WithEvents Ventas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Negocio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sedes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Show As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Promociones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSede As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarSede As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarSector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarSector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPromocion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPromocion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Compradores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarComprador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarComprador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fecha As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarFecha As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarFecha As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarTipo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarTipo As System.Windows.Forms.ToolStripMenuItem

End Class
