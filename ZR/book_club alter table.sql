use master;
go
drop database if exists Book_club;
go
create database Book_club;
go
use Book_club;

create table knjige (
sifra int not null primary key identity (1,1),
naziv varchar (50) not null,
autor varchar (50) not null,
godina datetime,
);

create table sastanci (
sifra int not null primary key identity (1,1),
datum datetime,
knjiga int,
mjesto varchar (50) not null
);

create table clanovi (
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
email varchar (50) not null,
lozinka int,
administrator bit
);

create table dolasci (
sastanak int,
clan int
);

alter table dolasci add foreign key (clan) references clanovi (sifra);
alter table dolasci add foreign key (sastanak) references sastanci (sifra);
alter table sastanci add foreign key (knjiga) references knjige (sifra);
