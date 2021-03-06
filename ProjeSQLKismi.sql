USE [master]
GO
/****** Object:  Database [Db1]    Script Date: 11.11.2020 03:38:47 ******/
CREATE DATABASE [Db1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Db1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Db1.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Db1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Db1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Db1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Db1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Db1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Db1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Db1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Db1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Db1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Db1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Db1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Db1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Db1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Db1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Db1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Db1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Db1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Db1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Db1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Db1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Db1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Db1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Db1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Db1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Db1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Db1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Db1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Db1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Db1] SET  MULTI_USER 
GO
ALTER DATABASE [Db1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Db1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Db1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Db1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Db1]
GO
/****** Object:  StoredProcedure [dbo].[Toplanti]    Script Date: 11.11.2020 03:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Toplanti]
as
select toplantiID,(yoneticiTablosu.ad+' '+yoneticiTablosu.soyad) as 'Yönetici', 
(personelTablosu.ad+' '+personelTablosu.soyad) as 'personel',tarih,saat,durum
from toplantiTablosu
inner join bolumlerTablosu
on
toplantiTablosu.bolumID=bolumlerTablosu.bolumID
inner join yoneticiTablosu
on
toplantiTablosu.yoneticiID=yoneticiTablosu.yoneticiID
inner join personelTablosu
on
toplantiTablosu.personelID=personelTablosu.personelID
GO
/****** Object:  StoredProcedure [dbo].[Toplantim]    Script Date: 11.11.2020 03:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Toplantim]
as
select toplantiID,(yoneticiTablosu.ad+' '+yoneticiTablosu.soyad) as 'Yönetici', 
tarih,saat,durum
from toplantiTablosu
inner join bolumlerTablosu
on
toplantiTablosu.bolumID=bolumlerTablosu.bolumID
inner join yoneticiTablosu
on
toplantiTablosu.yoneticiID=yoneticiTablosu.yoneticiID

GO
/****** Object:  Table [dbo].[bolumlerTablosu]    Script Date: 11.11.2020 03:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bolumlerTablosu](
	[bolumID] [smallint] IDENTITY(1,1) NOT NULL,
	[bolumSorumlusuAdSoyad] [varchar](50) NULL,
 CONSTRAINT [PK_bolumlerTablosu] PRIMARY KEY CLUSTERED 
(
	[bolumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personelTablosu]    Script Date: 11.11.2020 03:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personelTablosu](
	[personelID] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[foto] [varchar](100) NULL,
	[unvan] [varchar](20) NULL,
	[telefon] [varchar](15) NULL,
	[mail] [varchar](50) NULL,
 CONSTRAINT [PK_personelTablosu] PRIMARY KEY CLUSTERED 
(
	[personelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[toplantiTablosu]    Script Date: 11.11.2020 03:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[toplantiTablosu](
	[toplantiID] [smallint] IDENTITY(1,1) NOT NULL,
	[bolumID] [smallint] NULL,
	[yoneticiID] [smallint] NULL,
	[personelID] [smallint] NULL,
	[tarih] [varchar](12) NULL,
	[saat] [char](5) NULL,
	[durum] [bit] NULL,
 CONSTRAINT [PK_toplantiTablosu] PRIMARY KEY CLUSTERED 
(
	[toplantiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[yoneticiTablosu]    Script Date: 11.11.2020 03:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[yoneticiTablosu](
	[yoneticiID] [smallint] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[bolumID] [smallint] NULL,
 CONSTRAINT [PK_yoneticiTablosu] PRIMARY KEY CLUSTERED 
(
	[yoneticiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[bolumlerTablosu] ON 

INSERT [dbo].[bolumlerTablosu] ([bolumID], [bolumSorumlusuAdSoyad]) VALUES (1, N'NazımDemir')
INSERT [dbo].[bolumlerTablosu] ([bolumID], [bolumSorumlusuAdSoyad]) VALUES (2, N'LaleKutlu')
INSERT [dbo].[bolumlerTablosu] ([bolumID], [bolumSorumlusuAdSoyad]) VALUES (3, N'SerpilYılmaz')
INSERT [dbo].[bolumlerTablosu] ([bolumID], [bolumSorumlusuAdSoyad]) VALUES (4, N'CemilTekin')
INSERT [dbo].[bolumlerTablosu] ([bolumID], [bolumSorumlusuAdSoyad]) VALUES (5, N'ŞerifYıldız')
INSERT [dbo].[bolumlerTablosu] ([bolumID], [bolumSorumlusuAdSoyad]) VALUES (6, N'PelinKaya')
INSERT [dbo].[bolumlerTablosu] ([bolumID], [bolumSorumlusuAdSoyad]) VALUES (7, N'SelçukBulut')
SET IDENTITY_INSERT [dbo].[bolumlerTablosu] OFF
SET IDENTITY_INSERT [dbo].[personelTablosu] ON 

INSERT [dbo].[personelTablosu] ([personelID], [ad], [soyad], [foto], [unvan], [telefon], [mail]) VALUES (1, N'eyüp', N'kılıç', NULL, N'stajyer', N'5321113322', N'eyuppp@hotmail.com')
INSERT [dbo].[personelTablosu] ([personelID], [ad], [soyad], [foto], [unvan], [telefon], [mail]) VALUES (2, N'semra', N'çelik', NULL, N'sekreter', N'5321115522', N'semraaa@hotmail.com')
INSERT [dbo].[personelTablosu] ([personelID], [ad], [soyad], [foto], [unvan], [telefon], [mail]) VALUES (6, N'mehmet', N'aslan', NULL, N'yazılım mühendisi', N'5365554411', N'mehmet222@hotmail.com')
INSERT [dbo].[personelTablosu] ([personelID], [ad], [soyad], [foto], [unvan], [telefon], [mail]) VALUES (7, N'osman', N'kutlu', NULL, N'stajyer', N'(555) 555-5555', N'osmanKutluuu@gmail.com')
SET IDENTITY_INSERT [dbo].[personelTablosu] OFF
SET IDENTITY_INSERT [dbo].[toplantiTablosu] ON 

INSERT [dbo].[toplantiTablosu] ([toplantiID], [bolumID], [yoneticiID], [personelID], [tarih], [saat], [durum]) VALUES (1, 3, 1, NULL, N'15.09.2020', N'14:00', NULL)
INSERT [dbo].[toplantiTablosu] ([toplantiID], [bolumID], [yoneticiID], [personelID], [tarih], [saat], [durum]) VALUES (2, 2, 4, NULL, N'16.09.2020', N'15:00', NULL)
INSERT [dbo].[toplantiTablosu] ([toplantiID], [bolumID], [yoneticiID], [personelID], [tarih], [saat], [durum]) VALUES (3, 5, 8, NULL, N'12.09.2020', N'09:30', NULL)
INSERT [dbo].[toplantiTablosu] ([toplantiID], [bolumID], [yoneticiID], [personelID], [tarih], [saat], [durum]) VALUES (4, 3, 5, NULL, N'19.09.2020', N'10:15', NULL)
SET IDENTITY_INSERT [dbo].[toplantiTablosu] OFF
SET IDENTITY_INSERT [dbo].[yoneticiTablosu] ON 

INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (1, N'emel', N'aslan', 1)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (2, N'sami', N'kılıç', 1)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (3, N'mustafa', N'şekerci', 2)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (4, N'ahmet', N'kaşıkçı', 2)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (5, N'tarık', N'kutlu', 3)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (6, N'ayşe', N'gezgin', 4)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (7, N'beyza', N'kartal', 5)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (8, N'nuri', N'şahin', 5)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (9, N'arda', N'çolak', 6)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (10, N'pelin', N'ince', 6)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (11, N'özge', N'güzel', 7)
INSERT [dbo].[yoneticiTablosu] ([yoneticiID], [ad], [soyad], [bolumID]) VALUES (12, N'yeşim', N'kızıl', 3)
SET IDENTITY_INSERT [dbo].[yoneticiTablosu] OFF
ALTER TABLE [dbo].[toplantiTablosu]  WITH CHECK ADD  CONSTRAINT [FK_toplantiTablosu_bolumlerTablosu] FOREIGN KEY([bolumID])
REFERENCES [dbo].[bolumlerTablosu] ([bolumID])
GO
ALTER TABLE [dbo].[toplantiTablosu] CHECK CONSTRAINT [FK_toplantiTablosu_bolumlerTablosu]
GO
ALTER TABLE [dbo].[toplantiTablosu]  WITH CHECK ADD  CONSTRAINT [FK_toplantiTablosu_personelTablosu] FOREIGN KEY([personelID])
REFERENCES [dbo].[personelTablosu] ([personelID])
GO
ALTER TABLE [dbo].[toplantiTablosu] CHECK CONSTRAINT [FK_toplantiTablosu_personelTablosu]
GO
ALTER TABLE [dbo].[toplantiTablosu]  WITH CHECK ADD  CONSTRAINT [FK_toplantiTablosu_yoneticiTablosu] FOREIGN KEY([yoneticiID])
REFERENCES [dbo].[yoneticiTablosu] ([yoneticiID])
GO
ALTER TABLE [dbo].[toplantiTablosu] CHECK CONSTRAINT [FK_toplantiTablosu_yoneticiTablosu]
GO
ALTER TABLE [dbo].[yoneticiTablosu]  WITH CHECK ADD  CONSTRAINT [FK_yoneticiTablosu_bolumlerTablosu] FOREIGN KEY([bolumID])
REFERENCES [dbo].[bolumlerTablosu] ([bolumID])
GO
ALTER TABLE [dbo].[yoneticiTablosu] CHECK CONSTRAINT [FK_yoneticiTablosu_bolumlerTablosu]
GO
USE [master]
GO
ALTER DATABASE [Db1] SET  READ_WRITE 
GO
