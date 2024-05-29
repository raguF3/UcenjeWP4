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

select * from knjige

insert into knjige (naziv, autor, godina)
values ('The Cruel Princ','Holly Black', '2018');

select * from sastanci;

insert into sastanci (datum, knjiga, mjesto)
values ('2024-05-25', 1, 'Osijek');

select * from clanovi 

insert into clanovi (ime, prezime, email, lozinka, administrator) 
values ('Lea', 'Raguž','raguz.leaa@gmail.com','1251735',1),
('Damir','Bukvašević','damirbukvasevic@gmail.com','74884',1),
('Senka','Banjac','sbanjac88@gmail.com','93772',1),
('Igor','Brzica','igorbrzica1@gmail.com','32873',1),
('Ivan','Mesarić','mesaritchievan@gmail.com','2973',1),
('Mirko','Ereš','mirko.eres1@gmail.com','82733',1),
('Dominik  ','Daraždi','dominikdarazdi@gmail.com', '37823',1),
('Dean','Vagner','deanvagner@yahoo.com','28732',1),
('Marko','Mudrovčić','markomudrovcic12@gmail.com','33234',1);

select * from dolasci;

insert into dolasci (sastanak, clan)
values (1,1), (1,3),(1,5),(1,6);