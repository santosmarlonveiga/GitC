insert into NotasAlunos
(Nome,Materia,Nota)
values
('Marlon', 'Gerografia',10);

select 
	Nome,
	Materia,
	(SUM(Nota) / COUNT(Nota)) as 'Media',
	COUNT(Nota) as 'Provas'
from NotasAlunos 

GROUP BY Nome,Materia

order by Nome asc