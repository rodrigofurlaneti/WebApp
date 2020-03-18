# Sistema de venda

[![N|Solid](https://raw.githubusercontent.com/diegoeis/tableless-static-images/master/2015/02/laravel-introducao.jpg)](https://nodesource.com/products/nsolid)

[![N|Solid](https://lh3.googleusercontent.com/proxy/41cPeVGm4w18PngNYY8HOfljvgbeqtQX8w_t-5OoBcmKLvWhZcdvbce7w_ALy_W-iGXwwQ51N2fLHiBG2LLyFzmVkwW4qewjguu7)](https://nodesource.com/products/nsolid)



[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)


### Sql


USE [estoque]
GO

/****** Object:  Table [dbo].[Cargo]    Script Date: 17/03/2020 23:37:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cargo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [estoque]
GO

/****** Object:  Table [dbo].[Categoria]    Script Date: 17/03/2020 23:38:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [estoque]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 17/03/2020 23:38:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](90) NOT NULL,
	[Cpf] [varchar](11) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Celular] [varchar](11) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [estoque]
GO

/****** Object:  Table [dbo].[Comanda]    Script Date: 17/03/2020 23:38:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Comanda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NULL,
	[Data] [varchar](50) NULL,
	[Status] [varchar](7) NULL,
 CONSTRAINT [PK_Comanda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [estoque]
GO

/****** Object:  Table [dbo].[Pagamento]    Script Date: 17/03/2020 23:39:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pagamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ComandaId] [int] NULL,
	[ValorTotal] [decimal](8, 2) NULL,
	[DataPagamento] [varchar](50) NULL,
 CONSTRAINT [PK_Pagamento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [estoque]
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 17/03/2020 23:39:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](90) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Valor] [decimal](8, 2) NOT NULL,
	[CodigoCategoria] [int] NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [estoque]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 17/03/2020 23:39:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](90) NULL,
	[Email] [varchar](30) NULL,
	[Senha] [varchar](20) NULL,
	[IdCargo] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [estoque]
GO

/****** Object:  Table [dbo].[Venda]    Script Date: 17/03/2020 23:40:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Venda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Data] [varchar](50) NULL,
	[UserNome] [varchar](50) NULL,
	[ComandaId] [int] NULL,
 CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [estoque]
GO

/****** Object:  Table [dbo].[VendaProduto]    Script Date: 17/03/2020 23:40:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VendaProduto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VendaId] [int] NULL,
	[ProdutoId] [int] NULL,
	[Quantidade] [int] NULL,
	[Valor] [decimal](8, 2) NULL,
 CONSTRAINT [PK_VendaProduto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

