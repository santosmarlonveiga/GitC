CREATE TABLE [dbo].[Notas] (
    [Id]       INT  IDENTITY (1, 1) NOT NULL,
    [Nome]     INT  NOT NULL,
    [Turma]    INT  NOT NULL,
    [Notas]    INT  NOT NULL,
    [Presenca] BIT  NOT NULL,
    [UsuInc]   INT  NOT NULL,
    [UsuAlt]   INT  NOT NULL,
    [DatInc]   DATE DEFAULT (getdate()) NOT NULL,
    [DatAlt]   DATE DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Notas_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Notas_AlunosNome] FOREIGN KEY ([Nome]) REFERENCES [dbo].[Alunos] ([Id]),
    CONSTRAINT [FK_Alunos_TurmasNome] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id])
);

