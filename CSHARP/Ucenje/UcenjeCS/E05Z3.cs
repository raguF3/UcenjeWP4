using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Z3
    {
        internal static void Izvedi()
        {
            int[,] tablica = {
                {2,2,2 },
                {4,5,6},
                {6,7,7}
            };
            //program ispisuje jedno pokraj drugog razmakom brojeve u kutevima tablice

            Console.WriteLine("{0} {1} {2} {3}", tablica[0,0], tablica[0,1], tablica[1,0], tablica[1,1]);

        }
    }
}
