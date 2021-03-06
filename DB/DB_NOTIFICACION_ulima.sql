/****** 
LE FALTAN MUCHAS VALIDACIONES, RELACIONES Y PROC Y TRIGGER
PERO COMO NO TUVE MUCHO TIEMPO NO SE LAS HICE..........
 ******/

CREATE DATABASE [NOTIFICACION]
GO
USE [NOTIFICACION]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 23-Oct-19 3:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 23-Oct-19 3:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 23-Oct-19 3:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[Estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstudianteCursos]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstudianteCursos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEstudiante] [int] NOT NULL,
	[IdCurso] [int] NOT NULL,
	[Nota] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[Apellido] [varchar](40) NOT NULL,
	[Cedula] [char](11) NOT NULL,
	[Telefono] [char](10) NOT NULL,
	[Fecha_N] [date] NOT NULL,
	[Genero] [char](1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 23-Oct-19 3:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [varchar](40) NOT NULL,
	[Pwd] [varchar](40) NOT NULL,
	[Estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'Administrador', N'A')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'Normal', N'Normal', N'N')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'Publicar', N'Publicar', N'p')
SET IDENTITY_INSERT [dbo].[AspNetUserRoles] ON 

INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId], [Id]) VALUES (N'a0a5d0af-809a-4d3b-bfd4-233463f6fad4', N'1', 1)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId], [Id]) VALUES (N'a0a5d0af-809a-4d3b-bfd4-233463f6fad4', N'2', 2)
SET IDENTITY_INSERT [dbo].[AspNetUserRoles] OFF
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a0a5d0af-809a-4d3b-bfd4-233463f6fad4', N'warlin_sano@gmail.com', N'WARLINSANO@GMAIL.COM', N'warlinsano@gmail.com', N'WARLINSANO@GMAIL.COM', 1, N'http://localhost:60440/Account/Register', N'KBNM6LOPTL2QT5AJBQGTQS7P4IO3OWE5', N'f1035810-d6eb-42ae-b898-7bb787da6c4a', NULL, 0, 0, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([Id], [Nombre], [Estado]) VALUES (1, N'SQL SERVER', N'H')
INSERT [dbo].[Cursos] ([Id], [Nombre], [Estado]) VALUES (2, N'PROGRAMACION C# ', N'H')
INSERT [dbo].[Cursos] ([Id], [Nombre], [Estado]) VALUES (3, N'PYTHON BASICO', N'H')
INSERT [dbo].[Cursos] ([Id], [Nombre], [Estado]) VALUES (4, N'HTML BASICO', N'D')
INSERT [dbo].[Cursos] ([Id], [Nombre], [Estado]) VALUES (5, N'JAVASCRIPT BASICO', N'H')
INSERT [dbo].[Cursos] ([Id], [Nombre], [Estado]) VALUES (6, N'PROGRAMACION C# BASICO', N'H')
INSERT [dbo].[Cursos] ([Id], [Nombre], [Estado]) VALUES (7, N'PROGRAMACION WEB CSS', N'D')
SET IDENTITY_INSERT [dbo].[Cursos] OFF
SET IDENTITY_INSERT [dbo].[Estudiantes] ON 

INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Cedula], [Telefono], [Fecha_N], [Genero], [Email], [Estado]) VALUES (1, N'WARLIN ANTONIO', N'SANO BAEZ', N'40225883368', N'8293290694', CAST(N'1997-06-23' AS Date), N'M', N'warlinsano@gmail.com', N'H')
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Cedula], [Telefono], [Fecha_N], [Genero], [Email], [Estado]) VALUES (3, N'ANDERSON E.', N'SANO B.', N'01000658128', N'8293692828', CAST(N'1995-01-14' AS Date), N'M', N'andysano@gmail.com', N'D')
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Cedula], [Telefono], [Fecha_N], [Genero], [Email], [Estado]) VALUES (4, N'PEDRO', N'PEREZ', N'01001126703', N'8293331111', CAST(N'2001-01-01' AS Date), N'M', N'P.Perez@gmail.com', N'H')
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Cedula], [Telefono], [Fecha_N], [Genero], [Email], [Estado]) VALUES (5, N'SONIA', N'MARTES CORDERO', N'40225332176', N'8098582558', CAST(N'1993-12-30' AS Date), N'F', N'sonia@gmail.com', N'D')
INSERT [dbo].[Estudiantes] ([Id], [Nombre], [Apellido], [Cedula], [Telefono], [Fecha_N], [Genero], [Email], [Estado]) VALUES (6, N'LUIS', N'PIE', N'00300729720', N'8495255255', CAST(N'2001-10-23' AS Date), N'M', N'pie@hotmail.com', N'H')
SET IDENTITY_INSERT [dbo].[Estudiantes] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Nombre_Usuario], [Pwd], [Estado]) VALUES (1, N'jhoanbaez', N'123456', N'A')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Cursos__75E3EFCF5476F8ED]    Script Date: 23-Oct-19 3:55:21 PM ******/
ALTER TABLE [dbo].[Cursos] ADD UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Estudian__B4ADFE38134D678E]    Script Date: 23-Oct-19 3:55:21 PM ******/
ALTER TABLE [dbo].[Estudiantes] ADD UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__57A4BD194B9595C2]    Script Date: 23-Oct-19 3:55:21 PM ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[Nombre_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
