using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UcenjeCS.Zadaci
{
    internal class CiklicnaTablica
    {
        
        public static void Izvedi()
        {

            Console.Write("Unesi prvi broj: ");
            int red = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            int stupac = int.Parse(Console.ReadLine());


            int[,] tablica = new int[red, stupac];
            int broj = red * stupac;
            int r = 0;
            int s = 0;
            string smjer = "lijevo";

            for (int i = 1; i <= broj; i++)
            {
                tablica[r, s] = i;

                switch (smjer)
                {
                    case "desno":
                        s++;
                        if (s >= stupac || tablica[r, s] != 0)
                        {
                            s--;
                            r++;
                            smjer = "dolje";
                        }
                        break;
                    case "dolje":
                        r++;
                        if (r >= red || tablica[r, s] != 0)
                        {
                            r--;
                            s--;
                            smjer = "lijevo";
                        }
                        break;
                    case "lijevo":
                        s--;
                        if (s < 0 || tablica[r, s] != 0)
                        {
                            s++;
                            r--;
                            smjer = "gore";
                        }
                        break;
                    case "gore":
                        r--;
                        if (r < 0 || tablica[r, s] != 0)
                        {
                            r++;
                            s++;
                            smjer = "desno";
                        }
                        break;
                }
            }

            for (int j = 0; j < red; j++)
            {
                for (int k = 0; k < stupac; k++)
                {
                    Console.Write("{0,4}", tablica[j, k]);
                }
                Console.WriteLine();
            }
            
            

        }


        
    }
}
