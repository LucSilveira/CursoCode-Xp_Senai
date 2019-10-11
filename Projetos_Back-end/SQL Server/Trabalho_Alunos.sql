
CREATE DATABASE Exercicio_02;

USE Exercicio_02;

CREATE TABLE Aluno(
	Id_Aluno INT IDENTITY PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Idade INT NOT NULL,
	RA INT NOT NULL
);

SELECT * FROM Aluno;

CREATE TABLE Trabalho(
	Id_Trabalho INT IDENTITY PRIMARY KEY NOT NULL,
	NomeTrabalho VARCHAR(50) NOT NULL,
	Materia VARCHAR(50) NOT NULL,
	DataEntrega DATE NOT NULL,

	Id_Aluno INT FOREIGN KEY REFERENCES Aluno(Id_Aluno)
);

SELECT * FROM Trabalho;

/*____________________________________________*/

INSERT INTO Aluno(Nome, Idade, RA) VALUES ('Lucao', 18, 1234), ('Vitao', 18, 1233);

INSERT INTO Trabalho(NomeTrabalho, Materia, DataEntrega, Id_Aluno) VALUES ('Trabalho de Química', 'Quimica', '2019-10-11', 1),
																		  ('Trabalho de Matemática', 'Matemática', '2019-11-18', 2);