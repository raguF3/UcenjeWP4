
namespace UcenjeCS
{
    internal class E01Z2
    {

        public static void Izvedi()
        {
            // korisnik će unijeti dvoznamenkasti broj od 10-99
            //za uneseni parni broj upisati true za nepaarni upisali false
            // ispisuje se prva znamenka
            // 56=>5, 87=>8

            int broj;
         

            Console.WriteLine("unesi dvoznamenkasti broj od 10 d0 99: ");
            broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj / 10);

            bool paran = broj % 2 == 0;
            if (paran)
            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);
            }

            








        }


    }
}
