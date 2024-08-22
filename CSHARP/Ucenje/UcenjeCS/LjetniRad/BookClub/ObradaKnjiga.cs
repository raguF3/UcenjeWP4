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
            Console.WriteLine("4. Brisanje knjiga");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijaIzbornika();
        }

        private void OdabirOpcijaIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {

                case 1:
                    PrikažiKnjige();
                    PrikaziIzbornik();
                    break;

                case 2:
                    UnosNoveKnjige();
                    PrikaziIzbornik();
                    break;


                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void PrikažiKnjige()
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
        

            });
        }
    }
}   

