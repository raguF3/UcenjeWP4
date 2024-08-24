using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjetniRad.BookClub.Citateljskiklub
{
    internal class Dolazak: Entitet
    {
        public DateTime? sastanak {  get; set; }
        public int? clan {  get; set; }
      


        public override string ToString()
        {
            return "sastanak=" + sastanak + " ,clan =" + clan;

        }
    }
}
