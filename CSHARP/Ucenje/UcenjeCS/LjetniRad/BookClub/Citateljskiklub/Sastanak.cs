﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjetniRad.BookClub.Citateljskiklub
{
    internal class Sastanak: Entitet
    {
        public int? sifra {  get; set; }
        public DateTime? datum { get; set; }
        public int? knjiga { get; set; }
        public string? mjesto { get; set; }


        public override string ToString()
        {
            return "sifra=" + sifra + " ,datum=" + datum + ", knjiga=" + knjiga + ", mjesto=" + mjesto;

        }

    }
}
