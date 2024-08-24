using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.LjetniRad.BookClub.Citateljskiklub;

namespace UcenjeCS.LjetniRad.BookClub.LjetniRad.BookClub.Citateljskiklub
{
    internal class Clan: Entitet
    {
        public int? sifra {  get; set; }
        public string? ime {  get; set; }
        public string? prezime { get; set; }
        public string? Email {  get; set; }
        public int? lozinka { get; set; }
       
    }
}
