/*DROP DATABASE Exercicio_01;*/
/*CREATE DATABASE Exercicio_01;*/


/* Query (linha de código) - falar qual banco que irei utilizar*/
USE Exercicio_01;

/* identity - mesmo que o auto_increment */

CREATE TABLE Equipe(
	IdEquipe INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(30) NOT NULL,
	Especialidade VARCHAR(50) NOT NULL, 
	Localizacao VARCHAR(255) NOT  NULL
);

CREATE TABLE Jogador(
	IdJogador INT IDENTITY PRIMARY KEY NOT NULL,
	Id_Equipe INT NOT NULL,
	Nome VARCHAR(50) NOT NULL, 
	Idade INT NOT NULL,
	Endereco VARCHAR(255) NOT NULL,

	FOREIGN KEY(Id_Equipe) REFERENCES Equipe(IdEquipe)
);

CREATE TABLE Endereco(
	IdEndereco INT IDENTITY PRIMARY KEY NOT NULL,
	Rua VARCHAR(255) NOT NULL, 
	Numero INT NOT NULL,
	Bairro VARCHAR(50) NOT NULL,
	Estado VARCHAR(50) NOT NULL,
	Pais VARCHAR(50) NOT NULL,
	IdJogador INT FOREIGN KEY REFERENCES Jogador(IdJogador)
);

SELECT * FROM Equipe;

INSERT INTO Equipe(Nome, Especialidade, Localizacao) VALUES ('Fun Coders', 'Desenvolvimento de sistema', 'São Paulo');


SELECT * FROM Jogador;

INSERT INTO Jogador(Id_Equipe, Nome, Idade, Endereco) VALUES (1, 'Lucao', 18, 'Osasco, SP'), (1, 'Thiagueira', 18 ,'Fim do mundo, Desconhecido');

/*DELETE FROM Jogador WHERE IdJogador = 2;*/