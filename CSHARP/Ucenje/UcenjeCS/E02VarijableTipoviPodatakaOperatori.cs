

using System.Xml.Schema;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        // formatiranje koda CTRL + K + D

        public static void Izvedi()
        {

            int broj;

            broj = 7;

            Console.WriteLine("Unesi broj: ");
            broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj + 1);

            Console.WriteLine("Unesi decimalni broj: ");
            decimal db = decimal.Parse(Console.ReadLine());

            Console.WriteLine(db / 10);

            int modulo = 4 % 2;
            Console.WriteLine(modulo);

            int i = 5;
            int j = 3;

            Console.WriteLine(i / (float)j);

            bool logickaVrijednost = true;

            Console.WriteLine(i == j);

            int k = 5, l = 3;

            var ime = "Edunova";


            int b = 0;

            b = b + 1; //1
            b += 1; //2
            b++; //3
            ++b; //4

            Console.WriteLine(++b); //5
            Console.WriteLine(b++); //5
            Console.WriteLine(b); //6

            int x = 1, y= 2;
            Console.WriteLine("------------------");
            
            x = ++y; //x =3, y = 3
            //7Console.WriteLine(x);
            //Console.WriteLine(y);
            Console.WriteLine("x={0}, y={1}", x,y);
            Console.WriteLine("******************");

            y = x - --y; //3-2, y=1, x=3
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("*******************");

            Console.WriteLine(x+y); //4





        }

    }
}
