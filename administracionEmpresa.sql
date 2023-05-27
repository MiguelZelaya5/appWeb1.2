USE [pruebadb]
GO

/****** Object:  Table [dbo].[administracionEmpresa]    Script Date: 27/5/2023 01:12:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[administracionEmpresa](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empresa] [varchar](50) NULL,
	[descripcion_empresa] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[mision] [varchar](50) NULL,
	[vision] [varchar](50) NULL,
	[trabajo] [varchar](50) NULL,
	[ubicacion] [varchar](50) NULL,
	[descripcion_trabajo] [varchar](50) NULL,
	[sueldo] [decimal](8, 2) NULL,
	[requisito] [varchar](50) NULL,
	[detalle_contacto] [varchar](50) NULL,
 CONSTRAINT [PK_administracionEmpresa] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
