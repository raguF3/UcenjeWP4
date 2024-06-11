using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void Izvedi()

        {
            // program korisnika traži unos broj godina koje ima korisnik
            // Program ispisuje da li je korisnik punoljetna osoba ili ne

            int broj;

            Console.WriteLine("Unesite broj godina: ");
            broj= int.Parse(Console.ReadLine());

            if (broj > 18)
            {
                Console.WriteLine("Osoba je punoljetna");
            }
            else
            {
                Console.WriteLine("Osoba nije punoljetna");
            }
        }



    }
}
