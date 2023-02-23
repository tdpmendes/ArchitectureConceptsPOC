﻿USE [EFPoc]
GO

/****** Object:  Table [dbo].[Turma]    Script Date: 17/01/2023 22:22:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Turmas](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](150) NOT NULL,
	[dataCriacao] [datetime] NOT NULL,
	[operationId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Turma] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO