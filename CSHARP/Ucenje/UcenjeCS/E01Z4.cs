using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z4
    {
        //program od korisinika učitava dvije rečenice i ispisuje jednu nakon druge u istom retku.
        public static void Izvedi()
        {
            Console.Write("Upiši prvu rečenicu: ");
            string recenica1;

            recenica1 =Console.ReadLine();

            Console.Write("Unesi drugu recčenicu: ");

            string recenica2 = Console.ReadLine();
            Console.Write(recenica1 + "" + recenica2);

            Console.Write("{0} {1}", recenica1, recenica2);


        }

    }
}
