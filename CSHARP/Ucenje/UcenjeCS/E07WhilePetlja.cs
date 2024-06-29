using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhilePetlja
    {
        internal static void Izvedi()
        {
            //u for petlju se ne mora ući
            int brojDo = 1; // ovo može unijeti korisnik

            for (int i = 1; i <= brojDo; i++)
            {
                Console.WriteLine("kod u petlji");
            }
            // u whille petlju se ne mora ući
            int b = 1;
            while (b < brojDo)
            {
                Console.WriteLine("While u petlji");
            }
            // while radi s bool tipom podatka
            while(true)
            {
                Console.WriteLine("Kod u beskonačnoj petlji while");
                break; // continue radi isto kao i for

            }
            // ispiši prvih deset brojeva
            b = 0;
            while (++b < 10)
            {
                Console.WriteLine(b); 
            }
            Console.WriteLine("Nakon petrlje: " + b);


            Console.WriteLine("************************");

            brojDo = 10;
            b = 1;
            int j = 2;
            while(j>b && j<brojDo) // može ići i || te !
            {
                Console.WriteLine(j++);
            }
            Console.WriteLine("*************************");

            //isto se gnijezfi i prekida iznutra prema van s go to label 
        }
    }
}
