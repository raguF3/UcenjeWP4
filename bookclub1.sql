use master;
go
drop database if exists bookclub;
go
create database bookclub;
go
use bookclub;

create table knjige (
sifra int not null primary key identity (1,1),
naziv varchar (50),
autor varchar (50)
);

create table sastanci (
sifra int not null primary key identity (1,1),
datum datetime,
knjiga int,
mjesto varchar (50)
);

create database clanovi (
sifra int not null primary key identity (1,1),
ime varchar (50),
prezime varchar (50),
email varchar (50),
lozinka int,
admin_id bit
);

