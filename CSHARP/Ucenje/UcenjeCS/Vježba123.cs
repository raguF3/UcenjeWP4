using System;
using System.Collections.Generic;
using System.Drawing;
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
            /*
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
            */

            Console.WriteLine("************************");

            {
                int size = 5;
                int[,] table = new int[size, size];
                FillSpiralTable(table, size);
                PrintTable(table, size);
            }

            static void FillSpiralTable(int[,] table, int size)
            {
                int maxNumber = 25;
                int currentNumber = 1;
                int top = 0, bottom = size - 1;
                int left = 0, right = size - 1;

                while (top <= bottom && left <= right)
                {
                    // Popunjavajte gornji red s lijeva na desno
                    for (int i = left; i <= right; i++)
                    {
                        table[top, i] = currentNumber++;
                        if (currentNumber > maxNumber) currentNumber = 1;
                    }
                    top++;

                    // Popunjavajte desni stupac odozgo prema dolje
                    for (int i = top; i <= bottom; i++)
                    {
                        table[i, right] = currentNumber++;
                        if (currentNumber > maxNumber) currentNumber = 1;
                    }
                    right--;

                    // Popunjavajte donji red zdesna nalijevo
                    for (int i = right; i >= left; i--)
                    {
                        table[bottom, i] = currentNumber++;
                        if (currentNumber > maxNumber) currentNumber = 1;
                    }
                    bottom--;

                    // Popunjavajte lijevi stupac odozdo prema gore
                    for (int i = bottom; i >= top; i--)
                    {
                        table[i, left] = currentNumber++;
                        if (currentNumber > maxNumber) currentNumber = 1;
                    }
                    left++;
                }
            }

            static void PrintTable(int[,] table, int size)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(table[i, j].ToString("D2") + " ");
                    }
                    Console.WriteLine();
                }
            }


           


        }
        }


    }




