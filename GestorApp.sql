USE [master]
GO
/****** Object:  Database [GestorApp]    Script Date: 26/11/2021 09:09:56 p.m. ******/
CREATE DATABASE [GestorApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestorApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GestorApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestorApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GestorApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GestorApp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestorApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestorApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestorApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestorApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestorApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestorApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestorApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestorApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestorApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestorApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestorApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestorApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestorApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestorApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestorApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestorApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestorApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestorApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestorApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestorApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestorApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestorApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestorApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestorApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestorApp] SET  MULTI_USER 
GO
ALTER DATABASE [GestorApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestorApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestorApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestorApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestorApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestorApp] SET QUERY_STORE = OFF
GO
USE [GestorApp]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Mail] [nvarchar](150) NULL,
	[Phone] [nvarchar](150) NULL,
	[Card] [nvarchar](150) NULL,
	[Photo] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Keep]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Keep](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPatients] [int] NULL,
	[IdDoctor] [int] NULL,
	[Date] [datetime] NULL,
	[Reason] [nvarchar](150) NULL,
	[State] [int] NULL,
 CONSTRAINT [PK_Keep] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KeepStatus]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeepStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_KeepStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[Phone] [nvarchar](150) NULL,
	[Address] [nvarchar](150) NULL,
	[Card] [nvarchar](150) NULL,
	[Date_Birth] [datetime] NULL,
	[Smoker] [bit] NULL,
	[Allergies] [nvarchar](150) NULL,
	[Photo] [nvarchar](150) NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultLab]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultLab](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPatients] [int] NULL,
	[IdKeep] [int] NULL,
	[IdLabTest] [int] NULL,
	[IdDoctor] [int] NULL,
	[ResltTest] [nvarchar](150) NULL,
	[StateResult] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResultStatus]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Smoker]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Smoker](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Result] [nvarchar](50) NULL,
 CONSTRAINT [PK_Smoker] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestLab]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestLab](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[LastName] [nvarchar](150) NOT NULL,
	[Mail] [nvarchar](150) NOT NULL,
	[UserName] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](150) NOT NULL,
	[TypeUser] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 26/11/2021 09:09:56 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Smoker]  WITH CHECK ADD  CONSTRAINT [FK_Smoker_Patients] FOREIGN KEY([Id])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Smoker] CHECK CONSTRAINT [FK_Smoker_Patients]
GO
USE [master]
GO
ALTER DATABASE [GestorApp] SET  READ_WRITE 
GO
