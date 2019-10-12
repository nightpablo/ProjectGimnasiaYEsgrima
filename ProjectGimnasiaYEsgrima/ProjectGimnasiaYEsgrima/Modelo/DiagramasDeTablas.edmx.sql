
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/12/2019 14:57:31
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

IF OBJECT_ID(N'[dbo].[FK_ProfesorCategoria_Profesor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesorCategoria] DROP CONSTRAINT [FK_ProfesorCategoria_Profesor];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfesorCategoria_Categoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfesorCategoria] DROP CONSTRAINT [FK_ProfesorCategoria_Categoria];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_PersonaEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaDeporte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categorias] DROP CONSTRAINT [FK_CategoriaDeporte];
GO
IF OBJECT_ID(N'[dbo].[FK_SocioPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Socios] DROP CONSTRAINT [FK_SocioPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_CuotaSocioValorCuotaInicial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CuotaSocios] DROP CONSTRAINT [FK_CuotaSocioValorCuotaInicial];
GO
IF OBJECT_ID(N'[dbo].[FK_CuotaSocioSocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CuotaSocios] DROP CONSTRAINT [FK_CuotaSocioSocio];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoRegistroIngresoEgreso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RegistroIngresoEgresoes] DROP CONSTRAINT [FK_EmpleadoRegistroIngresoEgreso];
GO
IF OBJECT_ID(N'[dbo].[FK_SocioCategoria_Categoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SocioCategoria] DROP CONSTRAINT [FK_SocioCategoria_Categoria];
GO
IF OBJECT_ID(N'[dbo].[FK_SocioCategoria_Socio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SocioCategoria] DROP CONSTRAINT [FK_SocioCategoria_Socio];
GO
IF OBJECT_ID(N'[dbo].[FK_CuotaSocioCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CuotaSocios] DROP CONSTRAINT [FK_CuotaSocioCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_LoginEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Logins] DROP CONSTRAINT [FK_LoginEmpleado];
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

IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
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
IF OBJECT_ID(N'[dbo].[Socios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Socios];
GO
IF OBJECT_ID(N'[dbo].[CuotaSocios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CuotaSocios];
GO
IF OBJECT_ID(N'[dbo].[ValorCuotaInicials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ValorCuotaInicials];
GO
IF OBJECT_ID(N'[dbo].[Logins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logins];
GO
IF OBJECT_ID(N'[dbo].[Empleados_Profesor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados_Profesor];
GO
IF OBJECT_ID(N'[dbo].[Empleados_Secretaria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados_Secretaria];
GO
IF OBJECT_ID(N'[dbo].[ProfesorCategoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfesorCategoria];
GO
IF OBJECT_ID(N'[dbo].[SocioCategoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SocioCategoria];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [IdCategoria] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFin] datetime  NOT NULL,
    [Costo] float  NOT NULL,
    [EstadoCategoria] int  NOT NULL,
    [Deporte_IdDeporte] int  NOT NULL
);
GO

-- Creating table 'Deportes'
CREATE TABLE [dbo].[Deportes] (
    [IdDeporte] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [Descripcion] nvarchar(255)  NULL,
    [EstadoDeporte] int  NOT NULL
);
GO

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [IdPersona] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [Apellido] nvarchar(50)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [DNI] int  NOT NULL,
    [Foto] varbinary(max)  NULL
);
GO

-- Creating table 'Empleados'
CREATE TABLE [dbo].[Empleados] (
    [IdEmpleado] int IDENTITY(1,1) NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [DescripcionTarea] nvarchar(255)  NULL,
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
    [HoraEgreso] datetime  NULL,
    [Empleado_IdEmpleado] int  NULL
);
GO

-- Creating table 'Socios'
CREATE TABLE [dbo].[Socios] (
    [IdSocio] int IDENTITY(1,1) NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [CategoriaSocio] int  NOT NULL,
    [EstadoSocio] int  NOT NULL,
    [Direccion] nvarchar(50)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Localidad] nvarchar(50)  NOT NULL,
    [TipoDocumento] int  NOT NULL,
    [Persona_IdPersona] int  NOT NULL
);
GO

-- Creating table 'CuotaSocios'
CREATE TABLE [dbo].[CuotaSocios] (
    [IdCuota] int IDENTITY(1,1) NOT NULL,
    [FechaEmision] datetime  NOT NULL,
    [FechaCobro] datetime  NULL,
    [Importe] float  NOT NULL,
    [Estado] int  NOT NULL,
    [ValorCuotaInicial_IdCuotaInicial] int  NOT NULL,
    [Socio_IdSocio] int  NULL,
    [Categoria_IdCategoria] int  NULL
);
GO

-- Creating table 'ValorCuotaInicials'
CREATE TABLE [dbo].[ValorCuotaInicials] (
    [IdCuotaInicial] int IDENTITY(1,1) NOT NULL,
    [FechaInicio] datetime  NOT NULL,
    [FechaFin] datetime  NULL,
    [Importe] float  NOT NULL
);
GO

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [IdLogin] int IDENTITY(1,1) NOT NULL,
    [usuario] nvarchar(50)  NOT NULL,
    [contraseña] nvarchar(50)  NOT NULL,
    [Empleado_IdEmpleado] int  NOT NULL
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

-- Creating table 'ProfesorCategoria'
CREATE TABLE [dbo].[ProfesorCategoria] (
    [Profesores_IdEmpleado] int  NOT NULL,
    [Categorias_IdCategoria] int  NOT NULL
);
GO

-- Creating table 'SocioCategoria'
CREATE TABLE [dbo].[SocioCategoria] (
    [Categorias_IdCategoria] int  NOT NULL,
    [Socios_IdSocio] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCategoria] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
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

-- Creating primary key on [IdLogin] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([IdLogin] ASC);
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

-- Creating primary key on [Profesores_IdEmpleado], [Categorias_IdCategoria] in table 'ProfesorCategoria'
ALTER TABLE [dbo].[ProfesorCategoria]
ADD CONSTRAINT [PK_ProfesorCategoria]
    PRIMARY KEY CLUSTERED ([Profesores_IdEmpleado], [Categorias_IdCategoria] ASC);
GO

-- Creating primary key on [Categorias_IdCategoria], [Socios_IdSocio] in table 'SocioCategoria'
ALTER TABLE [dbo].[SocioCategoria]
ADD CONSTRAINT [PK_SocioCategoria]
    PRIMARY KEY CLUSTERED ([Categorias_IdCategoria], [Socios_IdSocio] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Profesores_IdEmpleado] in table 'ProfesorCategoria'
ALTER TABLE [dbo].[ProfesorCategoria]
ADD CONSTRAINT [FK_ProfesorCategoria_Profesor]
    FOREIGN KEY ([Profesores_IdEmpleado])
    REFERENCES [dbo].[Empleados_Profesor]
        ([IdEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Categorias_IdCategoria] in table 'ProfesorCategoria'
ALTER TABLE [dbo].[ProfesorCategoria]
ADD CONSTRAINT [FK_ProfesorCategoria_Categoria]
    FOREIGN KEY ([Categorias_IdCategoria])
    REFERENCES [dbo].[Categorias]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfesorCategoria_Categoria'
CREATE INDEX [IX_FK_ProfesorCategoria_Categoria]
ON [dbo].[ProfesorCategoria]
    ([Categorias_IdCategoria]);
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

-- Creating foreign key on [Deporte_IdDeporte] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [FK_CategoriaDeporte]
    FOREIGN KEY ([Deporte_IdDeporte])
    REFERENCES [dbo].[Deportes]
        ([IdDeporte])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaDeporte'
CREATE INDEX [IX_FK_CategoriaDeporte]
ON [dbo].[Categorias]
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

-- Creating foreign key on [Categorias_IdCategoria] in table 'SocioCategoria'
ALTER TABLE [dbo].[SocioCategoria]
ADD CONSTRAINT [FK_SocioCategoria_Categoria]
    FOREIGN KEY ([Categorias_IdCategoria])
    REFERENCES [dbo].[Categorias]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Socios_IdSocio] in table 'SocioCategoria'
ALTER TABLE [dbo].[SocioCategoria]
ADD CONSTRAINT [FK_SocioCategoria_Socio]
    FOREIGN KEY ([Socios_IdSocio])
    REFERENCES [dbo].[Socios]
        ([IdSocio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SocioCategoria_Socio'
CREATE INDEX [IX_FK_SocioCategoria_Socio]
ON [dbo].[SocioCategoria]
    ([Socios_IdSocio]);
GO

-- Creating foreign key on [Categoria_IdCategoria] in table 'CuotaSocios'
ALTER TABLE [dbo].[CuotaSocios]
ADD CONSTRAINT [FK_CuotaSocioCategoria]
    FOREIGN KEY ([Categoria_IdCategoria])
    REFERENCES [dbo].[Categorias]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CuotaSocioCategoria'
CREATE INDEX [IX_FK_CuotaSocioCategoria]
ON [dbo].[CuotaSocios]
    ([Categoria_IdCategoria]);
GO

-- Creating foreign key on [Empleado_IdEmpleado] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [FK_LoginEmpleado]
    FOREIGN KEY ([Empleado_IdEmpleado])
    REFERENCES [dbo].[Empleados]
        ([IdEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginEmpleado'
CREATE INDEX [IX_FK_LoginEmpleado]
ON [dbo].[Logins]
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