using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzulnaAplikacija.Model
{
    internal class Polaznik: Entitet
    {
        public string? ime { get; set; }
        public string? prezime { get; set; }
        public string? OIB { get; set; }
        public string? Email { get; set; }
    }
}

