CREATE DATABASE Parcial2CVALL;
GO
USE [master]
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD = N'12345678',
 DEFAULT_DATABASE = [Parcial2CVALL],
 CHECK_EXPIRATION = OFF,
 CHECK_POLICY = ON
GO
USE [Parcial2CVALL]
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2]
GO

DROP TABLE Serie;

CREATE TABLE Serie (
id INT PRIMARY KEY IDENTITY(1,1),
titulo VARCHAR(250) NOT NULL,
sinopsis VARCHAR(5000) NOT NULL,
director VARCHAR(100) NOT NULL,
episodios INT NOT NULL,
fechaEstreno DATE,
estado SMALLINT NOT NULL DEFAULT 1,
tipoClasificacion VARCHAR(200) NOT NULL
);

ALTER TABLE Serie ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Serie ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO

ALTER PROC paSerieListar @parametro VARCHAR(100)
AS
 SELECT * FROM Serie
 WHERE estado<>-1 AND titulo LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
 GO
 EXEC paSerieListar 'Naruto';
INSERT INTO Serie(titulo, sinopsis, director, episodios, fechaEstreno, tipoClasificacion)
VALUES ('Naruto','un joven ninja','Akira Toriyama', 120, '2001-01-01', 'A');