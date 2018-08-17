
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/17/2018 12:06:50
-- Generated from EDMX file: C:\Users\NightCrawler-Nbook\Source\Repos\ProjectGimnasiaYEsgrima\ProjectGimnasiaYEsgrima\ProjectGimnasiaYEsgrima\Modelo\DiagramasDeTablas.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbGimnasiaYEsgrima];
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

-- Creating table 'Curso'
CREATE TABLE [dbo].[Curso] (
    [IdCurso] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFin] datetime  NOT NULL,
    [DeporteIdDeporte] int  NOT NULL
);
GO

-- Creating table 'Deporte'
CREATE TABLE [dbo].[Deporte] (
    [IdDeporte] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCurso] in table 'Curso'
ALTER TABLE [dbo].[Curso]
ADD CONSTRAINT [PK_Curso]
    PRIMARY KEY CLUSTERED ([IdCurso] ASC);
GO

-- Creating primary key on [IdDeporte] in table 'Deporte'
ALTER TABLE [dbo].[Deporte]
ADD CONSTRAINT [PK_Deporte]
    PRIMARY KEY CLUSTERED ([IdDeporte] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeporteIdDeporte] in table 'Curso'
ALTER TABLE [dbo].[Curso]
ADD CONSTRAINT [FK_CursoDeporte]
    FOREIGN KEY ([DeporteIdDeporte])
    REFERENCES [dbo].[Deporte]
        ([IdDeporte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoDeporte'
CREATE INDEX [IX_FK_CursoDeporte]
ON [dbo].[Curso]
    ([DeporteIdDeporte]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------