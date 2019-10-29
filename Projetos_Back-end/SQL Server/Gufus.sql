
create database Gufus;

use Gufus;

create table Usuario(
	id_Usuario int identity primary key not null,
	nome varchar(50) not null,
	nascimento date not null,
	loginUsuario varchar(50) not null,
	email varchar(50) not null,
	senha varchar(50) not null,
	tipoUsuario varchar(50) not null
);

create table Categoria(
	id_Categoria int identity primary key not null,
	nomeCategoria varchar(50) not null
);

create table Evento(
	id_Evento int identity primary key not null,
	nomeEvento varchar(50) not null,
	dataEvento date not null,
	/*dataEvento smalldatetime not null,*/
	id_Categoria int foreign key references Categoria(id_Categoria)
);

create table Interesses(
	id_Interesse int identity primary key not null,
	id_Usuario int foreign key references Usuario(id_Usuario),
	id_Evento int foreign key references Evento(id_Evento)
);       
select * from Evento;
select * from Interesses; 

insert into Usuario(nome, nascimento, loginUsuario, email, senha, tipoUsuario) values ('Jhon', '1998-05-08', 'jhonSilva', 'jhon@email.com', 'jhon132', 'Aluno'),
																					  ('Angelina', '1999-04-02', 'Angelina_costa', 'angel@email.com', 'angel132', 'Admin');

insert into Categoria(nomeCategoria) values ('Bootcamp'), 
											('Hackton');

insert into Evento(nomeEvento, dataEvento, id_Categoria) values ('Hackton sobre React', '19-10-22', 2),
																('Bootcamp sobre Vue.js', '19-10-25', 1);

insert into Interesses(id_Usuario, id_Evento) values (1, 2),
													 (2, 1);