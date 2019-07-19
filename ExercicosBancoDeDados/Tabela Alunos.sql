CREATE TABLE [dbo].[Alunos] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (1000) NOT NULL,
    [Turma]  INT            NOT NULL,
    [UsuInc] INT            NOT NULL,
    [UsuAlt] INT            NOT NULL,
    [DatInc] DATE           DEFAULT (getdate()) NOT NULL,
    [DatAlt] DATE           DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alunos_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Alunos_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Alunos_Turmas] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id])
);

