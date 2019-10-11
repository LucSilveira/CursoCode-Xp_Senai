
CREATE DATABASE Exercicio_03;

USE Exercicio_03;

CREATE TABLE Empresa(
	Id_Empresa INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL
);

CREATE TABLE Diretor(
	Id_Diretor INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL, 
	Idade INT NOT NULL,
	Id_Empresa INT FOREIGN KEY REFERENCES Empresa(Id_Empresa)
);

CREATE TABLE Departamento(
	Id_Departamento INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Especialidade VARCHAR(50) NOT NULL,
	Id_Diretor INT FOREIGN KEY REFERENCES Diretor(Id_Diretor)
);

INSERT INTO Empresa(Nome) VALUES ('Microsoft'), ('Loft');

SELECT * FROM Empresa;

INSERT INTO Diretor(Nome, Idade, Id_Empresa) VALUES ('Michael', 32, 1), ('Jhon', 43, 1);

SELECT * FROM Diretor;

INSERT INTO Departamento(Nome, Especialidade, Id_Diretor) VALUES ('Financias', 'Contabilização', 1), ('Gestão', 'Administração', 2);

SELECT * FROM Departamento;