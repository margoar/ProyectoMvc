USE [bdproyecto]
GO
/****** Object:  Table [dbo].[Adjunto]    Script Date: 06-06-2021 21:58:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Adjunto](
	[id] [int] NOT NULL,
	[Alumno_id] [int] NULL,
	[Archivo] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 06-06-2021 21:58:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumno](
	[id] [int] NOT NULL,
	[Nombre] [varchar](255) NULL,
	[Apellido] [varchar](255) NULL,
	[Sexo] [varchar](100) NULL,
	[FechaNacimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AlumnoCurso]    Script Date: 06-06-2021 21:58:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlumnoCurso](
	[id] [int] NOT NULL,
	[Alumno_id] [int] NULL,
	[Curso_id] [int] NULL,
	[Nota] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Curso]    Script Date: 06-06-2021 21:58:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curso](
	[id] [int] NOT NULL,
	[Nombre] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Adjunto]  WITH CHECK ADD FOREIGN KEY([Alumno_id])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[AlumnoCurso]  WITH CHECK ADD FOREIGN KEY([Alumno_id])
REFERENCES [dbo].[Alumno] ([id])
GO
ALTER TABLE [dbo].[AlumnoCurso]  WITH CHECK ADD FOREIGN KEY([Curso_id])
REFERENCES [dbo].[Curso] ([id])
GO
