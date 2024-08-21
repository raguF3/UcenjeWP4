using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.LjetniRad.BookClub
{
    internal class Pomocno
    {
        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {

            int b;

            while(true) 
            {
                try 
                
                {
                    Console.WriteLine(poruka);
                    b=int.Parse(Console.ReadLine());
                    if(b < min || b> max )
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unos mora biti u rasponu {1} do {5}", min, max);
                }
            }

        }
    }
}
