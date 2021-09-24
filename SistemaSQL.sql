CREATE DATABASE gm;

USE gm;

-- ====================================== Tabelas do Sistema =============================

CREATE TABLE cidade (
	codigo INT NOT NULL,
	nome VARCHAR(70) NOT NULL,
	uf VARCHAR(2) NOT NULL,
	PRIMARY KEY(codigo)
);

CREATE TABLE sede (
	codigo INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
	endereco VARCHAR(60) NOT NULL,
	bairro VARCHAR(25) NOT NULL,
	cidade INT NOT NULL,
	PRIMARY KEY(codigo),
	CONSTRAINT FKSedeForCidade
		FOREIGN KEY (cidade) REFERENCES cidade(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

INSERT INTO sede(nome, endereco, bairro, cidade)
VALUES ('Minha Casa', 'Rua Hélio Alves de Figueiredo, 175', 'São Sebastião', 3164704);

CREATE TABLE usuario(
	codigo INT AUTO_INCREMENT,
	usuario VARCHAR(20) NOT NULL,
	senha VARCHAR(32) NOT NULL,
	nome VARCHAR(40) NOT NULL,
	permissao INT DEFAULT 1,
	vendedor INT DEFAULT 0,
	sede INT DEFAULT 0,
	pin VARCHAR(4),
	PRIMARY KEY(codigo)
);


INSERT INTO usuario(usuario, senha, nome, permissao, vendedor, sede, pin) 
VALUES('LUCASM', MD5('lucasg4'), 'Lucas Matheus Amaral Silva', 10, 1, 2, '0816');

CREATE TABLE tela(
	codigo INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
	disponivel INT DEFAULT 1,
	nivel INT DEFAULT 1,
	PRIMARY KEY(codigo)
);

INSERT INTO tela(nome, disponivel, nivel) VALUES
('CDCompra',    1,  10),
('CSCompra',    1,  10),
('PQCompra',    1,  10),
('CDCondicao',  1,  10),
('CSCondicao',  1,  10),
('CDMovimento', 1,  10),
('CSConta',     1,  10),
('CSPagar',     1,  10),
('CDCusto',     1,  10),
('CSCusto',     1,  10),
('PQCusto',     1,  10),
('CSEstoque',   1,  10),
('ATCompra',    1,  10),
('CDEndereco',  1,  10),
('CDPessoa',    1,  10),
('PQEndereco',  1,  10),
('PQPessoa',    1,  10),
('CDFamilia',   1,  10),
('CDProduto',   1,  10),
('CSFamilia',   1,  10),
('CSProduto',   1,  10),
('PQProduto',   1,  10),
('CDTela',      1,  10),
('CTUsuario',   1,  10),
('CTModulo',    1,  10),
('PQCidade',    1,  10),
('ATVenda',     1,  10),
('CSVenda',     1,  10),
('CDRelatorio', 1,  10),
('CSRelatorio', 1,  10),
('DGParametro', 1,  10),
('GRGrafico',   1,  10),
('GRTela',      1,  10);

-- ========================================= Cadastro de Pessoas ================================

CREATE TABLE pessoa (
	codigo INT AUTO_INCREMENT,
	nome VARCHAR(70) NOT NULL,
	documento VARCHAR(18) NOT NULL,
	observacao VARCHAR(200),
	contato VARCHAR(50),
	tipo INT DEFAULT 0,
	PRIMARY KEY(codigo),
	UNIQUE KEY pessoa (documento) USING HASH
);

CREATE TABLE endereco(
	codigo VARCHAR(10) NOT NULL,
	pessoa INT NOT NULL,
	rua VARCHAR(70),
	bairro VARCHAR(25),
	cidade INT NOT NULL,
	CONSTRAINT FKEndCidade
		FOREIGN KEY (cidade) REFERENCES cidade(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKEndPessoa
		FOREIGN KEY (pessoa) REFERENCES pessoa(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

INSERT INTO pessoa(nome, documento, observacao, contato, tipo)
VALUES('Venda Balcão', '00000000000', 'Cliente Padrão do Sistema', '', 0);

INSERT INTO endereco(codigo, pessoa, rua, bairro, cidade)
VALUES('Padrão', 1, 'Venda Balcão', '', 3164704);

-- ========================= Financeiro ==================================================

-- CREATE TABLE caixa (
-- 	codigo INT AUTO_INCREMENT,
-- 	dtcaixa DATE,
-- 	descricao VARCHAR(70),
-- 	tipo INT,
-- 	sede INT NOT NULL,
-- 	sequencia INT NOT NULL DEFAULT 1,
-- 	valor DECIMAL,
-- 	saldo DECIMAL,
-- 	refe_nome VARCHAR(10) DEFAULT 'FALSE',
-- 	refe_cod VARCHAR(15) DEFAULT 0,
-- 	PRIMARY KEY(codigo),
-- 	CONSTRAINT FKSedeForCaixa
-- 		FOREIGN KEY (sede) REFERENCES sede(codigo)
-- 		ON DELETE CASCADE
-- 		ON UPDATE CASCADE
-- );


CREATE TABLE custo_categoria(
	codigo INT AUTO_INCREMENT,
	nome VARCHAR(32),
	PRIMARY KEY(codigo)
);

CREATE TABLE custo (
	codigo INT AUTO_INCREMENT,
	pessoa INT NOT NULL,
	sede INT NOT NULL,
	tipo INT NOT NULL, -- 0 - Custo / 1 - Despesa
	emissao DATE NOT NULL,
	descricao VARCHAR(70) NOT NULL,
	observacao VARCHAR(200),
	valor DECIMAL NOT NULL,
	categoria INT NOT NULL,
	PRIMARY KEY(codigo),
	CONSTRAINT FKCustoPessoa
		FOREIGN KEY (pessoa) REFERENCES pessoa(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKCustoSede
		FOREIGN KEY (sede) REFERENCES sede(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKCustoCategoria
		FOREIGN KEY(categoria) REFERENCES custo_categoria(codigo)
);

-- Função para implantar custo/despesa e conseguir ID
DELIMITER //
CREATE FUNCTION NewCusto(Fornecedor INT, Loja INT, Tipo INT, Emissao DATE, Descricao VARCHAR(70), Observacao VARCHAR(200), Valor DECIMAL,
Categoria VARCHAR(30))
	RETURNS INT
BEGIN
	INSERT INTO custo(pessoa, sede, tipo, emissao, descricao, observacao, valor, categoria)
	VALUES(Fornecedor, Loja, Tipo, Emissao, Descricao, Observacao, Valor, Categoria);
	RETURN LAST_INSERT_ID();
END //
DELIMITER ;


CREATE TABLE contas (
	codigo INT AUTO_INCREMENT,
	emissao DATE NOT NULL,
	vencimento DATE NOT NULL,
	tipo INT NOT NULL,
	valor DECIMAL NOT NULL,
	sequencia INT DEFAULT 1,
	pessoa INT,
	sede INT NOT NULL,
	refe_nome VARCHAR(20),
	refe_cod INT DEFAULT 0,
	PRIMARY KEY(codigo),
	CONSTRAINT FKPagForne
		FOREIGN KEY (pessoa) REFERENCES pessoa(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKContaSede
		FOREIGN KEY (sede) REFERENCES sede(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE movi_contas (
	codigo INT AUTO_INCREMENT,
	dtmovimento DATE NOT NULL,
	descricao VARCHAR(50),
	conta INT NOT NULL,
	valor DECIMAL NOT NULL,
	PRIMARY KEY(codigo),
	CONSTRAINT FKMoviConta
		FOREIGN KEY (conta) REFERENCES contas(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE condicao (
	codigo INT AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	tipo INT DEFAULT 0,
	condicao VARCHAR(300) NOT NULL,
	PRIMARY KEY(codigo)
);

-- ========================= Produto / Estoque ===========================================

CREATE TABLE familia (
	codigo INT AUTO_INCREMENT,
	nome VARCHAR(70) NOT NULL,
	descricao VARCHAR(250),
	PRIMARY KEY(codigo)
);

CREATE TABLE produto (
	codigo INT AUTO_INCREMENT,
	cod_cliente VARCHAR(20) NOT NULL,
	descricao VARCHAR(100) NOT NULL,
	familia INT NOT NULL,
	unidade VARCHAR(30),
	cod_barra VARCHAR(200) DEFAULT '',
	situacao INT DEFAULT 1,
	preco DECIMAL DEFAULT 0,
	PRIMARY KEY(codigo),
	CONSTRAINT UNCliente UNIQUE (cod_cliente),
	CONSTRAINT FKFamiliaParaProduto
		FOREIGN KEY (familia) REFERENCES familia(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE estoque (
	codigo INT AUTO_INCREMENT,
	dtmov DATE NOT NULL,
	sede INT NOT NULL,
	produto INT NOT NULL,
	quantidade DECIMAL NOT NULL,
	tipo INT NOT NULL, -- 0 - Saída / 1 - Entrada
	refe_nome VARCHAR(20),
	refe_cod INT,
	PRIMARY KEY(codigo),
	CONSTRAINT FKEstSede
		FOREIGN KEY (sede) REFERENCES sede(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKEstProd
		FOREIGN KEY (produto) REFERENCES produto(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE compra (
	codigo INT AUTO_INCREMENT,
	sede INT NOT NULL,
	fornecedor INT NOT NULL,
	dtcompra DATE NOT NULL,
	condpagto INT NOT NULL,
	atendido INT NOT NULL,
	observacao VARCHAR(20),
	usuario INT NOT NULL,
	PRIMARY KEY(codigo),
	CONSTRAINT FKCondicaoPagamento
		FOREIGN KEY (condpagto) REFERENCES condicao(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKCompraFornecedor
		FOREIGN KEY (fornecedor) REFERENCES pessoa(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

CREATE TABLE compra_item (
	codigo INT AUTO_INCREMENT,
	compra INT NOT NULL,
	produto INT NOT NULL,
	quantidade DECIMAL NOT NULL,
	preco DECIMAL NOT NULL,
	PRIMARY KEY(codigo)
);

-- Função para implantar compra e conseguir ID
DELIMITER //
CREATE FUNCTION NewCompra(loja INT, Fornecedor INT, Dt DATE, Cond INT, Atendido INT, Observacao VARCHAR(200))
	RETURNS INT
BEGIN
	INSERT INTO compra(sede, fornecedor, dtcompra, observacao, condpagto, atendido)
	VALUES(loja, Fornecedor, Dt, Observacao, Cond, Atendido);
	RETURN LAST_INSERT_ID();
END //
DELIMITER ;

-- Função para obter Saldo
DELIMITER //
CREATE FUNCTION contas_saldo(Codigo INT)
	RETURNS DECIMAL
BEGIN
	RETURN (SELECT SUM(valor) FROM movi_contas WHERE conta = Codigo);
END //
DELIMITER ;


-- Trigger para inserir implatação da conta
DELIMITER //
CREATE TRIGGER ContasEntrada
AFTER INSERT ON contas FOR EACH ROW
BEGIN
	INSERT INTO movi_contas(dtmovimento, descricao, conta, valor) VALUES(NEW.emissao, 'Implantação', NEW.codigo, NEW.valor);
END; //
DELIMITER ;

-- Visão para Contas a pagar
CREATE OR REPLACE VIEW ContasPagar AS
(SELECT 
A.codigo AS numero,
A.emissao AS emissao,
A.vencimento AS vencimento,
A.valor AS original,
contas_saldo(A.codigo) AS saldo,
B.nome AS fornecedor,
CONCAT(refe_nome, ': ',refe_cod) AS referencia,
A.sede AS sede
FROM contas AS A
INNER JOIN pessoa AS B ON B.codigo = A.pessoa WHERE A.tipo = 0);

-- Visão para Contas a receber
CREATE OR REPLACE VIEW ContasReceber AS
(SELECT 
A.codigo AS numero,
A.emissao AS emissao,
A.vencimento AS vencimento,
A.valor AS original,
contas_saldo(A.codigo) AS saldo,
B.nome AS fornecedor,
CONCAT(refe_nome, ': ',refe_cod) AS referencia,
A.sede AS sede
FROM contas AS A
INNER JOIN pessoa AS B ON B.codigo = A.pessoa WHERE A.tipo = 1);

-- Visão para Crédito
CREATE OR REPLACE VIEW Credito AS
(SELECT 
A.codigo AS numero,
A.emissao AS emissao,
A.valor AS original,
contas_saldo(A.codigo) AS saldo,
B.codigo AS cod_fornecedor,
B.nome AS fornecedor,
CONCAT(refe_nome, ': ',refe_cod) AS referencia,
A.sede AS sede
FROM contas AS A
INNER JOIN pessoa AS B ON B.codigo = A.pessoa WHERE A.tipo = 3);

-- Função para obter saldo do estoque
DELIMITER //
CREATE FUNCTION SaldoEstoque (CodProduto INT)
	RETURNS DECIMAL
BEGIN
	RETURN (SELECT SUM(quantidade) FROM estoque WHERE produto = CodProduto);
END //
DELIMITER ;





-- === Vendas ===========================================================

CREATE TABLE venda (
	codigo INT AUTO_INCREMENT,
	dtimplantacao DATE NOT NULL,
	observacao VARCHAR(200) DEFAULT 'Venda',
	atendido INT DEFAULT 0,
	sede INT NOT NULL,
	pessoa INT NOT NULL,
	endereco VARCHAR(10),
	pagamento INT NOT NULL,
	usuario INT NOT NULL,
	PRIMARY KEY(codigo),
	CONSTRAINT FKVendaSede
		FOREIGN KEY (sede) REFERENCES sede(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKVendaPessoa
		FOREIGN KEY (pessoa) REFERENCES pessoa(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FkVendaCondicao
		FOREIGN KEY (pagamento) REFERENCES condicao(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);



CREATE TABLE venda_produto (
	codigo INT AUTO_INCREMENT,
	pedido INT NOT NULL,
	produto INT NOT NULL,
	quantidade DECIMAL NOT NULL,
	valor DECIMAL NOT NULL,
	PRIMARY KEY(codigo),
	CONSTRAINT FKVenPd
		FOREIGN KEY (pedido) REFERENCES venda(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT FKVProdProduto
		FOREIGN KEY (produto) REFERENCES produto(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

-- Função para conferência de estoque
CREATE OR REPLACE VIEW vendaestoque AS
(SELECT
pedido AS venda,
CONCAT(produto.codigo, ' - ', produto.descricao) AS produto,
quantidade AS solicitada,
SaldoEstoque(produto) AS disponivel
FROM venda_produto
INNER JOIN produto ON produto.codigo = venda_produto.produto);

-- Função para implantar venda e conseguir ID
DELIMITER //
CREATE FUNCTION NewVenda(Loja INT, Cliente INT, Entrega VARCHAR(10), Dt DATE, Cond INT, Atendido INT, Observacao VARCHAR(200), UserC INT)
	RETURNS INT
BEGIN
	INSERT INTO venda(atendido, dtimplantacao, observacao, sede, pessoa, endereco, pagamento, usuario)
	VALUES(Atendido, Dt, Observacao, Loja, Cliente, Entrega, Cond, UserC);
	RETURN LAST_INSERT_ID();
END //
DELIMITER ;

-- === Relatório =========================================================

CREATE TABLE relatorio (
	codigo INT AUTO_INCREMENT,
	descricao VARCHAR(70) NOT NULL,
	observacao VARCHAR(1000),
	permissao INT NOT NULL DEFAULT 0,
	comando VARCHAR(500),
	PRIMARY KEY(codigo)
);

CREATE TABLE relatorio_parametro (
	relatorio INT NOT NULL,
	parametro VARCHAR(25) NOT NULL,
	tipo INT NOT NULL,
	CONSTRAINT FKRelatorioParametro
		FOREIGN KEY (relatorio) REFERENCES relatorio(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);

-- Função para implantar venda e conseguir ID
DELIMITER //
CREATE FUNCTION NewRelatorio(Descricao VARCHAR(70), Observacao VARCHAR(250), Permissao INT, Comando VARCHAR(500))
	RETURNS INT
BEGIN
	INSERT INTO relatorio(descricao, observacao, permissao, comando)
	VALUES(Descricao, Observacao, Permissao, Comando);
	RETURN LAST_INSERT_ID();
END //
DELIMITER ;

CREATE TABLE relatorio_programado (
	codigo INT AUTO_INCREMENT,
	nome VARCHAR(32) NOT NULL,
	email VARCHAR(50) NOT NULL,
	relatorio INT NOT NULL,
	tipo INT NOT NULL,
	ultimo DATE NOT NULL,
	PRIMARY KEY(codigo),
	CONSTRAINT FKRelatorioProgramado
		FOREIGN KEY (relatorio) REFERENCES relatorio(codigo)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);