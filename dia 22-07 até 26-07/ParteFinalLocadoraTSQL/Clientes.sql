CREATE TABLE [dbo].[Clientes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] VARCHAR(100) NOT NULL,
	[Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL, 
    CONSTRAINT [FK_Clientes_Usuario_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Clientes_Usuario_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)
