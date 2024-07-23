using Bogus.Extensions.UnitedKingdom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Subota
{
    internal class Program
    {
        public Program()
        {
            var ime1 = "Ivicaaaaaaaaaaaa";
            var ime2 = "Marica";

            string s = ime1.ToLower() + ime2.ToLower();

            Console.WriteLine(s);

            int[] brojevi = new int[s.Length];



            for (int i = 0; i < s.Length; i++)
            {
                //u = 0;
                //for(int j = 0;j<s.Length;j++) 
                //{
                //    u++;

                //}
                brojevi[i] = s.Count(znak => znak == s[i]);
            }
            Console.WriteLine(string.Join(",", brojevi));

            //Console.WriteLine("{0} i {1} se vole {2}%", ime1, ime2, ljubav(brojevi  ));
            brojevi = srediNiz(brojevi);


            Console.WriteLine(string.Join(" ", brojevi));


        }

        private int ljubav(int[] brojevi)
        {

            if (brojevi.Length < 4)
            {
                var broj = int.Parse(string.Join("", brojevi));

                if (broj <= 100)
                {
                    return broj;

                }
            }

            int[] novi = new int[brojevi.Length % 2 == 0 ? brojevi.Length / 2 : brojevi.Length / 2];
            for (int i = 0; i < brojevi.Length; i++)
            {
                novi[i] = brojevi[i] + brojevi[brojevi.Length - 1 - i];
            }

            brojevi = srediNiz(novi);

            Console.WriteLine(string.Join(",", novi));
            //algoritam zbrajanja
            return ljubav(brojevi);

        }
        private int[] srediNiz(int[] brojevi) 
        {
            var niz = string.Join("", brojevi);
            brojevi = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++)
            {
                brojevi[i] = int.Parse(niz[i].ToString());


            }
            return brojevi;
        }


    }
}
