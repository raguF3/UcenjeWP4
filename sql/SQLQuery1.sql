use master;
go
drop database if exists loo;
go
create database loo;
go

use loo;

create table history(
sifra int not null,
ime varchar (50) not null,
prezime varchar (50) not null,
vrijeme datetime
);