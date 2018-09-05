--Eliminar Tablas

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbGimnasiaYEsgrima];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
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
IF OBJECT_ID(N'[dbo].[Empleados_Profesor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados_Profesor];
GO
IF OBJECT_ID(N'[dbo].[Empleados_Secretaria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados_Secretaria];
GO
IF OBJECT_ID(N'[dbo].[ProfesorCurso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfesorCurso];
GO