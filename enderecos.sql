USE [AddressManager_Wilco]
GO

/****** Object:  Table [dbo].[Enderecos]    Script Date: 26/05/2024 17:03:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Enderecos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Logradouro] [nvarchar](80) NULL,
	[Complemento] [nvarchar](80) NULL,
	[Bairro] [nvarchar](80) NULL,
	[Cidade] [nvarchar](80) NULL,
	[UF] [nchar](3) NULL,
	[Cep] [nchar](10) NULL,
 CONSTRAINT [PK_Enderecos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

