using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{

    internal class Program
    {
        /// <summary>
        /// A kör kerülete
        /// </summary>
        /// <param name="d">átmérő</param>
        /// <returns></returns>
        public static double korKerulet(int d)
        {
            return d * Math.PI;
        }

        /// <summary>
        /// A kör területe
        /// </summary>
        /// <param name="d">átmérő</param>
        /// <returns></returns>
        public static double korTerulet(double d)
        {
            return Math.Pow(d/2, 2)*Math.PI;
        }

        static void Main(string[] args)
        {
            Console.Write("Add meg a kör átmérőjét: ");
            int atmero = int.Parse(Console.ReadLine());
            Console.WriteLine($"A kör kerülete: {korKerulet(atmero)}");
            Console.WriteLine($"A kör területe: {korTerulet(atmero)}");

            Console.ReadKey();
        }
    }
}
