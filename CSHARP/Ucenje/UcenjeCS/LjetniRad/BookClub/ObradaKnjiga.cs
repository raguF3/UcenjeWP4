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
            Console.WriteLine(" Izbornik knjiga");
            Console.WriteLine("1. Pregled svih knjiga");
            Console.WriteLine("2. Unos novih knjiga");
            Console.WriteLine("3. Promjena postojećih knjiga");
            Console.WriteLine("4. Brisanje postojećih knjiga");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijaIzbornika();
        }

        private void OdabirOpcijaIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
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
                    Console.Clear();
                    break;
            }
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
                godina=Pomocno.Ucitajdatum("Unesi datum izdavanja", true)


            });
        }
    }
}   

