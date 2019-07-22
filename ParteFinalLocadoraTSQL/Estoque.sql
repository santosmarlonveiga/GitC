CREATE TABLE [dbo].[Estoque]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Ano] INT NOT NULL, 
    [Quantidade] INT NOT NULL, 
    [Ativo] BIT NOT NULL,
	[UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL,

	CONSTRAINT [FK_Estoque_Usuario_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Estoque_Usuario_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)
