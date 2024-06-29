﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10TryCatch
    {
        public static void Izvedi()
        {

            int i;

            while (true)
            {
                Console.WriteLine("Unesi cijeli pozitivni broj: ");
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i > 0 && i < 100)
                    {
                        break;

                    }
                    Console.WriteLine("Uneseni broj nije veći od 0 i manji od 100: ");
                }
                catch (Exception ex)

                {
                    Console.WriteLine("Niste unijeli cijeli pozitivan broj: ");
                }

            }
            Console.WriteLine("Unijeli ste broj: "+i); //ovdje si sto posto siguran da imaš cijeli broj


        }
    }
}
