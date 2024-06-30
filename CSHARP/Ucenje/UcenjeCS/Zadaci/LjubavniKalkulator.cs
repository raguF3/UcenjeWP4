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

            Console.Write("Unesi ime simpatije:");
            string imeSimpatije = Console.ReadLine().ToUpper();

            string kombiniranaImena = tvojeIme + imeSimpatije;



            List<int> brojevi = BrojPonovljenihSlova(kombiniranaImena);

            

            while (brojevi.Count > 2)
            {
                brojevi = ZbrojiSusjedneBrojeve(brojevi);
                
            }

            int postotakLjubavi = brojevi[0] * 10 + brojevi[1];
            Console.WriteLine($"Postotak ljubavi između {tvojeIme} i {imeSimpatije} je {postotakLjubavi}%.");
        }

       
        }
    }









