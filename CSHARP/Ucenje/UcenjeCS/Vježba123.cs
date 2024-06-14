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
            
            Console.WriteLine("Unesite prvi broj:");
            double broj1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            double broj2 = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Unesite operaciju (+, -, *, /):");
            char operacija = Console.ReadLine()[0];

            
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
                        Console.WriteLine("Greška: Dijeljenje sa nulom nije dozvoljeno.");
                    }
                    break;
                default:
                    Console.WriteLine("Greška: Operacija nije moguća.");
                    break;



            }
        }
    }
}
