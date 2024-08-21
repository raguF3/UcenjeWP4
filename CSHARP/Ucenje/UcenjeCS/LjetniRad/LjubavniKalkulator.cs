using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Zadaci
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {


            Console.Write("Unesi svoje ime:");
            string tvojeIme = Console.ReadLine().ToUpper();

            Console.Write("Unesi ime svoje simpatije:");
            string simpatijaIme = Console.ReadLine().ToUpper();

            string kombiniranaImena = tvojeIme + simpatijaIme;

            List<int> brojevi = new List<int>();
            foreach (char c in kombiniranaImena)
            {
                brojevi.Add(BrojPonavljanja(c, kombiniranaImena));
            }

            Console.WriteLine("Izračun: ");
            IspisiBrojeve(brojevi);

            brojevi = ZbrajajBrojeve(brojevi);

            int postotakLjubavi = brojevi[0] * 10 + brojevi[1];
            Console.WriteLine($"Postotak ljubavi između {tvojeIme} i {simpatijaIme} je: {postotakLjubavi}%");
        }

        static int BrojPonavljanja(char slovo, string tekst)
        {
            int count = 0;
            foreach (char c in tekst)
            {
                if (c == slovo) count++;
            }
            return count;
        }

        static List<int> ZbrajajBrojeve(List<int> brojevi)
        {
            if (brojevi.Count <= 2)
            {
                return brojevi;
            }

            List<int> noviBrojevi = new List<int>();
            for (int i = 0; i < brojevi.Count / 2; i++)
            {
                int zbroj = brojevi[i] + brojevi[brojevi.Count - 1 - i];
                noviBrojevi.Add(zbroj % 10);
            }

            
            if (brojevi.Count % 2 != 0)
            {
                noviBrojevi.Add(brojevi[brojevi.Count / 2]);
            }

            IspisiBrojeve(noviBrojevi);

            return ZbrajajBrojeve(noviBrojevi);
        }

        static void IspisiBrojeve(List<int> brojevi)
        {
            Console.WriteLine(string.Join(",", brojevi));
        }
    }
}









