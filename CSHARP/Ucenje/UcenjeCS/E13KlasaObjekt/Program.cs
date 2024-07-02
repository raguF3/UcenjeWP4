using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt
{
    public class Program
    {
        public static void Izvedi()
        {
            //Objekt je instanca(pojavnost) klase.
            //Osoba - klasa
            //osoba instanca (objekt, varijabla)

            Osoba osoba = new Osoba();

            osoba.Ime = "Pero"; // DZ: Napraviti metodu Pomocno.UcitajString koja osigurava unosa
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime());

            Osoba ravnatelj = new Osoba
            {
                Ime = "Eduard",
                Prezime = "Kuzma"
            };


            var direktor = new Osoba { Prezime = "Kas" };
            // https://gunnarpeipman.com/csharp-question-marks/
            // https://blog.wordbot.io/tech/what-do-two-question-marks-together-mean-in-c/
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
            Console.WriteLine(direktor.Ime?.ToUpper());


            Osoba o = new()
            {
                Ime = "Ana",
                Prezime = "Kiš"
            };

            o.Mjesto = new()
            {
                PostanskiBroj = "31000",
                Zupanija = new()
                {
                    Drzava = new() { Naziv = "Hrvatska" }
                }
            };

            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());

            Console.WriteLine(o.Mjesto?.Naziv ?? "Nema");

            



            




        }

    }
}
