using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.LjetniRad.BookClub.Citateljskiklub;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class ObradaDolazak
    {
        public List<Dolazak> Dolasci { get; set; }

        

        public ObradaDolazak()
        {
            Dolasci = new List<Dolazak>();

        }

        public void PrikaziIzbornik()

        {
            Console.WriteLine("    Dolasci   ");
            Console.WriteLine("1. Pregled svih dolazaka");
            Console.WriteLine("2. Unos novih dolazaka");
            Console.WriteLine("3. Promjena postojećih dolazaka");
            Console.WriteLine("4. Brisanje postojećih dolazaka");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijaIzbornika();
        }

        private void OdabirOpcijaIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {

                case 1:
                    PrikaziDolaske();
                    PrikaziIzbornik();
                    break;

                case 2:
                    UnosNovihDolazaka();
                    PrikaziIzbornik();
                    break;

                case 3:
                    PromjenaPostojecihDolazaka();
                    PrikaziIzbornik();
                    break;


                case 4:
                    BrisanjePostojecihDolazaka();
                    PrikaziIzbornik();
                    break;


                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void BrisanjePostojecihDolazaka()
        {
            PrikaziDolaske();
            var odabrani = Dolasci[Pomocno.UcitajRasponBroja("Odaberi redni broj dolazaka za brisanje",
                1, Dolasci.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.clan + "? (DA/NE)", "da"))
            {
                Dolasci.Remove(odabrani);
            }

        }

        private void PromjenaPostojecihDolazaka()
        {
            PrikaziDolaske();
            var odabrani = Dolasci[Pomocno.UcitajRasponBroja("Odaberi redni broj dolaka za promjenu",
                1, Dolasci.Count) - 1];
            odabrani.sastanak = Pomocno.Ucitajdatum("Unesi datum sastanka", true);
            odabrani.clan = Pomocno.UcitajRasponBroja("Unesi clana", 1, int.MaxValue);

        }



        private void PrikaziDolaske()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Popis dolazaka u bazi podataka");

            foreach (var d in Dolasci)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("*************************");
        }

        private void UnosNovihDolazaka()
        {

            Console.WriteLine("*************************");
            Console.WriteLine("Unesite podatke o dolascima");

            Dolasci.Add(new()
            {
                clan = Pomocno.UcitajRasponBroja("Unesi šifru knjige", 1, int.MaxValue),
                sastanak = Pomocno.Ucitajdatum("Unesi datum sastanka", true)


            });
        }
    }
}
