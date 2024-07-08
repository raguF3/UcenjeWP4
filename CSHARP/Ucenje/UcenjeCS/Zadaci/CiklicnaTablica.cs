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

            Console.Write("Unesi prvi cijeli broj: ");
            int redak = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijelim broj: ");
            int stupac = int.Parse(Console.ReadLine());


            int[,] tablica = new int[redak, stupac];

            int broj = 1;

            int top = 0, bottom = redak - 1, left = 0, right = stupac - 1;

            while (top <= bottom && left <= right)
            {

                for (int i = right; i >= left; i--)
                    tablica[bottom, i] = broj++;
                bottom--;


                for (int i = bottom; i >= top; i--)
                    tablica[i, left] = broj++;
                left++;


                for (int i = left; i <= right; i++)
                    tablica[top, i] = broj++;
                top++;


                for (int i = top; i <= bottom; i++)
                    tablica[i, right] = broj++;
                right--;
            }


            for (int i = 0; i < redak; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();

            }


        }
    }
}
