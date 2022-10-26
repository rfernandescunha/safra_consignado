/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 

cli.nome,
SUM(CASE WHEN par.dt_venc_parcela < GETDATE() AND par.dt_pgto_parcela IS NULL THEN 1 ELSE 0 END)  AS 'VENCIDAS',
SUM(CASE WHEN par.dt_pgto_parcela IS NOT NULL THEN 1 ELSE 0 END)  AS 'PAGAS',
SUM(CASE WHEN par.dt_venc_parcela >= GETDATE() AND par.dt_pgto_parcela IS NULL THEN 1 ELSE 0 END)  AS 'A VENCER',
SUM(CASE WHEN par.dt_pgto_parcela IS NOT NULL  THEN 1 ELSE 0 END)*100/count(par.idParcela) as 'PERCENTUAL PAGA',
SUM(CASE WHEN par.dt_venc_parcela >= GETDATE() AND par.dt_pgto_parcela IS NULL THEN 1 ELSE 0 END)*100/count(par.idParcela) as 'PERCENTUAL NÃO PAGA'

FROM tab_parcela par 
  inner join tab_financiamento fin on fin.idFinanciamento = par.idFinanciamento
  inner join tab_cliente cli on cli.idCliente = fin.idCliente

Where cli.uf = 'SP'

group by cli.nome