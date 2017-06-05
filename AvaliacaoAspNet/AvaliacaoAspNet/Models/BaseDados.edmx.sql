
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/04/2017 21:26:24
-- Generated from EDMX file: C:\Users\Alain\Documents\Faculdade\Asp.net\Aulas\AvaliacaoAspNet\AvaliacaoAspNet\Models\BaseDados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FarmaciaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AkumaNoMiTipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AkumaNoMi] DROP CONSTRAINT [FK_AkumaNoMiTipo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AkumaNoMi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AkumaNoMi];
GO
IF OBJECT_ID(N'[dbo].[Tipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AkumaNoMi'
CREATE TABLE [dbo].[AkumaNoMi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Habilidades] nvarchar(max)  NOT NULL,
    [Consumido] bit  NOT NULL,
    [TipoId] int  NOT NULL
);
GO

-- Creating table 'Tipo'
CREATE TABLE [dbo].[Tipo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AkumaNoMi'
ALTER TABLE [dbo].[AkumaNoMi]
ADD CONSTRAINT [PK_AkumaNoMi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tipo'
ALTER TABLE [dbo].[Tipo]
ADD CONSTRAINT [PK_Tipo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TipoId] in table 'AkumaNoMi'
ALTER TABLE [dbo].[AkumaNoMi]
ADD CONSTRAINT [FK_AkumaNoMiTipo]
    FOREIGN KEY ([TipoId])
    REFERENCES [dbo].[Tipo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AkumaNoMiTipo'
CREATE INDEX [IX_FK_AkumaNoMiTipo]
ON [dbo].[AkumaNoMi]
    ([TipoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------