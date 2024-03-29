CREATE DATABASE CoffeShop
USE [CoffeShop]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 9/24/2019 11:53:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ID], [Name], [Price]) VALUES (1, N'BLACK', 120)
INSERT [dbo].[Items] ([ID], [Name], [Price]) VALUES (2, N'Regular', 80)
SET IDENTITY_INSERT [dbo].[Items] OFF
