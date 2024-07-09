using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzulnaAplikacija.Model
{
    internal class Grupa: Entitet
    {

        public string? naziv { get; set; }
        public Smjer? Smjer { get; set; }
        public string? Predavac { get; set; }
        public int? MaximalnoPolaznika { get; set; }

        public List<Polaznik>? Polaznici { get; set; }

    }
}
