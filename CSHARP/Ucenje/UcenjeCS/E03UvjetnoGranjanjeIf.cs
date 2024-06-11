using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGranjanjeIf
    {


        public static void Izvedi()
        {


            int i = 8;

            bool uvjet = i == 7;

            Console.WriteLine(uvjet);

            if (uvjet) // u if granu se ulazi ako je vrijednost uvjeta   true 

            {
                Console.WriteLine("1. Ušao sam u if granu, uvjet je zadovoljen");
            }

            {

                Console.WriteLine("2. Uvjet nije zadovoljen , otišao u false granu");

            }


            if (i > 2) // ako ne postoje {} if se odnosi samo na 1. sljedeću liniju
            Console.WriteLine("3. Ušao u if bez vitičastih zagrada");
            Console.WriteLine("4. ovo se izvodi bez obzira na gornji if");

            var j = 2;

            // dodatni operatori & (and), &&, | (or), || (altgr + w), ! (not)

            if (i < 2 && j == 2)

            {

                Console.WriteLine("5. logičko &");
            }

            // & provjerava oba uvjeta bez obzira što možda prvi bude false
            // && ukoliko prvi uvjet bude false drugi se ne provjerava

            if(j==2 || i<2) 
            
            {

                Console.WriteLine("5. logičko or |");


                
            }
                   
            // | provjerava oba uvjeta bez obzira što prvi bude true
            // || ukoliko prvi uvjet bude true drugi se ne provjerava

            if ( i!= 5)

            {

                Console.WriteLine("7.i nema vrijednost 5");

            }

            var ocjena = 4;
            if (ocjena == 1)

            {
                Console.WriteLine("8.nedovoljan");
            } else if (ocjena == 2)

            {
                Console.WriteLine("9. ocjena je dobra");

            }
            else
            {
                Console.WriteLine("10. Ocjena nije dobra");

            }

            if (ocjena ==4)
            {

                Console.WriteLine("11.vrlo dobar si");

            }
            else
            {
                Console.WriteLine("12.oke si");
            }

            if (i > 0)
            {
                if (ocjena == 4) 
                {
                    Console.WriteLine("12. Gnježđenje se može zapravo ");
            }

        }



        }




    }
}
