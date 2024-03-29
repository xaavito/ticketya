USE [TicketYa]
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 09/14/2012 00:16:14 ******/
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
SET IDENTITY_INSERT [dbo].[Familia] OFF
/****** Object:  Table [dbo].[Permiso]    Script Date: 09/14/2012 00:16:14 ******/
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
SET IDENTITY_INSERT [dbo].[Permiso] OFF
/****** Object:  Table [dbo].[Idioma]    Script Date: 09/14/2012 00:16:14 ******/
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
/****** Object:  Table [dbo].[Usuario_Permiso]    Script Date: 09/14/2012 00:16:14 ******/
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
/****** Object:  StoredProcedure [dbo].[LISTAR_IDIOMAS_SP]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_IDIOMA_SP]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 09/14/2012 00:16:15 ******/
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
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [apellido], [usr], [pass], [idIdioma]) VALUES (1, N'Jose', N'Gonzalez', N'jose', N'89hmK6Wu4mcKo+h7D2xVUg==', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Familia_Permiso]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  Table [dbo].[MensajeControl]    Script Date: 09/14/2012 00:16:15 ******/
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
SET IDENTITY_INSERT [dbo].[MensajeControl] OFF
/****** Object:  StoredProcedure [dbo].[LOGIN_SP]    Script Date: 09/14/2012 00:16:15 ******/
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
	AND u.pass = @pass;
END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PERMISO_PERSONA_SP]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_PERMISO_FAMILIA_SP]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_MENSAJES_SP]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  Table [dbo].[Usuario_Familia]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  StoredProcedure [dbo].[BUSCAR_FAMILIAS_SP]    Script Date: 09/14/2012 00:16:15 ******/
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
/****** Object:  ForeignKey [FK_Usuario_Idioma]    Script Date: 09/14/2012 00:16:15 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
/****** Object:  ForeignKey [FK_Familia_Permiso_Familia]    Script Date: 09/14/2012 00:16:15 ******/
ALTER TABLE [dbo].[Familia_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Permiso_Familia] FOREIGN KEY([idFamilia])
REFERENCES [dbo].[Familia] ([identificador])
GO
ALTER TABLE [dbo].[Familia_Permiso] CHECK CONSTRAINT [FK_Familia_Permiso_Familia]
GO
/****** Object:  ForeignKey [FK_Familia_Permiso_Permiso]    Script Date: 09/14/2012 00:16:15 ******/
ALTER TABLE [dbo].[Familia_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Permiso_Permiso] FOREIGN KEY([idPermiso])
REFERENCES [dbo].[Permiso] ([identificador])
GO
ALTER TABLE [dbo].[Familia_Permiso] CHECK CONSTRAINT [FK_Familia_Permiso_Permiso]
GO
/****** Object:  ForeignKey [FK_MensajeControl_Idioma]    Script Date: 09/14/2012 00:16:15 ******/
ALTER TABLE [dbo].[MensajeControl]  WITH CHECK ADD  CONSTRAINT [FK_MensajeControl_Idioma] FOREIGN KEY([idIdioma])
REFERENCES [dbo].[Idioma] ([identificador])
GO
ALTER TABLE [dbo].[MensajeControl] CHECK CONSTRAINT [FK_MensajeControl_Idioma]
GO
/****** Object:  ForeignKey [FK_Usuario_Familia_Familia]    Script Date: 09/14/2012 00:16:15 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia_Familia] FOREIGN KEY([idFamilia])
REFERENCES [dbo].[Familia] ([identificador])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK_Usuario_Familia_Familia]
GO
/****** Object:  ForeignKey [FK_Usuario_Familia_Usuario]    Script Date: 09/14/2012 00:16:15 ******/
ALTER TABLE [dbo].[Usuario_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Usuario_Familia] CHECK CONSTRAINT [FK_Usuario_Familia_Usuario]
GO
