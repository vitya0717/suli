using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szovegesMuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "Viktor";
            int magassag = 190;
            Console.WriteLine($"{nev} {magassag} cm magas.");//komoj
            Console.WriteLine(nev + " " + magassag + " cm magas");//komoj
            Console.WriteLine("{0} {1} cm magas.", nev, magassag);//komoj
            Console.WriteLine(nev[0]);
            Console.WriteLine(nev.Substring(1, 4));
            Console.WriteLine(nev.Substring(5, 1));
            Console.WriteLine(nev.ToUpper());
            Console.WriteLine(nev.ToLower());
            Console.WriteLine(nev.Replace('r', 'R'));
            foreach (char item in nev)
            {
                Console.WriteLine(item);
            }
            string xd = magassag.ToString();
            Console.WriteLine(xd);


            Console.ReadKey();
        }
    }
}
