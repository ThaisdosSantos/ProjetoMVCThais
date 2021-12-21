/* L�gico_1: */

CREATE TABLE Agencia (
    CodCNPF varchar(14) PRIMARY KEY,
    Nome char(18)
);

CREATE TABLE Cliente (
    CodCliente int PRIMARY KEY,
    Idade int,
    fk_Agencia_CodCNPF varchar(14),
    fk_Destino_CodDest int,
    fk_Cadastro_CodCadastro int,
    fk_Carrinho_IdCarrinho int
);

CREATE TABLE Destino (
    CodDest int PRIMARY KEY,
    LocalNome char(50),
    Descricao char(50),
    PrecoDest float,
    fk_Agencia_CodCNPF varchar(14),
    fk_Promocao_CodProm int
);

CREATE TABLE Promocao (
    CodProm int PRIMARY KEY,
    Nome char(50),
    Data varchar(10),
    Descricao char(50),
    PrecoDest float,
    PrecoDesc float
);

CREATE TABLE Contatos (
    CodCont int PRIMARY KEY,
    Email char(50),
    Cidade char(50),
    estado varchar(2),
    fk_TelefoneAgen_TelefoneAgen_PK int,
    fk_Agencia_CodCNPF varchar(14)
);

CREATE TABLE Feedback (
    CodFeed int PRIMARY KEY,
    descricao char(50),
    Data varchar(8)
);

CREATE TABLE Cadastro (
    Nome char(50),
    CPF varchar(11),
    RG char(10),
    Cidade char(50),
    Cep varchar(8),
    Email char(50),
    Senha varchar(8),
    CodCadastro int PRIMARY KEY,
    fk_TelefoneClient_TelefoneClient_PK int,
    Sexo char(9)
);

CREATE TABLE Login (
    Email char(50),
    CodLogin int PRIMARY KEY,
    Senha varchar(8)
);

CREATE TABLE Carrinho (
    CodCarrinho int PRIMARY KEY,
    Destino char(50)
);

CREATE TABLE TelefoneAgen (
    TelefoneAgen_PK int NOT NULL PRIMARY KEY,
    TelefoneAgen char(12)
);

CREATE TABLE TelefoneClient (
    TelefoneClient_PK int NOT NULL PRIMARY KEY,
    TelefoneClient varchar(11)
);

CREATE TABLE acessa (
    fk_Contatos_CodCont int,
    fk_Cliente_CodCliente int
);

CREATE TABLE recebe (
    fk_Feedback_CodFeed int,
    fk_Destino_CodDest int
);

CREATE TABLE contem (
    fk_Promocao_CodProm int,
    fk_Feedback_CodFeed int
);

CREATE TABLE faz (
    fk_Cliente_CodCliente int,
    fk_Login_CodLogin int
);

CREATE TABLE E_Adicionada (
    fk_Destino_CodDest int,
    fk_Carrinho_IdCarrinho int
);

CREATE TABLE E_Adicionado (
    fk_Promocao_CodProm int,
    fk_Carrinho_IdCarrinho int
);
 
ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_2
    FOREIGN KEY (fk_Agencia_CodCNPF)
    REFERENCES Agencia (CodCNPF)
    
 
ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_3
    FOREIGN KEY (fk_Destino_CodDest)
    REFERENCES Destino (CodDest)
    ON DELETE CASCADE;
 
ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_4
    FOREIGN KEY (fk_Cadastro_CodCadastro)
    REFERENCES Cadastro (CodCadastro)
    ON DELETE CASCADE;
 
ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_5
    FOREIGN KEY (fk_Carrinho_IdCarrinho)
    REFERENCES Carrinho (CodCarrinho)
    ON DELETE CASCADE;
 
ALTER TABLE Destino ADD CONSTRAINT FK_Destino_2
    FOREIGN KEY (fk_Agencia_CodCNPF)
    REFERENCES Agencia (CodCNPF)
    
 
ALTER TABLE Destino ADD CONSTRAINT FK_Destino_3
    FOREIGN KEY (fk_Promocao_CodProm)
    REFERENCES Promocao (CodProm)
    ON DELETE SET NULL;
 
