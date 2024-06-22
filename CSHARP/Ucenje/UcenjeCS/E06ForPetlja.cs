using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        internal static void Izvedi()
        {
            //ispiši 10x osijek
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            Console.WriteLine("*****************");

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Osijek");
            }

            Console.WriteLine("******************");

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************");
            int suma = 0;
            for (int i = 0; i<10; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            Console.WriteLine("*********************");
            //ispiši prvih sto brojeva

            int suma1= 0;
            for ( int i = 1; i<=100;i++)
            {
                suma1 += 1;
            }
            Console.WriteLine(suma1);

            Console.WriteLine("*******************");
            //ispiši brojeve od 3 do 29
            //loše rješenje

            for(int i = 4; i<29; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***********************");
            //dobro rješenje
            for(int i = 3; i<29; i++)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
