CREATE DATABASE Exercicio_04;

USE Exercicio_04;

CREATE TABLE Curso(
	Id_Curso INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Duracao INT NOT NULL,
	Professor VARCHAR(50)
);

CREATE TABLE Aluno(
	Id_Aluno INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Idade INT NOT NULL,
	Id_Curso INT FOREIGN KEY REFERENCES Curso(Id_Curso)
);

INSERT INTO Curso(Nome, Duracao, Professor) VALUES ('Programação', 120, 'Tsukamoto'), ('Front', 120, 'Carol');

INSERT INTO Aluno(Nome, Idade, Id_Curso) VALUES ('Lucao', 18, 1), ('Thiaguu', 18, 2);

SELECT * FROM Curso;

SELECT * FROM Aluno;

SELECT Aln.Nome as 'Nome aluno', Aln.Idade as 'Idade do Aluno', Crs.Nome as 'Curso escolhido', Crs.Professor as 'Professor'
	from Aluno as Aln inner join Curso as Crs on Aln.Id_Aluno = Crs.Id_Curso;