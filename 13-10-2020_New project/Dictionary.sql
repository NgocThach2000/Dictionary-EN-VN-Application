USE [Dictionary]
GO
/****** Object:  Table [dbo].[ListWord]    Script Date: 10/13/2020 8:36:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListWord](
	[idword] [int] IDENTITY(1,1) NOT NULL,
	[English] [nvarchar](100) NULL,
	[VNShort] [nvarchar](100) NULL,
	[VNLong] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idword] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 10/13/2020 8:36:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[username] [nvarchar](100) NOT NULL,
	[pass] [nvarchar](100) NULL,
	[permission] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLikeWord]    Script Date: 10/13/2020 8:36:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLikeWord](
	[username] [nvarchar](100) NULL,
	[id] [int] NULL,
	[English] [nvarchar](100) NULL,
	[VNShort] [nvarchar](100) NULL,
	[VNLong] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ListWord] ON 

INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (13, N'sdaas', N'asd', N'asd')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (14, N'sdaas', N'asd', N'asd')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (15, N'asdfds', N'asdfdhdfh', N'asd')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (1003, N'love', N'love you', N'love you forerver')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (1004, N'sdaas', N'asd', N'asd')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (1005, N'sdaas', N'asd', N'asd')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (1006, N'sdaas', N'asd', N'asd')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (1007, N'sdaas', N'asd', N'asd')
INSERT [dbo].[ListWord] ([idword], [English], [VNShort], [VNLong]) VALUES (1008, N'sdaas', N'asd', N'asd')
SET IDENTITY_INSERT [dbo].[ListWord] OFF
GO
INSERT [dbo].[UserInfo] ([username], [pass], [permission]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[UserInfo] ([username], [pass], [permission]) VALUES (N'ki', N'kiki', 2)
INSERT [dbo].[UserInfo] ([username], [pass], [permission]) VALUES (N'user', N'1', 2)
GO
