GO
USE master

GO
DROP DATABASE LIVECOMMERCE


GO
CREATE DATABASE LIVECOMMERCE

GO
USE LIVECOMMERCE;

CREATE TABLE TIPO_PESSOA
	(ID_PESSOA INT NOT NULL PRIMARY KEY IDENTITY,
	 DS_PESSOA VARCHAR(10) NOT NULL)

GO
CREATE TABLE SITUACAO
(ID_SITUACAO INT NOT NULL IDENTITY PRIMARY KEY,
 DS_SITUACAO VARCHAR (10) );
 

CREATE TABLE SEXO
	(ID_SEXO INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	 DS_SEXO VARCHAR (10) NOT NULL)

CREATE TABLE TIPO_PRODUTO
(ID_TIPO INT NOT NULL PRIMARY KEY IDENTITY,
 DS_TIPO VARCHAR (30))



CREATE TABLE FORMA_DE_PAGAMENTO
	(ID_FORMAPAGAMENTO INT NOT NULL IDENTITY PRIMARY KEY,
	 DS_FORMAPAGAMENTO VARCHAR (20) NOT NULL)


GO
CREATE TABLE UNIDADE_MEDIDA
(ID_UNIDADE_MEDIDA INT PRIMARY KEY IDENTITY NOT NULL,
 DS_UNIDADE_MEDIDA VARCHAR (5) NOT NULL),
 LANCA_FINANCEIRO INT NOT NULL



GO
CREATE TABLE CATEGORIA_PRODUTO
(ID_CATEGORIA_PRODUTO INT PRIMARY KEY IDENTITY NOT NULL,
 DS_CATEGORIA_PRODUTO VARCHAR(10) NOT NULL)



CREATE TABLE UF
(ID_UF INT NOT NULL PRIMARY KEY IDENTITY,
 DS_UF VARCHAR(2) NOT NULL);


/*CREATE TABLE PLANO_DE_PAGAMENTO
	(ID_PLANOPAGAMENTO INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	 DS_PLANOPAGAMENTO VARCHAR (20) NOT NULL ,
	 VL_MINIMO FLOAT NOT NULL,
	 QT_PARCELAS INT NOT NULL,
	 ID_FORMAPAGAMENTO INT NOT NULL CONSTRAINT PLANO_PAGAMENTO_FORMA_PAGMENTO_FK FOREIGN KEY (ID_FORMAPAGAMENTO) REFERENCES FORMA_DE_PAGAMENTO )*/

CREATE TABLE CIDADE
(ID_CIDADE INT NOT NULL IDENTITY PRIMARY KEY,
 ID_UF INT CONSTRAINT UF_CIADADE_FK FOREIGN KEY (ID_UF) REFERENCES UF,
 DS_CIDADE VARCHAR (50)NOT NULL)

CREATE TABLE CLIENTE 
	(ID_CLIENTE INT NOT NULL IDENTITY PRIMARY KEY,
	 DATA_CADASTRO DATE,	 
	 NM_CLIENTE VARCHAR (35) NOT NULL ,
	 CPF_CLIENTE VARCHAR (15),
	 RG_CLIENTE VARCHAR(15),
	 DT_NASCIMENTO_CLIENTE DATE NOT NULL,
	 ENDERECO_CLIENTE VARCHAR (50),
	 NUMERO_ENDERECO_CLIENTE INT,
	 BAIRRO_ENDERECO_CLIENTE VARCHAR (30),
	 CEP_ENDERECO_CLIENTE VARCHAR (9),
	 CELULAR_CLIENTE VARCHAR (15),	 
	 ID_UF INT CONSTRAINT UF_CLIENTE_FK FOREIGN KEY (ID_UF) REFERENCES UF,
	 ID_SITUACAO INT CONSTRAINT SITUACAO_CLIENTE_FK FOREIGN KEY (ID_SITUACAO) REFERENCES SITUACAO,
	 ID_CIDADE INT CONSTRAINT CIDADE_CLIENTE_FK FOREIGN KEY (ID_CIDADE) REFERENCES CIDADE)


