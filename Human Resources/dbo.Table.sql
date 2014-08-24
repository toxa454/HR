CREATE TABLE [dbo].[Table]
(
	[IdPERS] INT NOT NULL PRIMARY KEY IDENTITY, 
    [f] CHAR(50) NULL, 
    [i] CHAR(50) NULL, 
    [o] CHAR(50) NULL, 
    [dateob] DATETIME NULL, 
    [address] NCHAR(10) NULL, 
    [marstat] INT NOT NULL, 
    [nation] INT NOT NULL, 
    [iddoc] NCHAR(10) NULL, 
    [hiredate] DATETIME NOT NULL, 
    [dtoffiring] DATETIME NULL, 
    [note] TEXT NULL
)
