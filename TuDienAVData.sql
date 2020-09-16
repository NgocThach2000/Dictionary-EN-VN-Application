USE [master]
GO
/****** Object:  Database [TuDienAVData]    Script Date: 9/16/2020 8:35:37 PM ******/
CREATE DATABASE [TuDienAVData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TuDienAVData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TuDienAVData.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TuDienAVData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TuDienAVData_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TuDienAVData] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TuDienAVData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TuDienAVData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TuDienAVData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TuDienAVData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TuDienAVData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TuDienAVData] SET ARITHABORT OFF 
GO
ALTER DATABASE [TuDienAVData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TuDienAVData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TuDienAVData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TuDienAVData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TuDienAVData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TuDienAVData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TuDienAVData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TuDienAVData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TuDienAVData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TuDienAVData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TuDienAVData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TuDienAVData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TuDienAVData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TuDienAVData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TuDienAVData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TuDienAVData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TuDienAVData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TuDienAVData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TuDienAVData] SET  MULTI_USER 
GO
ALTER DATABASE [TuDienAVData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TuDienAVData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TuDienAVData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TuDienAVData] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TuDienAVData] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TuDienAVData]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  Table [dbo].[TuDienAV]    Script Date: 9/16/2020 8:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuDienAV](
	[ID] [nvarchar](50) NOT NULL,
	[English] [nvarchar](100) NULL,
	[ShortVN] [nvarchar](100) NULL,
	[VN] [nvarchar](max) NULL,
 CONSTRAINT [PK_TuDienAV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_information]    Script Date: 9/16/2020 8:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_information](
	[username] [nvarchar](50) NOT NULL,
	[ID] [nvarchar](50) NULL,
	[English] [nvarchar](100) NULL,
	[ShortVN] [nvarchar](100) NULL,
	[VN] [nvarchar](100) NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[User_information]  WITH CHECK ADD  CONSTRAINT [FK_User_information_Login] FOREIGN KEY([username])
REFERENCES [dbo].[Login] ([username])
GO
ALTER TABLE [dbo].[User_information] CHECK CONSTRAINT [FK_User_information_Login]
GO
ALTER TABLE [dbo].[User_information]  WITH CHECK ADD  CONSTRAINT [FK_User_information_TuDienAV] FOREIGN KEY([ID])
REFERENCES [dbo].[TuDienAV] ([ID])
GO
ALTER TABLE [dbo].[User_information] CHECK CONSTRAINT [FK_User_information_TuDienAV]
GO
/****** Object:  StoredProcedure [dbo].[Login_Select]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Login_Them]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TuDien_Select]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TuDien_Select_user]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TuDien_Sua]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TuDien_Them_user]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TuDien_Them1]    Script Date: 9/16/2020 8:35:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TuDien_Them1]
			@ID nvarchar(50)
			,@English nvarchar(100)
			,@ShortVN nvarchar(100)
			,@VN nvarchar(max)
			
as	

INSERT INTO [dbo].[TuDienAV]
           ([ID]
           ,[English]
           ,[ShortVN]
           ,[VN])
     VALUES
           (@ID
		   ,@English
		   ,@ShortVN
		   ,@VN)

GO
/****** Object:  StoredProcedure [dbo].[TuDien_TraTu]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TuDIen_TraTu_user]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TuDien_Xoa]    Script Date: 9/16/2020 8:35:37 PM ******/
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
/****** Object:  StoredProcedure [dbo].[User_information_xoa]    Script Date: 9/16/2020 8:35:37 PM ******/
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
USE [master]
GO
ALTER DATABASE [TuDienAVData] SET  READ_WRITE 
GO
