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

insert into knjige (naziv, autor, godina) values 
('The Cruel Princ','Holly Black', '2018-01-02'),
('The Wicked King', 'Holly Black','2019-01-08'),
('The Queen of Nothing','Holly Black','2019-11-19'),
('Soul of a Witch', 'Harley Laroux','2023-08-31'),
('Crowed','Rina Kent','2019-01-30'),
('Scarred','Emily McIntire','2023-04-10');


insert into sastanci (datum, knjiga, mjesto) values 
('2024-05-02  14:30',1,'Osijek'),
('2024-05-10  15:25',2,'Beli Manastir'),
('2024-05-15  13:30',3,'Bilje'),
('2024-05-20  14:00',4,'Belišce'),
('2024-05-25  14:30',5,'Valpovo'),
('2024-06-02  18:15',6,'Osijek');


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

select * from knjige;
select * from sastanci;
select * from clanovi;
select * from dolasci;
