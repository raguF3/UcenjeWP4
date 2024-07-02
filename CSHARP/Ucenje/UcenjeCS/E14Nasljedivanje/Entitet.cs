using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{   //apstraktn klasa je ona klasa koja nemm aimplementaciju
    //kreira se kako bi sadržavala zajednička svojsjtva i metode
    internal abstract class Entitet: Object // sve klase, htjele ili ne nasljeđuju klasu object
    {
        public int? sifra {  get; set; }

        protected int VidiSeUPodKlasi = 7;

        private int VidiSeSamoUKlasiUKojojJeDefinirano = 2;

        public override string ToString()
        {
            Console.WriteLine( VidiSeSamoUKlasiUKojojJeDefinirano);
            return sifra.ToString();
        }
    }
}
