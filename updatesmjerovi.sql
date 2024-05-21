select * from smjerovi;
where sifra=1;

--promijeniti smjer web programiranja u c# programiranje
update smjerovi set naziv='c# programiranje'
where sifra=1;

--promijeniti cijenu i verificiran smjera čšćđž ČŠĆĐŽ
--update jednog reda, više kolona
update smjerovi set
cijena=1999.98, verificiran=0
where sifra=3;

--svim smjerovima čija je šifra veća od 1 postavi datum
--izvođenja na 01. veljača 2024
update smjerovi set
izvodiseod='2024-02-01'
where sifra>1;

--svim smjerovima koji imaju trajanje null
--postavi trajanje na 100
update smjerovi set
trajanje=100
where trajanje is null;

--postaviti cijenu web dizajna na 1000 eura
update smjerovi set cijena=1000
where naziv='web dizajn'; --ovo nije dobra praksa
--trebali smo ići s where sifra=2;

--svim smjerovima smanjiti cijenu za 10%
update smjerovi set cijena = cijena * 09;

--svim smjerovima povečajte cijene za 200 eura
update smjerovi set cijena = cijena + 200;

--uvjećajte cijene smjerova za PDV
update smjerovi set cijena = cijena * 1.25;


select * from polaznici;

--polazniku igoru brzici postaviti slučajni oib
update polaznici set
oib='65016660936'
where sifra=4;



