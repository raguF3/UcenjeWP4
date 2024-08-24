using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.LjetniRad.BookClub.Citateljskiklub;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class ObradaSastanak
    {
        public List<Sastanak> Sastanci { get; set; }



        public ObradaSastanak()
        {
            Sastanci = new List<Sastanak>();

        }

        public void PrikaziIzbornik()

        {
            Console.WriteLine("    Izbornik sastanka   ");
            Console.WriteLine("1. Pregled svih sastanaka");
            Console.WriteLine("2. Unos novog sastanka");
            Console.WriteLine("3. Promjena postojećeg sastanaka");
            Console.WriteLine("4. Brisanje postojećeg sastanka");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijaIzbornika();
        }

        private void OdabirOpcijaIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {

                case 1:
                    PrikaziSastanke();
                    PrikaziIzbornik();
                    break;

                case 2:
                    UnosNovogSastanka();
                    PrikaziIzbornik();
                    break;

                case 3:
                    PromjenaPostojecegSastanka();
                    PrikaziIzbornik();
                    break;


                case 4:
                    BrisanjePostojecegSastanka();
                    PrikaziIzbornik();
                    break;


                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void BrisanjePostojecegSastanka()
        {
            PrikaziSastanke();
            var odabrani = Sastanci[Pomocno.UcitajRasponBroja("Odaberi redni broj sastanka za brisanje",
                1, Sastanci.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.sifra + "? (DA/NE)", "da"))
            {
                Sastanci.Remove(odabrani);
            }

        }

        private void PromjenaPostojecegSastanka()
        {
            PrikaziSastanke();
            var odabrani = Sastanci[Pomocno.UcitajRasponBroja("Odaberi redni broj sastanka za promjenu",
                1, Sastanci.Count) - 1];
            odabrani.sifra = Pomocno.UcitajRasponBroja("Unesi redni broj sastanka", 1, int.MaxValue);
            odabrani.datum = Pomocno.Ucitajdatum("Unesi datum sastanka", true);
            odabrani.knjiga = Pomocno.UcitajRasponBroja("Unesi sifru knjige", 1, int.MaxValue);
            odabrani.mjesto = Pomocno.Ucitajstring("Unesi naziv mjesta sastanka", 50, true);


        }



        private void PrikaziSastanke()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Popis sastanaka u bazi podataka");

            foreach (var s in Sastanci)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("*************************");
        }

        private void UnosNovogSastanka()
        {

            Console.WriteLine("*************************");
            Console.WriteLine("Unesite podatke o sastanku");

            Sastanci.Add(new()
            {
                sifra = Pomocno.UcitajRasponBroja("Unesi redni broj sastanka", 1, int.MaxValue),
                datum = Pomocno.Ucitajdatum("Unesi datum sastanka", true),
                knjiga = Pomocno.UcitajRasponBroja("Unesi sifru knjige", 1, int.MaxValue),
                mjesto = Pomocno.Ucitajstring("Unesi naziv mjesta sastanka", 50, true)

            });
        }
    }
}
