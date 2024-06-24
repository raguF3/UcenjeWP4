using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        internal static void Izvedi()
        {
            Izvedi(0);
        }

        internal static void Izvedi(int v)
        {
           
            //ispiši 10x osijek
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            Console.WriteLine("*****************");

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Osijek");
            }

            Console.WriteLine("******************");

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*********************");
            int suma = 0;
            for (int i = 0; i<10; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            Console.WriteLine("*********************");
            //ispiši prvih sto brojeva

            int suma1= 0;
            for ( int i = 1; i<=100;i++)
            {
                suma1 += 1;
            }
            Console.WriteLine(suma1);

            Console.WriteLine("*******************");
            //ispiši brojeve od 3 do 29
            //loše rješenje

            for(int i = 4; i<29; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***********************");
            //dobro rješenje
            for(int i = 3; i<29; i++)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
               
                int brojod = 3;
                int brojdo = 29;

                for (int j = brojod; j < brojdo; j++)
                {
                    if (j % 2 ==0)
                    {        
                        Console.WriteLine(j); 
                    }
                    Console.WriteLine("*************************");
                    int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                    for (int k = 0; k < niz.Length; k++)
                    {
                        Console.WriteLine(niz[k]);
                    }


                    Console.WriteLine("*************************");
                    //ispiši sve boje od 20 do 10

                    for (int p =20; p>=10; p--)
                    {
                        Console.WriteLine(p);
                    }

                    Console.WriteLine("*************************");


                    // iapiši sve prim brojeve od 2 do 50
                    int ukupno = 0;
                    bool prim;
                    for (int h = 2; h<1400  ; h++)
                    {
                        prim = true;
                        for (int o =2; o<h; o++)
                        {
                           // Console.WriteLine("{0} % {1} = {2}",h,o,h%o);
                            if(h%o==0)
                            {
                                prim = false; // 2000000 nije prim broj
                                break;
                            }

                        }
                        if(!prim)
                        {
                            ukupno++;
                            //Console.WriteLine("Nepotrebno izvođenje",+ ++ukupno);
                        }
                        if (prim)
                        {
                            Console.WriteLine(h);
                        }


                    }
                    Console.WriteLine("nepottrebno izvodio: " + ukupno);

                    Console.WriteLine("*******************************");
                    


                }
            }
        }
    }
}
