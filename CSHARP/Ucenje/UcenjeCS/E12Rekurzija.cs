using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    

    internal class E12Rekurzija  //rekurzija kada metoda poziva samu sebe uz uvjet prekida rekurzije
    {
        // Rekurzija je kada metoda poziva samu sebe - nedovoljna definicija

        //objekt je instanca klase. klasa je opisnik objekta

        public static void Izvedi()    
        {
            do
            {
                // LosaMetoda();
                Console.WriteLine(Zbroj(Pomocno.UcitajCijeliBroj("Unesi broj za sumu svih brojeva do tog broja")));
            } while (Pomocno.UcitajCijeliBroj("-1 za prekid") != -1);

        }


        private static int Zbroj(int broj)
        {
            // uvijek prvo napraviti uvije prekida kekurzije
            if (broj == 0)
            {
                return broj;
            }
            return broj + Zbroj(broj - 1);
        }



        static void LosaMetoda()
        {
            LosaMetoda(); // stackoverflow exception
        }




    }
}
