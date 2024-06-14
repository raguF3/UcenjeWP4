using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            // 1-7 Pon-Ned
            int broj;

            Console.WriteLine("Unesi broj između 1 i 7: ");
            broj = int.Parse(Console.ReadLine());

            switch (broj)
                {
                case 1:
                    Console.WriteLine("Ponedjeljak");
                    break;
                    case 2:
                    Console.WriteLine("Utorak");
                    break;
                    case 3:
                    Console.WriteLine("Srijeda");
                    break;  
                    case 4:
                    Console.WriteLine("Četvrtak");
                    break;
                    case 5:
                    Console.WriteLine("Petak");
                    break;
                    case 6:
                    Console.WriteLine("Subota");
                    break;
                    case 7:
                    Console.WriteLine("Nedjelja");
                    break;
                default:
                    Console.WriteLine("Neodređeno");
                    break;
            }

           
        }

    }
}
