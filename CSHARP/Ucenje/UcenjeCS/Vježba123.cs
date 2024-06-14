using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Vježba123
    {
        public static void Izvedi()
        {
            //kalkulator
            // Tražimo od korisnika da unese dva broja
            Console.WriteLine("Unesite prvi broj:");
            double broj1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            double broj2 = double.Parse(Console.ReadLine());

            // Tražimo od korisnika da unese željenu operaciju
            Console.WriteLine("Unesite operaciju (+, -, *, /):");
            char operacija = Console.ReadLine()[0];

            // Koristimo switch da izvršimo odgovarajuću operaciju
            switch (operacija)
            {
                case '+':
                    Console.WriteLine("Rezultat: " + (broj1 + broj2));
                    break;
                case '-':
                    Console.WriteLine("Rezultat: " + (broj1 - broj2));
                    break;
                case '*':
                    Console.WriteLine("Rezultat: " + (broj1 * broj2));
                    break;
                case '/':
                    if (broj2 != 0)
                    {
                        Console.WriteLine("Rezultat: " + (broj1 / broj2));
                    }
                    else
                    {
                        Console.WriteLine("Greška: Deljenje sa nulom nije dozvoljeno.");
                    }
                    break;
                default:
                    Console.WriteLine("Greška: Nevažeća operacija.");
                    break;



            }
        }
    }
}
