using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KisebbNagyobb
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

            if(szam > szam2)
            {
                Console.WriteLine("A {0} szám nagyobb", szam);

            } else if(szam2 > szam) {

                Console.WriteLine("A {0} szám nagyobb", szam2);

            } else
            {
                Console.WriteLine("A két szám egyenlő!");
            }


        }
    }
}
