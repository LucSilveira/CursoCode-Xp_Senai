
CREATE DATABASE Exercicio_05;

USE Exercicio_05;

CREATE TABLE Escola(
	Id_Escola INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Numero INT NOT NULL,
	Endereco VARCHAR(100) NOT NULL
);

CREATE TABLE Turma(
	Id_Turma INT PRIMARY KEY IDENTITY NOT NULL,
	Sala INT NOT NULL,
	Nome VARCHAR(10),
	Id_Escola INT FOREIGN KEY REFERENCES Escola(Id_Escola)
);

CREATE TABLE Aluno(
	Id_Aluno INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Idade INT NOT NULL,
	RA INT NOT NULL,
	Id_Turma INT FOREIGN KEY REFERENCES Turma(Id_Turma)
);

INSERT INTO Escola(Nome, Numero, Endereco) VALUES ('Santos Drumont2', 743 ,'Alameda Barros');

INSERT INTO Turma(Sala, Nome, Id_Escola) VALUES (2, '3º ano B', 1), (3, '2º ano A', 1);

INSERT INTO Aluno(Nome, Idade, RA, Id_Turma) VALUES ('Carlos', 18, 1234, 1), ('Gabriel', 17, 1233, 2);

select * from Aluno;
select * from Turma;
select * from Escola;

SELECT Aln.Nome as 'Nome do Aluno', Trm.Nome as 'Ano do aluno', Trm.Sala as 'Sala de aula', Escl.Nome as 'Nome da escola'
	from Aluno as Aln inner join Turma as Trm on Aln.Id_Turma = Trm.Id_Turma inner join Escola as Escl on  Trm.Id_Escola = Escl.Id_Escola;
