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
               
                case 5:
                    Console.Clear();
                    break;
            }
        }
}
}   

