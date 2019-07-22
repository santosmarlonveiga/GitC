CREATE TABLE [dbo].[Locacao]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Cliente] INT NOT NULL, 
    [Nome Carro] INT NOT NULL, 
    [Locado?] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL,

	CONSTRAINT [FK_Locacao_Clientes_Nome] FOREIGN KEY ([Cliente]) REFERENCES [Clientes]([Id]),
	CONSTRAINT [FK_Locacao_Estoque_Nome] FOREIGN KEY ([Nome Carro]) REFERENCES [Estoque]([Id]),
	CONSTRAINT [FK_Locacao_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Locacao_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)
