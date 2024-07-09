﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzulnaAplikacija
{
    internal class Izbornik
    {
        public ObradaSmjer obradaSmjer { get; set; } = new ObradaSmjer();
        public Izbornik() 
        {
            PozdravnaPoruka();
            PrikaziIzbornik();

        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3.Grupe");
            Console.WriteLine("4.Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
          switch(Pomocno.UcitajRasponBrojeva("Odaberi stavku izbornika",1,4))
            {
                case 1:
                    Console.Clear();
                    obradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                case 4:
                    Console.WriteLine("Hvala na korištenju aplikacije, dovđenja!");
                    break;

            }
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** Edunova Console App v 1.0 ***");
            Console.WriteLine("*********************************");

        }
    }
}
