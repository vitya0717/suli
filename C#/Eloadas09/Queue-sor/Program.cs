using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_sor
{
    internal class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            Queue<int> szamok = new Queue<int>();

            for (int i = 0; i < 15; i++)
            {
                szamok.Enqueue(random.Next(1,21));
            }
            Console.WriteLine(szamok.Count);
            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Max: {szamok.Max()}");
            Console.WriteLine($"Min: {szamok.Min()}");

            Console.ReadKey();
        }
    }
}
