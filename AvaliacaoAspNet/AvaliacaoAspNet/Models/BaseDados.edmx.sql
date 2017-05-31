
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2017 08:49:16
-- Generated from EDMX file: C:\Documentos\Asp.Net_Aulas\AvaliacaoAspNet\AvaliacaoAspNet\Models\BaseDados.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RemedioSet'
CREATE TABLE [dbo].[RemedioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Dosagem] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Forma] nvarchar(max)  NOT NULL,
    [Validade] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Estoque] nvarchar(max)  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'CategoriaSet'
CREATE TABLE [dbo].[CategoriaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Recomendacoes] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'RemedioSet'
ALTER TABLE [dbo].[RemedioSet]
ADD CONSTRAINT [PK_RemedioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [PK_CategoriaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoriaId] in table 'RemedioSet'
ALTER TABLE [dbo].[RemedioSet]
ADD CONSTRAINT [FK_RemedioCategoria]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[CategoriaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RemedioCategoria'
CREATE INDEX [IX_FK_RemedioCategoria]
ON [dbo].[RemedioSet]
    ([CategoriaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------