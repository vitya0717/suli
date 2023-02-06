using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloadas04
{
    internal class Program
    {
        /// <summary>
        /// Téglalap területe
        /// </summary>
        public static void TeglalapTeruleteAdatbekeressel()
        {
            Console.Write("Kérem a téglalap 'a' olalát: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a téglalap 'b' olalát: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A téglalap területe: {getTerulet(a, b)}");
        }

        /// <summary>
        /// Téglalap a és b oldalát tartalmazó param'éter
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void TeglalapTeruleteAdatbekeresNelkul(int a, int b)
        {
            Console.WriteLine($"A téglalap területe: {getTerulet(a, b)}");
        }

        public static int getTerulet(int a, int b)
        {
            return a * b;
        }
        
        static void Main(string[] args)
        {
            
            TeglalapTeruleteAdatbekeressel();
            TeglalapTeruleteAdatbekeresNelkul(8,7);
            Console.ReadKey();
        }
    }
}