CREATE TABLE FUNCIONARIO
	(ID_FUNCIONARIO INT NOT NULL PRIMARY KEY IDENTITY,
	 NM_FUNCIONARIO VARCHAR (50) NOT NULL,
	 CPF_FUNCIONARIO VARCHAR (20) NOT NULL,
	 RG_FUNCIONARIO VARCHAR(15) NOT NULL,
	 END_FUNCIONARIO VARCHAR (50) NOT NULL,
	 TEL_FUNCIONARIO VARCHAR (15) NOT NULL, 
	 EMAIL_FUNCIONARIO VARCHAR (30) NOT NULL,
	 DT_NASCIMENTO_FUNCIONARIO DATE,
	 BAIRRO_ENDERECO_FUNCIONARIO VARCHAR (25) NOT NULL,
	 NUMERO_ENDERECO_FUNCIONARIO INT,	 
	 SALARIO_BASE_FUNCIONARIO FLOAT,
	 CEP_FUNCIONARIO VARCHAR(10),	 
	 ID_UF INT CONSTRAINT UF_FUNCIONARIO_FK FOREIGN KEY (ID_UF) REFERENCES UF,
	 ID_SITUACAO INT CONSTRAINT SITUACAO_FUNCIONARIO_FK FOREIGN KEY (ID_SITUACAO) REFERENCES SITUACAO,
	 ID_SEXO INT CONSTRAINT SEXO_FUNCIONARIO_FK FOREIGN KEY (ID_SEXO) REFERENCES SEXO,
	 ID_CIDADE INT CONSTRAINT CIDADE_FUNCIONARIO_FK FOREIGN KEY (ID_CIDADE) REFERENCES CIDADE)

	 CREATE TABLE USUARIO
	(ID_USUARIO INT NOT NULL PRIMARY KEY IDENTITY,
	 NM_USUARIO VARCHAR (10) NOT NULL,
	 DS_USUARIO VARCHAR (15),
	 SENHA_USUARIO VARCHAR (50)NOT NULL,
	 ID_FUNCIONARIO INT  CONSTRAINT FUNCIONARIO_FK FOREIGN KEY (ID_FUNCIONARIO) REFERENCES FUNCIONARIO)


CREATE TABLE FORNECEDOR
	(ID_FORNECEDOR INT NOT NULL PRIMARY KEY IDENTITY,
	 RAZAO VARCHAR (50) NOT NULL ,
	 NOME_FANTASIA VARCHAR (50) NOT NULL ,
	 DATA_CADASTRO DATE,
	 CPF_CNPJ_FORNECEDOR VARCHAR (20) NOT NULL ,
	 IE  NUMERIC (20) NOT NULL,
	 END_FORNECEDOR VARCHAR (50) NOT  NULL,
	 END_BAIRRO_FORNECEDOR VARCHAR (50) NOT NULL,
	 END_NUMERO_FORNECEDOR NUMERIC (4) NOT NULL,
	 END_CEP_FORNECEDOR VARCHAR (15) NOT NULL,
	 TELEFONE_FORNECEDOR VARCHAR (15),
	 CELULAR_FORNECEDOR VARCHAR (15),
	 EMAIL_FORNECEDOR VARCHAR (30),
	 ID_UF INT CONSTRAINT UF_FORNECEDOR_FK FOREIGN KEY (ID_UF) REFERENCES UF,
	 ID_SITUACAO INT CONSTRAINT SITUACAO_FORECEDOR_FK FOREIGN KEY (ID_SITUACAO) REFERENCES SITUACAO,
	 ID_CIDADE INT CONSTRAINT CIDADE_FORNECEDOR_FK FOREIGN KEY (ID_CIDADE) REFERENCES CIDADE,
	 ID_TIPO_PESSOA INT CONSTRAINT TIPO_FORNECEDOR_FK FOREIGN KEY (ID_TIPO_PESSOA) REFERENCES TIPO_PESSOA)


