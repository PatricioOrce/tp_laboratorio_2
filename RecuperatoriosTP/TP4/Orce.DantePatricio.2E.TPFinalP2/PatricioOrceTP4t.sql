USE [master]
GO
/****** Object:  Database [TP4PatricioOrce]    Script Date: 22/11/2021 13:00:52 ******/
CREATE DATABASE [TP4PatricioOrce]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4PatricioOrce', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4PatricioOrce.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4PatricioOrce_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4PatricioOrce_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4PatricioOrce] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4PatricioOrce].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4PatricioOrce] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TP4PatricioOrce] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4PatricioOrce] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4PatricioOrce] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TP4PatricioOrce] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4PatricioOrce] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP4PatricioOrce] SET  MULTI_USER 
GO
ALTER DATABASE [TP4PatricioOrce] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4PatricioOrce] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4PatricioOrce] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4PatricioOrce] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4PatricioOrce] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4PatricioOrce] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP4PatricioOrce] SET QUERY_STORE = OFF
GO
USE [TP4PatricioOrce]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 22/11/2021 13:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[edad] [int] NULL,
	[genero] [tinyint] NULL,
	[sector] [tinyint] NULL,
	[turno] [tinyint] NULL,
	[orientacion] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[nombre] ASC,
	[apellido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Adrian', N'Pugliese', 12, 2, 0, 1, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Agostina', N'Orce', 26, 1, 1, 2, 3)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Agustina', N'Prandi', 20, 1, 1, 1, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Alejandro', N'Ledesma', 11, 0, 0, 2, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Belen', N'DeJerusalen', 18, 2, 1, 1, 2)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Camila', N'Baez', 14, 1, 0, 0, 0)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Carolina', N'Extermidad', 17, 1, 1, 1, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Estevan', N'Quito', 11, 0, 0, 2, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Ezequiel', N'Cuticula', 22, 1, 1, 2, 3)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Facundo', N'Careri', 22, 0, 1, 1, 2)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Federico', N'Oggioni', 20, 0, 1, 2, 2)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Fermin', N'Garcia', 10, 0, 0, 0, 0)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Fito', N'Paez', 44, 0, 1, 2, 3)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Florencia', N'Prados', 19, 1, 0, 0, 2)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Francisco', N'Firulais', 9, 0, 0, 0, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Gabriel', N'Lopez', 19, 0, 1, 1, 0)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Hernesto', N'Giggliotti', 17, 0, 1, 1, 0)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Juan', N'Dinosaurio', 10, 0, 0, 1, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Julian', N'Scarlato', 21, 0, 0, 2, 3)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Justin', N'Bibero', 9, 2, 0, 0, 0)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Kaleb', N'Dimasi', 22, 0, 1, 2, 2)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Lucas', N'Martinez', 26, 2, 1, 2, 0)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Ludmila', N'Polimorfismo', 16, 1, 1, 0, 2)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Mauricio', N'Marfil', 13, 0, 0, 1, 3)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Micaela', N'Lassos', 13, 1, 0, 1, 1)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Patricio', N'Orce', 20, 0, 1, 0, 0)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Pedro', N'FrapucchinoDeDLL', 16, 0, 1, 0, 3)
INSERT [dbo].[Alumnos] ([nombre], [apellido], [edad], [genero], [sector], [turno], [orientacion]) VALUES (N'Pedro', N'Ramirez', 12, 2, 0, 0, 1)
GO
USE [master]
GO
ALTER DATABASE [TP4PatricioOrce] SET  READ_WRITE 
GO
