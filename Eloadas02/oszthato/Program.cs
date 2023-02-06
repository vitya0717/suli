using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az első számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Kérem a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            if (szam == szam2)
            {
                Console.WriteLine("A két szám egyenlő!");
            }
            else if (szam % szam2 == 0)
            {
                Console.WriteLine("A második szám osztója a elsőnek!");

            }
            else if (szam2 % szam == 0)
            {
                Console.WriteLine("Az első szám osztója a másodiknak!");
            }
            else
            {
                Console.WriteLine("Egyik sem osztója a másiknak!");
            }
            
        }
    }
}
