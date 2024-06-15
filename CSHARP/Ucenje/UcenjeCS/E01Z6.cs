using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z6
    {
        internal static void Izvedi()
        {
            //program od korisnika učitava ime grad i broj stanovnika
            // ispisuje rečenicu: u xxxxx živi xxxx ljudi

            Console.WriteLine("Upiši ime grada: ");
            string ime=Console.ReadLine();
            Console.WriteLine("Upiši broj stanovnika: ");
            int bs = int.Parse(Console.ReadLine());
            Console.WriteLine("U {0} živi {1} broj stanovnika", ime, bs);
        }
    }
}
