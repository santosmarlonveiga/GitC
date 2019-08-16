insert into Usuario
(Nome,[Login],Senha,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Geisi', 'geisi', '1234567', 'True', 1, 1, GETDATE(),GETDATE())
go
select * from Usuario