CREATE TABLE PRODUTO 
	(ID_PRODUTO INT NOT NULL PRIMARY KEY IDENTITY,
	 CD_BARRAS_PRODUTO INT,
	 DT_CADASTRO_PRODUTO DATE,
	 NM_PRODUTO VARCHAR (20),
	 VL_UNITARIO_PRODUTO_VENDA DECIMAL(9,2),
	 VALOR_COMPRA_PRODUTO DECIMAL (9,2),
	 LUCRO_PORCENTO_PRODUTO INT,
	 QT_PRODUTO INT  ,
	 ID_UNIDADE_MEDIDA INT CONSTRAINT UNIDADE_MEDIDA_PRODUTO_FK FOREIGN KEY(ID_UNIDADE_MEDIDA) REFERENCES UNIDADE_MEDIDA,
	 ID_CATEGORIA_PRODUTO INT CONSTRAINT PRODUTO_CATEGORIA_PRODUTO_FK FOREIGN KEY(ID_CATEGORIA_PRODUTO) REFERENCES CATEGORIA_PRODUTO,
	 ID_FORMA_COMPRA INT CONSTRAINT FORMA_COMPRA_PRODUTO_FK FOREIGN KEY(ID_UNIDADE_MEDIDA) REFERENCES UNIDADE_MEDIDA,
	 ID_FORNECEDOR INT CONSTRAINT PRODUTO_FORNECEDOR_FK FOREIGN KEY(ID_FORNECEDOR) REFERENCES FORNECEDOR,	 
	 ID_TIPO INT CONSTRAINT PRODUTO_TIPO_PRODUTO_FK FOREIGN KEY(ID_TIPO) REFERENCES TIPO_PRODUTO)	

CREATE TABLE VENDA 
	(ID_VENDA INT NOT NULL PRIMARY KEY IDENTITY,
	 VL_FINAL_VENDA DECIMAL (9,2) NOT NULL,
	 DT_VENDA SMALLDATETIME,
	 STATUS CHAR(10),
	 HORA_VENDA TIME,
	 ID_FUNCIONARIO INT NOT NULL CONSTRAINT VENDA_FUNCIONARIO_FK FOREIGN KEY (ID_FUNCIONARIO) REFERENCES FUNCIONARIO,
	 ID_CLIENTE INT NOT NULL CONSTRAINT VENDA_CLIENTE_FK FOREIGN KEY(ID_CLIENTE) REFERENCES CLIENTE,	 
	 ID_FORMAPAGAMENTO INT  NOT NULL CONSTRAINT VENDA_FORMA_PAGAMENTO_FK FOREIGN KEY (ID_FORMAPAGAMENTO) REFERENCES FORMA_DE_PAGAMENTO)

	 
CREATE TABLE VENDA_ITENS
	(ID_VENDA_ITENS INT NOT NULL PRIMARY KEY IDENTITY,
	 ID_PRODUTO INT NOT NULL CONSTRAINT VENDA_ITENS_PRODUTO_FK FOREIGN KEY (ID_PRODUTO) REFERENCES PRODUTO,
	 ID_VENDA INT NOT NULL CONSTRAINT VENDA_ITENS_VENDA_FK FOREIGN KEY (ID_VENDA) REFERENCES VENDA,
	 VALOR_PRODUTO DECIMAL(9,2) NOT NULL,
	 QT_PRODUTO INT NOT NULL,
	 VALOR_TOTAL DECIMAL(9,2) NOT NULL)

GO 
CREATE TABLE LPARAM
(LMNPARAM VARCHAR(10),
LVRPARAM VARCHAR(10))
/*---------------------------------------INSERT---------------------------------------------------------------*/

INSERT INTO TIPO_PESSOA(DS_PESSOA)
	VALUES ('FISICA'),
		   ('JURIDICA')


INSERT INTO UNIDADE_MEDIDA (DS_UNIDADE_MEDIDA)
		VALUES ('KG'),
				('CX'),
				('UN'),
				('KIT')


INSERT INTO SITUACAO
VALUES ('SIM'),
		('N�O')
		
INSERT INTO TIPO_PRODUTO
	VALUES('PRODUTO'),
			('SERVICOS')

INSERT INTO CATEGORIA_PRODUTO
	VALUES('HIGIENE'),
		  ('RACAO'),
		  ('REMEDIOS'),
		  ('OBJETOS')

