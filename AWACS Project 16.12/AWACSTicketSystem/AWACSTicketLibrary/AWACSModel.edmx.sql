
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2023 10:16:26
-- Generated from EDMX file: C:\Pablo\THI\9. Semester\Software Engineering und KI\AWACS Project\Coding\AWACSTicketSystem\AWACSTicketLibrary\AWACSModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AWACSTicketDatabase];
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

-- Creating table 'WorkerSet'
CREATE TABLE [dbo].[WorkerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WorkerId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [eMail] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Department] nvarchar(max)  NOT NULL,
    [AdminRole] bit  NOT NULL,
    [UserRole] bit  NOT NULL
);
GO

-- Creating table 'TicketSet'
CREATE TABLE [dbo].[TicketSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TicketId] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Solution] nvarchar(max)  NOT NULL,
    [DateObserved] datetime  NOT NULL,
    [PlannedEndDate] datetime  NOT NULL,
    [Progress] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [CreatorId] int  NOT NULL,
    [ResponsibleId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [PK_WorkerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [PK_TicketSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CreatorId] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_ToCreate]
    FOREIGN KEY ([CreatorId])
    REFERENCES [dbo].[WorkerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ToCreate'
CREATE INDEX [IX_FK_ToCreate]
ON [dbo].[TicketSet]
    ([CreatorId]);
GO

-- Creating foreign key on [ResponsibleId] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_ToResponsible]
    FOREIGN KEY ([ResponsibleId])
    REFERENCES [dbo].[WorkerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ToResponsible'
CREATE INDEX [IX_FK_ToResponsible]
ON [dbo].[TicketSet]
    ([ResponsibleId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------