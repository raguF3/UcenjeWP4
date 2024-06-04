﻿use master;
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
godina date,
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
lozinka varchar (8) not null,
administrator bit
);

create table dolasci (
sastanak int,
clan int
);

alter table dolasci add foreign key (clan) references clanovi (sifra);
alter table dolasci add foreign key (sastanak) references sastanci (sifra);
alter table sastanci add foreign key (knjiga) references knjige (sifra);

insert into knjige (naziv, autor, godina) values 
('The Cruel Princ','Holly Black', '2018-01-02');
insert into knjige (naziv, autor, godina) values 
('The Wicked King', 'Holly Black','2019-01-08');
insert into knjige (naziv, autor, godina) values 
('The Queen of Nothing','Holly Black','2019-11-19');
insert into knjige (naziv, autor, godina) values 
('Soul of a Witch', 'Harley Laroux','2023-08-31');
insert into knjige (naziv, autor, godina) values 
('Crowed','Rina Kent','2019-01-30');
insert into knjige (naziv, autor, godina) values 
('Scarred','Emily McIntire','2023-04-10');
insert into knjige (naziv, autor, godina) values 
('Doll House','John Hunt','2017-01-19');
insert into knjige (naziv, autor, godina) values 
('Morally Corrupt','Veronica Lancet','2023-03-27');
insert into knjige (naziv, autor, godina) values 
('Ruthless Rival','Lj Shen','2022-05-03');
insert into knjige (naziv, autor, godina) values 
('Punk 57','Penelope Douglas','2022-10-29');
insert into knjige (naziv, autor, godina) values 
('The Mindfuck Series','S.T. Abby','2022-10-09');
insert into knjige (naziv, autor, godina) values
('The Chalk Man','C.J. Tudor','2018-01-01');
insert into knjige (naziv, autor, godina) values
('the sun and her flowers','Rupi Kaur','2018-09-18');
insert into knjige (naziv, autor, godina) values
('Dark Matter','Blake Crouch','2016-06-26');
insert into knjige (naziv, autor, godina) values
('Ward D','Freida McFadden','2023-05-08');
insert into knjige (naziv, autor, godina) values
('Lured','Rina Kent','2019-05-19');
insert into knjige (naziv, autor, godina) values
('Restrain Me','Michelle Heard','2023-05-04');
insert into knjige (naziv, autor, godina) values
('Fractured Freedom','Shain Rose','2022-06-21');
insert into knjige (naziv, autor, godina) values
insert into knjige (naziv, autor, godina) values
insert into knjige (naziv, autor, godina) values
insert into knjige (naziv, autor, godina) values
insert into knjige (naziv, autor, godina) values




insert into sastanci (datum, knjiga, mjesto) values 
('2024-05-02  14:30',1,'Osijek');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-05-10  15:25',2,'Beli Manastir');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-05-15  13:30',3,'Bilje');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-05-20  14:00',4,'Belišce');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-05-25  14:30',5,'Valpovo');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-06-02  18:15',6,'Osijek');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-06-08  19:00',7,'Osijek');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-06-15  12:15',8,'Beli Manastir');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-06-23  20:15',9,'Đakovo');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-06-30  14:20',10,'Čepin');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-07-10  18:15',11,'Kozarac');
insert into sastanci (datum, knjiga, mjesto) values 
('2024-07-20  19:30',12,'Valpovo');



