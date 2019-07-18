select
	Bl.Nome,
	COUNT(LV.Id) as 'QuantidadeLivros',
	US.Nome as 'UserName'
	from Bibliotecas BL
	inner join Livro LV on BL.Id = LV.Biblioteca
	inner join Usuario US on LV.UsuInc = US.Id
	group by BL.Nome,US.Nome