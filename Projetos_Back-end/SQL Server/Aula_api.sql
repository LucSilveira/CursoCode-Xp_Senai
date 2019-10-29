create database aula_api;

use aula_api;

create table tbl_usuario(
	usr_id int identity(1,1) primary key not null,
	nome varchar(50) not null,
	email varchar(100) not null,
	senha varchar(255) not null
);

insert into tbl_usuario(nome, email, senha) values ('Lucas', 'lucas1-portal@hotmail.com', 'Lucas02'), ('Carlos', 'carlos@hotmail.com', 'carlos123');