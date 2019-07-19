CREATE TABLE [dbo].[Usuario] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Login]  VARCHAR (100) NOT NULL,
    [Senha]  VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATE          DEFAULT (getdate()) NOT NULL,
    [DatAlt] DATE          DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

