CREATE TABLE [dbo].[Carros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] INT NOT NULL, 
    [Ano] INT NOT NULL, 
	[Quantidade]INT NOT NULL,
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL,

	CONSTRAINT [FK_Carros_Usuario_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Carros_Usuario_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Carros_Estoque_Nome] FOREIGN KEY ([Nome]) REFERENCES [Estoque]([Id]),
	CONSTRAINT [FK_Carros_Estoque_Ano] FOREIGN KEY ([Ano]) REFERENCES [Estoque]([Id]),
	CONSTRAINT [FK_Carros_Estoque_Qnt] FOREIGN KEY ([Quantidade]) REFERENCES [Estoque]([Id])
)
