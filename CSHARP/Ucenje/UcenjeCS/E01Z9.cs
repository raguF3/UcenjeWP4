using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z9
    {
        internal static void Izvedi()
        {
            //program učitava od korisnika tri broja    
            // program ispisuje razliku druga dva broja pribrojenu prvom broju
            int b1;
                Console.WriteLine("Unesi prvi broj: ");
            b1=int.Parse(Console.ReadLine());
            int b2;
            Console.WriteLine("Unesi drugi broj: ");
            b2=int.Parse(Console.ReadLine());
            int b3;
            Console.WriteLine("Unesi treći broj: ");
            b3=int.Parse(Console.ReadLine());

            Console.WriteLine(b2-b3+b1);
        }
    }
}
