select
	Cardapio,
	SUM(TotalVendas) AS 'Vendas',
	 Month(DataDaVenda) as 'Mês Das Vendas'
	from BarracaDoDog

group by Cardapio, Month(DataDaVenda) 
order by Vendas desc