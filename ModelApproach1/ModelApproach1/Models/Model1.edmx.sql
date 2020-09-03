
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/29/2020 13:00:52
-- Generated from EDMX file: H:\29-08-2020\ModelApproach1\ModelApproach1\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [School];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'students'
CREATE TABLE [dbo].[students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'marks'
CREATE TABLE [dbo].[marks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Subject] nvarchar(max)  NOT NULL,
    [ObtainMark] nvarchar(max)  NOT NULL,
    [studentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'students'
ALTER TABLE [dbo].[students]
ADD CONSTRAINT [PK_students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'marks'
ALTER TABLE [dbo].[marks]
ADD CONSTRAINT [PK_marks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [studentId] in table 'marks'
ALTER TABLE [dbo].[marks]
ADD CONSTRAINT [FK_studentmark]
    FOREIGN KEY ([studentId])
    REFERENCES [dbo].[students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_studentmark'
CREATE INDEX [IX_FK_studentmark]
ON [dbo].[marks]
    ([studentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------