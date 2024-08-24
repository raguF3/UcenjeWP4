using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.LjetniRad.BookClub.Citateljskiklub;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class Izbornik
    {
        public ObradaKnjiga ObradaKnjiga { get; set; } = new ObradaKnjiga();
        public ObradaDolazak ObradaDolazak { get; set; } = new ObradaDolazak();
        public ObradaClan ObradaClan { get; set; } = new ObradaClan();

        public ObradaSastanak ObradaSastanak { get; set; } = new ObradaSastanak();


        public Izbornik()
        {
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
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
                    Console.Clear();
                    ObradaKnjiga.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                case 2:
                    Console.Clear();
                    ObradaSastanak.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;


                case 3:
                    Console.Clear();
                    ObradaDolazak.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                case 4:
                    Console.Clear();
                    ObradaClan.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;


                case 5:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja");
                    break;
            }
        }



        private void PozdravnaPoruka()

        {
            Console.WriteLine("*****************************");
            Console.WriteLine("           Welcome           ");
            Console.WriteLine("*****************************");
        }

    }
}

