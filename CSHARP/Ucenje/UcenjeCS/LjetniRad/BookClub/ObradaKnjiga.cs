using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.LjetniRad.BookClub.Citateljskiklub;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class ObradaKnjiga
    {
        public List<Knjiga> Knjige { get; set; }



        public ObradaKnjiga()
        {
            Knjige = new List<Knjiga>();

        }

        public void PrikaziIzbornik()

        {
            Console.WriteLine("    Izbornik knjiga   ");
            Console.WriteLine("1. Pregled svih knjiga");
            Console.WriteLine("2. Unos novih knjiga");
            Console.WriteLine("3. Promjena postojećih knjiga");
            Console.WriteLine("4. Brisanje postojećih knjiga");
            Console.WriteLine("5. Pretraživanje knjiga");
            Console.WriteLine("6. Glasaj za najbolju knjigu");
            Console.WriteLine("7. Prikaži najbolje knjige");
            Console.WriteLine("8. Povratak na glavni izbornik");
            OdabirOpcijaIzbornika();
        }

        private void OdabirOpcijaIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 8))
            {

                case 1:
                    PrikaziKnjige();
                    PrikaziIzbornik();
                    break;

                case 2:
                    UnosNoveKnjige();
                    PrikaziIzbornik();
                    break;

                case 3:
                    PromjenaPostojecihKnjiga();
                    PrikaziIzbornik();
                    break;


                case 4:
                    BrisanjePostojecihKnjiga();
                    PrikaziIzbornik();
                    break;

                case 5:
                    PretraziKnjige();
                    PrikaziIzbornik();
                    break;

                case 6:
                    GlasajZaKnjigu();
                    PrikaziIzbornik();
                    break;

                case 7:
                    PrikaziNajboljeKnjige();
                    PrikaziIzbornik();
                    break;

                case 8:
                    Console.Clear();
                    break;
            }
        }


        private void GlasajZaKnjigu()
        {
            PrikaziKnjige();
            var odabrani = Knjige[Pomocno.UcitajRasponBroja("Odaberi redni broj knjige za glasovanje", 1, Knjige.Count) - 1];
            odabrani.brojGlasova++;
            Console.WriteLine($"Glas za knjigu '{odabrani.naziv}' je uspješno dodan! Sada ima {odabrani.brojGlasova} glasova.");
        }

        private void PrikaziNajboljeKnjige()
        {
            if (Knjige.Count == 0)
            {
                Console.WriteLine("Nema knjiga za prikaz.");
                return;
            }

            var najboljeKnjige = Knjige.OrderByDescending(k => k.brojGlasova).ToList();

            Console.WriteLine("************************");
            Console.WriteLine("Najbolje knjige prema glasovima:");

            foreach (var k in najboljeKnjige)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("************************");
        }


        public void PretraziKnjige()
        {
            Console.WriteLine("Odaberite kriterij pretraživanja:");
            Console.WriteLine("1. Po nazivu");
            Console.WriteLine("2. Po autoru");
            Console.WriteLine("3. Po godini izdavanja");

            int odabir = Pomocno.UcitajRasponBroja("Odaberite opciju", 1, 3);
            List<Knjiga> rezultati = new List<Knjiga>();

            switch (odabir)
            {
                case 1:
                    string naziv = Pomocno.Ucitajstring("Unesite naziv ili dio naziva knjige", 80, false);
                    rezultati = Knjige.Where(k => k.naziv.ToLower().Contains(naziv.ToLower())).ToList();
                    break;

                case 2:
                    string autor = Pomocno.Ucitajstring("Unesite ime ili dio imena autora", 80, false);
                    rezultati = Knjige.Where(k => k.autor.ToLower().Contains(autor.ToLower())).ToList();
                    break;

                case 3:
                    int godina = Pomocno.UcitajRasponBroja("Unesite godinu izdavanja", 1, DateTime.Now.Year);
                    rezultati = Knjige.Where(k => k.godina.HasValue && k.godina.Value.Year == godina).ToList();
                    break;
            }

            PrikaziRezultatePretrage(rezultati);
        }


        private void PrikaziRezultatePretrage(List<Knjiga> rezultati)
        {
            if (rezultati.Count == 0)
            {
                Console.WriteLine("Nema rezultata koji odgovaraju vašem kriteriju pretraživanja.");
            }
            else
            {
                Console.WriteLine("Pronađene knjige:");
                foreach (var knjiga in rezultati)
                {
                    Console.WriteLine(knjiga);
                }
            }
            Console.WriteLine("*************************");
        }


        private void BrisanjePostojecihKnjiga()
        {
            PrikaziKnjige();
            var odabrani = Knjige[Pomocno.UcitajRasponBroja("Odaberi redni broj knjiga za brisanje",
                1, Knjige.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.naziv + "? (DA/NE)", "da"))
            {
                Knjige.Remove(odabrani);
            }

        }


        private void PromjenaPostojecihKnjiga()
        {
            PrikaziKnjige();
            var odabrani = Knjige[Pomocno.UcitajRasponBroja("Odaberi redni broj knjige za promjenu",
                1, Knjige.Count) - 1];
            odabrani.sifra = Pomocno.UcitajRasponBroja("Unesi šifru knjige", 1, int.MaxValue);
            odabrani.naziv = Pomocno.Ucitajstring("Unesi naziv knjige", 80, true);
            odabrani.autor = Pomocno.Ucitajstring("Unesi naziv autora", 80, true);
            odabrani.godina = Pomocno.Ucitajdatum("Unesi godinu izdavanja", true);
            odabrani.ocjena = Pomocno.UcitajRasponBroja("Unesi ocjenu knjige", 1, 5);

        }



        private void PrikaziKnjige()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Popis knjiga u bazi podataka");

            foreach (var k in Knjige)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("*************************");
        }

        private void UnosNoveKnjige()
        {

            Console.WriteLine("*************************");
            Console.WriteLine("Unesite podatke o knjizi i autoru");

            Knjige.Add(new()
            {
                sifra = Pomocno.UcitajRasponBroja("Unesi šifru knjige", 1, int.MaxValue),
                naziv = Pomocno.Ucitajstring("Unesi naziv knjige", 80, true),
                autor = Pomocno.Ucitajstring("Unesi ime autora", 80, true),
                godina = Pomocno.Ucitajdatum("Unesi datum izdavanja", true),
                ocjena = Pomocno.UcitajRasponBroja("Unesi ocjenu knjige", 1, 5)

            });

            Console.WriteLine("Knjiga je uspješno dodana!");
        }
    }
}


