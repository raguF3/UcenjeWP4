using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15RadSStringovima
{
    internal class Program
    {
        //konstruktor

        public Program()
        {

            //string je immuttable - nepromjenjiv
            var s = "Edunova";
            Console.WriteLine(s.GetHashCode());
            s = "Osijek";

            Console.WriteLine(s.GetHashCode());

            var sb = new StringBuilder();
            
            sb.AppendLine("Edunova");
            Console.WriteLine(sb.GetHashCode());


            sb.Clear();

            sb.AppendLine("Osijek");
            Console.WriteLine(sb.GetHashCode());

            s = "a";
            s += " b";
            s += "c";

            Console.WriteLine(s);
            // u radu s stringovimma se preporuča koristiti StringBuilder Klasu

            sb = new StringBuilder();
            sb.Append('a');
            sb.Append("b");
            sb.Append('c');

            Console.WriteLine(sb);

            //var ce = s.GetEnumerator();
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());

            s = "Osijek";
            Console.WriteLine(s.Substring(1));
            Console.WriteLine(s.Substring(1,2));

            s = "    Ana Marija ";
            Console.WriteLine(">{0}<",s);
            Console.WriteLine(">{0}<",s.Trim());



            Console.WriteLine(s.Replace('a','b'));

            //veliko A i malo a  zamjenjeno na malo b
            Console.WriteLine(s.Replace("a","b", true,CultureInfo.CurrentCulture));

            


        }

    }
}
