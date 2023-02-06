using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeglalapFuggveny
{
    internal class Program
    {
        /// <summary>
        /// Téglalap területének kiszámítása
        /// </summary>
        /// <param name="a">a oldal</param>
        /// <param name="b">b oldal</param>
        /// <returns>A téglalap területe</returns>
        public static int getTeglalapTerulet(int a, int b)
        {
            
            return a * b;
        }
        /// <summary>
        /// Téglalap kerületének kiszámítása
        /// </summary>
        /// <param name="a">a oldal</param>
        /// <param name="b">b oldal</param>
        /// <returns>A téglalap kerület</returns>
        public static int getTeglalapKerulet(int a, int b)
        {
            return 2*a+2*b;
        }
        public static double getTeglalapAtlo(int a, int b)
        {
            return Math.Sqrt(a*a+b*b);
        }
        static void Main(string[] args)
        {
            Console.Write("Kérem a téglalap 'a' olalát: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a téglalap 'b' olalát: ");
            int b = int.Parse(Console.ReadLine());
            int terulet = getTeglalapTerulet(a, b);
            Console.WriteLine($"A téglalap területe: {terulet}");
            int kerulet = getTeglalapKerulet(a, b);
            Console.WriteLine($"A téglalap kerülete: {kerulet}");
            double atlo = getTeglalapAtlo(a, b);
            Console.WriteLine($"A téglalap kerülete: {atlo}");

            Console.ReadKey();
        }
    }
}
