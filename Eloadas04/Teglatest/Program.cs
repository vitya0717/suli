using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teglatest
{
    
    internal class Program
    {
        /// <summary>
        /// Téglatest felületének kiszámítása paraméterek nélkül
        /// </summary>
        public static void getTeglatestF()
        {
            Console.Write("Kérem az 'a' oldalát: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem az 'b' oldalát: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Kérem az 'c' oldalát: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"A téglatest felszine: {(a*b+a*c+b*c)*2}");
        }
        /// <summary>
        /// Téglatest felületének kiszámítása paraméterek nélkül
        /// </summary>
        /// <param name="a">a oldal</param>
        /// <param name="b">b oldal</param>
        /// <param name="c">c oldal</param>
        public static void getTeglatestF(int a, int b, int c)
        {
            Console.WriteLine($"A téglatest felszine: {(a * b + a * c + b * c) * 2}");
        }


        static void Main(string[] args)
        {
            getTeglatestF();
            getTeglatestF(10,10,10);

            Console.ReadKey();
        }
    }
}
