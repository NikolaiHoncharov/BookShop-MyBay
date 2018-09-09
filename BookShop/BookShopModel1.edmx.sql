
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/09/2018 20:08:42
-- Generated from EDMX file: D:\Николай\Рабочая\ШАГ\ЭКЗАМЕНЫ С#\Book Shop MyBay\BookShop\BookShopModel1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BookShop];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Books__AuthorsID__398D8EEE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Books] DROP CONSTRAINT [FK__Books__AuthorsID__398D8EEE];
GO
IF OBJECT_ID(N'[dbo].[FK__Sales__BooksID__403A8C7D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK__Sales__BooksID__403A8C7D];
GO
IF OBJECT_ID(N'[dbo].[FK__Shop__BooksID__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shop] DROP CONSTRAINT [FK__Shop__BooksID__3C69FB99];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Authors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Authors];
GO
IF OBJECT_ID(N'[dbo].[Books]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Books];
GO
IF OBJECT_ID(N'[dbo].[Sales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sales];
GO
IF OBJECT_ID(N'[dbo].[Seller]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Seller];
GO
IF OBJECT_ID(N'[dbo].[Shop]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shop];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Authors'
CREATE TABLE [dbo].[Authors] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Theme] nvarchar(50)  NOT NULL,
    [Publisher] nvarchar(50)  NULL,
    [Price] decimal(19,4)  NOT NULL,
    [AgeOfReceipt] int  NOT NULL,
    [Pages] int  NOT NULL,
    [AuthorsID] int  NOT NULL
);
GO

-- Creating table 'Sales'
CREATE TABLE [dbo].[Sales] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [BooksID] int  NOT NULL,
    [DateOfSales] datetime  NOT NULL,
    [Quantity] int  NOT NULL,
    [Price] int  NOT NULL
);
GO

-- Creating table 'Seller'
CREATE TABLE [dbo].[Seller] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [Login] nvarchar(30)  NOT NULL,
    [Password] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Shop'
CREATE TABLE [dbo].[Shop] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [BooksID] int  NOT NULL,
    [QuantityBooks] int  NOT NULL,
    [DateSales] datetime  NOT NULL,
    [PriceSales] decimal(19,4)  NOT NULL,
    [Picture] nvarchar(100)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Authors'
ALTER TABLE [dbo].[Authors]
ADD CONSTRAINT [PK_Authors]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [PK_Sales]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Seller'
ALTER TABLE [dbo].[Seller]
ADD CONSTRAINT [PK_Seller]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Shop'
ALTER TABLE [dbo].[Shop]
ADD CONSTRAINT [PK_Shop]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AuthorsID] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [FK__Books__AuthorsID__398D8EEE]
    FOREIGN KEY ([AuthorsID])
    REFERENCES [dbo].[Authors]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Books__AuthorsID__398D8EEE'
CREATE INDEX [IX_FK__Books__AuthorsID__398D8EEE]
ON [dbo].[Books]
    ([AuthorsID]);
GO

-- Creating foreign key on [BooksID] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [FK__Sales__BooksID__403A8C7D]
    FOREIGN KEY ([BooksID])
    REFERENCES [dbo].[Books]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Sales__BooksID__403A8C7D'
CREATE INDEX [IX_FK__Sales__BooksID__403A8C7D]
ON [dbo].[Sales]
    ([BooksID]);
GO

-- Creating foreign key on [BooksID] in table 'Shop'
ALTER TABLE [dbo].[Shop]
ADD CONSTRAINT [FK__Shop__BooksID__3C69FB99]
    FOREIGN KEY ([BooksID])
    REFERENCES [dbo].[Books]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Shop__BooksID__3C69FB99'
CREATE INDEX [IX_FK__Shop__BooksID__3C69FB99]
ON [dbo].[Shop]
    ([BooksID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------