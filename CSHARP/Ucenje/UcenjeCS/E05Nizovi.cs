using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
           
            int[] godine = new int[17];

            godine[0] = 43; //element na indesu 0 
            godine[godine.Length - 1] = 23;

            Console.WriteLine(godine);
            Console.WriteLine(string.Join(",", godine));

            int[] niz = { 2, 8, 4, 5, 6, 7, 5, 4, 3, 4, 5, 5, 5, };

            Console.WriteLine(niz[1]);

            string[] gradovi = { "osijek", "Donji Miholjac", "Valpovo" };

            int[,] tablica ={

                {1,2,3 },
                {4,5,6},
                {7,8,9}

            };

            Console.WriteLine(tablica[0,2]);

            int[,,,,] multiverse = new int [10,10,10,10,10];

            object[] objekti = { 1, "Pero", true, 2.2 };

        }
    }
}
