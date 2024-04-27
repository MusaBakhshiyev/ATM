USE [master]
GO
/****** Object:  Database [ATM]    Script Date: 4/27/2024 4:47:11 PM ******/
CREATE DATABASE [ATM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ATM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ATM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ATM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ATM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ATM] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ATM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ATM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ATM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ATM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ATM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ATM] SET ARITHABORT OFF 
GO
ALTER DATABASE [ATM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ATM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ATM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ATM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ATM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ATM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ATM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ATM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ATM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ATM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ATM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ATM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ATM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ATM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ATM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ATM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ATM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ATM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ATM] SET  MULTI_USER 
GO
ALTER DATABASE [ATM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ATM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ATM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ATM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ATM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ATM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ATM] SET QUERY_STORE = ON
GO
ALTER DATABASE [ATM] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ATM]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 4/27/2024 4:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sender] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Recipient] [nvarchar](50) NOT NULL,
	[Amount] [int] NOT NULL,
	[Time] [datetime] NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/27/2024 4:47:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[CardNumber] [nvarchar](4) NOT NULL,
	[PIN] [nvarchar](4) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Balance] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[CardNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Transactions] ON 
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (3, N'1000', N'Deposit', N'1000', 1000, CAST(N'2024-04-10T14:58:44.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (4, N'1000', N'Deposit', N'1000', 200, CAST(N'2024-04-10T14:59:17.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (5, N'1001', N'Deposit', N'1001', 500, CAST(N'2024-04-11T08:58:17.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (6, N'1001', N'Transfer', N'1000', 100, CAST(N'2024-04-11T08:58:27.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (7, N'1000', N'Withdraw', N'1000', 800, CAST(N'2024-04-11T09:25:28.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (8, N'1000', N'Deposit', N'1000', 1000, CAST(N'2024-04-11T10:26:19.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (9, N'1000', N'Withdraw', N'1000', 1000, CAST(N'2024-04-11T10:26:28.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (10, N'1000', N'Transfer', N'1001', 1000, CAST(N'2024-04-11T10:26:48.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (11, N'1000', N'Transfer', N'1005', 1000, CAST(N'2024-04-11T10:27:16.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (12, N'1000', N'Deposit', N'1000', 500, CAST(N'2024-04-11T10:33:42.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (13, N'1000', N'Transfer', N'1001', 200, CAST(N'2024-04-11T10:35:08.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (14, N'1001', N'Transfer', N'1000', 500, CAST(N'2024-04-11T10:35:48.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (15, N'1000', N'Deposit', N'1000', 100, CAST(N'2024-04-15T09:32:09.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (16, N'1000', N'Withdraw', N'1000', 200, CAST(N'2024-04-15T09:32:19.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (17, N'1000', N'Transfer', N'1001', 200, CAST(N'2024-04-15T09:32:51.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (18, N'1000', N'Deposit', N'1000', 100, CAST(N'2024-04-15T13:33:03.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (19, N'1000', N'Transfer', N'1001', 500, CAST(N'2024-04-15T13:33:39.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (20, N'1000', N'Deposit', N'1000', 500, CAST(N'2024-04-15T14:28:39.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (21, N'1000', N'Withdraw', N'1000', 100, CAST(N'2024-04-15T14:28:57.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (22, N'1000', N'Transfer', N'1001', 200, CAST(N'2024-04-15T14:32:12.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1015, N'1000', N'Deposit', N'1000', 100, CAST(N'2024-04-23T23:50:02.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1016, N'1000', N'Withdraw', N'1000', 100, CAST(N'2024-04-23T23:50:08.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1017, N'1001', N'Transfer', N'1000', 200, CAST(N'2024-04-23T23:50:50.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1018, N'1000', N'Withdraw', N'1000', 100, CAST(N'2024-04-24T10:07:13.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1019, N'1000', N'Withdraw', N'1000', 100, CAST(N'2024-04-24T10:19:33.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1020, N'1000', N'Deposit', N'1000', 10, CAST(N'2024-04-24T10:19:52.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1021, N'1000', N'Deposit', N'1000', 110, CAST(N'2024-04-24T10:20:05.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1022, N'1000', N'Deposit', N'1000', 180, CAST(N'2024-04-24T10:20:13.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1023, N'1000', N'Transfer', N'1001', 210, CAST(N'2024-04-24T10:20:47.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1024, N'1000', N'Deposit', N'1000', 50, CAST(N'2024-04-24T10:26:52.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1025, N'1000', N'Deposit', N'1000', 30, CAST(N'2024-04-24T10:29:07.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1026, N'1000', N'Deposit', N'1000', 10, CAST(N'2024-04-24T10:31:13.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1027, N'1000', N'Transfer', N'1001', 100, CAST(N'2024-04-24T10:31:46.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1028, N'1000', N'Transfer', N'1001', 40, CAST(N'2024-04-24T10:31:54.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1029, N'1000', N'Transfer', N'1001', 20, CAST(N'2024-04-24T10:31:57.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1030, N'1000', N'Withdraw', N'1000', 100, CAST(N'2024-04-24T10:33:32.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1031, N'1000', N'Withdraw', N'1000', 100, CAST(N'2024-04-24T10:35:27.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1032, N'1000', N'Deposit', N'1000', 1000, CAST(N'2024-04-24T11:11:39.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1033, N'1002', N'Deposit', N'1002', 110, CAST(N'2024-04-24T13:28:53.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1034, N'1002', N'Transfer', N'1000', 70, CAST(N'2024-04-24T13:30:10.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1035, N'1002', N'Withdraw', N'1002', 30, CAST(N'2024-04-24T13:30:23.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1036, N'1003', N'Deposit', N'1003', 30, CAST(N'2024-04-24T13:35:28.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1037, N'1003', N'Transfer', N'1002', 20, CAST(N'2024-04-24T13:35:39.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1038, N'1007', N'Deposit', N'1007', 90, CAST(N'2024-04-24T14:39:03.000' AS DateTime))
GO
INSERT [dbo].[Transactions] ([Id], [Sender], [Type], [Recipient], [Amount], [Time]) VALUES (1039, N'1007', N'Transfer', N'1003', 20, CAST(N'2024-04-24T14:41:25.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Transactions] OFF
GO
INSERT [dbo].[Users] ([Name], [Surname], [CardNumber], [PIN], [PhoneNumber], [DateOfBirth], [Balance]) VALUES (N'Musa', N'Bakhshiyev', N'1000', N'2005', N'0559423512', CAST(N'2005-06-29' AS Date), 1190)
GO
INSERT [dbo].[Users] ([Name], [Surname], [CardNumber], [PIN], [PhoneNumber], [DateOfBirth], [Balance]) VALUES (N'Samir', N'Manafov', N'1001', N'2024', N'0771524862', CAST(N'2005-01-05' AS Date), 2220)
GO
INSERT [dbo].[Users] ([Name], [Surname], [CardNumber], [PIN], [PhoneNumber], [DateOfBirth], [Balance]) VALUES (N'nhst', N'ceferli', N'1002', N'2580', N'0506851530', CAST(N'2024-04-24' AS Date), 30)
GO
INSERT [dbo].[Users] ([Name], [Surname], [CardNumber], [PIN], [PhoneNumber], [DateOfBirth], [Balance]) VALUES (N'Nihat', N'Ceferli', N'1003', N'2005', N'0506851530', CAST(N'2005-04-08' AS Date), 30)
GO
INSERT [dbo].[Users] ([Name], [Surname], [CardNumber], [PIN], [PhoneNumber], [DateOfBirth], [Balance]) VALUES (N'Aytac', N'Meherremova', N'1007', N'2580', N'0506851530', CAST(N'2000-03-06' AS Date), 70)
GO
USE [master]
GO
ALTER DATABASE [ATM] SET  READ_WRITE 
GO
