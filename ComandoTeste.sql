-- Comando a ser executado para puxar itens
SELECT quantidade AS Quantidade, descricao AS Nome, A.preco AS Preço, (quantidade * A.preco) AS Total  FROM compra_item AS A INNER JOIN produto AS B ON B.codigo = A.produto;

-- Comando da tela PQCompra
SELECT
A.codigo AS Numero,
A.dtcompra AS Data_compra,
C.nome AS Loja,
B.nome AS Fornecedor,
A.observacao AS Observacao,
REPLACE(REPLACE(atendido, 0, 'NÃO ATENDIDO'), 1, 'ATENDIDO') AS Situação
FROM compra AS A
INNER JOIN pessoa AS B ON B.codigo = A.fornecedor
INNER JOIN sede AS C ON C.codigo = A.sede
ORDER BY A.codigo ASC
LIMIT 100;

-- Select da tela Consulta
SELECT 
A.codigo AS Numero,
A.emissao AS Emissão,
A.vencimento AS Vecimento,
A.valor AS Original,
contas_saldo(A.codigo) AS Saldo,
B.nome AS Fornecedor,
CONCAT(refe_nome, ': ',refe_cod) AS Referencia
FROM contas AS A
INNER JOIN pessoa AS B ON B.codigo = A.pessoa;

CREATE OR REPLACE VIEW ContasPagar AS
(SELECT 
A.codigo AS Numero,
A.emissao AS Emissão,
A.vencimento AS Vecimento,
A.valor AS Original,
contas_saldo(A.codigo) AS Saldo,
B.nome AS Fornecedor,
CONCAT(refe_nome, ': ',refe_cod) AS Referencia,
A.sede AS sede
FROM contas AS A
INNER JOIN pessoa AS B ON B.codigo = A.pessoa);


SELECT * FROM contaspagar WHERE sede = 2 AND emissao BETWEEN '2021-07-08' AND '2021-07-15';

SELECT SUM(valor) FROM movi_contas WHERE conta = 14;

SELECT SaldoEstoque(1);

SELECT * FROM estoque ORDER BY dtmov, codigo ASC;

SELECT COUNT(codigo) FROM cidade

SELECT codigo, sequencia, vencimento, FORMAT(valor, 'C', 'pt-br'), contas_saldo(codigo) AS saldo FROM contas WHERE refe_nome = 'Custo' AND refe_cod = 7

SELECT codigo FROM custo ORDER BY codigo DESC LIMIT 1

SELECT * FROM relatorio WHERE permissao <= 6

SELECT  vencimento AS 'Dia', CONCAT('R$ ', FORMAT((valor - contas_saldo(codigo)), 2, 'pt_BR')) AS 'Recebimento dia (R$)' FROM contas  WHERE refe_nome = 'Venda' AND CONCAT(LPAD(MONTH(vencimento),2,0), '/', YEAR(vencimento)) = '08/2021' GROUP BY vencimento

SELECT LPAD(codigo, 6, 0) AS Codigo, LPAD(sequencia, 2, 0) AS Parcela, DATE_FORMAT(vencimento,'%d/%m/%Y') AS Vencimento, CONCAT('R$ ', FORMAT(valor, 2, 'pt_BR')) AS 'Valor (R$)', CONCAT('R$ ', FORMAT(contas_saldo(codigo), 2, 'pt_BR')) AS 'Saldo (R$)' FROM contas

SELECT 
CONCAT('Dia ', LPAD(DAY(dtmov),2,0)) AS Dia, 
(SELECT IFNULL(SUM(quantidade),0) FROM estoque WHERE tipo = 1 AND dtmov = est.dtmov) AS Entrada,
(SUM(quantidade)*-1) AS Saida
FROM estoque AS est
WHERE tipo = 0 
AND MONTH(dtmov) = 7
GROUP BY DAY(dtmov)

SELECT COUNT(codigo) FROM usuario WHERE usuario = 'LUCASM' AND codigo != 0;

SELECT * FROM Credito WHERE cod_fornecedor = 3;