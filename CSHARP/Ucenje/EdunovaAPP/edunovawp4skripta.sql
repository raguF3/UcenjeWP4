﻿

-- Zamjeniti db_a98acf_edunovawp4 s imenom svoje baze

SELECT name, collation_name FROM sys.databases;
GO
ALTER DATABASE db_a98acf_edunovawp4 SET SINGLE_USER WITH
ROLLBACK IMMEDIATE;
GO
ALTER DATABASE db_a98acf_edunovawp4 COLLATE Croatian_CI_AS;
GO
ALTER DATABASE db_a98acf_edunovawp4 SET MULTI_USER;
GO
SELECT name, collation_name FROM sys.databases;
GO


drop table clanovi;
drop table polaznici;
drop table grupe;
drop table smjerovi;



-- Tipovi podataka:https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
trajanje int null, -- ne treba pisati null jer je on podrazumijevan
cijena decimal(18,2),
izvodiseod datetime,
verificiran bit
);


create table grupe(
sifra int not null primary key identity(1,1),
naziv varchar(20) not null,
smjer int not null,
predavac varchar(50),
maxpolaznika int not null
);


create table polaznici(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(20) not null,
oib char(11), -- provjeriti doma CHECK(LEN(OIB)=11),
email varchar(50) not null
);


create table clanovi(
grupa int not null,
polaznik int not null
);

alter table grupe add foreign key (smjer) references smjerovi(sifra);
alter table clanovi add foreign key (grupa) references grupe(sifra);
alter table clanovi add foreign key (polaznik) references polaznici(sifra);



-- INSERT NAREDBE
--select * from smjerovi;

-- Školska sintaksa
-- 1 - šifra koju je dodjelila baza
insert into smjerovi (naziv,trajanje,cijena,izvodiseod,verificiran)
values ('Web programiranje',225,1589.89,'2024-01-15',1);

-- loša sintaksa
-- 2
insert into smjerovi values 
('Web dizajn',null,null,null,null);


-- MVP minimalna dobra sintaksa
-- 3
insert into smjerovi (naziv) values ('čšćđž ČŠĆĐŽ');


--select * from grupe;
-- 1
insert into grupe (naziv, smjer, maxpolaznika)
values ('WP4',1,26);
-- 2
insert into grupe (naziv, smjer,maxpolaznika)
values ('WP5',1,26);

--select * from polaznici;

-- 1 - 27
insert into polaznici (ime, prezime, email) values
('Igor','Balažić','igorbalazic11@gmail.com'),
('Damir','Bukvašević','damirbukvasevic@gmail.com'),
('Senka','Banjac','sbanjac88@gmail.com'),
('Igor','Brzica','igorbrzica1@gmail.com'),
('Ivan','Mesarić','mesaritchievan@gmail.com'),
('Mirko','Ereš','mirko.eres1@gmail.com'),
('Lea','Raguž','raguz.leaa@gmail.com'),
('Dominik','Daraždi','dominikdarazdi@gmail.com'),
('Dean','Vagner','deanvagner@yahoo.com'),
('Marko','Mudrovčić','markomudrovcic12@gmail.com'),
('Mario','Kušen','kusen.mario@gmail.com'),
('Leon','Jalovičar','ringerajacar@gmail.com'),
('Dražen','Kalazić','thekalazic@gmail.com'),
('Matej','Sudarić','matejsudo@gmail.com'),
('Antonijo','Šakić','a.sakic.1.g@gmail.com'),
('Nikola','Milić','nikk.mil@gmail.com'),
('Manuela','Slobođanac','manja496@gmail.com'),
('Srđan','Filipović','srdjanfilipovic991@gmail.com'),
('Goran','Matoš','goran.matos@a1.hr'),
('Igor','Tomić','i.tomic.babinski@gmail.com'),
('Borna','Štajduhar','bornastajduhar1999@gmail.com'),
('Ante','Filipović','ante.filipovic72@gmail.com'),
('Domagoj','Glavačević','glavacevic.d@gmail.com'),
('Lorena','Ostroški','lorena.ostroski2503@gmail.com'),
('Sanja','Boduljak','matkosanja@gmail.com'),
('Leon','Puhanić','leonpuhanic@gmail.com'),
('Danijel','Sačer','sacerdanijel@gmail.com');


--select * from clanovi;

-- članovi grupe WP4
insert into clanovi (grupa,polaznik) values
(1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),
(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),(1,17),(1,18),(1,19),(1,20),
(1,21),(1,22),(1,23),(1,24),(1,25),(1,26),(1,27);

-- članovi grupe WP5
insert into clanovi (grupa,polaznik) values
(2,1),(2,3),(2,4);