CREATE TABLE ListaGrupe
(
	[IdGrupa] INT NOT NULL PRIMARY KEY, 
    [IdSpecializare] INT NOT NULL, 
    [Enabled] BIT NOT NULL DEFAULT 1
)
