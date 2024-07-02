using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{
    internal class ObradaIzlazniRacun : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("Vidi tko je kupac");
            Console.WriteLine("Pošalji račun");
        }
    }
}
