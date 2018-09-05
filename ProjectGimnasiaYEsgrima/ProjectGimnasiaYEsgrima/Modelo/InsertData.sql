--Insertar Datos en las tablas

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbGimnasiaYEsgrima];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO



INSERT INTO [dbo].[Deportes] VALUES ('Futbol', 'Juego de una pelota y se juega con las piernas');
INSERT INTO [dbo].[Deportes] VALUES ('Basquet', 'Juego de una pelota y se juega con las manos');
INSERT INTO [dbo].[Deportes] VALUES ('Hockey', 'Juego de una bola y se juega con las manos manejando un palo');

INSERT INTO [dbo].[Personas] VALUES ('Pablo', 'Barragan', '05/09/2018 13:47:55',36001182);