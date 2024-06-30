using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Metode
    {
        internal static void Izvedi()
        {
            //pozizv metode
            Tip1();
            Tip1();

            for (int i = 0; i < 55; i++)
            {
                Tip1();
            }

            Tip2("Edunova");

            Console.WriteLine("Unesi ime: ");
            Tip2(Console.ReadLine());

            Tip2("Frano", "Perić");


            int broj = Tip3();
            Console.WriteLine(broj);
            for (int i = 0; i < 55; i++)
            {
                Console.WriteLine(Tip3());
            }

            Console.WriteLine(Tip4(2,8));


            //ispiši sve prim brojeve od dva unesena broja
            int odBroja = Pomocno.UcitajCijeliBroj("Unesi od broja: ");
            int doBroja = Pomocno.UcitajCijeliBroj("Unesi do broja: ");
            for (int i = odBroja;
                i <doBroja; i++)
            {
                if(primBroj(i))
                {
                    Console.WriteLine(i);
                }
            }


        }

        //tip 1. metoda ne prima parametre i ne vraća vrijednost
        //  ovdje je deklarirana i napisana
        //private se vidi samo u trenutnoj klasi

        private static void Tip1()
        {

            Console.WriteLine("Hello iz metode koja ne prima parametre i ne vraća vrijednost: ");
            Console.WriteLine("Drugi red");
            Console.WriteLine("Treći red");

        }
        //tip 2. pprima parametre i ne vraća vrijednost 
        //kada ispred static void nema načina tada je private 

        static void Tip2(string ime)
        {
            Console.WriteLine("Hello {0}", ime);
        }

        //nazim metode ne mora biti jedinstven
        //potpis metode + lista parametara
        //method signnature
        //method overload

        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("Hello {0} {1}", ime, prezime);

        }

        //tip 3.metoda ne prima parametre i vraća vrijednost
        
        //vraća prema ACSII tablici, pogledati https://simple.m.wikipedia.org/wiki/File:ASCII-Table-wide.svg
        static int Tip3()
        {

            return new Random().Next(20, 30);
            

           // return '7';//return vraća metodu onome tko ju je poslao
        }
        //tip 4. najbitnije metoda prima parametre, metoda vraaća vrijednost
        //protected je vidljiv u ovoj klasi u svim podklasama (OOP - kasnije)
        /// <summary>
        /// metoda za dva primljena cijela broja vraća zbroj sviih bbrojeva između njih
        /// </summary>
        /// <param name="OdBroja">broj od kojeg se kreće uključujući taj broj</param> 
        /// <param name="DoBroja">broj do kojeg se kreće uključujući taj broj</param>
        /// <returns>zbroj brojeva između dva primljena broja</returns>
        protected static int Tip4(int OdBroja, int DoBroja)
        {
            //throw new NotImplementedException();  //može i ovako
            int suma = 0;
            for (int i = OdBroja; i <= DoBroja; i++)
            {
                suma += i;
            }

            return suma;
        
        }

        // primjer metode s više izraza
        static bool primBroj(int broj)
        {
            for (int i = 2; i<broj; i++)
            {
                if(broj % i==0)
                {
                    return false; 
                }
            }
            return true;
        }

    }
}