insert into clanovi (ime, prezime, email, lozinka, administrator) 
values ('Lea', 'Raguž','raguz.leaa@gmail.com',12515,1),
('Damir','Bukvašević','damirbukvasevic@gmail.com',74884,1),
('Senka','Banjac','sbanjac88@gmail.com',93772,1),
('Igor','Brzica','igorbrzica1@gmail.com',32873,1),
('Ivan','Mesarić','mesaritchievan@gmail.com',2973,1),
('Mirko','Ereš','mirko.eres1@gmail.com',82733,1),
('Dominik  ','Daraždi','dominikdarazdi@gmail.com', 37823,1),
('Dean','Vagner','deanvagner@yahoo.com',28732,1),
('Marko','Mudrovčić','markomudrovcic12@gmail.com',33234,1),
('Mario','Kušen','kusen.mario@gmail.com',43364,1),
('Leon','Jalovičar','ringerajacar@gmail.com',45151,1),
('Dražen','Kalazić','thekalazic@gmail.com',67851,1),
('Matej','Sudarić','matejsudo@gmail.com',67573,1),
('Antonijo','Šakić','a.sakic.1.g@gmail.com',75857,1),
('Nikola','Milić','nikk.mil@gmail.com',65786,1),
('Manuela','Slobođanac','manja496@gmail.com',76583,1),
('Srđan','Filipović','srdjanfilipovic991@gmail.com',36575,1),
('Goran','Matoš','goran.matos@a1.hr',68542,1),
('Igor','Tomić','i.tomic.babinski@gmail.com',78577,1),
('Borna','Štajduhar','bornastajduhar1999@gmail.com',84457,1),
('Ante','Filipović','ante.filipovic72@gmail.com',67471,1),
('Domagoj','Glavačević','glavacevic.d@gmail.com',76876,1),
('Lorena','Ostroški','lorena.ostroski2503@gmail.com',85871,1),
('Sanja','Boduljak','matkosanja@gmail.com',58752,1),
('Leon','Puhanić','leonpuhanic@gmail.com',75879,1),
('Danijel','Sačer','sacerdanijel@gmail.com',67878,1);



insert into dolasci (sastanak, clan) values 
(1,1), (1,3),(1,5),(1,6),(1,7),(1,9),(1,12),(1,15),(1,19),(1,20),(1,21),(1,22),(1,23);
insert into dolasci (sastanak, clan) values
(2,2), (2,4),(2,5),(2,6),(2,8),(2,10),(2,13),(2,15),(2,17),(2,18),(2,19),(2,22),(2,26);
insert into dolasci (sastanak, clan) values
(3,1), (3,4),(3,5),(3,7),(3,9),(3,10),(3,14),(3,15),(3,16),(3,18),(3,21),(3,24),(3,25);
insert into dolasci (sastanak, clan) values
(4,1), (4,2),(4,5),(4,6),(4,8),(4,10),(4,11),(4,14),(4,17),(4,18),(4,19),(4,25),(4,26);
insert into dolasci (sastanak, clan) values
(5,2), (5,3),(5,4),(5,6),(5,7),(5,12),(5,16),(5,17),(5,18),(5,20),(5,23),(5,24),(5,26);
insert into dolasci (sastanak, clan) values
(6,1), (6,3),(6,5),(6,6),(6,7),(6,8),(6,9),(6,11),(6,14),(6,19),(6,21),(6,22),(6,26);
insert into dolasci (sastanak, clan) values
(7,1), (7,3),(7,7),(7,8),(7,9),(7,10),(7,11),(7,13),(7,14),(7,16),(7,20),(7,22),(7,26);
insert into dolasci (sastanak, clan) values
(8,1), (8,3),(8,5),(8,6),(8,7),(8,8),(8,9),(8,11),(8,14),(8,19),(8,21),(8,24),(8,25);
insert into dolasci (sastanak, clan) values
(9,3), (9,4),(9,5),(9,9),(9,10),(9,12),(9,14),(9,16),(9,17),(9,19),(9,24),(9,25),(9,26);
insert into dolasci (sastanak, clan) values
(10,1), (10,3),(10,5),(10,6),(10,7),(10,8),(10,9),(10,11),(10,14),(10,19),(10,21),(10,22),(10,26);
insert into dolasci (sastanak, clan) values
(11,5), (11,6),(11,9),(11,12),(11,14),(11,18),(11,19),(11,20),(11,21),(11,22),(11,24),(11,25),(11,26);
insert into dolasci (sastanak, clan) values
(12,1), (12,4),(12,5),(12,6),(12,7),(12,12),(12,13),(12,14),(12,15),(12,19),(12,20),(12,22),(12,26);

select * from knjige;
select * from sastanci;
select * from clanovi;
select * from dolasci;
