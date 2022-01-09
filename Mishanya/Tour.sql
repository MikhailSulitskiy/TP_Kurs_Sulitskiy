create database var8TurPoezdka
use var8TurPoezdka

CREATE TABLE [dbo].[Poezdka]
(
[Id] INT NOT NULL PRIMARY KEY,
[nazvanie] NVARCHAR(50) NULL,
[datePoezdki] NVARCHAR(50) NULL,
[dlitelnost] NVARCHAR(50) NULL,
[cena] NVARCHAR(50) NULL,
[transport] NVARCHAR(50) NULL,
[projivanie] NVARCHAR(50) NULL,
[type] NVARCHAR(50) NULL
)
 select * from [dbo].[Poezdka]