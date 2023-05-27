USE [pruebadb]
GO

/****** Object:  Table [dbo].[Trabajo]    Script Date: 27/5/2023 01:12:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Trabajo](
	[idtrabajo] [int] IDENTITY(1,1) NOT NULL,
	[titulotrabajo] [varchar](50) NULL,
	[nombreempresa] [varchar](50) NULL,
	[ubicacion] [varchar](50) NULL,
	[tipotrabajo] [varchar](50) NULL,
	[fechapublicacion] [varchar](50) NULL,
	[salario] [decimal](5, 2) NULL,
	[nivelexperiencia] [varchar](50) NULL,
	[sectorlaboral] [varchar](50) NULL,
	[tipocontrato] [varchar](50) NULL,
 CONSTRAINT [PK_Trabajo] PRIMARY KEY CLUSTERED 
(
	[idtrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
