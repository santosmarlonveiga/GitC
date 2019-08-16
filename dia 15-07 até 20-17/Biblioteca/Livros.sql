﻿CREATE TABLE [dbo].[Livros] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Registro]     INT            NOT NULL,
    [Titulo]       VARCHAR (1200) NOT NULL,
    [Isbn]         VARCHAR (20)   NOT NULL,
    [Genero]       INT            NOT NULL,
    [Editora]      INT            NOT NULL,
    [Sinopse]      NVARCHAR (MAX) NULL,
    [Observacaoes] VARCHAR (1000) NULL,
    [Ativo]        BIT            NOT NULL,
    [UsuInc]       INT            NOT NULL,
    [UsuAlt]       INT            NOT NULL,
    [DatInc]       DATETIME       DEFAULT (getdate()) NOT NULL,
    [DatAlt]       DATETIME       DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Livros_To_Genero] FOREIGN KEY ([Genero]) REFERENCES [dbo].[Genero] ([Id]),
    CONSTRAINT [FK_Livros_To_Editora] FOREIGN KEY ([Editora]) REFERENCES [dbo].[Editora] ([Id]),
    CONSTRAINT [FK_Livros_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Livros_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);

