
create database tarefa;

use tarefa;

create table tbl_tarefa(
	id_tarefa int identity primary key not null,
	nome varchar(30) not null,
	descricao varchar(255) not null,
	dataTarefa date not null
);
