using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGranjanjeSwitch
    {
        public static void Izvedi()
        {
            // ako je i ==0 ispiši DOBAR, 1 LOŠ, 2 ZAO


            int i = 0;

            switch (i) // radi s int, string i char tipovima podataka
            {
                case 0:
                    Console.WriteLine("DOBAR");
                    break;
                case 1:
                    Console.WriteLine("LOŠ");
                    break;
                case 2:
                    Console.WriteLine("ZAO");
                    break;
                default: //to je else u if-u
                    Console.WriteLine("Nije definirano");
                    break;

                    // korisnik unosi brojčani iznos ocjene. Program ispisuje
                    //Tekstualno ocjenu
            }

            int ocjena;
            Console.WriteLine("Unesi ocjenu u brojčanom obliku: ");
            ocjena = int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo Dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Nije određeno");
                    break;

            }
        }
    }
}
