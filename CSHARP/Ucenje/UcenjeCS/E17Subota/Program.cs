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
            var ime1 = "Ivica";
            var ime2 = "Marica";

            string s = ime1[0].ToString();
            char c = ime1[0];

            Console.WriteLine(s);

            s = ime1.ToLower() + ime2.ToLower();
            Console.WriteLine(s);

            int[] brojevi = new int[s.Length];
            //ivicamarica
            int u;
            for (int i = 0; i < s.Length; i++)
            {
                /*  u = 0;
                  for (int j = 0; j < s.Length; j++)
                  {
                      if (s[i] == s[j])
                      {
                          u++;
                      }
                  }
                  brojevi[i] = u;
                */
                brojevi[i] = s.Count(znak=> znak == s[i]);
                brojevi = srediniz(brojevi);

            }
            Console.WriteLine(string.Join(",", brojevi));
           // Console.WriteLine("{0} i {1} se vole {2} %", ime1, ime2, ljubav(brojevi));


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
            int[] novi = new int[brojevi.Length%2==0? brojevi.Length/2 : brojevi.Length/2+1];
            for (int i = 0; i < brojevi.Length; i++)
            {
                novi[i] = brojevi[i] + brojevi[brojevi.Length - 1-i];
            }
            Console.WriteLine(string.Join(",", novi));
            return ljubav(novi);
        }
        private int[] srediniz(int[] brojevi)
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
