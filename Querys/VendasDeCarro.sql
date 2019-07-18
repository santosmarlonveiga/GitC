select 'Carros' as 'Carros',
	SUM(Temp.Media) as 'Vendas',
	Temp.AnoVenda
	from (
	   select
				Modelo,
				Ano,
				(SUM(NumerodeVendas) / COUNT(*)) as 'Media',
				YEAR(DataDaVenda) as 'AnoVenda'
			from VendaDeCarros
			group by Modelo,Ano,YEAR(DataDaVenda)) Temp
group by Temp.AnoVenda