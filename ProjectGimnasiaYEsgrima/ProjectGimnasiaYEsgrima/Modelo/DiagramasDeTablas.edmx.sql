
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/23/2018 21:07:53
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

IF OBJECT_ID(N'[dbo].[FK_CursoDeporte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Curso] DROP CONSTRAINT [FK_CursoDeporte];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_EmpleadoPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesorDeporte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Deporte] DROP CONSTRAINT [FK_ProfesorDeporte];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesorCurso_Profesor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesorCurso] DROP CONSTRAINT [FK_ProfesorCurso_Profesor];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesorCurso_Curso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesorCurso] DROP CONSTRAINT [FK_ProfesorCurso_Curso];
GO
IF OBJECT_ID(N'[dbo].[FK_Profesor_inherits_Empleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados_Profesor] DROP CONSTRAINT [FK_Profesor_inherits_Empleado];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Curso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Curso];
GO
IF OBJECT_ID(N'[dbo].[Deporte]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deporte];
GO
IF OBJECT_ID(N'[dbo].[Personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas];
GO
IF OBJECT_ID(N'[dbo].[Empleados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados];
GO
IF OBJECT_ID(N'[dbo].[Empleados_Profesor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados_Profesor];
GO
IF OBJECT_ID(N'[dbo].[ProfesorCurso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfesorCurso];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cursos'
CREATE TABLE [dbo].[Cursos] (
    [IdCurso] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFin] datetime  NOT NULL,
    [DeporteIdDeporte] int  NOT NULL
);
GO

-- Creating table 'Deportes'
CREATE TABLE [dbo].[Deportes] (
    [IdDeporte] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Profesor_IdEmpleado] int  NOT NULL
);
GO

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [IdPersona] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [DNI] int  NOT NULL
);
GO

-- Creating table 'Empleados'
CREATE TABLE [dbo].[Empleados] (
    [IdEmpleado] int IDENTITY(1,1) NOT NULL,
    [FechaInicio] nvarchar(max)  NOT NULL,
    [DescripcionTarea] nvarchar(max)  NOT NULL,
    [Persona_IdPersona] int  NOT NULL
);
GO

-- Creating table 'Empleados_Profesor'
CREATE TABLE [dbo].[Empleados_Profesor] (
    [IdEmpleado] int  NOT NULL
);
GO

-- Creating table 'ProfesorCurso'
CREATE TABLE [dbo].[ProfesorCurso] (
    [Profesores_IdEmpleado] int  NOT NULL,
    [Cursos_IdCurso] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCurso] in table 'Cursos'
ALTER TABLE [dbo].[Cursos]
ADD CONSTRAINT [PK_Cursos]
    PRIMARY KEY CLUSTERED ([IdCurso] ASC);
GO

-- Creating primary key on [IdDeporte] in table 'Deportes'
ALTER TABLE [dbo].[Deportes]
ADD CONSTRAINT [PK_Deportes]
    PRIMARY KEY CLUSTERED ([IdDeporte] ASC);
GO

-- Creating primary key on [IdPersona] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IdEmpleado] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [PK_Empleados]
    PRIMARY KEY CLUSTERED ([IdEmpleado] ASC);
GO

-- Creating primary key on [IdEmpleado] in table 'Empleados_Profesor'
ALTER TABLE [dbo].[Empleados_Profesor]
ADD CONSTRAINT [PK_Empleados_Profesor]
    PRIMARY KEY CLUSTERED ([IdEmpleado] ASC);
GO

-- Creating primary key on [Profesores_IdEmpleado], [Cursos_IdCurso] in table 'ProfesorCurso'
ALTER TABLE [dbo].[ProfesorCurso]
ADD CONSTRAINT [PK_ProfesorCurso]
    PRIMARY KEY CLUSTERED ([Profesores_IdEmpleado], [Cursos_IdCurso] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeporteIdDeporte] in table 'Cursos'
ALTER TABLE [dbo].[Cursos]
ADD CONSTRAINT [FK_CursoDeporte]
    FOREIGN KEY ([DeporteIdDeporte])
    REFERENCES [dbo].[Deportes]
        ([IdDeporte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoDeporte'
CREATE INDEX [IX_FK_CursoDeporte]
ON [dbo].[Cursos]
    ([DeporteIdDeporte]);
GO

-- Creating foreign key on [Persona_IdPersona] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_EmpleadoPersona]
    FOREIGN KEY ([Persona_IdPersona])
    REFERENCES [dbo].[Personas]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoPersona'
CREATE INDEX [IX_FK_EmpleadoPersona]
ON [dbo].[Empleados]
    ([Persona_IdPersona]);
GO

-- Creating foreign key on [Profesor_IdEmpleado] in table 'Deportes'
ALTER TABLE [dbo].[Deportes]
ADD CONSTRAINT [FK_ProfesorDeporte]
    FOREIGN KEY ([Profesor_IdEmpleado])
    REFERENCES [dbo].[Empleados_Profesor]
        ([IdEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesorDeporte'
CREATE INDEX [IX_FK_ProfesorDeporte]
ON [dbo].[Deportes]
    ([Profesor_IdEmpleado]);
GO

-- Creating foreign key on [Profesores_IdEmpleado] in table 'ProfesorCurso'
ALTER TABLE [dbo].[ProfesorCurso]
ADD CONSTRAINT [FK_ProfesorCurso_Profesor]
    FOREIGN KEY ([Profesores_IdEmpleado])
    REFERENCES [dbo].[Empleados_Profesor]
        ([IdEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Cursos_IdCurso] in table 'ProfesorCurso'
ALTER TABLE [dbo].[ProfesorCurso]
ADD CONSTRAINT [FK_ProfesorCurso_Curso]
    FOREIGN KEY ([Cursos_IdCurso])
    REFERENCES [dbo].[Cursos]
        ([IdCurso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesorCurso_Curso'
CREATE INDEX [IX_FK_ProfesorCurso_Curso]
ON [dbo].[ProfesorCurso]
    ([Cursos_IdCurso]);
GO

-- Creating foreign key on [IdEmpleado] in table 'Empleados_Profesor'
ALTER TABLE [dbo].[Empleados_Profesor]
ADD CONSTRAINT [FK_Profesor_inherits_Empleado]
    FOREIGN KEY ([IdEmpleado])
    REFERENCES [dbo].[Empleados]
        ([IdEmpleado])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------