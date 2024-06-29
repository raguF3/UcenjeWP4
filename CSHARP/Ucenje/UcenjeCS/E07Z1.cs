using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {
        public static void Izvedi()
        {
            // program od korisnika unosi cijeli broj
            // koristeći while petlju program ispisuje
            //zbroj svih parnih beojeva od 1 do unsenog


            Console.WriteLine("Unesi cijeli broj: ");
            int c = int.Parse(Console.ReadLine());

            int i = 1;

            int suma = 0;
            
            while (i <= c)
            {
                
                if (i % 2 == 0)
                {
                    
                    Console.WriteLine(i);
                    suma += i;
                }
                
                i++;
            }
            Console.WriteLine($"Zbroj svih parnih brojeva od 1 do {c} je: {suma}");
        }
    }
}
