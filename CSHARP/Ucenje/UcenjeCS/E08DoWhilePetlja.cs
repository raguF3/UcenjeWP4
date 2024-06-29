using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08DoWhilePetlja
    {
        public static void Izvedi()
        {
            // do while izdvaja činjenica da će se barem jednom izvest
            int i = 0;

            do
            {
                Console.WriteLine("u do while: " +i); //provjera u uvjeta na kraju pa se izvodi


            } while (i > 0);

            while (i > 0)
            { 
                Console.WriteLine("u while: " +i); // provjera uvjeta na početku veze pa se ne mora izvesti
            }

            // svi ostali elementi kao i u for i while 
        }    
    }
}
