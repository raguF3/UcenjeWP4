using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Vježba123
    {
        public static void Izvedi()
        {
            //kalkulator
            
            Console.WriteLine("Unesite prvi broj:");
            double broj1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            double broj2 = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Unesite operaciju (+, -, *, /):");
            char operacija = Console.ReadLine()[0];

            
            switch (operacija)
            {
                case '+':
                    Console.WriteLine("Rezultat: " + (broj1 + broj2));
                    break;
                case '-':
                    Console.WriteLine("Rezultat: " + (broj1 - broj2));
                    break;
                case '*':
                    Console.WriteLine("Rezultat: " + (broj1 * broj2));
                    break;
                case '/':
                    if (broj2 != 0)
                    {
                        Console.WriteLine("Rezultat: " + (broj1 / broj2));
                    }
                    else
                    {
                        Console.WriteLine("Greška: Dijeljenje sa nulom nije dozvoljeno.");
                    }
                    break;
                default:
                    Console.WriteLine("Greška: Operacija nije moguća.");
                    break;



            }
            //kalkulator tjelesne mase (BMI)
            // Tražimo od korisnika da unese težinu i visinu
           

           
                double tezina, visina;

                // Unos težine
                Console.WriteLine("Unesite težinu (kg):");
                if (!double.TryParse(Console.ReadLine(), out tezina) || tezina <= 0)
                {
                    Console.WriteLine("Nevažeći unos za težinu.");
                    return;
                }

                // Unos visine
                Console.WriteLine("Unesite visinu (m):");
                if (!double.TryParse(Console.ReadLine(), out visina) || visina <= 0)
                {
                    Console.WriteLine("Nevažeći unos za visinu.");
                    return;
                }

                // Izračun BMI
                double bmi = tezina / (visina * visina);

                // Ispis rezultata na osnovu BMI kategorije
                if (bmi < 18.5)
                {
                    Console.WriteLine($"BMI je {bmi:F2}. Nedovoljna težina.");
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    Console.WriteLine($"BMI je {bmi:F2}. Normalna težina.");
                }
                else if (bmi >= 25 && bmi <= 29.9)
                {
                    Console.WriteLine($"BMI je {bmi:F2}. Prekomjerna težina.");
                }
                else // bmi >= 30
                {
                    Console.WriteLine($"BMI je {bmi:F2}. Pretilost.");
                }


            // upisati pozdrav

            Console.WriteLine("Upiši svoje ime: ");
            string ime= Console.ReadLine();

            Console.WriteLine($"Pozdrav, {ime}");



            //računjanje zbroja i prosjek brojeva


            Console.WriteLine("Unesi prvi broj: ");
            int b1;
            b1=int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj: ");
            int b2;
            b2=int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi treći broj: ");
            int b3;
            b3=int.Parse(Console.ReadLine());

            //Console.WriteLine(b1+b2+b3);
            double zbroj = b1 + b2 + b3;
            double prosjek = zbroj / 3;

            Console.WriteLine($"Zbroj brojeva je {zbroj}");
            Console.WriteLine($"Prosjek brojeva je {prosjek}");



        }
        }


    }




