using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EljarasKorTerulete
{
    internal class Program
    {

        /// <summary>
        /// A kör sugarát kell itt megadni.
        /// </summary>
        ///
        public static void getKorTerulet()
        {
            Console.Write("Kérem a kör sugarát: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"A kör területe: {Math.Round((r * r) * Math.PI, 2)}");

        }

        /// <summary>
        /// Itt adjuk meg a kör sugarát paraméternek, h kiszámoljuk a csicska területét.
        /// </summary>
        /// <param name="r"></param>
        public static void getKorTerulet(int r)
        {
        
            Console.WriteLine($"A kör területe: {Math.Round((r * r) * Math.PI, 2)}");

        }

        static void Main(string[] args)
        {
            getKorTerulet();
            getKorTerulet(4);
            
            Console.ReadKey();
        }
    }
}