INSERT INTO ESPECIE 
	VALUES ('CACHORRO'),
		   ('GATO')


INSERT INTO RACA(DS_RACA,ID_ESPECIE) 
	VALUES ('GOLDEN',1),
		   ('PITBULL',1),
		   ('VIRA-LATA',1),
		   ('PASTOR ALEM�O',1),
		   ('POODLE',1),
		   ('BEAGLE',1),
		   ('BORDER COLLIE',1),
		   ('BULDOGUE FRANC�S',1),
		   ('BULDOGUE INGL�S',1),
		   ('BULDOGUE CAMPEIRO',1),
		   ('CHIHUAHUA',1),
		   ('DALMATA',1),
		   ('DOBERMAN',1),
		   ('FILA BRASILEIRO',1),
		   ('HUSKY SIBERIANO',1),
		   ('LABRADOR',1),
		   ('GATO PERSA',2),
		   ('SIAM�S',2),
		   ('RAGDOLL',2),
		   ('MAIME COON',2),
		   ('SAGRADO DA BIRM�NIA',2),
		   ('HAVANA BROWN',2),
		   ('EXOTIC LONGHAIR',2),
		   ('BOMBIAN',2),
		   ('SCOTTISH FOLD',2),
		   ('AMERICAN SHORTHAIR',2)

		   
 
INSERT INTO SEXO
	 VALUES ('MASCULINO'),				 
			('FEMININO')

INSERT INTO FORMA_DE_PAGAMENTO 
		VALUES ('DINHEIRO',2),
				('CHEQUE',1),
			('CART�O DE DEBITO',2),
			('CART�O DE CREDITO',2)

INSERT INTO UF (DS_UF)
VALUES		('AC'),
			('AL'),
			('AP'),
			('AM'),
			('BA'),
			('CE'),
			('DF'),
			('ES'),
			('GO'),
			('MA'),
			('MT'),
			('MS'),
			('MG'),
			('PA'),
			('PB'),
			('PR'),
			('PE'),
			('PI'),
			('RJ'),
			('RN'),
			('RS'),
			('RO'),
			('RR'),
			('SC'),
			('SP'),
			('SE'),
			('TO')



/*---------------------------------------------------------------------------------*/

CREATE PROCEDURE USP_USUARIOS_SEL
@LOGIN VARCHAR(50),
@SENHA VARCHAR(100)
AS
	SELECT ID_USUARIO, NM_USUARIO, SENHA_USUARIO, DS_USUARIO
	FROM USUARIO
	WHERE NM_USUARIO = @LOGIN AND SENHA_USUARIO = @SENHA


CREATE VIEW VW_PETS
AS
SELECT 
       P.ID_PET [CODIGO],
       P.NM_PET [NOME],
	   LTRIM(STR(P.ID_ESPECIE)) + ' - ' + E.DS_ESPECIE [ESPECIE],
	   LTRIM(STR(P.ID_RACA)) + ' - '+ D.DS_RACA [RACA],
	   LTRIM(STR(P.ID_PORTE)) + ' - '+ O.DS_PORTE [PORTE],
	   P.ID_CLIENTE
FROM PET P
INNER JOIN ESPECIE E ON E.ID_ESPECIE = P.ID_ESPECIE
INNER JOIN RACA D ON D.ID_RACA = P.ID_RACA
INNER JOIN PORTE O ON O.ID_PORTE = P.ID_PORTE



CREATE PROCEDURE USP_SEL_RELATORIO_VENDAS
AS
SELECT a.NR_QUANTIDADE, a.NR_VALOR, a.NR_VALOR_TOTAL_ITEM,
b.DT_VENDA,d.DE_NOME, d.DE_DESCRICAO, 
b.ID_VENDA, c.ID_CLIENTE, d.ID_PRODUTO
FROM TB_VENDAS_ITENS a
INNER JOIN TB_VENDAS b ON a.ID_VENDA = b.ID_VENDA
INNER JOIN TB_CLIENTE c ON b.ID_CLIENTE = c.ID_CLIENTE
INNER JOIN TB_PRODUTO d ON a.ID_PRODUTO = d.ID_PRODUTO


