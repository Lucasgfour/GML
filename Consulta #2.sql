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


SELECT * FROM ContasPagar WHERE sede = 1 AND emissao BETWEEN '2021-07-08' AND '2021-07-09';

SELECT SUM(valor) FROM movi_contas WHERE conta = 14;

SELECT SaldoEstoque(1);

SELECT * FROM estoque ORDER BY dtmov, codigo ASC;
