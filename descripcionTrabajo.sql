USE [pruebadb]
GO

/****** Object:  Table [dbo].[descripcionTrabajo]    Script Date: 27/5/2023 01:12:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[descripcionTrabajo](
	[id_descripcion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_trabajo] [varchar](50) NULL,
	[requisitos] [varchar](50) NULL,
	[beneficios] [varchar](50) NULL,
	[responsabilidades] [varchar](50) NULL,
	[comentarios] [varchar](50) NULL,
 CONSTRAINT [PK_descripcionTrabajo] PRIMARY KEY CLUSTERED 
(
	[id_descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
