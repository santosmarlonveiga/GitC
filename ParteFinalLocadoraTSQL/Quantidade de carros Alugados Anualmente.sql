select 
	
	year(l.datAlo) as 'Ano de Locação',
	count (l.[Nome Carro]) as 'Quantidade'
from Locacao l
inner join Carros Ca on l.[Nome Carro] = Ca.Id
inner join Estoque Es on Ca.Nome = Es.Id

group by year(l.datAlo) 
order by 'Quantidade' desc