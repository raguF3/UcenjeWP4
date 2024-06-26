using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class DZ
    {
        internal static void Izvedi()
        {
            // Domaća zadaća. Ispisati tablicu množenja 10x10. Formatirati na ovaj način
            //  1   2   3   4   5  6   7   8   9   10
            //  2   4   6   8  10  12  14  16  18  20
            //  3   6   9  12  15  18  21  24  27  30
            //  4   8  12  16  20  24  28  32  36  40
            //  5  10  15  20  25  30  35  40  45  50
            //  6  12  18  24  30  36  42  48  54  60
            //  7  14  21  28  35  42  49  56  63  70
            //  8  16  24  32  40  48  56  64  72  80
            //  9  18  27  36  45  54  63  72  81  90
            // 10  20  30  40  50  60  70  80  90 100
            /*

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }
            */

            Console.Write("Unesite broj redaka: ");
            int redaka = int.Parse(Console.ReadLine());
            Console.Write("Unesite broj stupaca: ");
            int stupaca = int.Parse(Console.ReadLine());

            
            int[,] tablica = new int[redaka, stupaca];

            int broj = 1; 

            int top = 0, bottom = redaka - 1, left = 0, right = stupaca - 1;

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

            
            for (int i = 0; i < redaka; i++)
            {
                for (int j = 0; j < stupaca; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}

