select
	bl.Nome,
	(select COUNT(*)
	from Livro LV
	where lv.Biblioteca = bl.Id) as 'QuantLivros'
from Bibliotecas bl
