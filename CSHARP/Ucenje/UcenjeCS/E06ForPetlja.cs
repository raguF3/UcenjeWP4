﻿using System;
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
            Izvedi(0);
        }

        internal static void Izvedi(int v)
        {
           
            // Ispiši 10 puta Osijek
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

            Console.WriteLine("*************************");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Osijek");
            }

            Console.WriteLine("*************************");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************");
            // Zbrojiti prvih 100 brojeva
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            Console.WriteLine("*************************");
            // ispiši sve parne brojeve od 3 do 29
            // loše rješenje
            for (int i = 4; i < 29; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************");
            int brojOd = 3; // ovo se može učitati od korisnika
            int brojDo = 29; // ovo se može učitati od korisnika
            // u nastavku u kodu nema konstanti
            for (int i = brojOd; i < brojDo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("*************************");

            int[] niz = { 2, 3, 2, 3, 2, 2, 3, 34, 4, 5 };

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }


            Console.WriteLine("*************************");
            // Ispiši sve brojeve od 20 do 10
            for(int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************");


            // Ispiši sve prim brojeve od 2 do 14
            int ukupno = 0;
            bool prim;
            for(int i = 2; i < 1400; i++)
            {
                prim = true;
                for(int j = 2; j < i; j++)
                {
                    //Console.WriteLine("{0} % {1} = {2}", i,j,i%j);
                    if(i%j== 0)
                    {
                        prim = false; // 2000000 da li je prim broj
                        // prekini unutarnju petlju jer sve ostale provjere nisu više bitne
                        break;
                    }
                    if (!prim)
                    {
                       ukupno++;
                        //Console.WriteLine("Nepotrebno izvođenje " + ++ukupno);
                    }
                }
                if (prim)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("nepotrebno izvodio: " + ukupno);


            Console.WriteLine("*************************");
            // preskakanje petlje
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i = 0; i < 10; i++)
            {
                for(int j=0; j < 10; j++)
                {
                    Console.WriteLine(i*j);
                    // želim prekinuti vanjsku petlju: varijabla i
                    goto labela;
                }
            }



        labela:
            Console.WriteLine("********************");




        }

    }
}