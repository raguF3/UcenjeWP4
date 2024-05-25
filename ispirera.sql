use master;
go

drop database if exists ispitEra;
go

create database ispitEra;
go

use ispitEra;

create table ispitni_Rok(
sifra int not null primary key identity (1,1),
predmet varchar (50),
vrasta_Ispita varchar (50),
datum datetime,
pristio varchar (50),
);

create table pristupnici (
ispitni_rok int not null,
student varchar (50),
broj_bodova int  not null,
ocjena int not null
);

alter table pristupnici add foreign key (ispitni_rok) references ispitni_Rok (sifra);