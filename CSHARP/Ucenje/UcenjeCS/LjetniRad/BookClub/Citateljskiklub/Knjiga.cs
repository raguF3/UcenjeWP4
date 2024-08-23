using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjetniRad.BookClub.Citateljskiklub
{
    internal class Knjiga : Entitet

    {
        public int? sifra { get; set; }
        public string? naziv { get; set; }
        public string? autor { get; set; }
        public DateTime? godina { get; set; }


        public override string ToString()
        {
            return "sifra=" + sifra + " ,naziv=" + naziv + ", autor=" + autor + ", godina=" + godina;

        }
    }
}
