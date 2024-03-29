USE [TicketYa]
GO
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 10/09/2012 00:20:40 ******/
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
INSERT [dbo].[Usuario_Permiso] ([idUsuario], [idPermiso]) VALUES (2, 1)
INSERT [dbo].[Usuario_Permiso] ([idUsuario], [idPermiso]) VALUES (3, 4)
INSERT [dbo].[Usuario_Permiso] ([idUsuario], [idPermiso]) VALUES (3, 5)
INSERT [dbo].[Usuario_Permiso] ([idUsuario], [idPermiso]) VALUES (5, 11)
INSERT [dbo].[Usuario_Permiso] ([idUsuario], [idPermiso]) VALUES (7, 11)
/****** Object:  Table [dbo].[Permiso]    Script Date: 10/09/2012 00:20:40 ******/
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
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (31, N'Realizar Backup', N'RealizarBackupButton', N'Realizar Backup')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (32, N'Realizar Restore', N'RealizarRestoreButton', N'Realizar Restore')
INSERT [dbo].[Permiso] ([identificador], [descripcion], [componente], [formulario]) VALUES (33, N'Buscar Usuario', N'BuscarUsuariosButton', N'Buscar Usuario')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
/****** Object:  Table [dbo].[Excepcion]    Script Date: 10/09/2012 00:20:40 ******/
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
/****** Object:  Table [dbo].[Formulario]    Script Date: 10/09/2012 00:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formulario](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Formulario] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Formulario] ON
INSERT [dbo].[Formulario] ([identificador], [descripcion]) VALUES (1, N'Login')
INSERT [dbo].[Formulario] ([identificador], [descripcion]) VALUES (15, N'BuscarUsuario')
INSERT [dbo].[Formulario] ([identificador], [descripcion]) VALUES (16, N'Principal')
INSERT [dbo].[Formulario] ([identificador], [descripcion]) VALUES (23, N'Buscar Usuario')
SET IDENTITY_INSERT [dbo].[Formulario] OFF
/****** Object:  Table [dbo].[Familia]    Script Date: 10/09/2012 00:20:40 ******/
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
INSERT [dbo].[Familia] ([identificador], [descripcion]) VALUES (6, N'Nueva')
SET IDENTITY_INSERT [dbo].[Familia] OFF
/****** Object:  Table [dbo].[Backups]    Script Date: 10/09/2012 00:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Backups](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[path] [varchar](200) NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Backup] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Backups] ON
INSERT [dbo].[Backups] ([identificador], [descripcion], [path], [fecha]) VALUES (1, N'lolo', N'D:\\Prueba\\TicketYa18/09/2012 14:23:49.sql', CAST(0x0000A0D000ED475E AS DateTime))
INSERT [dbo].[Backups] ([identificador], [descripcion], [path], [fecha]) VALUES (2, N'lolo', N'D:\\Prueba\\TicketYa18/09/2012 19:07:10.sql', CAST(0x0000A0D0013B1512 AS DateTime))
INSERT [dbo].[Backups] ([identificador], [descripcion], [path], [fecha]) VALUES (3, N'lolo', N'D:\\Prueba\\TicketYa06/10/2012 21:29:11.sql', CAST(0x0000A0E201621640 AS DateTime))
SET IDENTITY_INSERT [dbo].[Backups] OFF
/****** Object:  Table [dbo].[Control]    Script Date: 10/09/2012 00:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Control](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[idFormulario] [int] NOT NULL,
 CONSTRAINT [PK_Control] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Control] ON
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (1, N'AceptarButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (2, N'CancelarButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (3, N'UsuarioLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (4, N'PassLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (5, N'CambiarIdiomaLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (11, N'UsuarioLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (13, N'ActivoColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (15, N'NombreColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (17, N'ApellidoColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (19, N'UsuarioColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (21, N'FechaAltaColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (23, N'FechaBajaColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (25, N'BuscarUsuariosButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (27, N'ModificarUsuarioButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (29, N'EliminarUsuarioButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (31, N'Usuarios', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (33, N'Familias', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (35, N'Permisos', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (37, N'Bitacora', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (39, N'Backup', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (41, N'BuscarUsuario', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (43, N'AltaUsuario', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (45, N'UsuarioColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (47, N'UsuarioLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (49, N'PassLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (51, N'NombreLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (53, N'ApellidoLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (55, N'FamiliaLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (57, N'IdiomaLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (59, N'AgregarFamiliaButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (61, N'QuitarFamiliaButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (63, N'FamiliaColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (65, N'AltaUsuariosButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (67, N'ModificarUsuariosButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (69, N'ActivoLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (71, N'BuscarFamilia', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (73, N'GenerarFamilia', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (75, N'PermisosUsuario', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (77, N'PermisosFamilia', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (79, N'BuscarBitacora', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (81, N'BuscarBackup', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (83, N'RealizarRestore', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (85, N'BuscarFamiliaButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (87, N'ModificarFamiliaButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (89, N'EliminarFamiliaButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (91, N'AltaFamiliaButton', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (93, N'TipoLabel', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (95, N'DescripcionColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (97, N'FechaColumn', 1)
INSERT [dbo].[Control] ([identificador], [descripcion], [idFormulario]) VALUES (99, N'TipoColumn', 1)
SET IDENTITY_INSERT [dbo].[Control] OFF
/****** Object:  Table [dbo].[Idioma]    Script Date: 10/09/2012 00:20:40 ******/
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
/****** Object:  Table [dbo].[Mensaje_Base_Bitacora]    Script Date: 10/09/2012 00:20:40 ******/
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
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (4, 4, N'No Hay Idioma')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (5, 5, N'Idioma no encontrado')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (6, 6, N'Mensaje No encontrado')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (8, 7, N'Permiso no encontrado')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (9, 8, N'Usuario no encontrado')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (10, 9, N'Fallo insert')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (11, 10, N'Usuarios no encontrados')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (12, 11, N'Bitacora No encontrada')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (13, 12, N'Familias No encontradas')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (14, 12, N'Fallo delete')
INSERT [dbo].[Mensaje_Base_Bitacora] ([identificador], [codigo], [descripcion]) VALUES (16, 13, N'Nada')
SET IDENTITY_INSERT [dbo].[Mensaje_Base_Bitacora] OFF
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/09/2012 00:20:40 ******/
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
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (1, N'Jose', N'Gonzalez', N'jose', N'89hmK6Wu4mcKo+h7D2xVUg==', 2, 1, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (2, N'Marcos', N'Gutierrez', N'marcos', N'oXupws50jPg2O6QuKS/Ctg==', 1, 1, CAST(0x0000A0CF015A183F AS DateTime), CAST(0x0000A0D0001D5D69 AS DateTime))
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (3, N'Javier', N'Gonzalez', N'javier', N'yHjTGmjahlAc2HOYKVaLxQ==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), CAST(0x0000A0CF015BEE14 AS DateTime))
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (4, N'Javier', N'Gonzalez', N'javier', N'qdPaowNCcjmPbKYZZpCrow==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (5, N'Increible', N'Hulk', N'hulk', N'H6CwidJscgtODohNQV3/NA==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (6, N'Increible', N'Hulk', N'hulk', N'H6CwidJscgtODohNQV3/NA==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (7, N'Diego', N'Maradona', N'diego', N'qiIgv06XrO7HbK1eiFtiwQ==', 1, 0, CAST(0x0000A0CF015A183F AS DateTime), NULL)
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (8, N'Bruce', N'Wayne', N'batman', N'EmhCFBB9qyoEmQQEhnp30A==', 1, 0, CAST(0x0000A0CF01769AA6 AS DateTime), CAST(0x0000A0CF0176A8B6 AS DateTime))
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (9, N'Linterna', N'Verde', N'linterna', N'H6CwidJscgtODohNQV3/NA==', 1, 0, CAST(0x0000A0CF0178F69B AS DateTime), CAST(0x0000A0CF017A3E9E AS DateTime))
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma], [activo], [fecha], [fechaBaja]) VALUES (10, N'Clark', N'Kent', N'superman', N'qdPaowNCcjmPbKYZZpCrow==', 1, 0, CAST(0x0000A0CF01797DF0 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  StoredProcedure [dbo].[MODIFICAR_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  Table [dbo].[MensajeControl]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MensajeControl](
	[identificador] [int] IDENTITY(1,1) NOT NULL,
	[mensaje] [varchar](50) NULL,
	[idIdioma] [int] NULL,
	[idControl] [int] NOT NULL,
 CONSTRAINT [PK_MensajeControl] PRIMARY KEY CLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MensajeControl] ON
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (1, N'Aceptar', 1, 1)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (2, N'Cancelar', 1, 2)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (3, N'Usuario', 1, 3)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (4, N'Contraseña', 1, 4)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (5, N'Cambiar Idioma', 1, 5)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (6, N'Accept', 2, 1)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (7, N'Cancel', 2, 2)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (8, N'User', 2, 3)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (9, N'Password', 2, 4)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (10, N'Change Language', 2, 5)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (11, N'Usuario', 1, 11)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (12, N'User', 2, 11)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (13, N'Activo', 1, 13)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (14, N'Active', 2, 13)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (15, N'Nombre', 1, 15)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (16, N'Name', 2, 15)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (17, N'Apellido', 1, 17)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (18, N'Lastname', 2, 17)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (19, N'Usuario', 1, 19)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (20, N'User', 2, 19)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (21, N'Fecha Alta', 1, 21)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (22, N'Start Date', 2, 21)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (23, N'Fecha Baja', 1, 23)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (24, N'Out Date', 2, 23)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (25, N'Buscar', 1, 25)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (26, N'Search', 2, 25)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (27, N'Modificar', 1, 27)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (28, N'Modify', 2, 27)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (29, N'Eliminar', 1, 29)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (30, N'Eliminate', 2, 29)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (31, N'Usuarios', 1, 31)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (32, N'Users', 2, 31)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (33, N'Familia', 1, 33)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (34, N'Family', 2, 33)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (35, N'Permisos', 1, 35)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (36, N'Permissions', 2, 35)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (37, N'Bitacora', 1, 37)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (38, N'Log', 2, 37)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (39, N'Backup', 1, 39)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (40, N'Backup', 2, 39)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (41, N'Buscar Usuario', 1, 41)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (42, N'User Search', 2, 41)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (43, N'Alta Usuario', 1, 43)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (44, N'New User', 2, 43)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (45, N'Usuario', 1, 45)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (46, N'User', 2, 45)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (47, N'Usuario', 1, 47)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (48, N'User', 2, 47)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (49, N'Contraseña', 1, 49)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (50, N'Password', 2, 49)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (51, N'Nombre', 1, 51)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (52, N'Name', 2, 51)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (53, N'Apellido', 1, 53)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (54, N'Lastname', 2, 53)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (55, N'Familia', 1, 55)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (56, N'Family', 2, 55)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (57, N'Idioma', 1, 57)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (58, N'Language', 2, 57)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (59, N'Agregar', 1, 59)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (60, N'Add', 2, 59)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (61, N'Quitar', 1, 61)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (62, N'Remove', 2, 61)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (63, N'Familia', 1, 63)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (64, N'Family', 2, 63)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (65, N'Alta', 1, 65)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (66, N'Done', 2, 65)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (67, N'Modificar', 1, 67)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (68, N'Modify', 2, 67)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (69, N'Activo', 1, 69)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (70, N'Active', 2, 69)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (71, N'Buscar Familia', 1, 71)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (72, N'Family Search', 2, 71)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (73, N'Generar Familia', 1, 73)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (74, N'Family Generation', 2, 73)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (75, N'Permisos Usuario', 1, 75)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (76, N'User Permissions', 2, 75)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (77, N'Permisos Familia', 1, 77)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (78, N'Family Permissions', 2, 77)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (79, N'Buscar Bitacora', 1, 79)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (80, N'Log Search', 2, 79)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (81, N'Buscar Backup', 1, 81)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (82, N'Backup Search', 2, 81)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (83, N'Realizar Restore', 1, 83)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (84, N'Restore', 2, 83)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (85, N'Buscar Familia', 1, 85)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (86, N'Family Search', 2, 85)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (87, N'Modificar', 1, 87)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (88, N'Modify', 2, 87)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (89, N'Eliminar', 1, 89)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (90, N'Eliminate', 2, 89)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (91, N'Alta', 1, 91)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (92, N'Do', 2, 91)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (93, N'Tipo', 1, 93)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (94, N'Type', 2, 93)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (95, N'Descripcion', 1, 95)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (96, N'Description', 2, 95)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (97, N'Fecha', 1, 97)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (98, N'Date', 2, 97)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (99, N'Tipo', 1, 99)
INSERT [dbo].[MensajeControl] ([identificador], [mensaje], [idIdioma], [idControl]) VALUES (100, N'Type', 2, 99)
GO
print 'Processed 100 total records'
SET IDENTITY_INSERT [dbo].[MensajeControl] OFF
/****** Object:  Table [dbo].[Mensaje_Bitacora]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTAR_TIPO_BITACORAS_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTAR_PERMISOS_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_PERMISOS_SP]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT p.identificador,p.componente,p.descripcion
	FROM Permiso p;
END
GO
/****** Object:  StoredProcedure [dbo].[LISTAR_IDIOMAS_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_IDIOMAS_SP]
@nom VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	SELECT i.identificador, i.descripcion
	FROM Idioma i
	WHERE i.descripcion LIKE '%' + @nom + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[LISTAR_FAMILIAS_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTAR_BACKUPS_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTAR_BACKUPS_SP]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
		SELECT identificador,descripcion, fecha FROM Backups;
END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[INSERTAR_PERMISOS_USUARIO_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_PERMISOS_USUARIO_SP]
@idUsuario INTEGER,
@idPermiso INTEGER

AS

BEGIN	
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    
    
	INSERT INTO Usuario_Permiso (idUsuario,idPermiso) VALUES (@idUsuario,@idPermiso);
    
    
END
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[ELIMINAR_PERMISOS_USUARIO_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ELIMINAR_PERMISOS_USUARIO_SP]
@idUsuario INTEGER

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    DELETE FROM Usuario_Permiso WHERE idUsuario = @idUsuario;
   
    
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_IDIOMA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_FAMILIAS_DESC_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  Table [dbo].[Excepcion_Mensaje]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  Table [dbo].[Familia_Permiso]    Script Date: 10/09/2012 00:20:41 ******/
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
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 1)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 4)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 5)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 6)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 7)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 8)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 9)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 10)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 11)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 12)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 13)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 14)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 15)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 16)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 17)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 18)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 19)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 20)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 22)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 23)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 24)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 27)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 28)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 29)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 30)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 31)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (2, 32)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (3, 1)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (4, 8)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (5, 14)
INSERT [dbo].[Familia_Permiso] ([idFamilia], [idPermiso]) VALUES (6, 11)
/****** Object:  StoredProcedure [dbo].[INSERTAR_BACKUP_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_BACKUP_SP]
@descripcion VARCHAR(100),
@path VARCHAR(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
		INSERT INTO Backups(descripcion,path,fecha) VALUES
						(@descripcion,@path,CURRENT_TIMESTAMP);
END
GO
/****** Object:  StoredProcedure [dbo].[MODIFICAR_USUARIO_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  Table [dbo].[Usuario_Familia]    Script Date: 10/09/2012 00:20:41 ******/
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
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (1, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (1, 2)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (2, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (3, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (4, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (4, 6)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (5, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (6, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (6, 4)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (7, 2)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (8, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (8, 6)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (9, 1)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (9, 3)
INSERT [dbo].[Usuario_Familia] ([idUsuario], [idFamilia]) VALUES (10, 1)
/****** Object:  StoredProcedure [dbo].[ELIMINAR_USUARIO_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 10/09/2012 00:20:41 ******/
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
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (109, NULL, N'jose,jose', 1, CAST(0x0000A0D000909772 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (110, 1, N'jose', 2, CAST(0x0000A0D00090A122 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (111, 1, N'jose', 3, CAST(0x0000A0D00090A2AB AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (112, 1, N'jose', 2, CAST(0x0000A0D00090AD5D AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (113, 1, N'jose', 2, CAST(0x0000A0D000912660 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (114, 1, N'jose', 2, CAST(0x0000A0D000919EBC AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (115, 1, N'jose', 2, CAST(0x0000A0D00091C986 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (116, 1, N'jose', 2, CAST(0x0000A0D000DAD1F2 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (117, 1, N'jose', 2, CAST(0x0000A0D000DB4F0B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (118, 1, N'jose', 2, CAST(0x0000A0D000DBDF55 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (119, 1, N'jose', 2, CAST(0x0000A0D000DCC97D AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (120, 1, N'jose', 2, CAST(0x0000A0D000DE1868 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (121, 1, N'jose', 2, CAST(0x0000A0D000DED51D AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (122, 1, N'jose', 2, CAST(0x0000A0D000DF5184 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (123, 1, N'jose', 2, CAST(0x0000A0D000E08336 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (124, 1, N'jose', 2, CAST(0x0000A0D000E0BE15 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (125, 1, N'jose', 2, CAST(0x0000A0D000E1872A AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (126, 1, N'jose', 2, CAST(0x0000A0D000E9F235 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (127, 1, N'jose', 2, CAST(0x0000A0D000EAF959 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (128, 1, N'jose', 2, CAST(0x0000A0D000EB2181 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (129, 1, N'jose', 2, CAST(0x0000A0D000EB4739 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (130, 1, N'jose', 2, CAST(0x0000A0D000EBCA9A AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (131, 1, N'jose', 2, CAST(0x0000A0D000ECD615 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (132, 1, N'jose', 2, CAST(0x0000A0D000ED3221 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (133, 1, N'jose', 2, CAST(0x0000A0D0013AECCE AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (134, 1, N'jose', 3, CAST(0x0000A0D0013AF104 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (135, 1, N'jose', 2, CAST(0x0000A0D0013AFEB6 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (136, 1, N'jose', 2, CAST(0x0000A0D0013DC651 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (137, 1, N'jose', 2, CAST(0x0000A0D0013FF4CE AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (138, 1, N'jose', 3, CAST(0x0000A0D0013FF641 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (139, 1, N'jose', 2, CAST(0x0000A0D00140644C AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (140, 1, N'jose', 2, CAST(0x0000A0D00140F470 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (141, 1, N'jose', 2, CAST(0x0000A0D0014284F7 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (142, 1, N'jose', 2, CAST(0x0000A0D00142CA28 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (143, 1, N'jose', 2, CAST(0x0000A0D00143326B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (144, 1, N'jose', 3, CAST(0x0000A0D0014365BA AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (145, 1, N'jose', 2, CAST(0x0000A0D0014401BB AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (146, 1, N'jose', 2, CAST(0x0000A0D0014C6C39 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (147, 1, N'jose', 3, CAST(0x0000A0D0014C6ECE AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (148, 1, N'jose', 2, CAST(0x0000A0D0014D164F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (149, 1, N'jose', 2, CAST(0x0000A0D0014D8B1D AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (150, 1, N'jose', 3, CAST(0x0000A0D0014DD106 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (151, 1, N'jose', 2, CAST(0x0000A0D0014E804B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (152, 1, N'jose', 2, CAST(0x0000A0D00156832E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (153, 1, N'jose', 2, CAST(0x0000A0D00156FA4B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (154, 1, N'jose', 2, CAST(0x0000A0D00157579F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (155, 1, N'jose', 2, CAST(0x0000A0D0016214C0 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (156, 1, N'jose', 2, CAST(0x0000A0D001625607 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (157, 1, N'jose', 2, CAST(0x0000A0D001632A31 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (158, 1, N'jose', 2, CAST(0x0000A0D0016412BC AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (159, 1, N'jose', 2, CAST(0x0000A0D0016445F7 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (160, 1, N'jose', 2, CAST(0x0000A0E2013C67AF AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (161, 1, N'jose', 2, CAST(0x0000A0E20142BFE3 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (162, 1, N'jose', 2, CAST(0x0000A0E201431C10 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (163, 1, N'jose', 2, CAST(0x0000A0E201435C2F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (164, 1, N'jose', 2, CAST(0x0000A0E2014478E1 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (165, 1, N'jose', 2, CAST(0x0000A0E201485077 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (166, 1, N'jose', 2, CAST(0x0000A0E20149776E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (167, 1, N'jose', 2, CAST(0x0000A0E20156B120 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (168, 1, N'jose', 2, CAST(0x0000A0E2015760DA AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (169, 1, N'jose', 2, CAST(0x0000A0E2015788AD AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (170, 1, N'jose', 2, CAST(0x0000A0E20157D95E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (171, 1, N'jose', 2, CAST(0x0000A0E201588101 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (172, NULL, N'jose,jose', 1, CAST(0x0000A0E2015C9B7B AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (173, 1, N'jose', 2, CAST(0x0000A0E2015CA02F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (174, 1, N'jose', 2, CAST(0x0000A0E2015D9826 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (175, 1, N'jose', 2, CAST(0x0000A0E2015E3B2A AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (176, 1, N'jose', 2, CAST(0x0000A0E2016023E0 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (177, 1, N'jose', 2, CAST(0x0000A0E2016064BB AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (178, 1, N'jose', 2, CAST(0x0000A0E20160B43C AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (179, 1, N'jose', 2, CAST(0x0000A0E20160E833 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (180, 1, N'jose', 2, CAST(0x0000A0E201615542 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (181, 1, N'jose', 2, CAST(0x0000A0E20161CE38 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (182, 1, N'jose', 2, CAST(0x0000A0E3009F20C1 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (183, 1, N'jose', 2, CAST(0x0000A0E3009FE3DA AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (184, 1, N'jose', 3, CAST(0x0000A0E300A09F76 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (185, 1, N'jose', 2, CAST(0x0000A0E300AF4B28 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (186, 1, N'jose', 2, CAST(0x0000A0E4012F34EA AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (187, 1, N'jose', 2, CAST(0x0000A0E4012F7C8C AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (188, 1, N'jose', 2, CAST(0x0000A0E4012FC588 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (189, 1, N'jose', 3, CAST(0x0000A0E4012FFCA5 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (190, 1, N'jose', 2, CAST(0x0000A0E401310460 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (191, 1, N'jose', 3, CAST(0x0000A0E401312660 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (192, 1, N'jose', 2, CAST(0x0000A0E401359D1E AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (193, 1, N'jose', 2, CAST(0x0000A0E401361F79 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (194, 1, N'jose', 3, CAST(0x0000A0E401365984 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (195, 1, N'jose', 2, CAST(0x0000A0E40189D6F1 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (196, 1, N'jose', 2, CAST(0x0000A0E500006AEE AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (197, 1, N'jose', 3, CAST(0x0000A0E500006D00 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (198, 1, N'jose', 2, CAST(0x0000A0E500007884 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (199, 1, N'jose', 3, CAST(0x0000A0E500007F17 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (200, 1, N'jose', 2, CAST(0x0000A0E50000882C AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (201, 1, N'jose', 2, CAST(0x0000A0E50001163F AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (202, 1, N'jose', 2, CAST(0x0000A0E50001CD50 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (203, 1, N'jose', 2, CAST(0x0000A0E50001FA44 AS DateTime))
GO
print 'Processed 200 total records'
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (204, 1, N'jose', 2, CAST(0x0000A0E500042291 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (205, 1, N'jose', 3, CAST(0x0000A0E50004ADB5 AS DateTime))
INSERT [dbo].[Bitacora] ([identificador], [idUsuario], [mensaje], [idMensajeBase], [fecha]) VALUES (206, 1, N'jose', 2, CAST(0x0000A0E50004B7BE AS DateTime))
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
/****** Object:  StoredProcedure [dbo].[BUSCAR_EXCEPCION_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_USUARIO_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_PERMISO_PERSONA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_PERMISO_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_MENSAJES_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
	SELECT mc.idIdioma, f.descripcion as formulario, c.descripcion as control, mc.mensaje
	FROM MensajeControl mc
	INNER JOIN Control c ON (c.identificador = mc.idControl)
	INNER JOIN Formulario f ON (f.identificador = c.idFormulario)
	WHERE mc.idIdioma = @idIdioma;
END
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_PERMISOS_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ELIMINAR_PERMISOS_FAMILIA_SP]
@idFamilia INTEGER

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    DELETE FROM Familia_Permiso WHERE idFamilia = @idFamilia;
   
    
END
GO
/****** Object:  StoredProcedure [dbo].[GENERAR_IDIOMA_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GENERAR_IDIOMA_SP]
@nom VARCHAR(100),
@base INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	--ID IDIOMA GENERADO
	DECLARE @idNuevoIdioma INTEGER
	
	SET NOCOUNT OFF;
	
	INSERT INTO Idioma(descripcion) VALUES (@nom);
	
	SELECT @idNuevoIdioma = MAX(identificador) FROM Idioma
	
	-- CURSOR DE EXCEPCIONES
	DECLARE @idExcepcion INTEGER
	DECLARE @mensaje VARCHAR(100)
	
	DECLARE curExcepcion CURSOR FOR 
	SELECT idExcepcion, mensaje 
	FROM Excepcion_Mensaje 
	WHERE idIdioma = @base
	
	OPEN curExcepcion   
	FETCH NEXT FROM curExcepcion INTO @idExcepcion, @mensaje   

	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		   INSERT INTO Excepcion_Mensaje (idExcepcion,mensaje,idIdioma) VALUES
									      (@idExcepcion,@mensaje,@idNuevoIdioma)

		   FETCH NEXT FROM curExcepcion INTO @idExcepcion, @mensaje   
	END   

	CLOSE curExcepcion   
	DEALLOCATE curExcepcion
    
    
    --MENSAJE BITACORA
    
    DECLARE @idBase INTEGER
	DECLARE @mensaje2 VARCHAR(100)
	
	DECLARE curBitacora CURSOR FOR 
	SELECT idBase, mensaje 
	FROM Mensaje_Bitacora 
	WHERE idIdioma = @base
	
	OPEN curBitacora   
	FETCH NEXT FROM curBitacora INTO @idBase, @mensaje2   

	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		   INSERT INTO Mensaje_Bitacora (idBase,idIdioma,mensaje) VALUES
									      (@idBase,@idNuevoIdioma,@mensaje2)

		   FETCH NEXT FROM curBitacora INTO @idBase, @mensaje2    
	END   

	CLOSE curBitacora   
	DEALLOCATE curBitacora
	
	
	--CONTROLES
    
    DECLARE @idControl INTEGER
	DECLARE @mensaje3 VARCHAR(100)
	
	DECLARE curControl CURSOR FOR 
	SELECT mensaje, idControl
	FROM MensajeControl 
	WHERE idIdioma = @base
	
	OPEN curControl   
	FETCH NEXT FROM curControl INTO @mensaje3, @idControl   

	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		   INSERT INTO MensajeControl (mensaje,idIdioma,idControl) VALUES
									      (@mensaje3,@idNuevoIdioma,@idControl)

		   FETCH NEXT FROM curControl INTO @mensaje3, @idControl      
	END   

	CLOSE curControl   
	DEALLOCATE curControl
	
END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_PERMISOS_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_PERMISOS_FAMILIA_SP]
@idFamilia INTEGER,
@idPermiso INTEGER

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT OFF;
	
    -- Insert statements for procedure here
    INSERT INTO Familia_Permiso (idFamilia,idPermiso) VALUES (@idFamilia,@idPermiso);
   
    
END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_USUARIO_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[LOGIN_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTAR_USUARIOS_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[REMOVER_USUARIO_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[INSERTAR_USUARIO_FAMILIA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[INSERTAR_BITACORA_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[CHECK_FAMILIA_ASOCIACION_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_FAMILIAS_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_BITACORAS_SP]    Script Date: 10/09/2012 00:20:41 ******/
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
/****** Object:  Default [DF_Control_idFormulario]    Script Date: 10/09/2012 00:20:40 ******/
ALTER TABLE [dbo].[Control] ADD  CONSTRAINT [DF_Control_idFormulario]  DEFAULT ((1)) FOR [idFormulario]
GO
/****** Object:  Default [DF_Usuario_activo]    Script Date: 10/09/2012 00:20:40 ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_activo]  DEFAULT ((1)) FOR [activo]
GO
/****** Object:  Default [DF_MensajeControl_idControl]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[MensajeControl] ADD  CONSTRAINT [DF_MensajeControl_idControl]  DEFAULT ((1)) FOR [idControl]
GO
/****** Object:  ForeignKey [FK_Usuario_Idioma]    Script Date: 10/09/2012 00:20:40 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
/****** Object:  ForeignKey [FK_MensajeControl_Control]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[MensajeControl]  WITH CHECK ADD  CONSTRAINT [FK_MensajeControl_Control] FOREIGN KEY([idControl])
REFERENCES [dbo].[Control] ([identificador])
GO
ALTER TABLE [dbo].[MensajeControl] CHECK CONSTRAINT [FK_MensajeControl_Control]
GO
/****** Object:  ForeignKey [FK_MensajeControl_Idioma]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[MensajeControl]  WITH CHECK ADD  CONSTRAINT [FK_MensajeControl_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[MensajeControl] CHECK CONSTRAINT [FK_MensajeControl_Idioma]
GO
/****** Object:  ForeignKey [FK_Mensaje_Bitacora_Idioma]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Mensaje_Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Mensaje_Bitacora_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[Mensaje_Bitacora] CHECK CONSTRAINT [FK_Mensaje_Bitacora_Idioma]
GO
/****** Object:  ForeignKey [FK_Mensaje_Bitacora_Mensaje_Base_Bitacora]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Mensaje_Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Mensaje_Bitacora_Mensaje_Base_Bitacora] FOREIGN KEY([idBase])
REFERENCES [dbo].[Mensaje_Base_Bitacora] ([identificador])
GO
ALTER TABLE [dbo].[Mensaje_Bitacora] CHECK CONSTRAINT [FK_Mensaje_Bitacora_Mensaje_Base_Bitacora]
GO
/****** Object:  ForeignKey [FK_Excepcion_Mensaje_Excepcion]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Excepcion_Mensaje]  WITH CHECK ADD  CONSTRAINT [FK_Excepcion_Mensaje_Excepcion] FOREIGN KEY([idExcepcion])
REFERENCES [dbo].[Excepcion] ([identificador])
GO
ALTER TABLE [dbo].[Excepcion_Mensaje] CHECK CONSTRAINT [FK_Excepcion_Mensaje_Excepcion]
GO
/****** Object:  ForeignKey [FK_Excepcion_Mensaje_Idioma]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Excepcion_Mensaje]  WITH CHECK ADD  CONSTRAINT [FK_Excepcion_Mensaje_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[Excepcion_Mensaje] CHECK CONSTRAINT [FK_Excepcion_Mensaje_Idioma]
GO
/****** Object:  ForeignKey [FK_Familia_Permiso_Familia]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Familia_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Permiso_Familia] FOREIGN KEY([idFamilia])
REFERENCES [dbo].[Familia] ([identificador])
GO
ALTER TABLE [dbo].[Familia_Permiso] CHECK CONSTRAINT [FK_Familia_Permiso_Familia]
GO
/****** Object:  ForeignKey [FK_Familia_Permiso_Permiso]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Familia_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Permiso_Permiso] FOREIGN KEY([idPermiso])
REFERENCES [dbo].[Permiso] ([identificador])
GO
ALTER TABLE [dbo].[Familia_Permiso] CHECK CONSTRAINT [FK_Familia_Permiso_Permiso]
GO
/****** Object:  ForeignKey [FK_Usuario_Familia_Familia]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia_Familia] FOREIGN KEY([idFamilia])
REFERENCES [dbo].[Familia] ([identificador])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK_Usuario_Familia_Familia]
GO
/****** Object:  ForeignKey [FK_Usuario_Familia_Usuario]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK_Usuario_Familia_Usuario]
GO
/****** Object:  ForeignKey [FK_Bitacora_Mensaje_Base_Bitacora]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Mensaje_Base_Bitacora] FOREIGN KEY([idMensajeBase])
REFERENCES [dbo].[Mensaje_Base_Bitacora] ([identificador])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Mensaje_Base_Bitacora]
GO
/****** Object:  ForeignKey [FK_Bitacora_Usuario]    Script Date: 10/09/2012 00:20:41 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
