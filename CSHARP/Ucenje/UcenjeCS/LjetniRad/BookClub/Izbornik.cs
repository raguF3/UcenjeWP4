using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E18KonzolnaAplikacija;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class Izbornik
    {
        public Izbornik()
        {

            PozdravnaPoruka();
            PrikaziIzornik();

        }

        private void PrikaziIzornik()
        {
            Console.WriteLine("     GLAVNI IZBORNIK    ");
            Console.WriteLine("1. Knjige");
            Console.WriteLine("2. Sastanci");
            Console.WriteLine("3. Dolasci");
            Console.WriteLine("4. Clanovi");
            Console.WriteLine("5. Izlaz");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    Console.WriteLine("Pozivv izbornika smjera");
                    break;
            }
        }


        private void PozdravnaPoruka()

        {
            Console.WriteLine("*****************************");
            Console.WriteLine("********   Welcome   ********");
            Console.WriteLine("*****************************");
        }

    }
}

