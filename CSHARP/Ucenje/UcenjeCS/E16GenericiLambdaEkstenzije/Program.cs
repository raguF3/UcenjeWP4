using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS.E16GenericiLambdaEkstenzije
{
    internal class Program
    {

        public Program() 
        {
            // problem nizova - unaprijed moramo znati kolikoo će imati elemenata
            //lista je klasa, generička..lista nije osnovni dio jezika

            //generička lista cijelih brojeva int
            List<int> brojevi = new List<int>();

            brojevi.Add(1);
            brojevi.Add(2);

            Console.WriteLine(brojevi[0]);

            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }

            List<string> imena = new List<string>();

            imena.Add("Pero");
            imena.Add("Marko");

            // functional programing
            imena.ForEach(Console.WriteLine);


            List<Smjer> smjerovi = new List<Smjer>();

            smjerovi.Add(new() { sifra = 1, naziv = "Web programiranje" });

            smjerovi.ForEach(Console.WriteLine);


        }

    }
}
