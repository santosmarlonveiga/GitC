CREATE TABLE [dbo].[Diario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Data] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Turma] INT NOT NULL,
	[Obs] VARCHAR(500) NOT NULL,
	[Ativo] BIT NOT NULL,
	[UsuInc] INT NOT NULL,
	[UsuAlt] INT NOT NULL,
	[DatInc] DATETIME NOT NULL,
	[DatAlt] DATETIME NOT NULL, 
    CONSTRAINT [FK_Diario_Turmas] FOREIGN KEY ([Turma]) REFERENCES [Turmas]([Id]),
    CONSTRAINT [FK_Diario_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Diario_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)
