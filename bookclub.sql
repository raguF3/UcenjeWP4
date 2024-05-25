use master;
go
drop database if exists bookclub;
go
create database bookclub;
go
use bookclub;

create table prijave (
sifra int not null primary key identity (1,1),
ime varchar (50),
prezime varchar (50),
adresa varchar (50),
email int
);

create table bookclub_zanrovi (
sifra int not null primary key identity (1,1),
zanr varchar (50) not null,
naziv_grupe varchar (50),
naziv_knjige varchar (50),
prijava int
);

create table zajednice (
sifra int not null primary key identity (1,1),
vijesti int,
clanovi varchar (100),
aktivan bit
);


alter table bookclub_zanrovi add foreign key (prijava) references prijave (sifra);
alter table bookclub_zanrovi add foreign key (prijava) references zajednice (sifra);
alter table prijave add foreign key (email) references zajednice (sifra);
