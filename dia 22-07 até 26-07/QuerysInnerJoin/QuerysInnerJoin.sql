--Trazer somente as marcas que Felipe cadastrou
select 
	M.Nome,
	Us.Usuario
from Marcas M
inner join Usuarios Us on M.UsuInc = Us.Id
where m.UsuInc = 1;


--Trazer somente as marcas que Giomar cadastrou
select 
	M.Nome,
	Us.Usuario
from Marcas M
inner join Usuarios Us on M.UsuInc = Us.Id
where m.UsuInc = 2;

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para Menor
select 
	count (M.UsuInc) 'Qnt de Marcas cadastradas',
	Us.Usuario
from Marcas M
inner join Usuarios Us on M.UsuInc = Us.Id
where m.UsuInc = 1
group by Us.Usuario
order by Us.Usuario desc;

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select 
	count (M.UsuInc) 'Qnt de Marcas cadastradas',
	Us.Usuario
from Marcas M
inner join Usuarios Us on M.UsuInc = Us.Id
where m.UsuInc = 2
group by Us.Usuario
order by Us.Usuario asc;

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select 
	count (M.UsuInc) 'Qnt de Marcas cadastradas',
	Us.Usuario
from Marcas M
inner join Usuarios Us on M.UsuInc = Us.Id
group by Us.Usuario
order by Us.Usuario desc;

--Trazer somente os carros que Felipe cadastrou
select 
	Us.Usuario,
	Ca.Modelo
from Carros Ca
inner join Usuarios Us on Ca.UsuInc = Us.Id
where Ca.UsuInc = 1;

--Trazer somente os carros que Giomar cadastrou
select 
	Us.Usuario,
	Ca.Modelo
from Carros Ca
inner join Usuarios Us on Ca.UsuInc = Us.Id
where Ca.UsuInc = 2;

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select 
	count (Ca.UsuInc) 'Qnt de carros cadastrados',
	Us.Usuario
from Carros Ca
inner join Usuarios Us on Ca.UsuInc = Us.Id
where Ca.UsuInc = 1
group by Us.Usuario
order by 'Qnt de carros cadastrados' desc;

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select 
	count (Ca.UsuInc) 'Qnt de carros cadastrados',
	Us.Usuario
from Carros Ca
inner join Usuarios Us on Ca.UsuInc = Us.Id
where Ca.UsuInc = 2
group by Us.Usuario
order by 'Qnt de carros cadastrados' asc;

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram
select 
	count (Ca.UsuInc) 'Qnt de carros cadastrados',
	Us.Usuario
from Carros Ca
inner join Usuarios Us on Ca.UsuInc = Us.Id
group by Us.Usuario
order by 'Qnt de carros cadastrados' asc;

--Trazer somente os carros das marcas que Felipe cadastrou
select 
	Ca.Modelo as 'Carros',
	M.Nome as 'Marca'
from Carros Ca
inner join Marcas M on M.Id = Ca.Marca
where M.UsuInc = 1;

--Trazer somente os carros das marcas que Giomar cadastrou
select 
	Ca.Modelo as 'Carros',
	M.Nome as 'Marca'
from Carros Ca
inner join Marcas M on M.Id = Ca.Marca
where M.UsuInc = 2;

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select 
	count (Ca.UsuInc) as 'Quantidade',
	M.Nome as 'Marcas'
from Carros Ca
inner join Marcas M on Ca.Marca = M.Id
where M.UsuInc = 1
group by M.Nome
order by 'Quantidade' desc;

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select 
	count (Ca.UsuInc) as 'Quantidade',
	M.Nome as 'Marcas'
from Carros Ca
inner join Marcas M on Ca.Marca = M.Id
where M.UsuInc = 2
group by M.Nome
order by 'Quantidade' asc;

--Trazer o valor total de vendas 2019 isolado
select 
	year(V.DatInc) as  'Ano das vendas',
	sum (V.Quantidade) as 'Qnt de carros vendidos'
from Vendas V
where year(V.DatInc) = 2019 
group By year(V.DatInc);

