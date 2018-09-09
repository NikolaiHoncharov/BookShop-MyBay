CREATE DATABASE BookShop;

Create Table Authors(
	ID int not null identity Primary Key,
	LastName nvarchar(50) not null,
	FirstName nvarchar(50) not null)

Create Table Books(
	ID int not null identity Primary Key,
	Title nvarchar(50) not null,
	Theme  nvarchar(50) not null,
	Publisher nvarchar(50),
	Price money not null,
	AgeOfReceipt int not null,
	Pages int not null,
	AuthorsID int not null Foreign Key References Authors(ID) on delete no action)

	Create Table Shop (
	ID  int not null identity Primary Key,
	BooksID int not null Foreign Key References Books(ID),
	QuantityBooks int not null,
	DateSales date not null default getdate(),
	PriceSales money not null)
	
//add [picter] column
	
	
	Create Table Sales (
	ID int not null identity Primary Key,
	BooksID int not null Foreign Key References Books(ID),
	DateOfSales date not null default getdate(),
	Quantity int not null)


	Create Table Seller(
	ID int not null identity Primary Key,
	LastName nvarchar(50) not null,
	FirstName nvarchar(50) not null,
	[Login] nvarchar(30) not null,
	[Password] nvarchar(30) not null)

Insert into  Seller
Values('Гончаров', 'Николай', 'admin','admin')



Insert dbo.Authors
Values('Пономаренко','Сергей'),
	('Могилевская','Наталия'),
	('Тюдор','С. Дж.'),
	('Талан','Светлана')

Insert dbo.Books
Values('Надеюсь и люблю','Роман','Книжный Клуб',110,2018,288,4),
	('Зеркало из прошлого','Детектив','Книжный Клуб',87,2018,336,1),
	('Меловой Человек','Детектив','Клуб Семейного Досуга',148,2017,336,3),
	('Худеем вместе','Здоровье и красота','Клуб Семейного Досуга',150,2016,176,2)

Insert dbo.Shop
Values(1,10,'01.01.2018',120,'Talan_Nadeus_i_lublu.jpg'),
	(2,10,'02.01.2018',100,'Ponomarev_Zerkalo_iz_proshlogo.jpg'),
	(3,20,'03.02.2018',180,'Tudor_Melovou_chel.jpg'),
	(4,15,'02.02.2018',180,'Mogilevcka_Hydeem_Vmeste.jpg')

	
	
	
	
	
	
	
	
	
	
	USE [BookShop]
GO

/****** Object:  Table [dbo].[Books]    Script Date: 16.04.2018 14:42:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Theme] [nvarchar](50) NOT NULL,
	[Publisher] [nvarchar](50) NULL,
	[Price] [money] NOT NULL,
	[AgeOfReceipt] [int] NOT NULL,
	[Pages] [int] NOT NULL,
	[AuthorsID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD FOREIGN KEY([AuthorsID])
REFERENCES [dbo].[Authors] ([ID])
GO











USE [BookShop]
GO

/****** Object:  Table [dbo].[Sales]    Script Date: 16.04.2018 14:42:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BooksID] [int] NOT NULL,
	[DateOfSales] [date] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Sales] ADD  DEFAULT (getdate()) FOR [DateOfSales]
GO

ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([BooksID])
REFERENCES [dbo].[Books] ([ID])
GO








USE [BookShop]
GO

/****** Object:  Table [dbo].[Shop]    Script Date: 16.04.2018 14:42:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Shop](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BooksID] [int] NOT NULL,
	[QuantityBooks] [int] NOT NULL,
	[DateSales] [date] NOT NULL,
	[PriceSales] [money] NOT NULL,
	[Picture] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Shop] ADD  DEFAULT (getdate()) FOR [DateSales]
GO

ALTER TABLE [dbo].[Shop]  WITH CHECK ADD FOREIGN KEY([BooksID])
REFERENCES [dbo].[Books] ([ID])
GO












