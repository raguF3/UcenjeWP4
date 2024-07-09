using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E14Nasljedivanje;

namespace UcenjeCS.E16GenericiLambdaEkstenzije
{
    internal class Smjer: Entitet, ISucelje, IComparable<Smjer>
    {
        public int? sifra { get; set; }
        public string? naziv { get; set; }

        public override string ToString()
        {
            // return sifra + " - " + naziv;

            return new StringBuilder().Append(sifra).Append(" - ").Append(naziv).ToString();


        }

        public override void PredstaviSe()
        {
            Console.WriteLine(sifra + " - " + naziv);
        }

        public void Posao()
        {
            Console.WriteLine("Radim na klasi Smjer, naziv je: " + naziv);
        }

        public int CompareTo(Smjer? other)
        {
            return naziv?.CompareTo(other?.naziv) ?? 0;
        }
    }
}