CREATE PROCEDURE USP_TB_PET_OBTER_POR_PESSOA
@ID_CLIENTE INT
AS
SELECT ID_PET, ID_CLIENTE, NM_PET
FROM PET where ID_CLIENTE= @ID_CLIENTE

/*NOVAS PROCEDURES E A TRIGGER*/


CREATE PROCEDURE USP_VENDAS_DIA
@DATA VARCHAR(10)
AS
BEGIN
	IF @DATA = ' '
	
	SELECT V.ID_VENDA[NUMERO VENDA], V.DT_VENDA[DATA], C.NM_CLIENTE [NOME CLIENTE], V.VL_FINAL_VENDA[TOTAL] 
	FROM VENDA V 
	INNER JOIN CLIENTE C ON C.ID_CLIENTE = V.ID_CLIENTE 	
	WHERE DAY(V.DT_VENDA) = DAY(GETDATE())  AND V.STATUS LIKE 'FINALIZADA'
	
	
	ELSE
	SELECT V.ID_VENDA[NUMERO VENDA], V.DT_VENDA[DATA], C.NM_CLIENTE [NOME CLIENTE], V.VL_FINAL_VENDA [TOTAL]FROM VENDA V INNER JOIN CLIENTE C ON C.ID_CLIENTE = V.ID_CLIENTE 
	WHERE V.DT_VENDA LIKE '%'+@DATA+'%'	AND V.STATUS LIKE 'FINALIZADA'
END


CREATE TRIGGER QUANTIDADE_PRODUTO
ON VENDA_ITENS
FOR INSERT, DELETE
AS
BEGIN
		IF NOT EXISTS (SELECT 1 FROM inserted) AND EXISTS(SELECT 1 FROM deleted)
		UPDATE PRODUTO
		SET QT_PRODUTO = QT_PRODUTO + (SELECT QT_PRODUTO FROM deleted)
		WHERE ID_PRODUTO = (SELECT ID_PRODUTO FROM deleted WHERE ID_VENDA = ID_VENDA )


		IF EXISTS(SELECT 1 FROM inserted) AND NOT EXISTS(SELECT 1 FROM deleted)		
		UPDATE PRODUTO
		SET  QT_PRODUTO = QT_PRODUTO - (SELECT QT_PRODUTO FROM inserted) 
		WHERE ID_PRODUTO = (SELECT ID_PRODUTO FROM inserted	WHERE ID_VENDA = ID_VENDA)

END


CREATE PROCEDURE USP_STATUS_VENDA
@ID INT
AS
BEGIN
	UPDATE VENDA
	SET STATUS = 'CANCELADA'
	WHERE ID_VENDA = @ID
	
	DELETE FROM VENDA_ITENS WHERE ID_VENDA = @ID
END


CREATE PROCEDURE USP_IMPRIMI_VENDA
@ID INT
AS
BEGIN
	UPDATE LPARAM
	SET LVRPARAM = @ID
	WHERE LMNPARAM ='IMPVND'
	
END

--SELECT A.ID_AGENDAMENTO,C.ID_CLIENTE, C.NM_CLIENTE, C.CELULAR_CLIENTE, P.NM_PET, P.ID_ESPECIE, P.ID_RACA, P.ID_PORTE 
--FROM CLIENTE C
--INNER JOIN PET P ON P.ID_CLIENTE = C.ID_CLIENTE
--INNER JOIN AGENDAMENTO A ON A.ID_CLIENTE = C.ID_CLIENTE



	

CREATE PROCEDURE USP_PRODUTO_ESTOQUE
AS
	SELECT ID_PRODUTO, NM_PRODUTO, VL_UNITARIO_PRODUTO_VENDA, QT_PRODUTO FROM PRODUTO WHERE ID_TIPO = 1


CREATE PROCEDURE USP_RELATORIO_CLIENTES
AS
SELECT ID_CLIENTE AS ID, NM_CLIENTE AS NOME, CPF_CLIENTE AS CPF, ENDERECO_CLIENTE AS ENDERE�O, BAIRRO_ENDERECO_CLIENTE as BAIRRO, CELULAR_CLIENTE AS CELULAR 
FROM CLIENTE




