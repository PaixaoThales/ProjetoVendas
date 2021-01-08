CREATE DATABASE dbVendas
use dbVendas
CREATE TABLE Produtos(
codigo INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
preco numeric(10,2),
quantidade int,
status bit,
caminhoFoto VARCHAR(100),
)
CREATE TABLE Vendedores(
codigo INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
comissao int,
email VARCHAR(60),
status bit,
)
CREATE TABLE Clientes(
codigo INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(50),
endereco VARCHAR(50),
status bit,
)
CREATE TABLE Grupos(
codigo INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(30),
status bit,
clienteConsultar BIT,
clienteIncluir BIT,
clienteAlterar BIT,
clienteAtivar BIT,
clienteDesativar BIT,

produtoConsultar BIT,
produtoIncluir BIT,
produtoAlterar BIT,
produtoAtivar BIT,
produtoDesativar BIT,

vendedoresConsultar BIT,
vendedoresIncluir BIT,
vendedoresAlterar BIT,
vendedoresAtivar BIT,
vendedoresDesativar BIT,

vendasConsultar BIT,
vendasIncluir BIT,
vendasAlterar BIT,
vendasAtivar BIT,
vendasDesativar BIT,

usuarioConsultar BIT,
usuarioIncluir BIT,
usuarioAlterar BIT,
usuarioAtivar BIT,
usuarioDesativar BIT,

grupoConsultar BIT,
grupoIncluir BIT,
grupoAlterar BIT,
grupoAtivar BIT,
grupoDesativar BIT,
)
CREATE TABLE Usuarios(
codigo INT PRIMARY KEY IDENTITY(1,1),
codFuncionario INT,
login VARCHAR(20),
senha VARCHAR(32),
status bit,
codGrupo int,
FOREIGN KEY (codGrupo) REFERENCES Grupos (codigo),
FOREIGN KEY (codFuncionario) REFERENCES Vendedores (codigo)
)
CREATE TABLE Telefones(
codigo INT PRIMARY KEY IDENTITY(1,1),
codCliente INT,
numero VARCHAR(15),
tipo VARCHAR(20) 
FOREIGN KEY (codCliente) REFERENCES Clientes (codigo),
)
CREATE TABLE Vendas(
	codigo INT PRIMARY KEY IDENTITY(1,1),
	data DATE NOT NULL,
	codVendedor INT NOT NULL,
	codCliente INT NOT NULL,
	FOREIGN KEY (codVendedor) REFERENCES Vendedores (codigo),
	FOREIGN KEY (codCliente) REFERENCES Clientes (codigo)
)
CREATE TABLE ItemVenda(
	codigo INT PRIMARY KEY IDENTITY(1,1),
	codVenda INT NOT NULL,
	codProduto INT NOT NULL,
	quantidade INT NOT NULL,
	preco numeric(10,2),
	FOREIGN KEY (codVenda) REFERENCES Vendas (codigo),
	FOREIGN KEY (codProduto) REFERENCES Produtos (codigo)
)
CREATE TABLE Comissoes(
	codigo INT NOT NULL PRIMARY KEY IDENTITY,
	codVendedor INT,
	codItemVenda INT,
	data DATE,
	quantidade INT,
	vlUnit NUMERIC(10,2),
	comissao INT,
	vlComissa NUMERIC(10,2),

	FOREIGN KEY (codVendedor) REFERENCES Vendedores(codigo),
	FOREIGN KEY (codItemVenda) REFERENCES ItemVenda(codigo)
)

CREATE TRIGGER fiVenda --Cria TRIGGER
ON ItemVenda -- Em qual tabela ela será disparada
FOR INSERT --AFTER faz com que o disparo se dê somente após a ação que o gerou ser concluída, INSTEAD OF faz com que o trigger seja executado no lugar da ação que o gerou e FOR é o valor padrão e faz com o que o gatilho seja disparado junto da ação:INSERT, UPDATE, DELETE
AS 
BEGIN 
	DECLARE 
		@quantidade int,
		@codigo int,
		@qtdEst int;

	DECLARE cursorProdutosI CURSOR FOR
		SELECT
			INSERTED.quantidade, 
			INSERTED.codProduto,
			Produtos.quantidade
		FROM 
		INSERTED
		INNER JOIN Produtos
		ON Produtos.codigo = INSERTED.codProduto

	OPEN cursorProdutosI
	FETCH NEXT FROM cursorProdutosI INTO @quantidade, @codigo, @qtdEst
		WHILE @@FETCH_STATUS = 0
		BEGIN
			IF @quantidade > 0 
				BEGIN
				IF @quantidade <= @qtdEst
					BEGIN
						UPDATE Produtos SET quantidade = quantidade - @quantidade WHERE codigo = @codigo
					END
				ELSE
					BEGIN
						SELECT 'Erro, Não há essa quantidade no estoque!!!'
					END
				END
			ELSE
				BEGIN
					SELECT 'Erro, insira um valor maior que zero!!!'
			END
			FETCH NEXT FROM cursorProdutosI INTO @quantidade, @codigo, @qtdEst
		END
	CLOSE cursorProdutosI
	DEALLOCATE cursorProdutosI
