using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.Edunova
{
    internal class Grupa
    {
        public int? sifra {  get; set; }
        public string? naziv {  get; set; }
        public Smjer? smjer { get; set; }
        public string? predavac {  get; set; }
        public int? maxmilanoPolaznika { get; set; }

        public Polaznik[]? Polaznici { get; set; }

    }
}
