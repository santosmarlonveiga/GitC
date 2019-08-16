select
a.Nome,
(sum(nt.Notas)/count(*)) as 'Média',
iif(((sum(nt.Notas)/count(*)) >= 7), 'Aprovado', 'Reprovado') as 'Status Media',
iif(((count(iif(Presenca=1,1,null))) >= 3),'Aprovado', 'Reprovado') as 'Status Frequencia'
from Alunos a
inner join Notas nt on nt.Nome = a.Id
group by a.Nome;