END


CREATE TRIGGER fdVenda 
ON ItemVenda
FOR DELETE 
AS 
BEGIN 
	DECLARE 
		@quantidade int,
		@codigo int;

	DECLARE cursorProdutosD CURSOR FOR
		SELECT
			quantidade, 
			codProduto
		FROM 
		DELETED

	OPEN cursorProdutosD
	FETCH NEXT FROM cursorProdutosD INTO @quantidade, @codigo
		WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE Produtos SET quantidade = quantidade + @quantidade WHERE codigo = @codigo
			FETCH NEXT FROM cursorProdutosD INTO @quantidade, @codigo
		END
	CLOSE cursorProdutosD
	DEALLOCATE cursorProdutosD
		
END


CREATE TRIGGER fuVenda
ON ItemVenda
FOR UPDATE
AS
BEGIN
	DECLARE 
		@quantidadeD int,
		@codigoD int,
		@quantidadeI int,
		@codigoI int;
	DECLARE cursorProdutosUI CURSOR FOR
		SELECT quantidade, codProduto FROM INSERTED

	DECLARE cursorProdutosUD CURSOR FOR
		SELECT quantidade, codProduto FROM DELETED
		
	OPEN cursorProdutosUD
	FETCH NEXT FROM cursorProdutosUD INTO @quantidadeD, @codigoD
		WHILE @@FETCH_STATUS = 0
		BEGIN
			UPDATE Produtos SET quantidade = quantidade + @quantidadeD
			WHERE codigo = @codigoD

			FETCH NEXT FROM cursorProdutosUD INTO @quantidadeD, @codigoD
		END
	
	CLOSE cursorProdutosUD
	DEALLOCATE cursorProdutosUD

	OPEN cursorProdutosUI
	FETCH NEXT FROM cursorProdutosUI INTO @quantidadeI, @codigoI
		WHILE @@FETCH_STATUS = 0
		BEGIN

			UPDATE Produtos SET quantidade = quantidade - @quantidadeI
			WHERE codigo = @codigoI
			FETCH NEXT FROM cursorProdutosUI INTO @quantidadeI, @codigoI
		END
	CLOSE cursorProdutosUI
	DEALLOCATE cursorProdutosUI

END


CREATE TRIGGER aiItemVenda
ON ItemVenda
AFTER INSERT
AS
BEGIN
	DECLARE
		@codVendedor INT,
		@data DATE,
		@codigo INT,	
		@quantidade INT,
		@preco NUMERIC(10,2),
		@comissao INT;

		DECLARE cursorComissaoI CURSOR FOR
			SELECT  Vendas.codVendedor, Vendas.data, INSERTED.codigo, INSERTED.quantidade, Produtos.preco, Vendedores.comissao FROM INSERTED 
			INNER JOIN Vendas 
			ON Vendas.codigo = INSERTED.codVenda
			INNER JOIN Produtos
			ON Produtos.codigo = inserted.codProduto
			INNER JOIN Vendedores
			ON Vendas.codVendedor = Vendedores.codigo

	OPEN cursorComissaoI
	FETCH NEXT FROM cursorComissaoI INTO @codVendedor, @data, @codigo, @quantidade, @preco, @comissao
		WHILE @@FETCH_STATUS = 0
		BEGIN
			INSERT INTO Comissoes VALUES(
			@codVendedor, 
			@codigo, 
			@data, 
			@quantidade,
			@preco,
			@comissao,
			((@quantidade * @preco) * @comissao) / 100
			)
			FETCH NEXT FROM cursorComissaoI INTO @codVendedor, @data, @codigo, @quantidade, @preco, @comissao
		END
	
	CLOSE cursorComissaoI
	DEALLOCATE cursorComissaoI
	
END


CREATE TRIGGER adItemVenda
ON ItemVenda
INSTEAD OF DELETE
AS
BEGIN
	DECLARE
	@codigo int;

	DECLARE cursorComissaoD CURSOR FOR 
	SELECT codigo FROM deleted

	OPEN cursorComissaoD
	FETCH NEXT FROM cursorComissaoD INTO @codigo
		WHILE @@FETCH_STATUS = 0
		BEGIN
			DELETE	FROM Comissoes WHERE codItemVenda = @codigo
			FETCH NEXT FROM cursorComissaoD INTO @codigo
		END		
	CLOSE cursorComissaoD
	DEALLOCATE cursorComissaoD
	DELETE FROM ItemVenda WHERE codigo = @codigo
END


