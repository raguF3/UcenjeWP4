using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z5
    {

        //program od korisnika učitava decimalni broj te ispisuje korjen učitanog broja
        internal static void Izvedi()
        {
            double x;
            Console.WriteLine("Unesi decimalni broj: ");
            x= double.Parse(Console.ReadLine());
            x= Math.Sqrt(x);
            Console.WriteLine(x);


            Console.WriteLine("Unesi decimalni broj: ");
            Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));

            

        }



    }

}

