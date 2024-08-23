using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.LjetniRad.BookClub.Citateljskiklub;
using UcenjeCS.LjetniRad.BookClub.LjetniRad.BookClub.Citateljskiklub;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class ObradaClan
    {
        public List<Clan> Clanovi { get; set; }


        public ObradaClan()
        {
            Clanovi = new List<Clan>();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("   Članovi   ");
            Console.WriteLine("1. Pregled članova");
            Console.WriteLine("2. Unos novih članova");
            Console.WriteLine("3. Promjena postojećih članova");
            Console.WriteLine("4. Brisanje postojećih članova");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijaIzbornika();
        }

        private void OdabirOpcijaIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {

                case 1:
                    PrikaziClanove();
                    PrikaziIzbornik();
                    break;

                case 2:
                    UnosNovogClana();
                    PrikaziIzbornik();
                    break;

                case 3:
                    PromjenaPostojecihClanova();
                    PrikaziIzbornik();
                    break;


                case 4:
                    BrisanjePostojecihClanova();
                    PrikaziIzbornik();
                    break;


                case 5:
                    Console.Clear();
                    break;
            }
        }
        private void BrisanjePostojecihClanova()
        {
            PrikaziClanove();
            var odabrani = Clanovi[Pomocno.UcitajRasponBroja("Odaberi redni broj člana za brisanje",
                1, Clanovi.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.ime + "? (DA/NE)", "da"))
            {
                Clanovi.Remove(odabrani);
            }

        }

        private void PromjenaPostojecihClanova()
        {
            PrikaziClanove();
            var odabrani = Clanovi[Pomocno.UcitajRasponBroja("Odaberi redni broj člana za promjenu",
                1, Clanovi.Count) - 1];
            odabrani.sifra = Pomocno.UcitajRasponBroja("Unesi šifru knjige", 1, int.MaxValue);
            odabrani.ime = Pomocno.Ucitajstring("Unesi naziv knjige", 80, true);
            odabrani.prezime = Pomocno.Ucitajstring("Unesi naziv autora", 80, true);
            odabrani.Email = Pomocno.Ucitajstring("Unesi Email adresu", 80, true);


        }



        private void PrikaziClanove()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Popis članova u bazi podataka");

            foreach (var c in Clanovi)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("*************************");
        }

        private void UnosNovogClana()
        {

            Console.WriteLine("*************************");
            Console.WriteLine("Unesite podatke o članu");

            Clanovi.Add(new()
            {
                sifra = Pomocno.UcitajRasponBroja("Unesi šifru knjige", 1, int.MaxValue),
                ime = Pomocno.Ucitajstring("Unesi naziv knjige", 80, true),
                prezime = Pomocno.Ucitajstring("Unesi ime autora", 80, true),
                Email = Pomocno.Ucitajstring("Unesi Email adresu", 80, true),


            });
        }
    }

   
}
