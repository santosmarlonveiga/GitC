select
	Bl.Nome,
	COUNT(LV.Id) as 'QuantidadeLivros'
	from Bibliotecas BL
	inner join Livro LV on BL.Id = LV.Biblioteca
	group by BL.Nome