
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/06/2023 19:36:49
-- Generated from EDMX file: C:\Pablo\THI\9. Semester\Software Engineering und KI\AWACS Project\Coding\AWACSTicketSystem\AWACSTicketSystemLibrary\AWACSDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AWACSTicketWebDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Responsible]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketSet] DROP CONSTRAINT [FK_Responsible];
GO
IF OBJECT_ID(N'[dbo].[FK_Creator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketSet] DROP CONSTRAINT [FK_Creator];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[TicketSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TicketSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WorkerId] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Department] nvarchar(max)  NULL,
    [EMail] nvarchar(max)  NULL
);
GO

-- Creating table 'TicketSet'
CREATE TABLE [dbo].[TicketSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TicketId] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Solution] nvarchar(max)  NULL,
    [DateObserved] nvarchar(max)  NULL,
    [PlannedEndDate] nvarchar(max)  NULL,
    [Progress] nvarchar(max)  NULL,
    [Status] nvarchar(max)  NULL,
    [ResponsibleId] int  NOT NULL,
    [CreatedId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
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

-- Creating foreign key on [ResponsibleId] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_Responsible]
    FOREIGN KEY ([ResponsibleId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Responsible'
CREATE INDEX [IX_FK_Responsible]
ON [dbo].[TicketSet]
    ([ResponsibleId]);
GO

-- Creating foreign key on [CreatedId] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_Creator]
    FOREIGN KEY ([CreatedId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Creator'
CREATE INDEX [IX_FK_Creator]
ON [dbo].[TicketSet]
    ([CreatedId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------