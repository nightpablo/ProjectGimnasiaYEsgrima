
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/20/2018 16:06:40
-- Generated from EDMX file: C:\Users\NightCrawler-NBOOK\source\repos\ProjectGimnasiaYEsgrima\ProjectGimnasiaYEsgrima\ProjectGimnasiaYEsgrima\Modelo\DiagramasDeTablas.edmx
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

IF OBJECT_ID(N'[dbo].[FK_ProfesorCurso_Profesor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesorCurso] DROP CONSTRAINT [FK_ProfesorCurso_Profesor];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesorCurso_Curso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesorCurso] DROP CONSTRAINT [FK_ProfesorCurso_Curso];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_PersonaEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_CursoDeporte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cursos] DROP CONSTRAINT [FK_CursoDeporte];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoRegistroIngresoSalida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroIngresoEgresoes] DROP CONSTRAINT [FK_EmpleadoRegistroIngresoSalida];
GO
IF OBJECT_ID(N'[dbo].[FK_Profesor_inherits_Empleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados_Profesor] DROP CONSTRAINT [FK_Profesor_inherits_Empleado];
GO
IF OBJECT_ID(N'[dbo].[FK_Secretaria_inherits_Empleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados_Secretaria] DROP CONSTRAINT [FK_Secretaria_inherits_Empleado];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cursos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cursos];
GO
IF OBJECT_ID(N'[dbo].[Deportes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deportes];
GO
IF OBJECT_ID(N'[dbo].[Personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas];
GO
IF OBJECT_ID(N'[dbo].[Empleados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados];
GO
IF OBJECT_ID(N'[dbo].[RegistroIngresoEgresoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegistroIngresoEgresoes];
GO
IF OBJECT_ID(N'[dbo].[Empleados_Profesor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados_Profesor];
GO
IF OBJECT_ID(N'[dbo].[Empleados_Secretaria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados_Secretaria];
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
    [EstadoCurso] int  NOT NULL,
    [Costo] float  NOT NULL,
    [Deporte_IdDeporte] int  NOT NULL
);
GO

-- Creating table 'Deportes'
CREATE TABLE [dbo].[Deportes] (
    [IdDeporte] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NULL,
    [EstadoDeporte] int  NOT NULL
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
    [FechaInicio] datetime  NOT NULL,
    [DescripcionTarea] nvarchar(max)  NULL,
    [TipoEmpleado] int  NOT NULL,
    [EstadoEmpleado] int  NOT NULL,
    [Persona_IdPersona] int  NOT NULL
);
GO

-- Creating table 'RegistroIngresoEgresoes'
CREATE TABLE [dbo].[RegistroIngresoEgresoes] (
    [IdRegistro] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [HoraIngreso] datetime  NOT NULL,
    [HoraEgreso] datetime  NOT NULL,
    [Empleado_IdEmpleado] int  NULL
);
GO

-- Creating table 'Socios'
CREATE TABLE [dbo].[Socios] (
    [IdSocio] int IDENTITY(1,1) NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [CategoriaSocio] int  NOT NULL,
    [EstadoSocio] int  NOT NULL,
    [Persona_IdPersona] int  NOT NULL
);
GO

-- Creating table 'CuotaSocios'
CREATE TABLE [dbo].[CuotaSocios] (
    [IdCuota] int IDENTITY(1,1) NOT NULL,
    [FechaEmision] datetime  NOT NULL,
    [FechaCobro] datetime  NOT NULL,
    [Importe] float  NOT NULL,
    [Estado] int  NOT NULL,
    [ValorCuotaInicial_IdCuotaInicial] int  NOT NULL,
    [Socio_IdSocio] int  NOT NULL
);
GO

-- Creating table 'ValorCuotaInicials'
CREATE TABLE [dbo].[ValorCuotaInicials] (
    [IdCuotaInicial] int IDENTITY(1,1) NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFin] datetime  NOT NULL,
    [Importe] float  NOT NULL
);
GO

-- Creating table 'Empleados_Profesor'
CREATE TABLE [dbo].[Empleados_Profesor] (
    [IdEmpleado] int  NOT NULL
);
GO

-- Creating table 'Empleados_Secretaria'
CREATE TABLE [dbo].[Empleados_Secretaria] (
    [IdEmpleado] int  NOT NULL
);
GO

-- Creating table 'ProfesorCurso'
CREATE TABLE [dbo].[ProfesorCurso] (
    [Profesores_IdEmpleado] int  NOT NULL,
    [Cursos_IdCurso] int  NOT NULL
);
GO

-- Creating table 'SocioCurso'
CREATE TABLE [dbo].[SocioCurso] (
    [Socios_IdSocio] int  NOT NULL,
    [SocioCurso_Socio_IdCurso] int  NOT NULL
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

-- Creating primary key on [IdRegistro] in table 'RegistroIngresoEgresoes'
ALTER TABLE [dbo].[RegistroIngresoEgresoes]
ADD CONSTRAINT [PK_RegistroIngresoEgresoes]
    PRIMARY KEY CLUSTERED ([IdRegistro] ASC);
GO

-- Creating primary key on [IdSocio] in table 'Socios'
ALTER TABLE [dbo].[Socios]
ADD CONSTRAINT [PK_Socios]
    PRIMARY KEY CLUSTERED ([IdSocio] ASC);
GO

-- Creating primary key on [IdCuota] in table 'CuotaSocios'
ALTER TABLE [dbo].[CuotaSocios]
ADD CONSTRAINT [PK_CuotaSocios]
    PRIMARY KEY CLUSTERED ([IdCuota] ASC);
GO

-- Creating primary key on [IdCuotaInicial] in table 'ValorCuotaInicials'
ALTER TABLE [dbo].[ValorCuotaInicials]
ADD CONSTRAINT [PK_ValorCuotaInicials]
    PRIMARY KEY CLUSTERED ([IdCuotaInicial] ASC);
GO

-- Creating primary key on [IdEmpleado] in table 'Empleados_Profesor'
ALTER TABLE [dbo].[Empleados_Profesor]
ADD CONSTRAINT [PK_Empleados_Profesor]
    PRIMARY KEY CLUSTERED ([IdEmpleado] ASC);
GO

-- Creating primary key on [IdEmpleado] in table 'Empleados_Secretaria'
ALTER TABLE [dbo].[Empleados_Secretaria]
ADD CONSTRAINT [PK_Empleados_Secretaria]
    PRIMARY KEY CLUSTERED ([IdEmpleado] ASC);
GO

-- Creating primary key on [Profesores_IdEmpleado], [Cursos_IdCurso] in table 'ProfesorCurso'
ALTER TABLE [dbo].[ProfesorCurso]
ADD CONSTRAINT [PK_ProfesorCurso]
    PRIMARY KEY CLUSTERED ([Profesores_IdEmpleado], [Cursos_IdCurso] ASC);
GO

-- Creating primary key on [Socios_IdSocio], [SocioCurso_Socio_IdCurso] in table 'SocioCurso'
ALTER TABLE [dbo].[SocioCurso]
ADD CONSTRAINT [PK_SocioCurso]
    PRIMARY KEY CLUSTERED ([Socios_IdSocio], [SocioCurso_Socio_IdCurso] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [Persona_IdPersona] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_PersonaEmpleado]
    FOREIGN KEY ([Persona_IdPersona])
    REFERENCES [dbo].[Personas]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaEmpleado'
CREATE INDEX [IX_FK_PersonaEmpleado]
ON [dbo].[Empleados]
    ([Persona_IdPersona]);
GO

-- Creating foreign key on [Deporte_IdDeporte] in table 'Cursos'
ALTER TABLE [dbo].[Cursos]
ADD CONSTRAINT [FK_CursoDeporte]
    FOREIGN KEY ([Deporte_IdDeporte])
    REFERENCES [dbo].[Deportes]
        ([IdDeporte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoDeporte'
CREATE INDEX [IX_FK_CursoDeporte]
ON [dbo].[Cursos]
    ([Deporte_IdDeporte]);
GO

-- Creating foreign key on [Persona_IdPersona] in table 'Socios'
ALTER TABLE [dbo].[Socios]
ADD CONSTRAINT [FK_SocioPersona]
    FOREIGN KEY ([Persona_IdPersona])
    REFERENCES [dbo].[Personas]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SocioPersona'
CREATE INDEX [IX_FK_SocioPersona]
ON [dbo].[Socios]
    ([Persona_IdPersona]);
GO

-- Creating foreign key on [Socios_IdSocio] in table 'SocioCurso'
ALTER TABLE [dbo].[SocioCurso]
ADD CONSTRAINT [FK_SocioCurso_Socio]
    FOREIGN KEY ([Socios_IdSocio])
    REFERENCES [dbo].[Socios]
        ([IdSocio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SocioCurso_Socio_IdCurso] in table 'SocioCurso'
ALTER TABLE [dbo].[SocioCurso]
ADD CONSTRAINT [FK_SocioCurso_Curso]
    FOREIGN KEY ([SocioCurso_Socio_IdCurso])
    REFERENCES [dbo].[Cursos]
        ([IdCurso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SocioCurso_Curso'
CREATE INDEX [IX_FK_SocioCurso_Curso]
ON [dbo].[SocioCurso]
    ([SocioCurso_Socio_IdCurso]);
GO

-- Creating foreign key on [ValorCuotaInicial_IdCuotaInicial] in table 'CuotaSocios'
ALTER TABLE [dbo].[CuotaSocios]
ADD CONSTRAINT [FK_CuotaSocioValorCuotaInicial]
    FOREIGN KEY ([ValorCuotaInicial_IdCuotaInicial])
    REFERENCES [dbo].[ValorCuotaInicials]
        ([IdCuotaInicial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuotaSocioValorCuotaInicial'
CREATE INDEX [IX_FK_CuotaSocioValorCuotaInicial]
ON [dbo].[CuotaSocios]
    ([ValorCuotaInicial_IdCuotaInicial]);
GO

-- Creating foreign key on [Socio_IdSocio] in table 'CuotaSocios'
ALTER TABLE [dbo].[CuotaSocios]
ADD CONSTRAINT [FK_CuotaSocioSocio]
    FOREIGN KEY ([Socio_IdSocio])
    REFERENCES [dbo].[Socios]
        ([IdSocio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuotaSocioSocio'
CREATE INDEX [IX_FK_CuotaSocioSocio]
ON [dbo].[CuotaSocios]
    ([Socio_IdSocio]);
GO

-- Creating foreign key on [Empleado_IdEmpleado] in table 'RegistroIngresoEgresoes'
ALTER TABLE [dbo].[RegistroIngresoEgresoes]
ADD CONSTRAINT [FK_EmpleadoRegistroIngresoEgreso]
    FOREIGN KEY ([Empleado_IdEmpleado])
    REFERENCES [dbo].[Empleados]
        ([IdEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoRegistroIngresoEgreso'
CREATE INDEX [IX_FK_EmpleadoRegistroIngresoEgreso]
ON [dbo].[RegistroIngresoEgresoes]
    ([Empleado_IdEmpleado]);
GO

-- Creating foreign key on [IdEmpleado] in table 'Empleados_Profesor'
ALTER TABLE [dbo].[Empleados_Profesor]
ADD CONSTRAINT [FK_Profesor_inherits_Empleado]
    FOREIGN KEY ([IdEmpleado])
    REFERENCES [dbo].[Empleados]
        ([IdEmpleado])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEmpleado] in table 'Empleados_Secretaria'
ALTER TABLE [dbo].[Empleados_Secretaria]
ADD CONSTRAINT [FK_Secretaria_inherits_Empleado]
    FOREIGN KEY ([IdEmpleado])
    REFERENCES [dbo].[Empleados]
        ([IdEmpleado])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------