/*Tabela para guardar os perfil dos usu�rios*/
go
CREATE TABLE TB_PERFIL
(
	ID INT IDENTITY(1,1) CONSTRAINT PK_TB_PERFIL PRIMARY KEY,
	DE_PERFIL VARCHAR (30)
)

/*Insert dos perfil*/
INSERT INTO TB_PERFIL (DE_PERFIL) VALUES ('Administrador')
INSERT INTO TB_PERFIL (DE_PERFIL) VALUES ('Gestor')
INSERT INTO TB_PERFIL (DE_PERFIL) VALUES ('Usu�rio Comum')

/*Tabela onde ser�o armazenados os usu�rios*/
go
CREATE TABLE TB_USUARIOS(
 USUA_ID INT IDENTITY(1,1) CONSTRAINT PK_TB_USUARIO PRIMARY KEY,
 USUA_DE_LOGIN VARCHAR (50) NOT NULL,
 USUA_DE_SENHA VARCHAR (100) NOT NULL,
 USUA_ID_PERFIL INT CONSTRAINT FK_TB_USUARIOS_TB_PERFIL REFERENCES TB_PERFIL(ID),
 USUA_DT_ULTIMO_ACESSO DATETIME
 )

 /*Procedure para selecionar os usu�rios*/

  GO
 CREATE PROCEDURE USP_TB_USUARIOS_SEL
	@LOGIN VARCHAR(50),
	@SENHA VARCHAR(100)
	AS
	SELECT USUA_ID, USUA_DE_LOGIN, USUA_DE_SENHA, USUA_ID_PERFIL, USUA_DT_ULTIMO_ACESSO
	FROM TB_USUARIOS
	WHERE USUA_DE_LOGIN = @LOGIN AND USUA_DE_SENHA = @SENHA	
GO

 /*Procedure para Inserir os usu�rios*/
CREATE PROCEDURE USP_TB_USUARIOS_INS
	@DE_LOGIN VARCHAR(50),
	@DE_SENHA VARCHAR(100),
	@ID_PERFIL INT,
	@ID_OUT int output
as 
INSERT INTO TB_USUARIOS
	(USUA_DE_LOGIN,
	USUA_DE_SENHA,
	USUA_ID_PERFIL,
	USUA_DT_ULTIMO_ACESSO) 
VALUES 
	(@DE_LOGIN,
	@DE_SENHA,
	@ID_PERFIL,
	GETDATE())
SET @ID_OUT = (SELECT SCOPE_IDENTITY())
RETURN @ID_OUT

 /*Procedure para obter os usu�rios*/
GO
CREATE PROCEDURE USP_TB_USUARIOS_OBTER_TODOS
AS
SELECT USUA_ID, USUA_DE_LOGIN, USUA_DE_SENHA, USUA_DT_ULTIMO_ACESSO, USUA_ID_PERFIL, b.DE_PERFIL 
FROM TB_USUARIOS a
INNER JOIN TB_PERFIL b ON a.USUA_ID_PERFIL = b.ID

 /*Procedure para dar update nos usu�rios*/
GO
CREATE PROCEDURE USP_TB_USUARIO_UPD
@DE_LOGIN VARCHAR(50),
@DE_SENHA VARCHAR(100),
@ID_PERFIL INT,
@ID INT
AS
UPDATE TB_USUARIOS SET 
USUA_DE_LOGIN = @DE_LOGIN,
USUA_DE_SENHA = @DE_SENHA,
USUA_ID_PERFIL = @ID_PERFIL
WHERE USUA_ID = @ID

 /*Procedure para deletar os usu�rios*/
go
CREATE PROCEDURE USP_TB_USUARIOS_DEL
@ID INT
AS
DELETE FROM TB_USUARIOS
WHERE USUA_ID = @ID
/*Inserirndo um usu�rio padr�o*/
go
INSERT INTO TB_USUARIOS VALUES ('adm', '2c2c2c2c2c2c2c2c2c2c2c2c2c2c2c2c', 1, getdate())

