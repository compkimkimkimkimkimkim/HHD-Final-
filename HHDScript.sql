/****** Object:  Database [HHD_db]    Script Date: 5/4/2024 2:34:01 pm ******/
CREATE DATABASE [HHD_db]  (EDITION = 'Standard', SERVICE_OBJECTIVE = 'S0', MAXSIZE = 250 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [HHD_db] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [HHD_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HHD_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HHD_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HHD_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HHD_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [HHD_db] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [HHD_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HHD_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HHD_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HHD_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HHD_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HHD_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HHD_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HHD_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HHD_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HHD_db] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [HHD_db] SET  MULTI_USER 
GO
ALTER DATABASE [HHD_db] SET ENCRYPTION ON
GO
ALTER DATABASE [HHD_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [HHD_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/****** Object:  Table [dbo].[AboutUs]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AboutUs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Images] [varchar](1000) NULL,
	[Name] [nvarchar](1000) NULL,
	[Major] [nvarchar](max) NULL,
	[Ambitions] [nvarchar](max) NULL,
	[AboutUsType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Community]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Community](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
	[Password] [nvarchar](16) NOT NULL,
	[Title] [nvarchar](512) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[CreationTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommunityCategory]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunityCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CommunityId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommunityCollection]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunityCollection](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CommunityId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommunityComment]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunityComment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CommunityId] [int] NOT NULL,
	[Username] [nvarchar](32) NOT NULL,
	[Password] [nvarchar](16) NOT NULL,
	[Content] [nvarchar](512) NOT NULL,
	[CreationTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommunityPicture]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunityPicture](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CommunityId] [int] NOT NULL,
	[Path] [nvarchar](512) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventLists]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventLists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EventPoster] [varchar](1000) NULL,
	[EventType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Home]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Home](
	[IdHome] [int] IDENTITY(1,1) NOT NULL,
	[Image] [varchar](255) NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](max) NULL,
	[category] [nvarchar](50) NULL,
	[Link] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[Rank] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHome] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LevelMary]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LevelMary](
	[name] [nvarchar](max) NULL,
	[filePath] [varchar](1000) NULL,
	[type] [int] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localtion]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localtion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LocaltionName] [nvarchar](1000) NULL,
	[LocaltionAddress] [nvarchar](1000) NULL,
	[LocaltionType] [int] NULL,
	[LineColour] [varchar](1000) NULL,
	[Distance] [float] NULL,
	[Minutes] [int] NULL,
	[BusNumbers] [varchar](1000) NULL,
	[Images] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerCommunity]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerCommunity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](3000) NULL,
	[Content] [nvarchar](4000) NULL,
	[ManagerCommunityType] [int] NULL,
 CONSTRAINT [PK_ManagerCommunity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orientation]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orientation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Images] [varchar](1000) NULL,
	[Name] [nvarchar](1000) NULL,
	[Rank] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[Title] [nvarchar](1000) NULL,
	[OrientationType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PSBC]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PSBC](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Images] [varchar](1000) NULL,
	[Name] [nvarchar](1000) NULL,
	[Content] [nvarchar](max) NULL,
	[Title] [nvarchar](1000) NULL,
	[PSBCType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentClub]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentClub](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Images] [varchar](1000) NULL,
	[Name] [nvarchar](1000) NULL,
	[Content] [nvarchar](max) NULL,
	[Link] [nvarchar](1000) NULL,
	[StudentClubType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TitleImage]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TitleImage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](1000) NOT NULL,
	[PageName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_TitleImage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UoN]    Script Date: 5/4/2024 2:34:02 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UoN](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Images] [varchar](1000) NULL,
	[Name] [nvarchar](1000) NULL,
	[Rank] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[Title] [nvarchar](1000) NULL,
	[UoNType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AboutUs] ON 
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (1, N'kimimg.png', N'Kim Sungyeon', N'Bachelor of Information Technology The University Of Newcastle, Australia', N'When I was in charge of the project, I was worried about whether I could complete it properly. Can I get the project done on time? Can the functions you imagined work properly?  In fact, there are still some fears even now that the project has progressed considerably. However, our group members are working hard on their respective parts, so we are trying to carry out the project with a little more confidence.  Please check the result of the completed project with your eyes :)', 1)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (2, N'krisimg1.png', N'Bui Ho Minh Tho', N'Bachelor of Information Technology The University Of Newcastle, Australia', N'Hello all new members as well as those studying at the University of Newcastle. My name is Bui Ho Minh Tho. I am currently a final year student at UON and am working on a project with 4 of our friends. At first, when we accepted this project and read through it, we found it very difficult and did not think it would be completed as expected. And then we almost completed it with all the efforts of our teammates. At first glance, the prototype may not seem good, but we hope you will look at it positively so we can constantly innovate and create. Thank you for reading :)))', 1)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (3, N'juntaoimg.png', N'Juntao Zhao', N'Bachelor of Information Technology The University Of Newcastle, Australia', N'When encountering difficulties or problems during the process, members help each other and successfully complete the task. This made me understand the importance of teamwork. We hold group meetings after class or on weekends, and the group leader checks the completion of each section and makes suggestions for improvement. This is the important role that leaders play in the team.', 1)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (5, N'doanimg1.png', N'Doan Tuan Minh', N'Bachelor of Information Technology The University Of Newcastle, Australia', N'Before starting the project, I was quite worried that my skills might slow down the team''s progress. But members help other and successfully complete all tasks, it made me more confidently. Moreover, building use case diagrams and er diagrams help me gain a deep understanding of the database and system structure.', 1)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (6, N'discord.png', N'Discord', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (7, N'asana.png', N'Asana', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (8, N'trello.png', N'Trello', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (9, N'msexcel.png', N'MS Excel', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (10, N'drawio.png', N'Draw.io', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (11, N'figma.png', N'Figma', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (12, N'vs2022.png', N'Visual Studio 2022', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (13, N'aspnet.png', N'C# ASP.NET', N'', N'', 2)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (14, N'aboutustitle.png', NULL, NULL, NULL, 3)
GO
INSERT [dbo].[AboutUs] ([id], [Images], [Name], [Major], [Ambitions], [AboutUsType]) VALUES (15, N'yirenimg2.png', N'Yiren Huang', N'Bachelor of Information Technology The University Of Newcastle, Australia', N'In the process of designing class diagram, I deeply understood the importance of system architecture. By building class diagrams, I learned how to effectively organize and present various classes, objects and their relationships in the project, and strengthened my understanding of the system structure. This experience taught me how to think and plan projects in a more systematic way, ensuring design scalability and flexibility.', 1)
GO
SET IDENTITY_INSERT [dbo].[AboutUs] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'SCHOOL')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'QUESTIONS')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'DISCUSS')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'JOB SEARCH')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (5, N'FOOD')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (6, N'PLACE')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (7, N'INFO SHARING')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (8, N'SOCIAL ACTIVITIES')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (9, N'Others')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (10, N'ADMIN')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Community] ON 
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1, N'KIMKIMKIM', N'123', N'How To Check My Attendance?
', 0, N'123', CAST(N'2024-02-11T08:00:00.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (3, N'hiiamadmin', N'11', N'thisisfirstpostinourcommunitypage!!!!!', 0, N'hahaahaha', CAST(N'2024-02-10T08:00:00.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (9, N'JJ', N'11', N'i like Mongolia', 0, N'have anyone went Mongolia befo?', CAST(N'2024-02-13T15:47:58.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (10, N'june', N'11', N'good places in sg', 0, N'hi i came sg last year and i like trip around.
tdy i want to share good placed in sg i went.', CAST(N'2024-02-15T14:31:51.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1018, N'Jack', N'11', N'is JACK common name?', 0, N'i am chinese student named jack, but i think jack is too common that not good to use', CAST(N'2024-02-15T14:31:51.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1045, N'movieboy', N'11', N'Please recommend some good Netflix movie', 0, N'I like action or thrillers. Sometimes I watch romance movies too', CAST(N'2024-02-13T15:47:58.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1075, N'jobseeker', N'11', N'where can i get intern in sg', 0, N'it is hard to get job in sg....', CAST(N'2024-02-26T09:03:01.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1076, N'hahahopes', N'11', N'when psb campus closing', 0, N'i heard 11pm a weekday', CAST(N'2024-03-08T10:34:20.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1079, N'Muhilan', N'11', N'hi i am Business Degree freshman, look for freshmans to be close to me', 0, N'+65)98765432. plz whatsapp me', CAST(N'2024-03-18T17:36:07.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1083, N'mr kim', N'11', N'hello i am kim sung yeon', 0, N'is there any other korean?', CAST(N'2024-04-01T00:42:03.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1085, N'Minh', N'1', N'Home', 0, N'hii', CAST(N'2024-04-01T03:34:33.000' AS DateTime))
GO
INSERT [dbo].[Community] ([Id], [Name], [Password], [Title], [CategoryId], [Content], [CreationTime]) VALUES (1093, N'MR.ADMIN', N'123123', N'Welcome', 0, N' Welcome to our website', CAST(N'2024-04-01T14:04:54.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Community] OFF
GO
SET IDENTITY_INSERT [dbo].[CommunityCategory] ON 
GO
INSERT [dbo].[CommunityCategory] ([Id], [CommunityId], [CategoryId]) VALUES (5, 8, 2)
GO
INSERT [dbo].[CommunityCategory] ([Id], [CommunityId], [CategoryId]) VALUES (6, 8, 4)
GO
INSERT [dbo].[CommunityCategory] ([Id], [CommunityId], [CategoryId]) VALUES (1025, 1085, 1)
GO
INSERT [dbo].[CommunityCategory] ([Id], [CommunityId], [CategoryId]) VALUES (1026, 1085, 2)
GO
INSERT [dbo].[CommunityCategory] ([Id], [CommunityId], [CategoryId]) VALUES (1034, 1093, 10)
GO
SET IDENTITY_INSERT [dbo].[CommunityCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[EventLists] ON 
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (11, N'Evt-Emergency-Preparedness.jpg', 3)
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (12, N'Evt-Influencing-Other.jpg', 3)
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (13, N'Evt-Culinary-Appreciation.jpg', 2)
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (20, N'Evt-Stem-Career Fair.jpg', 1)
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (21, N'Evt-Problem-Solving.jpg', 1)
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (22, N'Evt-Matic-Festival.jpg', 2)
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (24, N'Evt-Main.png', 4)
GO
INSERT [dbo].[EventLists] ([id], [EventPoster], [EventType]) VALUES (26, N'Evt-Godzilla.jpg', 3)
GO
SET IDENTITY_INSERT [dbo].[EventLists] OFF
GO
SET IDENTITY_INSERT [dbo].[Home] ON 
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (9, N'ntc.png', N'Navigate to Campus', N'', N'3', N'', N'', 1)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (15, NULL, NULL, NULL, N'2', N'https://www.youtube.com/embed/4K3PRjmyT_w', N' ', 0)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (17, N'slideshow1.png', N'', N'', N'1', N'', N'', 0)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (19, N'slideshow2.png', N'', N'', N'1', N'', N'', 0)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (22, N'about_ms.png', N'About Marina Square', NULL, N'3', NULL, NULL, 2)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (23, N'student_club.png', N'Student Club', NULL, N'3', NULL, NULL, 3)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (24, NULL, NULL, N'The University of Newcastle Singapore campus exists within the PSB Academy as a partnership with the PSB Academy.', N'4', NULL, NULL, 1)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (25, NULL, NULL, N'Our university is ranked in the top 175 of the world’s universities and stands as a global leader distinguished by our commitment to equity and excellence.', N'4', NULL, NULL, 2)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (26, NULL, NULL, N'PSB Academy is one of Singapore''s leading private educational institutions, producing more than 200,000 learners for nearly 60 years.', N'4', NULL, NULL, 3)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (27, N'home2.png', NULL, N'Share your experiences about UoN Singapore campus on the community! Post freely and show support with a simple click of the heart button.', N'5', NULL, NULL, 0)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (29, N'', N'', N'', N'2', N'https://www.youtube.com/embed/_HWGWdXhNfY', N'', 0)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (38, N'', N'', N'', N'2', N'https://www.youtube.com/embed/lfsj9asGlXE', N'', 0)
GO
INSERT [dbo].[Home] ([IdHome], [Image], [Name], [Description], [category], [Link], [Content], [Rank]) VALUES (43, N'slideshow3.jpg', N'', N'', N'1', N'', N'', 0)
GO
SET IDENTITY_INSERT [dbo].[Home] OFF
GO
SET IDENTITY_INSERT [dbo].[LevelMary] ON 
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'ASTON Steak & Salad', N'ASTON Steak & Salad.png', 3, 6)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Beyond Pancakes', N'Beyond Pancakes.png', 3, 7)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Coco Veggie Nyonya Cusine', N'Coco Veggie Nyonya Cusine.png', 3, 10)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Gloria jean’s coffees', N'Gloria jeans coffees.png', 3, 11)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Jia he xing', N'Jia he xing.png', 3, 12)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Kai Garden', N'Kai Garden.png', 3, 13)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'La Coffee', N'La Coffee.png', 3, 14)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Pizza Hut', N'Pizza Hut.png', 3, 15)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Seoul Garden', N'Seoul Garden.png', 3, 16)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'SOFRA Turkish cafe & restaurant', N'SOFRA Turkish cafe & restaurant.png', 3, 17)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'dal.komm COFFEE', N'dalkomm COFFEE.png', 2, 22)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Burger King', N'Burger King.png', 2, 23)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Eccellente by HAO mart', N'Eccellente by HAO mart.png', 2, 24)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Gourmet Paradise', N'Gourmet Paradise.png', 2, 25)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'7-Eleven(Level 1)', N'7 Eleven.png', 1, 26)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'A_Live House by Relax', N'A_Live House by Relax.png', 1, 27)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Carl’s Jr.', N'Carls Jr.png', 1, 28)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Haidilao hotpot', N'Haidilao hotpot.png', 1, 29)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Malts', N'Malts.png', 1, 30)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'COLLIN’S', N'COLLINS.png', 1, 31)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Kith Cafe', N'Kith Cafe.png', 1, 32)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'OJBK- Oyster Joint, Bar and Kitchen', N'OJBK- Oyster Joint, Bar and Kitchen.png', 1, 33)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Made’s Cafe', N'Mades A Cafe.png', 0, 35)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Han’s', N'Hans.png', 2, 40)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Jia Xiang Sarawak Kolo Mee', N'Jia Xiang Sarawak Kolo Mee.png', 2, 41)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Kei Kaisendon', N'Kei Kaisendon.png', 2, 42)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Kenny Roger Roasters', N'Kenny Roger Roasters.png', 2, 43)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Luckin Coffee', N'Luckin Coffee.png', 2, 45)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'MAKAN MAKAN by D’PENTETZ GROUP', N'MAKAN MAKAN by DPENTETZ GROUP.png', 2, 46)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'OH MY COWI', N'OH MY COWI.png', 2, 47)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'PUTIEN', N'PUTIEN.png', 2, 48)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Saizeriya', N'Saizeriya.png', 2, 49)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Shine Korea Supermarket', N'Shine Korea Supermarket.png', 2, 50)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'SUKIYA', N'SUKIYA.png', 2, 51)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'TANAMERA COFFEE', N'TANAMERA COFFEE.png', 2, 52)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'The Vermilion House', N'The Vermilion House.png', 2, 53)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'YaKun Kaya Toast', N'YaKun Kaya Toast.png', 2, 54)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Yi Zun noodle', N'Yi Zun noodle.png', 2, 55)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'ZUYA VEGETARIAN', N'ZUYA VEGETARIAN.png', 2, 56)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Yechun Xiao Jiang Nan', N'Yechun Xiao Jiang Nan.png', 2, 57)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Victoria Bakery & Cafe', N'Victoria Bakery & Cafe.png', 2, 58)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'The Tree Cafe', N'The Tree Cafe.png', 2, 59)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'SUSHI-GO', N'SUSHI-GO.png', 2, 60)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Suki- Ya (shabu shabu hotpot)', N'Suki- Ya (shabu shabu hotpot).png', 2, 61)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Shang Pin Hotpot', N'Shang Pin Hotpot.png', 2, 62)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Rolling Rice', N'Rolling rice.png', 2, 63)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Orange & Teal', N'Orange & Teal.png', 2, 64)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'McDonald’s', N'McDonalds.png', 2, 65)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Ma Mere Boulangeria', N'Ma Mere Boulangeria.png', 2, 66)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'lao Huo Tang', N'lao Huo Tang.png', 2, 67)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'KEITAKU', N'KEITAKU.png', 2, 68)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Kanada-ya', N'Kanada-ya.png', 2, 71)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Hongkong Zhai Dimsum', N'Hongkong Zhai Dimsum.png', 2, 72)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Gyo-kaku Japanese BBQ restaurant', N'Gyo-kaku Japanese BBQ restaurant.png', 2, 74)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Encik Tan', N'Encik Tan.png', 2, 75)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Dian Xiao Er', N'Dian Xiao Er.png', 2, 76)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'CHICHA San Chen', N'CHICHA San Chen.png', 2, 77)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'BHC chicken', N'BHC chicken.png', 2, 78)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (N'Bangkok Jam', N'Bangkok Jam.png', 2, 79)
GO
INSERT [dbo].[LevelMary] ([name], [filePath], [type], [Id]) VALUES (NULL, N'main img navi.png', 4, 80)
GO
SET IDENTITY_INSERT [dbo].[LevelMary] OFF
GO
SET IDENTITY_INSERT [dbo].[Localtion] ON 
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (29, N'CITY CAMPUS: MAIN WING', N'6 Raffles Blvd, Marina Square #O3-200 Singapore 039594', 1, N'', 0, 0, N'', NULL)
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (30, N'CITY CAMPUS: STEM WING', N'6 Raffles Blvd, Marina Square #04-101/102 Singapore 039594', 1, N'', 0, 0, N'', NULL)
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (31, N'Bus Stop at Promenade Station/Pan Pacific', N'', 3, N'', 0, 0, N'36 36B 97 97e 107M 961M', NULL)
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (32, N'Bus Stop at The Esplanade or The Float @ Marina Bay', N'', 3, N'', 0, 0, N'36 36B 56 70M 75 77 97 97e 106 111 133 162M 195 195A 857 960 960M ', NULL)
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (34, N'City Hall', N'', 2, N'Green', 300, 10, N'', NULL)
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (35, N'Esplanade', N'', 2, N'Blue', 500, 5, N'', NULL)
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (36, N'Promenade', N'', 2, N'Red', 300, 3, N'', NULL)
GO
INSERT [dbo].[Localtion] ([id], [LocaltionName], [LocaltionAddress], [LocaltionType], [LineColour], [Distance], [Minutes], [BusNumbers], [Images]) VALUES (37, NULL, NULL, 4, NULL, 0, 0, NULL, N'vos.png')
GO
SET IDENTITY_INSERT [dbo].[Localtion] OFF
GO
SET IDENTITY_INSERT [dbo].[ManagerCommunity] ON 
GO
INSERT [dbo].[ManagerCommunity] ([id], [Title], [Content], [ManagerCommunityType]) VALUES (1, N'Welcome to Community Page', N'Please share your thoughts and opinions about life in Singapore or school!', 1)
GO
INSERT [dbo].[ManagerCommunity] ([id], [Title], [Content], [ManagerCommunityType]) VALUES (2, N'Submission Guidelines', N'Articles And Discussions Should Be Directly Related To Campus Life In Singapore.', 2)
GO
INSERT [dbo].[ManagerCommunity] ([id], [Title], [Content], [ManagerCommunityType]) VALUES (3, N'Copyright And Responsibility For Posts ggg', N'The Copyright Of The Posts (Including Comments) Posted In The Gallery Belongs To The Publisher Himself And Should Not Infringe On The Rights Of Others.', 2)
GO
INSERT [dbo].[ManagerCommunity] ([id], [Title], [Content], [ManagerCommunityType]) VALUES (4, N'Post Deletion Criteria', N'If You Post A Post That Corresponds To Wallpapers, Advertisements, Pornography, Abusive Language, Copyright Infringement, Or Personal Information Infringement, You Will Be Deleted Or Blocked, And You May Be Liable For Civil Or Criminal Charges.', 2)
GO
SET IDENTITY_INSERT [dbo].[ManagerCommunity] OFF
GO
SET IDENTITY_INSERT [dbo].[Orientation] ON 
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (9, N'Ori_img6.png', N'', 0, N'', N'Most people know that Singapore is a hot country, so they only prepare thin clothes.                          However, the air conditioning is very cold inside in Singapore.                          It is important to prepare outerwear, especially because the inside of the school campus is famous for being cold.', N'Prepare outerwear or warm clothes.', 1)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (10, N'Ori_img7.png', N'', 0, N'', N'Prices in Singapore are high. If you eat at a restaurant, youll get an additional 10% service charge and 9% GST charge on the price of the food (9% as of 2024). If you want to go to a reasonably priced restaurant, you can eat at the Hawker Center across Singapore. The Hawker Center, lined with restaurants from various cultures, offers a wide variety of local foods at reasonable prices.', N'Food', 1)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (11, N'Ori_img8.png', N'', 0, N'', N'As a student, youre bound to have a fairly limited budget. Of course, you wont spend all that on your rent alone as you still have utilities, everyday expenses and savings to pay for. Read your contract carefully and keep in mind that contracts set the minimum renting time for HDB units at 6 months. Regarding home location, you should look for rooms near schools or near buses or near metro lines, which will help you conveniently go to university.', N'Infrastructure', 1)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (12, N'Ori_img1.png', N'', 0, N'', N'Singapore house prices are one of the most expensive countries in Asia.                         Most students live on HDB or condominiums. The price of a common room in HDB per room is about 1,000 per month, and the price of a master room is around 1500.                         Condos trade at an average of 2,000 SGD, and vary by region. If youre looking for a real estate site, I recommend 99.CO and propertyguru.                         Note, the minimum rent period for HDB is 6 months, and the minimum rent period for condos is 3 months.', N'How to find a house in Singapore?', 2)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (13, N'Ori_img2.png', N'', 0, N'', N'An overseas student in Singapore spends more than S$1,500 per month on living expenditures on average. This amount varies according to your lifestyle and degree of study. Regarding accommodation, the rental price varies according to geographical location, kind, size, demand, and facilities given, and ranges from S$1000 to S$1500 for HDB and from S$2000 for Condo. Food costs between S$10 and S$20 each day. The cost of transportation is determined by the distance traveled and the form of transportation used. It costs between S$150 and S$200.', N'How much is living expenses per month?', 2)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (15, N'Ori_img4.png', N'', 0, N'', N'As PSB Academy offers courses ranging from certificates and short courses to doctorate degrees, our course fees can range from as low as S$642 for a single short course to S$69,956.60 for a Doctor of Business Administration.However, scholarships or course funding support for selected courses are available.', N'How much are UoN and PSB Academy course fees?', 2)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (19, NULL, NULL, 0, NULL, N'Please check and prepare your University and Singapore life.', N'Welcome to Orientation Page', 3)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (20, N'Ori_img9.png', N'', 0, N'', N'Singapore’s public transport system is highly interconnected – you can easily travel from the heartlands to the city in 15 minutes! Trains are the fastest way to travel around in Singapore while buses can get you to more specific or remote places. An EZ-Link card is necessary for travel on public transport and can be purchased at any mrt station or 7-11 store.', N'Transport', 1)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (21, N'Ori_img10.png', N'', 0, N'', N'Singapore is a mixture of cultures and languages because it has a multiracial society and a history of frequent visits by former colonizers. The four common languages in Singapore are English, Chinese, Malay, and Tamil, and the main languages are English among Singaporeans of different races.', N'Languages', 1)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (22, N'Ori_img13.png', N'', 0, N'', N'University of Newcastle Australias Singapore campus exists within the PSB campus because the university partners with the countrys renowned university, the PSB Academy. On the PSB campus, students from other universities that have partnered with the university can also be found, and occasionally can join in events at other universities.', N'PSB campus', 1)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (23, N'Ori_img3.png', N'', 0, N'', N'PSB Academy has two campuses in Singapore – Main Wing and Stem Wing. Both are in Marina square and are a 2.3 minute walk from each other', N'Where is the university campus?', 2)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (24, N'Ori_img11.png', N'', 0, N'', N' If you are having difficulty studying, don''t hesitate to ask for help. PSB Academy provides a variety of support services, including academic tutoring, writing centers, study groups, etc. You can also communicate with teachers, classmates or academic advisors to seek their advice and help. ', N'What should I do if I have difficulty studying?', 2)
GO
INSERT [dbo].[Orientation] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [OrientationType]) VALUES (25, N'Ori_img12.png', N'', 0, N'', N'Singapore has a high-quality healthcare system, including public and private hospitals, clinics and pharmacies. In an emergency, you can call 999 for help or go to the nearest emergency room for medical treatment. The quality of medical services in Singapore is high, but it is also relatively expensive, so it is recommended to purchase appropriate medical insurance to protect against accidents.', N'How is the healthcare system in Singapore?', 2)
GO
SET IDENTITY_INSERT [dbo].[Orientation] OFF
GO
SET IDENTITY_INSERT [dbo].[PSBC] ON 
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (3, N'Edinburgh.png', N'Edinburgh Napier University', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (4, N'ECU.png', N'Edith Cowan University', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (5, N'La Trobe.png', N'La Trobe University', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (6, N'Massey.png', N'Massey University', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (7, N'Newcastle.png', N'The University Of Newcastle, Australia', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (8, N'Canberra.png', N'University Of Canberra', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (9, N'Hertfordshire.png', N'University Of Hertfordshire', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (10, N'Nottingham.png', N'University Of Nottingham', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (11, N'Cambridge.png', N'Cambridge Assessment International Education', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (13, N'PSB_Effort.png', N' PSB Academy Effort', N'PSB Academy is committed to preparing our students as industry-ready graduates by offering unique courses and a holistic education approach that readies students for successful careers. Collaborating closely with industry partners, our programmes equip students with sought-after skills and knowledge. Our career services provide a host of resources as well as workshops and career fairs during your time with us to get you prepared for your first job or get into a conversation about your next promotionensure smooth transitions to the professional world.  The recent 2022 Graduate Employment Survey (GES) by PSB Academy shows an impressive 78% employment rate within 6 months of exams, up from 69% the previous year. Our graduates also experience pay raises and promotions, highlighting their skills’ value. PSB Academy’s diverse student population of 16,000 reflects our commitment to fostering inclusivity and a vibrant learning environment, preparing individuals for careers and challenges of a competitive job market through training, education, and support services.', N'PSB Academy’s Effort ', 2)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (17, N'PSB_Banner.png', NULL, N'PSB Academy is a well-known academy in Singapore that provides a variety of subject courses and is committed to cultivating students'' skills and knowledge for career development. The college focuses on practical applications and provides students with abundant academic resources and career development support.', N'PSB Academy', 4)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (18, N'PSB_Overview.png', N'', N'', N'PSB Academy is a highly recognized institution in Singapore, established in 1964. As an academy focused on providing high-quality education, PSB Academy is committed to cultivating professionals with innovative thinking and practical skills. The college offers a diverse range of disciplines, covering areas such as business administration, engineering, and computer science.  PSB Academy''s education model focuses on practical application and industry docking, providing students with courses that are closely integrated with the career market. The college has advanced teaching facilities and a senior teaching team, creating a good academic environment for students. PSB Academy actively promotes internationalization and establishes close cooperation with world-renowned universities and enterprises to provide students with broad international exchange and career development opportunities. Through unremitting efforts, PSB Academy has become one of the leading educational institutions in Asia.', 3)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (20, N'ACE.png', N'	American Council on Exercise (ACE)', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (21, N'PSB.png', N'PSB Academy', N'', N'', 1)
GO
INSERT [dbo].[PSBC] ([id], [Images], [Name], [Content], [Title], [PSBCType]) VALUES (22, N'Conventry.png', N'Coventry University', N'', N'', 1)
GO
SET IDENTITY_INSERT [dbo].[PSBC] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentClub] ON 
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (4, N'Club-Google.png', N'Google Developer Student Club PSB Academy', N'Supported by Google Developer and with over 1000 clubs across the globe, Google Developer Student Clubs aim to help students bridge the gap between theory and practice. Google Developer Student Club PSB Academy (DSC – PSBA) is for students interested in Google developer technologies and with interests in growing as a developer. By joining DSC- PSBA, students grow their knowledge in a peer-to-peer learning environment and build solutions for local businesses and their community.', N'https://www.instagram.com/google_dsc_psba/', 2)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (6, N'Club-Chinese-Student.jpg', N'Chinese Student Club', N'The club paves the way for Chinese students to meet and connect through social activities like a Lunar New Year celebration with other student groups to showcase the Chinese culture.', N'https://www.instagram.com/psbcsa/', 1)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (7, N'Club-Global-Student.jpg', N'Global Student Club', N'Global Student Club welcomes students from Malaysia, Vietnam, Thailand, Laos, Cambodia and many more', N'https://www.instagram.com/psb_gsc/', 1)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (8, N'Club-Indonesian.jpg', N'Indonesian Student Club', N'Expect nothing less than social and cultural activities from the Indonesian students to promote mutual understanding among all students. Their schedule is packed with gatherings and sports games, all year round.', N'https://www.instagram.com/psb_gsc/', 1)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (9, N'Club-South-Asian.jpg', N'South Asian Student Club', N'A place where South Asian students can feel comfortable learning and interacting with one another while helping them feel closer to home at PSB Academy. Discover various fun activities – from welcoming the new students to celebrating Diwali.', N'https://www.instagram.com/sasapsb/', 1)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (12, N'Club-Main.png', NULL, NULL, NULL, 4)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (13, N'Club-IES.jpg', N'	IES - PSBA Student Chapter Google Developer Student Club PSB Academy', N'Institution of Engineers Singapore (IES) is the national society of engineers in Singapore. The student chapter advances the art, science and profession of engineering, and provides a platform for engineering students in Singapore to network. Student members will gain access to “The Singapore Engineer” e-magazine, talks, workshops and industrial visits.', N'https://www.instagram.com/iespsbacademy/	', 3)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (14, N'Club-IET.jpg', N'IET PSB Academy On Campus', N'The Institution of Engineering & Technology (IET) is one of the world’s largest engineering institutions with over 168,000 members in 150 countries. The student chapter organises technical hands-on workshops, industry visits and guest lectures. In 2017, the student chapter won the Global IET Group of The Year Award.', N'https://www.instagram.com/ietpsb/', 3)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (15, N'Club-Vietnamese-Student.jpg', N'Vietnamese Student Club', N'Xin chào! If you are a Vietnamese student, look no further! Vietnamese Student Club provides a platform where Vietnamese students can come together and bond through different activities. Special occasions that celebrate the unique Vietnamese culture are also held.', N'https://www.instagram.com/vsa.psba/', 1)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (16, N'Club-IPRS.jpg', N'PSB Academy IPRS & Media Club', N'Want to embark on this exciting journey in Public Relations and Communication? Come on board now!', N'https://www.instagram.com/psb.iprsnmedia/', 3)
GO
INSERT [dbo].[StudentClub] ([id], [Images], [Name], [Content], [Link], [StudentClubType]) VALUES (17, N'Club-Leadership-Development.jpg', N'Leadership Development Club', N'Leadership Development Club, a team of passionate individuals, focuses on offering opportunities for students to equip themselves with skills to be the leaders of tomorrow.', N'https://www.instagram.com/ldc.psba/', 2)
GO
SET IDENTITY_INSERT [dbo].[StudentClub] OFF
GO
SET IDENTITY_INSERT [dbo].[UoN] ON 
GO
INSERT [dbo].[UoN] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [UoNType]) VALUES (16, N'UON_Banner.png', N'', 0, N'', N'The University of Newcastle, is a world-leading comprehensive university renowned for its excellence in teaching and research. providing students with a diverse range of disciplines and an international academic environment.', N'University of NewCastle', 3)
GO
INSERT [dbo].[UoN] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [UoNType]) VALUES (18, N'Earth.png', N'', 175, N'	university in the world', N'', N'', 1)
GO
INSERT [dbo].[UoN] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [UoNType]) VALUES (19, N'Earth.png', N'', 200, N'12 subjects ranked in the top 200 in the world	', N'', N'', 1)
GO
INSERT [dbo].[UoN] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [UoNType]) VALUES (20, N'Australia.png', N'', 8, N'in Australia for research well above world standard', N'', N'', 1)
GO
INSERT [dbo].[UoN] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [UoNType]) VALUES (25, N'UON_Overview.png', N'', 0, N'', N'The University of Newcastle, Australia, was founded in 1965 and is a highly respected and globally renowned university. The school is known for its excellent educational quality and cutting-edge research results, and is committed to cultivating future leaders with international vision and innovative thinking. The University of Newcastle is famous for its unique subject setting and interdisciplinary research, covering engineering, medicine, business, social sciences and other fields.  The school adheres to the concept of openness and inclusiveness and provides students from all over the world with a rich and colorful academic experience. Its modern campus facilities and advanced teaching technology provide students with a good learning environment. As a university that pays attention to social responsibility, Newcastle University actively participates in community services and sustainable development projects to continuously promote social progress.  The University of Newcastle maintains close ties with many universities and industry partners around the world, providing students with a wealth of international exchange and internship opportunities. In its continuous pursuit of excellence, the University of Newcastle in Australia has become one of the models for academic innovation and global collaboration.', N'Overview', 2)
GO
INSERT [dbo].[UoN] ([id], [Images], [Name], [Rank], [Description], [Content], [Title], [UoNType]) VALUES (26, N'Principal_Sign.png', N'', 0, N'Welcome to Looking Ahead, the University of Newcastle Strategic Plan 2020-2025. Our vision is to be a world-leading university for our regions.', N'When we look ahead, we are motivated by the opportunities we see. We are driven by the challenges we need to solve. And we are stirred by the future we can imagine.This strategic plan is our framework for creating that very future. A future where Australia''s First Peoples are empowered and enjoy true equality. A future where anyone who has the drive and talent to succeed is given the opportunity to study. A future where our research benefits our local communities as well as our fellow global citizens. A future where our environment is safeguarded and at the heart of all of our big decisions.We will create this future together. We are a University of our regions and for our regions. Indeed, in shaping this strategic plan, we have asked our students, our staff and our communities to tell us what is most important to them. And we''ve listened. With more than 4,500 contributions, at the heart of this plan is the voice of the people with whom we will share our future.Over the coming five years, our University has much to do.With an outstanding student experience clearly in our sights, we will build on our reputation for high-quality education and research in health and medicine, science and engineering, energy and the environment, business and law, and education and arts.We will prepare our students for the rapidly changing world by giving them more opportunities for work experience before they graduate. And, we will introduce new measures to make sure each of our graduates is more healthy, resilient and community-minded when they leave our institution than when they arrived. Helping to develop these life-ready graduates will be at the core of our actions.We will establish four Engagement Priorities to guide our research and education efforts. We will draw on the wisdom of our Indigenous communities and use the lessons we''ve learned through the success of entities like the Newcastle Institute for Energy and Resources (NIER) and the Hunter Medical Research Institute (HMRI) to address global challenges.Knowing we have an important place in the Asia Pacific Region, we will pursue deeper and richer partnerships and engagements in this region, and as a global citizen we will proudly contribute to the United Nations Sustainable Development Goals (SDGs).In doing all this, we will make sure our regions continue to benefit from having their own university. By reimagining our campuses, we will open the doors to let the community in. Together with our inspiring people, we will cultivate a thriving innovation and start-up culture and will bring global expertise and knowledge to drive the future of these communities.There is much to do. We know this won''t always be an easy journey, but we know it is the right one.The spirit of looking to the future - of imagining and then realising possibilities - is embedded in the rich heritage of our University. Indeed, our motto ''I look ahead'' has long embodied that forward-looking character and resolve.We are excited to be Looking Ahead with you.', N'A message from our Chancellor and Vice-chancellor', 4)
GO
SET IDENTITY_INSERT [dbo].[UoN] OFF
GO
ALTER DATABASE [HHD_db] SET  READ_WRITE 
GO
