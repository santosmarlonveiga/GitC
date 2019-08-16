select 
	Lv.Id,
	Lv.Nome,
	IIF(LV.Alocado = 1, 'sim', 'não') as 'Alocado',
	BL.Nome as 'Nome da Biblioteca'
	from Bibliotecas BL
	inner join Livro LV on BL.Id = LV.Biblioteca