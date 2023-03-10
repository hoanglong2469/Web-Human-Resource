USE [master]
GO
/****** Object:  Database [QLNV]    Script Date: 12/26/2022 12:35:59 PM ******/
CREATE DATABASE [QLNV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNV', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLNV.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLNV_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLNV_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLNV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLNV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNV] SET  MULTI_USER 
GO
ALTER DATABASE [QLNV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLNV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLNV]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/26/2022 12:35:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [nchar](50) NOT NULL,
	[UserName] [nchar](50) NOT NULL,
	[Password] [nchar](50) NULL,
	[Email] [nchar](50) NULL,
	[Tel] [nchar](50) NULL,
	[Disabled] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID001                                             ', N'Long                                              ', N'132434325                                         ', N'long@gmail                                        ', N'0123456789                                        ', NULL)
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID002                                             ', N'Long2                                             ', N'12345                                             ', N'long2@gmail                                       ', N'0123456799                                        ', NULL)
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID003                                             ', N'Long3                                             ', N'14324325                                          ', N'long4@gmail                                       ', N'0123456789                                        ', NULL)
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID004                                             ', N'Long4                                             ', N'1234                                              ', N'long5@gmail                                       ', N'0123456789                                        ', NULL)
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID005                                             ', N'Long                                              ', N'123456                                            ', N'long5@gmail                                       ', N'019304324                                         ', NULL)
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID006                                             ', N'Long                                              ', N'123                                               ', N'long5@gmail                                       ', N'0174823741                                        ', NULL)
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID007                                             ', N'Long                                              ', N'123                                               ', N'long5@gmail                                       ', N'0123456789                                        ', NULL)
INSERT [dbo].[NhanVien] ([Id], [UserName], [Password], [Email], [Tel], [Disabled]) VALUES (N'ID008                                             ', N'Long                                              ', N'123                                               ', N'long5@gmail                                       ', N'0123456789                                        ', NULL)
USE [master]
GO
ALTER DATABASE [QLNV] SET  READ_WRITE 
GO
