create database 3c1pedro35;
USE 3c1pedro35;
CREATE TABLE tbl_login
(
    Nome           varchar (50) not null primary key,
    Senha                 varchar(40) not null,
    CPF                 int not null

)ENGINE=INNODB;

create table tbl_jogos
(
	ID			 int not null primary key auto_increment,
    Jogo         varchar (50) not null ,
	Tipo		 varchar (50) not null,	
    Preco        double not null

)ENGINE=INNODB;