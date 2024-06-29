using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09RorEachPetlja
    {
        public static void Izvedi()
        {
            // foreach je skraćeni for
            //ispiši svaki znak riječi jedan ispod drugog

            string rijec = "Osijek";

            for (int i = 0; i<rijec.Length; i++)
            {
                Console.WriteLine(rijec[i]);

            }

            foreach(var znak in rijec) //foreach radi s listama, nizovima, riječnicima, stringovima
            {
                Console.WriteLine(znak);  // ne ide za brojeve

            }
        }

    }
}
