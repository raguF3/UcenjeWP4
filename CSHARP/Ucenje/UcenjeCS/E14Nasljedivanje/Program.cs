using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{
    internal class Program
    {

        //peta vrsta metode-konstruktor:posebna vrsta metode koja se poziva prilikom kreiranja instance klase - objekra
        //ključna riječ new
        //konstruktor se naziva kao i klasa
        public Program()
        {
           // Console.WriteLine("hello");

            Smjer s= new Smjer();
            s.Naziv = "Web programiranje";
            Console.WriteLine(s); //ovdje se poziva metoda toString na objektu s


            var p = new Polaznik() { Ime = "Pero", sifra = 1 };
            Console.WriteLine(p);


            //apstraktna klasa se ne može instancirati
            //var e = new Entitet(); // e je isntanca klasa entiteta

            Obrada[] poslovi = new Obrada[2];
            poslovi[0] = new ObradaIzlazniRacun();
            poslovi[1] = new ObradaUlazniRacun();
            


        }

        // za konstruktor vrijedi pravilo method overloading 

        public Program(string s)
        {
            Console.WriteLine(s);
        }


    }
}
