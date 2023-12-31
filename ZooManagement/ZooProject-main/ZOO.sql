CREATE database [PRN211_ZOO]
USE [PRN211_ZOO]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 11/4/2023 7:56:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[Animail_id] [nvarchar](50) NOT NULL,
	[AnimalSpecies_id] [nvarchar](50) NOT NULL,
	[Animal_gender] [bit] NULL,
	[Animal_Name] [nvarchar](50) NOT NULL,
	[Animal_DOB] [nvarchar](50) NOT NULL,
	[Food_ID] [nvarchar](50) NULL,
	[Animal_Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED 
(
	[Animail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnimalSpecies]    Script Date: 11/4/2023 7:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnimalSpecies](
	[AnimalSpecies_ID] [nvarchar](50) NOT NULL,
	[AnimalSpecies_Name] [nvarchar](50) NULL,
	[AnimalSpecies_Decription] [nvarchar](max) NULL,
 CONSTRAINT [PK_AnimalSpecies] PRIMARY KEY CLUSTERED 
(
	[AnimalSpecies_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 11/4/2023 7:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[AreaID] [nvarchar](50) NOT NULL,
	[Area_area] [nvarchar](50) NULL,
	[User_ID] [nvarchar](50) NULL,
	[AreaName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cage]    Script Date: 11/4/2023 7:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cage](
	[CageId] [nvarchar](50) NOT NULL,
	[AnimalSpecies_ID] [nvarchar](50) NOT NULL,
	[Area_ID] [nvarchar](50) NOT NULL,
	[User_ID] [nvarchar](50) NULL,
	[Cage_area] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cage] PRIMARY KEY CLUSTERED 
(
	[CageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 11/4/2023 7:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[FoodID] [nvarchar](50) NOT NULL,
	[FoodName] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manage]    Script Date: 11/4/2023 7:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manage](
	[UserID] [nvarchar](50) NOT NULL,
	[ConstrainID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Manage] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[ConstrainID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/4/2023 7:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[pasword] [nvarchar](50) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[phonenumber] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
	[experience] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZooTrainerAnimal]    Script Date: 11/4/2023 7:56:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZooTrainerAnimal](
	[id] [nvarchar](2) NOT NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[Animal_ID] [nvarchar](50) NOT NULL,
	[Food_ID] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ZooTrainerAnimal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Animal_AnimalSpecies] FOREIGN KEY([AnimalSpecies_id])
REFERENCES [dbo].[AnimalSpecies] ([AnimalSpecies_ID])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Animal_AnimalSpecies]
GO
ALTER TABLE [dbo].[Area]  WITH CHECK ADD  CONSTRAINT [FK_Area_User] FOREIGN KEY([User_ID])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Area] CHECK CONSTRAINT [FK_Area_User]
GO
ALTER TABLE [dbo].[Cage]  WITH CHECK ADD  CONSTRAINT [FK_Cage_AnimalSpecies] FOREIGN KEY([AnimalSpecies_ID])
REFERENCES [dbo].[AnimalSpecies] ([AnimalSpecies_ID])
GO
ALTER TABLE [dbo].[Cage] CHECK CONSTRAINT [FK_Cage_AnimalSpecies]
GO
ALTER TABLE [dbo].[Cage]  WITH CHECK ADD  CONSTRAINT [FK_Cage_Area] FOREIGN KEY([Area_ID])
REFERENCES [dbo].[Area] ([AreaID])
GO
ALTER TABLE [dbo].[Cage] CHECK CONSTRAINT [FK_Cage_Area]
GO
ALTER TABLE [dbo].[Cage]  WITH CHECK ADD  CONSTRAINT [FK_Cage_User] FOREIGN KEY([User_ID])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Cage] CHECK CONSTRAINT [FK_Cage_User]
GO
ALTER TABLE [dbo].[Manage]  WITH CHECK ADD  CONSTRAINT [FK_Manage_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Manage] CHECK CONSTRAINT [FK_Manage_User]
GO
ALTER TABLE [dbo].[Manage]  WITH CHECK ADD  CONSTRAINT [FK_Manage_User1] FOREIGN KEY([ConstrainID])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Manage] CHECK CONSTRAINT [FK_Manage_User1]
GO
ALTER TABLE [dbo].[ZooTrainerAnimal]  WITH CHECK ADD  CONSTRAINT [FK_ZooTrainerAnimal_Animal] FOREIGN KEY([Animal_ID])
REFERENCES [dbo].[Animal] ([Animail_id])
GO
ALTER TABLE [dbo].[ZooTrainerAnimal] CHECK CONSTRAINT [FK_ZooTrainerAnimal_Animal]
GO
ALTER TABLE [dbo].[ZooTrainerAnimal]  WITH CHECK ADD  CONSTRAINT [FK_ZooTrainerAnimal_Food] FOREIGN KEY([Food_ID])
REFERENCES [dbo].[Food] ([FoodID])
GO
ALTER TABLE [dbo].[ZooTrainerAnimal] CHECK CONSTRAINT [FK_ZooTrainerAnimal_Food]
GO
ALTER TABLE [dbo].[ZooTrainerAnimal]  WITH CHECK ADD  CONSTRAINT [FK_ZooTrainerAnimal_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[ZooTrainerAnimal] CHECK CONSTRAINT [FK_ZooTrainerAnimal_User]
GO
