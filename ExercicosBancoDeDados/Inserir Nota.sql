insert into Notas
(Nome,Turma,Notas,Presenca,UsuInc,UsuAlt,DatInc,DatAlt)
values
(1,1,10,'True',1,1,GETDATE(),GETDATE())
go
select * from Notas