ALTER TABLE Contatos ADD CONSTRAINT FK_Contatos_2
    FOREIGN KEY (fk_TelefoneAgen_TelefoneAgen_PK)
    REFERENCES TelefoneAgen (TelefoneAgen_PK)
    ON DELETE NO ACTION;
 
ALTER TABLE Contatos ADD CONSTRAINT FK_Contatos_3
    FOREIGN KEY (fk_Agencia_CodCNPF)
    REFERENCES Agencia (CodCNPF)
    
 
ALTER TABLE Cadastro ADD CONSTRAINT FK_Cadastro_2
    FOREIGN KEY (fk_TelefoneClient_TelefoneClient_PK)
    REFERENCES TelefoneClient (TelefoneClient_PK)
    ON DELETE NO ACTION;
 
ALTER TABLE acessa ADD CONSTRAINT FK_acessa_1
    FOREIGN KEY (fk_Contatos_CodCont)
    REFERENCES Contatos (CodCont)
    
 
ALTER TABLE acessa ADD CONSTRAINT FK_acessa_2
    FOREIGN KEY (fk_Cliente_CodCliente)
    REFERENCES Cliente (CodCliente)
    
ALTER TABLE recebe ADD CONSTRAINT FK_recebe_1
    FOREIGN KEY (fk_Feedback_CodFeed)
    REFERENCES Feedback (CodFeed)
    ON DELETE SET NULL;
 
ALTER TABLE recebe ADD CONSTRAINT FK_recebe_2
    FOREIGN KEY (fk_Destino_CodDest)
    REFERENCES Destino (CodDest)
    ON DELETE SET NULL;
 
ALTER TABLE contem ADD CONSTRAINT FK_contem_1
    FOREIGN KEY (fk_Promocao_CodProm)
    REFERENCES Promocao (CodProm)
    ON DELETE SET NULL;
 
ALTER TABLE contem ADD CONSTRAINT FK_contem_2
    FOREIGN KEY (fk_Feedback_CodFeed)
    REFERENCES Feedback (CodFeed)
    ON DELETE SET NULL;
 
ALTER TABLE faz ADD CONSTRAINT FK_faz_1
    FOREIGN KEY (fk_Cliente_CodCliente)
    REFERENCES Cliente (CodCliente)
    ON DELETE SET NULL;
 
ALTER TABLE faz ADD CONSTRAINT FK_faz_2
    FOREIGN KEY (fk_Login_CodLogin)
    REFERENCES Login (CodLogin)
    ON DELETE SET NULL;
 
ALTER TABLE E_Adicionada ADD CONSTRAINT FK_E_Adicionada_1
    FOREIGN KEY (fk_Destino_CodDest)
    REFERENCES Destino (CodDest)
    ON DELETE SET NULL;
 
ALTER TABLE E_Adicionada ADD CONSTRAINT FK_E_Adicionada_2
    FOREIGN KEY (fk_Carrinho_IdCarrinho)
    REFERENCES Carrinho (CodCarrinho)
    ON DELETE SET NULL;
 
ALTER TABLE E_Adicionado ADD CONSTRAINT FK_E_Adicionado_1
    FOREIGN KEY (fk_Promocao_CodProm)
    REFERENCES Promocao (CodProm)
    ON DELETE SET NULL;
 
ALTER TABLE E_Adicionado ADD CONSTRAINT FK_E_Adicionado_2
    FOREIGN KEY (fk_Carrinho_IdCarrinho)
    REFERENCES Carrinho (CodCarrinho)
    ON DELETE SET NULL;

	select * from Agencia;
	select * from Cliente;
	select * from  Destino;
	select * from  Promocao;
	select * from  Contatos;
	select * from  Feedback;
	select * from  Cadastro;
	select * from  Login;
	select * from  TelefoneAgen;
	select * from  TelefoneClient;
	select * from  acessa;
	select * from  recebe;
	select * from  contem;
	select * from  faz;
	select * from Cadastro;



	