--Trazer a quantidade total de vendas 2019 isolado
select 
	year(V.DatInc) as  'Ano das vendas',
	sum (V.Quantidade * V.Valor) as 'Total das vendas'
from Vendas V
where year(V.DatInc) = 2019 
group By year(V.DatInc);

--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
select
	sum(V.Quantidade * V.Valor) as  'Total De Vendas',
	year(V.DatInc) as 'Ano das Vendas'
from Vendas V
group by year(V.DatInc)
order by 'Total De Vendas' desc;

--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
select 
	sum(V.Quantidade) as 'Quantidade Anual',
	year(V.DatInc) as 'Ano das Vendas'
from Vendas V
group by year(V.DatInc)
order by 'Quantidade Anual' desc;

--Trazer o mês de cada ano que retornou a maior quantidade de vendas
select 
	sum(V.Quantidade * V.Valor) as 'Valor Total',
	month(V.DatInc) as 'Mês da Venda'
from Vendas V
group by month(V.DatInc)
order by 'Valor Total' desc;

--Trazer o mês de cada ano que retornou o maior valor de vendas
select 
	sum(V.Quantidade) as 'Quantidade de Carros',
	month(V.DatInc)as 'Mês das vendas'
from Vendas V
group by month(V.DatInc)
order by 'Quantidade de Carros' desc;

--Trazer o valor total de vendas que Felipe realizou
select 
	sum(V.Quantidade * V.Valor) as 'Valor das Vendas',
	V.UsuInc
from Vendas V
where V.UsuInc = 1
group by V.UsuInc;

--Trazer o valor total de vendas que Giomar realizou
select 
	sum(V.Quantidade * V.Valor) as 'Valor das Vendas',
	V.UsuInc
from Vendas V
where V.UsuInc = 2
group by V.UsuInc;

--Trazer a quantidade total de vendas que Felipe realizou
select 
	sum(V.Quantidade) as 'Qnt Total de Vendas',
	V.UsuInc
from Vendas V
where V.UsuInc = 1
group by V.UsuInc;

--Trazer a quantidade de vendas que Giomar realizou
select 
	sum(V.Quantidade) as 'Qnt Total de Vendas',
	V.UsuInc
from Vendas V
where V.UsuInc = 2
group by V.UsuInc;

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select
	sum(V.Quantidade) as 'Quantidade de Vendas',
	Us.Usuario
from Vendas V
inner join Usuarios Us on V.UsuInc = Us.Id
group by Us.Usuario
order by 'Quantidade de Vendas' desc;

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select 
	sum(V.Quantidade * V.Valor) as 'Valor Total',
	Us.Usuario
from Vendas V
inner join Usuarios Us on V.UsuInc = Us.Id
group by Us.Usuario
order by 'Valor Total' desc;

--Trazer  a marca mais vendida de todos os anos
select 
	sum(V.Quantidade) as 'Qnt de carros vendidos',
	Ma.Nome as 'Marca'
from Vendas V
inner join Carros Ca on V.Carro = Ca.Id
inner join Marcas Ma on Ca.Marca = Ma.Id
group by Ma.Nome
order by 'Qnt de carros vendidos' desc;

--Trazer o valor total da marca mais vendida de todos os anos
select 
	sum(V.Quantidade * V.Valor) as 'Valor das Vendas',
	Ma.Nome as 'Marca'
from Vendas V
inner join Carros Ca on V.Carro = Ca.Id
inner join Marcas Ma on Ca.Marca = Ma.Id
group by Ma.Nome
order by 'Valor das Vendas' desc;

--Trazer a quantidade do carro mais vendido de todos os anos
select 
	sum(V.Quantidade) as 'Quantidade de carros',
	Ca.Modelo
from Vendas V
inner join Carros Ca on V.Carro = Ca.Id
group by Ca.Modelo
order by 'Quantidade de carros' desc;

--Trazer o valor do carro mais vendido de todos os anos
select 
	sum(V.Quantidade * V.Valor) as 'Valor Total',
	Ca.Modelo
from Vendas V
inner join Carros Ca on V.Carro = Ca.Id
group by Ca.Modelo
order by 'Valor Total' desc;