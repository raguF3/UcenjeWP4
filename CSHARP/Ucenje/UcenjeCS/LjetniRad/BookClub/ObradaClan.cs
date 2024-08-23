using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.LjetniRad.BookClub.LjetniRad.BookClub.Citateljskiklub;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class ObradaClan
    {
        public List<Clan> Clanovi { get; set; }


        public ObradaClan()
        {
            Clanovi = new List<Clan>();
        }
    }

   
}
