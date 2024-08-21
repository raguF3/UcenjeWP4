using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjetniRad.BookClub.Citateljskiklub
{
    internal class Sastanci: Entitet
    {
        public int? sifra {  get; set; }
        public DateTime? datum { get; set; }
        public int? knjiga { get; set; }
        public string? mjesto { get; set; }


    }
}
