CREATE TABLE ListaStudenti
(
	[NumarMatricol] INT NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(MAX) NOT NULL, 
    [Grupa] INT NOT NULL, 
    [Enabled] BIT NOT NULL DEFAULT 1 
)
