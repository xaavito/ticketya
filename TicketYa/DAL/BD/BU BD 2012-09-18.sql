USE [TicketYa]
GO
/****** Object:  Table [dbo].[Excepcion]    Script Date: 09/18/2012 01:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Excepcion](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[codigo] [int] NOT NULL,
 CONSTRAINT [PK_Excepcion] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Excepcion] ON
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (1, N'ConexionFallida', 1)
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (2, N'MensajeExcepcion', 2)
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (3, N'FamiliaNoEncontrada', 3)
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (4, N'NoHayIdioma', 4)
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (5, N'IdiomaNoEncontrado', 5)
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (6, N'MensajeNoEncontrado', 6)
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (7, N'PermisoNoEncontrado', 7)
INSERT [dbo].[Excepcion] ([identificador], [descripcion], [codigo]) VALUES (8, N'UsuarioNoEncontrado', 8)
SET IDENTITY_INSERT [dbo].[Excepcion] OFF
/****** Object:  Table [dbo].[Familia]    Script Date: 09/18/2012 01:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Familia] ON
INSERT [dbo].[Familia] ([identificador], [descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Familia] ([identificador], [descripcion]) VALUES (2, N'Root')
INSERT [dbo].[Familia] ([identificador], [descripcion]) VALUES (3, N'Usuario')
INSERT [dbo].[Familia] ([identificador], [descripcion]) VALUES (4, N'Supervisor')
INSERT [dbo].[Familia] ([identificador], [descripcion]) VALUES (5, N'Vendedor')
INSERT [dbo].[Familia] ([identificador], [descripcion]) VALUES (6, N'Nueva2')
SET IDENTITY_INSERT [dbo].[Familia] OFF
/****** Object:  Table [dbo].[Idioma]    Script Date: 09/18/2012 01:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Idioma](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON
INSERT [dbo].[Idioma] ([identificador], [descripcion]) VALUES (1, N'Español')
INSERT [dbo].[Idioma] ([identificador], [descripcion]) VALUES (2, N'Ingles')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
/****** Object:  Table [dbo].[Permiso]    Script Date: 09/18/2012 01:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permiso](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[componente] [varchar](100) NOT NULL,
	[formulario] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (1, N'Buscar Bitacora', N'BuscarBitacora', N'Principal')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (4, N'Menu Bitacora ', N'Bitacora', N'Principal')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (5, N'Menu Usuario', N'Usuarios', N'Principal')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (6, N'Menu Familia', N'Familia', N'Principal')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (7, N'Menu Permisos', N'Permisos', N'Principal')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (8, N'Menu Bitacora', N'Bitacora', N'Principal')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (9, N'Menu Backup', N'Backup', N'Principal')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (10, N'Buscar Usuario', N'BuscarUsuario', N'Menu Usuario')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (11, N'Alta usuario', N'AltaUsuario', N'Menu Usuario')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (12, N'Buscar Familia', N'BuscarFamilia', N'Menu Familia')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (13, N'Generar Familia', N'GenerarFamilia', N'Menu Familia')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (14, N'Permisos Usuario', N'PermisosUsuario', N'Menu Permisos')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (15, N'Permisos Familia', N'PermisosFamilia', N'Menu Permisos')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (16, N'Buscar Bitacora', N'BuscarBitacora', N'Menu Bitacora')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (17, N'Buscar Backup', N'BuscarBackup', N'Menu Backup')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (18, N'Realizar Restore', N'RealizarRestore', N'Menu Backup')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (19, N'Modificar Usuario', N'ModificarUsuarioButton', N'Buscar Usuario')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (20, N'Eliminar Usuario', N'EliminarUsuarioButton', N'Buscar Usuario')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (22, N'Modificar Familia', N'ModificarFamiliaButton', N'Buscar Familia')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (23, N'Eliminar Familia', N'EliminarFamiliaButton', N'Buscar Familia')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (24, N'Agregar Permiso Usuario', N'AgregarPermisoUsuarioButton', N'Permisos Usuario')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (27, N'Quitar Permiso Usuario', N'QuitarPermisosUsuarioButton', N'Permisos Usuario')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (28, N'Agregar Permiso Familia', N'AgregarPermisoFamiliaButton', N'Permisos Familia')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (29, N'Quitar Permiso Familia', N'QuitarPermisoFamiliaButton', N'Permisos Familia')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (30, N'Eliminar Backup', N'EliminarBackupButton', N'Realizar Backup')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (31, N'Realizar Backup', N'RealizaBackupButton', N'Realizar Backup')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (32, N'Realizar Restore', N'RealizarRestoreButton', N'Realizar Restore')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
/****** Object:  Table [dbo].[Mensaje_Base_Bitacora]    Script Date: 09/18/2012 01:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mensaje_Base_Bitacora](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [int] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Mensaje_Base_Bitacora] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Mensaje_Base_Bitacora] ON
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (1, 1, N'Intento de logueo sin exito')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (2, 2, N'Logueo Existoso')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (3, 3, N'Logout Exitoso')
SET IDENTITY_INSERT [dbo].[Mensaje_Base_Bitacora] OFF
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 09/18/2012 01:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Permiso](
	[idUsuario] [int] NOT NULL,
	[idPermiso] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Permiso] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idPermiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Usuario_Permiso] ([idUsuario], [idPermiso]) VALUES (1, 1)
/****** Object:  Table [dbo].[Usuario]    Script Date: 09/18/2012 01:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[usr] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[idIdioma] [int] NULL,
	[activo] [bit] NULL,
	[fecha] [datetime] NULL,
	[fechaBaja] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (1, N'Jose', N'Gonzalez', N'jose', N'89hmK6Wu4mcKo+h7D2xVUg==', 1, 1, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (2, N'Marcos', N'Gutierrez', N'marcos', N'oXupws50jPg2O6QuKS/Ctg==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (3, N'Javier', N'Gonzalez', N'javier', N'yHjTGmjahlAc2HOYKVaLxQ==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), CAST(0x0000A0CF015BEE14 AS DateTime))
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (4, N'Javier', N'Gonzalez', N'javier', N'yHjTGmjahlAc2HOYKVaLxQ==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (5, N'Increible', N'Hulk', N'hulk', N'H6CwidJscgtODohNQV3/NA==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (6, N'Increible', N'Hulk', N'hulk', N'H6CwidJscgtODohNQV3/NA==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (7, N'Diego', N'Maradona', N'diego', N'qiIgv06XrO7HbK1eiFtiwQ==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (8, N'Bruce', N'Wayne', N'batman', N'EmhCFBB9qyoEmQQEhnp30A==', 1, 0, CAST(0x0000A0CF01769AA6 AS DateTime), CAST(0x0000A0CF0176A8B6 AS DateTime))
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (9, N'Linterna', N'Verde', N'linterna', N'H6CwidJscgtODohNQV3/NA==', 1, 0, CAST(0x0000A0CF0178F69B AS DateTime), CAST(0x0000A0CF017A3E9E AS DateTime))
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (10, N'Clark', N'Kent', N'superman', N'qdPaowNCcjmPbKYZZpCrow==', 1, 0, CAST(0x0000A0CF01797DF0 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  StoredProcedure [dbo].[INSERTAR_FAMILIA_SP]    Script Date: 09/18/2012 01:33:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_FAMILIA_SP]
@descripcion VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    INSERT INTO Familia (descripcion) VALUES (@descripcion);
END
GO
/****** Object:  StoredProcedure [dbo].[LISTAR_TIPO_BITACORAS_SP]    Script Date: 09/18/2012 01:33:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_TIPO_BITACORAS_SP]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT b.identificador, b.descripcion
	FROM Mensaje_Base_Bitacora b;	
	--WHERE mb.idIdioma = @idIdioma
	--AND b.fecha = @fecha
	--AND b.idUsuario = @idUsuario;
END
GO
/****** Object:  StoredProcedure [dbo].[LISTAR_IDIOMAS_SP]    Script Date: 09/18/2012 01:33:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_IDIOMAS_SP]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT i.identificador, i.descripcion
	FROM Idioma i;
END
GO
/****** Object:  StoredProcedure [dbo].[LISTAR_FAMILIAS_SP]    Script Date: 09/18/2012 01:33:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_FAMILIAS_SP]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT f.identificador, f.descripcion
	FROM Familia f;
END
GO
/****** Object:  StoredProcedure [dbo].[MODIFICAR_FAMILIA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MODIFICAR_FAMILIA_SP]
@idFamilia INTEGER,
@descripcion VARCHAR(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    UPDATE Familia SET descripcion = @descripcion WHERE identificador = @idFamilia;

END
GO
/****** Object:  Table [dbo].[MensajeControl]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MensajeControl](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[formulario] [varchar](50) NULL,
	[control] [varchar](50) NULL,
	[mensaje] [varchar](50) NULL,
	[idIdioma] [int] NULL,
 CONSTRAINT [PK_MensajeControl] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MensajeControl] ON
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (1, N'Login', N'AceptarButton', N'Aceptar', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (2, N'Login', N'CancelarButton', N'Cancelar', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (3, N'Login', N'UsuarioLabel', N'Usuario', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (4, N'Login', N'PassLabel', N'Contraseña', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (5, N'Login', N'CambiarIdiomaLabel', N'Cambiar Idioma', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (6, N'Login', N'AceptarButton', N'Accept', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (7, N'Login', N'CancelarButton', N'Cancel', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (8, N'Login', N'UsuarioLabel', N'User', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (9, N'Login', N'PassLabel', N'Password', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (10, N'Login', N'CambiarIdiomaLabel', N'Change Language', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (11, N'BuscarUsuario', N'UsuarioLabel', N'Usuario', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (12, N'BuscarUsuario', N'UsuarioLabel', N'User', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (13, N'BuscarUsuario', N'ActivoColumn', N'Activo', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (14, N'BuscarUsuario', N'ActivoColumn', N'Active', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (15, N'BuscarUsuario', N'NombreColumn', N'Nombre', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (16, N'BuscarUsuario', N'NombreColumn', N'Name', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (17, N'BuscarUsuario', N'ApellidoColumn', N'Apellido', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (18, N'BuscarUsuario', N'ApellidoColumn', N'Lastname', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (19, N'BuscarUsuario', N'UsuarioColumn', N'Usuario', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (20, N'BuscarUsuario', N'UsuarioColumn', N'User', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (21, N'BuscarUsuario', N'FechaAltaColumn', N'Fecha Alta', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (22, N'BuscarUsuario', N'FechaAltaColumn', N'Start Date', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (23, N'BuscarUsuario', N'FechaBajaColumn', N'Fecha Baja', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (24, N'BuscarUsuario', N'FechaBajaColumn', N'Out Date', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (25, N'BuscarUsuario', N'BuscarUsuariosButton', N'Buscar', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (26, N'BuscarUsuario', N'BuscarUsuariosButton', N'Search', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (27, N'BuscarUsuario', N'ModificarUsuarioButton', N'Modificar', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (28, N'BuscarUsuario', N'ModificarUsuarioButton', N'Modify', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (29, N'BuscarUsuario', N'EliminarUsuarioButton', N'Eliminar', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (30, N'BuscarUsuario', N'EliminarUsuarioButton', N'Eliminate', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (31, N'Principal', N'Usuarios', N'Usuarios', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (32, N'Principal', N'Usuarios', N'Users', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (33, N'Principal', N'Familia', N'Familia', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (34, N'Principal', N'Familia', N'Family', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (35, N'Principal', N'Permisos', N'Permisos', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (36, N'Principal', N'Permisos', N'Permissions', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (37, N'Principal', N'Bitacora', N'Bitacora', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (38, N'Principal', N'Bitacora', N'Log', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (39, N'Principal', N'Backup', N'Backup', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (40, N'Principal', N'Backup', N'Backup', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (41, N'Principal', N'BuscarUsuario', N'Buscar Usuario', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (42, N'Principal', N'BuscarUsuario', N'User Search', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (43, N'Principal', N'AltaUsuario', N'Alta Usuario', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (44, N'Principal', N'AltaUsuario', N'New User', 2)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (45, N'Buscar Usuario', N'UsuarioColumn', N'Usuario', 1)
INSERT [dbo].[MensajeControl] ([identificador], [formulario], [control], [mensaje], [idIdioma]) VALUES (46, N'Buscar', N'UsuarioColumn', N'User', 2)
SET IDENTITY_INSERT [dbo].[MensajeControl] OFF
/****** Object:  Table [dbo].[Mensaje_Bitacora]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mensaje_Bitacora](
	[idBase] [int] NOT NULL,
	[idIdioma] [int] NOT NULL,
	[mensaje] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Mensaje_Bitacora] PRIMARY KEY CLUSTERED 
(
	[idBase] ASC,
	[idIdioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Mensaje_Bitacora] ([idBase], [idIdioma], [mensaje]) VALUES (1, 1, N'Usuario: {1} y contraseña {2}, logueo sin exito')
INSERT [dbo].[Mensaje_Bitacora] ([idBase], [idIdioma], [mensaje]) VALUES (1, 2, N'User: {1} and password: {2},unsucsefull login')
INSERT [dbo].[Mensaje_Bitacora] ([idBase], [idIdioma], [mensaje]) VALUES (2, 1, N'Usuario: {1} logeado existosamente')
INSERT [dbo].[Mensaje_Bitacora] ([idBase], [idIdioma], [mensaje]) VALUES (2, 2, N'User: {1} logged in succesfully')
/****** Object:  Table [dbo].[Familia_Permiso]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia_Permiso](
	[idFamilia] [int] NOT NULL,
	[idPermiso] [int] NOT NULL,
 CONSTRAINT [PK_Familia_Permiso] PRIMARY KEY CLUSTERED 
(
	[idFamilia] ASC,
	[idPermiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (1, 4)
/****** Object:  Table [dbo].[Excepcion_Mensaje]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Excepcion_Mensaje](
	[idExcepcion] [int] NOT NULL,
	[mensaje] [varchar](100) NOT NULL,
	[idIdioma] [int] NOT NULL,
 CONSTRAINT [PK_Excepcion_Mensaje_1] PRIMARY KEY CLUSTERED 
(
	[idExcepcion] ASC,
	[idIdioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (1, N'Conexion a la BD fallida', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (1, N'DB conecction Failure', 2)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (2, N'Excepcion no Encontrado', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (2, N'Exception not found', 2)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (3, N'Familia no Encontrada', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (3, N'Family not found', 2)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (4, N'Usuario sin idioma', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (4, N'User does not have a selected language', 2)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (5, N'Idioma no encontrado', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (5, N'Language not found', 2)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (6, N'Mensaje no encontrado', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (6, N'Message not found', 2)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (7, N'Permiso no encontrado', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (7, N'Permission not found', 2)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (8, N'Usuario no encontrado', 1)
INSERT [dbo].[Excepcion_Mensaje] ([idExcepcion], [mensaje], [idIdioma]) VALUES (8, N'User not found', 2)
/****** Object:  StoredProcedure [dbo].[BUSCAR_IDIOMA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_IDIOMA_SP]
@idIdioma INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT i.identificador,i.descripcion
	FROM Idioma i
	WHERE i.identificador = @idIdioma;
END
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_FAMILIA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ELIMINAR_FAMILIA_SP]
@idFamilia INTEGER

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	DELETE FROM Familia WHERE identificador = @idFamilia;
	
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_FAMILIAS_DESC_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_FAMILIAS_DESC_SP]
@descripcion VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT f.identificador,f.descripcion
	FROM Familia f
	WHERE f.descripcion LIKE '%' + @descripcion + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_USUARIO_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_USUARIO_SP]
@usr VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT U.idUsuario,U.nombre,u.apellido,u.usr,u.activo,u.fecha,u.fechaBaja,u.idIdioma
	FROM Usuario U
	WHERE U.usr LIKE '%' + @usr +'%';
	
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PERMISO_PERSONA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_PERMISO_PERSONA_SP]
@idUsuario INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT p.identificador,p.descripcion,p.componente,p.formulario
	FROM Usuario u
	INNER JOIN Usuario_Permiso up ON (up.idUsuario = u.idUsuario)
	INNER JOIN Permiso p ON (p.identificador = up.idPermiso)	
	WHERE up.idUsuario = @idUsuario;
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PERMISO_FAMILIA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_PERMISO_FAMILIA_SP]
@idFamilia INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT p.identificador,p.descripcion,p.componente,p.formulario
	FROM Familia f
	INNER JOIN Familia_Permiso fp ON (fp.idFamilia = f.identificador)	
	INNER JOIN Permiso p ON (p.identificador = fp.idPermiso)	
	WHERE fp.idFamilia = @idFamilia;
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_MENSAJES_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_MENSAJES_SP]
@idIdioma INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT mc.idIdioma,mc.formulario, mc.control, mc.mensaje
	FROM MensajeControl mc
	WHERE mc.idIdioma = @idIdioma;
END
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bitacora](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NULL,
	[mensaje] [varchar](100) NOT NULL,
	[idMensajeBase] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (1, NULL, N'JOSE,JOSE', 1, CAST(0x0000A0CE00D08777 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (2, NULL, N'jose,jose', 1, CAST(0x0000A0CE00D0B63A AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (3, NULL, N'jose,jose', 1, CAST(0x0000A0CE00D14579 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (4, NULL, N'jose,jose', 1, CAST(0x0000A0CE00D22D15 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (5, NULL, N'jose,jose', 1, CAST(0x0000A0CE00D30A09 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (6, NULL, N'jose,jose', 1, CAST(0x0000A0CE00D33DE4 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (7, NULL, N'jose,jose', 1, CAST(0x0000A0CE00D3A114 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (8, NULL, N'jose,jose', 1, CAST(0x0000A0CE00D4A85E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (9, 1, N'jose', 2, CAST(0x0000A0CE00D5BD5A AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (10, 1, N'jose', 2, CAST(0x0000A0CE00D60279 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (11, 1, N'jose', 2, CAST(0x0000A0CE00DC1EF7 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (12, 1, N'jose', 2, CAST(0x0000A0CE00DC2069 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (13, 1, N'jose', 2, CAST(0x0000A0CE00DC4C4C AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (14, 1, N'jose', 2, CAST(0x0000A0CE00DC4DC3 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (15, 1, N'jose', 2, CAST(0x0000A0CE00DC9F64 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (17, 1, N'jose', 2, CAST(0x0000A0CE00DCCCAD AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (19, 1, N'jose', 2, CAST(0x0000A0CE011623B1 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (20, 1, N'jose', 2, CAST(0x0000A0CE0116869B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (21, 1, N'jose', 2, CAST(0x0000A0CE011705A4 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (22, 1, N'jose', 2, CAST(0x0000A0CE01177CB3 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (23, 1, N'jose', 2, CAST(0x0000A0CE0117F927 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (24, 1, N'jose', 3, CAST(0x0000A0CE0118373F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (25, 1, N'jose', 2, CAST(0x0000A0CE0126D479 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (26, 1, N'jose', 2, CAST(0x0000A0CE0126F963 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (27, 1, N'jose', 2, CAST(0x0000A0CE01271DEB AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (28, 1, N'jose', 2, CAST(0x0000A0CE012781E9 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (29, 1, N'jose', 2, CAST(0x0000A0CE0127F37E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (30, 1, N'jose', 2, CAST(0x0000A0CE0128AC6E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (31, 1, N'jose', 2, CAST(0x0000A0CE01298EAD AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (32, 1, N'jose', 2, CAST(0x0000A0CE013C25AD AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (33, 1, N'jose', 2, CAST(0x0000A0CE013CC286 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (34, 1, N'jose', 2, CAST(0x0000A0CE013E6B4B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (35, 1, N'jose', 2, CAST(0x0000A0CE013F3111 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (36, 1, N'jose', 2, CAST(0x0000A0CE013F5B7E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (37, 1, N'jose', 2, CAST(0x0000A0CE013F9945 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (38, 1, N'jose', 2, CAST(0x0000A0CE013FCE06 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (39, 1, N'jose', 2, CAST(0x0000A0CE013FFE74 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (40, 1, N'jose', 2, CAST(0x0000A0CE014020D8 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (41, 1, N'jose', 2, CAST(0x0000A0CE01408775 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (42, 1, N'jose', 2, CAST(0x0000A0CE0140A2C6 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (43, 1, N'jose', 2, CAST(0x0000A0CE0141CCFF AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (44, 1, N'jose', 3, CAST(0x0000A0CE0141CEAA AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (45, 1, N'jose', 2, CAST(0x0000A0CE014278EA AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (46, 1, N'jose', 2, CAST(0x0000A0CE01441D24 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (47, 1, N'jose', 2, CAST(0x0000A0CE01461F36 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (48, 1, N'jose', 2, CAST(0x0000A0CE01464CDC AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (49, 1, N'jose', 2, CAST(0x0000A0CE0146E458 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (50, 1, N'jose', 2, CAST(0x0000A0CE0152A072 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (51, 1, N'jose', 2, CAST(0x0000A0CE0152E3CA AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (52, 1, N'jose', 2, CAST(0x0000A0CE015314C5 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (53, 1, N'jose', 2, CAST(0x0000A0CE01534322 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (54, 1, N'jose', 2, CAST(0x0000A0CE0153D4AB AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (55, 1, N'jose', 2, CAST(0x0000A0CE01787B65 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (56, 1, N'jose', 2, CAST(0x0000A0CE0178B0E1 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (57, 1, N'jose', 2, CAST(0x0000A0CE01790C94 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (58, 1, N'jose', 2, CAST(0x0000A0CE017D4845 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (59, 1, N'jose', 2, CAST(0x0000A0CE017EDD51 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (60, 1, N'jose', 2, CAST(0x0000A0CE017F9E66 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (61, 1, N'jose', 2, CAST(0x0000A0CE01811B68 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (62, 1, N'jose', 2, CAST(0x0000A0CE01815841 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (63, 1, N'jose', 2, CAST(0x0000A0CE01834218 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (64, 1, N'jose', 2, CAST(0x0000A0CE01858DD4 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (65, 1, N'jose', 2, CAST(0x0000A0CE0185F271 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (66, 1, N'jose', 2, CAST(0x0000A0CE0186E5F5 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (67, 1, N'jose', 2, CAST(0x0000A0CE01874721 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (68, 1, N'jose', 2, CAST(0x0000A0CE0187974B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (69, 1, N'jose', 2, CAST(0x0000A0CE0189CCA2 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (70, 1, N'jose', 2, CAST(0x0000A0CE018AE344 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (71, 1, N'jose', 2, CAST(0x0000A0CF0010EE1B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (72, 1, N'jose', 2, CAST(0x0000A0CF00114B57 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (73, 1, N'jose', 2, CAST(0x0000A0CF0011D57F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (74, 1, N'jose', 2, CAST(0x0000A0CF0012B594 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (75, NULL, N'hulk,hulk', 1, CAST(0x0000A0CF01403EFB AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (76, 1, N'jose', 2, CAST(0x0000A0CF014DEF95 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (77, 1, N'jose', 3, CAST(0x0000A0CF014DF157 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (78, 1, N'jose', 2, CAST(0x0000A0CF015325E0 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (79, 1, N'jose', 2, CAST(0x0000A0CF01541934 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (80, 1, N'jose', 2, CAST(0x0000A0CF01547A73 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (81, 1, N'jose', 2, CAST(0x0000A0CF01550C25 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (82, 1, N'jose', 2, CAST(0x0000A0CF01563516 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (83, NULL, N'marcos,marcos', 1, CAST(0x0000A0CF0157108A AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (84, 1, N'jose', 2, CAST(0x0000A0CF0158BF13 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (85, 1, N'jose', 2, CAST(0x0000A0CF0158FE6E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (86, 1, N'jose', 2, CAST(0x0000A0CF01591763 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (87, 1, N'jose', 2, CAST(0x0000A0CF01599355 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (88, 1, N'jose', 2, CAST(0x0000A0CF015A8948 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (89, 1, N'jose', 2, CAST(0x0000A0CF015AD39F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (90, 1, N'jose', 2, CAST(0x0000A0CF015B9020 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (91, 1, N'jose', 2, CAST(0x0000A0CF015BD3FC AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (92, 1, N'jose', 2, CAST(0x0000A0CF0160EB05 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (93, 1, N'jose', 2, CAST(0x0000A0CF01616556 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (94, 1, N'jose', 2, CAST(0x0000A0CF0161B869 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (95, 1, N'jose', 2, CAST(0x0000A0CF0162B26B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (96, 1, N'jose', 2, CAST(0x0000A0CF0165794B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (97, 1, N'jose', 2, CAST(0x0000A0CF0165A376 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (98, 1, N'jose', 2, CAST(0x0000A0CF0165DF80 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (99, 1, N'jose', 2, CAST(0x0000A0CF0168E4B8 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (100, 1, N'jose', 2, CAST(0x0000A0CF0169E634 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (101, 1, N'jose', 2, CAST(0x0000A0CF016A2C13 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (102, 1, N'jose', 2, CAST(0x0000A0CF016B1019 AS DateTime))
GO
print 'Processed 100 total records'
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (103, 1, N'jose', 2, CAST(0x0000A0CF016BEE26 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (104, 1, N'jose', 2, CAST(0x0000A0CF016D436C AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (105, 1, N'jose', 2, CAST(0x0000A0CF016D8C3E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (106, 1, N'jose', 2, CAST(0x0000A0CF016E153E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (107, 1, N'jose', 2, CAST(0x0000A0CF016FA19C AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (108, 1, N'jose', 2, CAST(0x0000A0CF017675F9 AS DateTime))
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
/****** Object:  StoredProcedure [dbo].[BUSCAR_EXCEPCION_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_EXCEPCION_SP]
@idIdioma INTEGER,
@codigoExcepcion INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT em.mensaje	
	FROM Excepcion_Mensaje em
	INNER JOIN Excepcion e ON (e.identificador = em.idExcepcion)
	WHERE em.idIdioma = @idIdioma
	AND e.codigo = @codigoExcepcion;
END
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_USUARIO_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ELIMINAR_USUARIO_SP]
@usr INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    UPDATE Usuario SET activo = 0, fechaBaja = CURRENT_TIMESTAMP WHERE idUsuario = @usr;
END
GO
/****** Object:  StoredProcedure [dbo].[MODIFICAR_USUARIO_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MODIFICAR_USUARIO_SP]
@id INTEGER,
@usr VARCHAR(100),
@pass VARCHAR(100),
@nom VARCHAR(100),
@ape VARCHAR(100),
@idioma INTEGER,
@act BIT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    UPDATE Usuario SET usr = @usr,
					   pass = @pass,
					   nombre = @nom,
					   apellido = @ape,
					   idIdioma = @idioma,
					   activo = @act
					WHERE idUsuario = @id;

END
GO
/****** Object:  StoredProcedure [dbo].[LOGIN_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOGIN_SP]
@usr VARCHAR(50),
@pass VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT u.idUsuario,u.nombre, u.apellido,u.idIdioma
	FROM Usuario u 
	WHERE u.usr = @usr
	AND u.pass = @pass
	AND u.activo = 1;
END
GO
/****** Object:  StoredProcedure [dbo].[LISTAR_USUARIOS_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_USUARIOS_SP]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT u.idUsuario, u.nombre + ' ' + u.apellido
	FROM Usuario u;	
	--WHERE mb.idIdioma = @idIdioma
	--AND b.fecha = @fecha
	--AND b.idUsuario = @idUsuario;
END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_USUARIO_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_USUARIO_SP]
@usr VARCHAR(100),
@pass VARCHAR(100),
@nom VARCHAR(100),
@ape VARCHAR(100),
@idioma INTEGER

AS
Declare @ID INT;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    INSERT INTO Usuario(usr,pass,nombre,apellido,idIdioma,fecha) VALUES
					   (@usr,@pass,@nom,@ape,@idioma,CURRENT_TIMESTAMP);
	Set @ID = Scope_Identity();
	RETURN @ID
END
GO
/****** Object:  Table [dbo].[Usuario_Familia]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Familia](
	[idUsuario] [int] NOT NULL,
	[idFamilia] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Familia] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idFamilia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (2, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (3, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (4, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (5, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (6, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (6, 4)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (7, 2)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (8, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (8, 6)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (9, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (9, 3)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (10, 1)
/****** Object:  StoredProcedure [dbo].[INSERTAR_BITACORA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_BITACORA_SP]
@idUsuario INTEGER,
@mensaje VARCHAR(100),
@codigo INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
    IF @idUsuario = 0 
		BEGIN
			INSERT INTO Bitacora (idMensajeBase,mensaje,fecha) VALUES
							 (@codigo,@mensaje,CURRENT_TIMESTAMP);
		END
	ELSE
		BEGIN
		INSERT INTO Bitacora (idUsuario,idMensajeBase,mensaje,fecha) VALUES
							 (@idUsuario,@codigo,@mensaje,CURRENT_TIMESTAMP);
		END	
END
GO
/****** Object:  StoredProcedure [dbo].[REMOVER_USUARIO_FAMILIA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[REMOVER_USUARIO_FAMILIA_SP]
@idUsuario INTEGER


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    DELETE FROM Usuario_Familia WHERE idUsuario = @idUsuario;

END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_USUARIO_FAMILIA_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_USUARIO_FAMILIA_SP]
@idUsuario INTEGER,
@idFamilia INTEGER

AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    INSERT INTO Usuario_Familia(idUsuario,idFamilia) VALUES
					   (@idUsuario,@idFamilia);
END
GO
/****** Object:  StoredProcedure [dbo].[CHECK_FAMILIA_ASOCIACION_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHECK_FAMILIA_ASOCIACION_SP]
@idFamilia INTEGER

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT COUNT(*)
	FROM Usuario_Familia uf
	WHERE uf.idFamilia = @idFamilia;
	
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_FAMILIAS_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_FAMILIAS_SP]
@idUsuario INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT f.identificador,f.descripcion
	FROM Familia f
	INNER JOIN Usuario_Familia uf ON (uf.idFamilia = f.identificador)	
	WHERE uf.idUsuario = @idUsuario;
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_BITACORAS_SP]    Script Date: 09/18/2012 01:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_BITACORAS_SP]
@idIdioma INTEGER,
@idUsuario INTEGER,
@fecha DATETIME,
@codigo INTEGER

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT b.identificador, mb.mensaje, b.mensaje,b.fecha
	FROM Bitacora b
	INNER JOIN Mensaje_Bitacora mb ON (mb.idBase = b.idMensajeBase)
	WHERE mb.idIdioma = @idIdioma
	AND B.idMensajeBase = @codigo
	AND b.idUsuario = @idUsuario
	ORDER BY b.fecha;
	
END
GO
/****** Object:  Default [DF_Usuario_activo]    Script Date: 09/18/2012 01:33:41 ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_activo]  DEFAULT ((1)) FOR [activo]
GO
/****** Object:  ForeignKey [FK_Usuario_Idioma]    Script Date: 09/18/2012 01:33:41 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
/****** Object:  ForeignKey [FK_MensajeControl_Idioma]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[MensajeControl]  WITH CHECK ADD  CONSTRAINT [FK_MensajeControl_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[MensajeControl] CHECK CONSTRAINT [FK_MensajeControl_Idioma]
GO
/****** Object:  ForeignKey [FK_Mensaje_Bitacora_Idioma]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Mensaje_Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Mensaje_Bitacora_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[Mensaje_Bitacora] CHECK CONSTRAINT [FK_Mensaje_Bitacora_Idioma]
GO
/****** Object:  ForeignKey [FK_Mensaje_Bitacora_Mensaje_Base_Bitacora]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Mensaje_Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Mensaje_Bitacora_Mensaje_Base_Bitacora] FOREIGN KEY([idBase])
REFERENCES [dbo].[Mensaje_Base_Bitacora] ([identificador])
GO
ALTER TABLE [dbo].[Mensaje_Bitacora] CHECK CONSTRAINT [FK_Mensaje_Bitacora_Mensaje_Base_Bitacora]
GO
/****** Object:  ForeignKey [FK_Familia_Permiso_Familia]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Familia_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Permiso_Familia] FOREIGN KEY([idFamilia])
REFERENCES [dbo].[Familia] ([identificador])
GO
ALTER TABLE [dbo].[Familia_Permiso] CHECK CONSTRAINT [FK_Familia_Permiso_Familia]
GO
/****** Object:  ForeignKey [FK_Familia_Permiso_Permiso]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Familia_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Permiso_Permiso] FOREIGN KEY([idPermiso])
REFERENCES [dbo].[Permiso] ([identificador])
GO
ALTER TABLE [dbo].[Familia_Permiso] CHECK CONSTRAINT [FK_Familia_Permiso_Permiso]
GO
/****** Object:  ForeignKey [FK_Excepcion_Mensaje_Excepcion]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Excepcion_Mensaje]  WITH CHECK ADD  CONSTRAINT [FK_Excepcion_Mensaje_Excepcion] FOREIGN KEY([idExcepcion])
REFERENCES [dbo].[Excepcion] ([identificador])
GO
ALTER TABLE [dbo].[Excepcion_Mensaje] CHECK CONSTRAINT [FK_Excepcion_Mensaje_Excepcion]
GO
/****** Object:  ForeignKey [FK_Excepcion_Mensaje_Idioma]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Excepcion_Mensaje]  WITH CHECK ADD  CONSTRAINT [FK_Excepcion_Mensaje_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[Excepcion_Mensaje] CHECK CONSTRAINT [FK_Excepcion_Mensaje_Idioma]
GO
/****** Object:  ForeignKey [FK_Bitacora_Mensaje_Base_Bitacora]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Mensaje_Base_Bitacora] FOREIGN KEY([idMensajeBase])
REFERENCES [dbo].[Mensaje_Base_Bitacora] ([identificador])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Mensaje_Base_Bitacora]
GO
/****** Object:  ForeignKey [FK_Bitacora_Usuario]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
/****** Object:  ForeignKey [FK_Usuario_Familia_Familia]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia_Familia] FOREIGN KEY([idFamilia])
REFERENCES [dbo].[Familia] ([identificador])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK_Usuario_Familia_Familia]
GO
/****** Object:  ForeignKey [FK_Usuario_Familia_Usuario]    Script Date: 09/18/2012 01:33:43 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK_Usuario_Familia_Usuario]
GO
