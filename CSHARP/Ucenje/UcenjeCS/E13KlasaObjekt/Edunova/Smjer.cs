using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.Edunova
{
    internal class Smjer
    {
        private int broj;

        public int? sifra { get; set; }
        public string? naziv {get; set; }
        public int? trajanje { get; set; }
        public decimal? cijena { get; set; }
        public DateTime? IzvodiseOd { get; set; }
        public bool? verificiran {  get; set; }
        public int Broj { get; private set; }









        //ovaj gore prop bi u  većini drugih programskih jezika (a može i ovdje) izgleda

        private int getBroj()
        {
            return broj;

        }
        public void setBroj(int broj)
        {
            this.broj = broj;
        }
    }
}
