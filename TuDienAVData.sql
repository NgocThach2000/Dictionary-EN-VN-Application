
/****** Object:  Table [dbo].[Login]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[permission] [int] NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TuDienAV]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuDienAV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[English] [nvarchar](100) NULL,
	[ShortVN] [nvarchar](100) NULL,
	[VN] [nvarchar](max) NULL,
 CONSTRAINT [PK_TuDienAV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_information]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_information](
	[username] [nvarchar](50) NOT NULL,
	[ID] [int] NULL,
	[English] [nvarchar](100) NULL,
	[ShortVN] [nvarchar](100) NULL,
	[VN] [nvarchar](100) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'', N'', NULL)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'ád', N'sad', NULL)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'ádds', N'', 2)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'ailapronam2010', N'kiprao123', NULL)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'ailapronam201022', N'kiprao123', 2)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'asd', N'sd', NULL)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'asdasd', N'asd', NULL)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'asdsa', N'asd', NULL)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'luanml', N'1', 2)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'nguyencongkhoi', N'123', 2)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'phuc', N'phuc', 2)
INSERT [dbo].[Login] ([username], [password], [permission]) VALUES (N'user', N'1', 2)
INSERT [dbo].[User_information] ([username], [ID], [English], [ShortVN], [VN]) VALUES (N'ád', 3, N'2', N'2', N'c')
INSERT [dbo].[User_information] ([username], [ID], [English], [ShortVN], [VN]) VALUES (N'asd', 3, N'a', N'b', N'c')
INSERT [dbo].[User_information] ([username], [ID], [English], [ShortVN], [VN]) VALUES (N'luanml', 3, N'2', N'2', N'c')
INSERT [dbo].[User_information] ([username], [ID], [English], [ShortVN], [VN]) VALUES (N'nguyencongkhoi', NULL, N'2', N'2', N'c')
ALTER TABLE [dbo].[User_information]  WITH CHECK ADD  CONSTRAINT [FK_User_information_Login] FOREIGN KEY([username])
REFERENCES [dbo].[Login] ([username])
GO
ALTER TABLE [dbo].[User_information] CHECK CONSTRAINT [FK_User_information_Login]
GO
/****** Object:  StoredProcedure [dbo].[Login_Select]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Login_Select]
	@user nvarchar(50),
	@pass nvarchar(50)
as



SELECT [username]
      ,[password]
      ,[permission]
  FROM [dbo].[Login]
  WHERE @user=[username]
	and @pass=[password]
GO
/****** Object:  StoredProcedure [dbo].[Login_Them]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Login_Them]
			@username nvarchar(50),
			@password nvarchar(50) ,
			@permission int 
as

INSERT INTO [dbo].[Login]
           ([username]
           ,[password]
		   ,[permission]
           )
     VALUES
           (@username
		   ,@password
		   ,@permission
		   )
GO
/****** Object:  StoredProcedure [dbo].[TuDien_Select]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TuDien_Select]
as

SELECT [ID]
      ,[English]
      ,[ShortVN]
      ,[VN]
  FROM [dbo].[TuDienAV]

GO
/****** Object:  StoredProcedure [dbo].[TuDien_Select_user]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDien_Select_user]
		
as

SELECT [username]
      ,[ID]
      ,[English]
      ,[ShortVN]
      ,[VN]
  FROM [dbo].[User_information]
GO
/****** Object:  StoredProcedure [dbo].[TuDien_Sua]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDien_Sua]	
			@ID nvarchar(50)
			,@English nvarchar(100)
			,@ShortVN nvarchar(100)
			,@VN nvarchar(max)

as
			

UPDATE [dbo].[TuDienAV]
   SET [ID] = @ID
      ,[English] = @English
      ,[ShortVN] = @ShortVN
      ,[VN] = @VN
 WHERE [ID]=@ID


GO
/****** Object:  StoredProcedure [dbo].[TuDien_Them_user]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDien_Them_user]
			@username nvarchar(50)
			,@ID nvarchar(50)
           ,@English nvarchar(100)
           ,@ShortVN nvarchar(100)
           ,@VN nvarchar(100)
as

INSERT INTO [dbo].[User_information]
           (	
		   [username]	   
           ,[English]
           ,[ShortVN]
           ,[VN])
     VALUES
			(	
			@username		
          , @English 
           ,@ShortVN 
           ,@VN )
GO
/****** Object:  StoredProcedure [dbo].[TuDien_Them1]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDien_Them1]
			
			@English nvarchar(100)
			,@ShortVN nvarchar(100)
			,@VN nvarchar(max)
			
as	

INSERT INTO [dbo].[TuDienAV]
           (
           [English]
           ,[ShortVN]
           ,[VN])
     VALUES
           (
		   @English
		   ,@ShortVN
		   ,@VN)
GO
/****** Object:  StoredProcedure [dbo].[TuDien_TraTu]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDien_TraTu]
@eng nvarchar(50)
as


SELECT [ID]
      ,[English]
      ,[ShortVN]
      ,[VN]
  FROM [dbo].[TuDienAV]
	where [English]=@eng
GO
/****** Object:  StoredProcedure [dbo].[TuDIen_TraTu_user]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDIen_TraTu_user]
@user nvarchar(50)
as

SELECT [username]
      ,[ID]
      ,[English]
      ,[ShortVN]
      ,[VN]
  FROM [dbo].[User_information]
  where [username]=@user
GO
/****** Object:  StoredProcedure [dbo].[TuDien_Xoa]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDien_Xoa]
@ID nvarchar(50)
as
DELETE FROM [dbo].[TuDienAV]
      WHERE [ID]=@ID
GO
/****** Object:  StoredProcedure [dbo].[User_information_xoa]    Script Date: 9/19/2020 11:18:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[User_information_xoa]
			@eng nvarchar(50)
as
DELETE FROM [dbo].[User_information]
      WHERE [English]=@eng
GO
