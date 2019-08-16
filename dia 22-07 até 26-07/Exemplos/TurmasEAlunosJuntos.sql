CREATE TABLE [dbo].[TurmasAlunos]
(
	[Turmas] INT NOT NULL, 
    [Alunos] INT NOT NULL ,

	CONSTRAINT [FK_TurmasAlunos_Turmas] FOREIGN KEY ([Turmas]) REFERENCES [Turmas]([Id]),
	CONSTRAINT [FK_TurmasAlunos_Alunos] FOREIGN KEY ([Alunos]) REFERENCES [Alunos]([Id])
)