CREATE TRIGGER auItemVenda
ON ItemVenda
AFTER UPDATE 
AS
BEGIN
	DECLARE
	@codigoD INT,
	@codVendedor INT,
	@data DATE,
	@codigoI INT,	
	@quantidade INT,
	@preco NUMERIC(10,2),
	@comissao INT;

	DECLARE cursorComissaoI CURSOR FOR
			SELECT  Vendas.codVendedor, Vendas.data, INSERTED.codigo, INSERTED.quantidade, Produtos.preco, Vendedores.comissao FROM INSERTED 
			INNER JOIN Vendas 
			ON Vendas.codigo = INSERTED.codVenda
			INNER JOIN Produtos
			ON Produtos.codigo = inserted.codProduto
			INNER JOIN Vendedores
			ON Vendas.codVendedor = Vendedores.codigo

	DECLARE cursorComissaoU CURSOR FOR
			SELECT codigo FROM deleted
	

	OPEN cursorComissaoI 
	OPEN cursorComissaoU
	FETCH NEXT FROM cursorComissaoI INTO @codVendedor, @data, @codigoI, @quantidade, @preco, @comissao
		WHILE @@FETCH_STATUS =0
		BEGIN
			FETCH NEXT FROM cursorComissaoU INTO @codigoD
			WHILE @@FETCH_STATUS = 0
			BEGIN
				UPDATE Comissoes SET codVendedor = @codVendedor,
				codItemVenda = @codigoD,
				data = @data,
				quantidade =  @quantidade,
				vlUnit = @preco,
				comissao = @comissao,
				vlComissa = ((@quantidade * @preco) * @comissao) / 100
				WHERE codItemVenda = @codigoD
				FETCH NEXT FROM cursorComissaoU INTO @codigoD
			END
			DEALLOCATE cursorComissaoU
			CLOSE cursorComissaoU
		END
	DEALLOCATE cursorComissaoI
	CLOSE cursorComissaoI
END


CREATE PROCEDURE calcularComissoes @dataInicial AS DATE, @dataFinal AS DATE
AS
BEGIN
	DECLARE @codigoV INT, @nome VARCHAR(30),@totalVenda DECIMAL(9,2);
	
	DECLARE  cursorVendedor  CURSOR FOR SELECT Vendedores.codigo , Vendedores.nome, SUM(ItemVenda.quantidade * Produtos.preco) AS Total FROM Vendedores 
	INNER JOIN Vendas ON Vendedores.codigo = Vendas.codVendedor
	INNER JOIN ItemVenda ON Vendas.codigo = ItemVenda.codVenda
	INNER JOIN Produtos ON ItemVenda.codProduto = Produtos.codigo
	WHERE Vendas.data >= @dataInicial AND Vendas.data <= @dataFinal
	GROUP BY Vendedores.codigo, Vendedores.nome

	OPEN cursorVendedor;
	FETCH NEXT FROM cursorVendedor INTO @codigoV, @nome, @totalVenda;
		WHILE @@FETCH_STATUS = 0 
		BEGIN
		DECLARE @codigoC INT, @comissao INT, @totalC DECIMAL(9,2);
		DECLARE cursorComissao CURSOR FOR SELECT codigo, comissao, (vlUnit * quantidade) 
		FROM Comissoes WHERE codVendedor = @codigoV AND data >= @dataInicial AND data <= @dataFinal
		OPEN cursorComissao;
			FETCH NEXT FROM cursorComissao INTO @codigoC, @comissao, @totalC;
			WHILE @@FETCH_STATUS = 0 
			BEGIN
				DECLARE @valorC AS FLOAT = @comissao
				IF @totalVenda > 30000
				BEGIN
					SET @valorC += 3
					SET @valorC = (@valorC / 100)
					UPDATE Comissoes SET comissao = @comissao + 3, vlComissa = (@totalC * @valorC) WHERE codigo = @codigoC
				END
				ELSE
				BEGIN
					IF @totalVenda <= 30000 AND @totalVenda > 20000
					BEGIN
						SET @valorC += 2
						SET @valorC = @valorC/100
						UPDATE Comissoes SET comissao = @comissao + 2, vlComissa = (@totalC * @valorC) WHERE codigo = @codigoC
					END
					ELSE
					BEGIN
						IF @totalVenda <= 20000 AND @totalVenda > 10000
						BEGIN
							SET @valorC += 1
							SET @valorC = (@valorC/100)
							UPDATE Comissoes SET comissao = @comissao + 1, vlComissa = (@totalC *  @valorC) WHERE codigo = @codigoC
						END
					END
				END
				FETCH NEXT FROM cursorComissao INTO @codigoC, @comissao, @totalC;
			END
		CLOSE cursorComissao;
		DEALLOCATE cursorComissao;
		FETCH NEXT FROM cursorVendedor INTO @codigoV, @nome, @totalVenda;
		END
		CLOSE cursorVendedor
		DEALLOCATE cursorVendedor
END

///////////////////////////////////////////

insert into Grupos values('Master',1,1,1,1,1,1,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1) 
insert into Vendedores values('Master', 15, 'testedeemailemail@gmail.com', 1)
insert into Vendedores values('Thomas', 16, 'testedeemailemail@gmail.com', 1)
insert into Vendedores values('GUI', 17, 'jsessi@gmail.com', 1)
insert into Usuarios values(1, 'Master', 'f03bde11d261f185cbacfa32c1c6538c',1, 1)


































































































































































































































































































































	