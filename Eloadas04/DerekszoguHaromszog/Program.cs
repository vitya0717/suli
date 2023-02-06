using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekszoguHaromszog
{
    internal class Program
    {
        /// <summary>
        /// Derékszögű háromszög megállapítása!
        /// </summary>
        public static void getHaromszog()
        {
            Console.Write("Kérem az 'a' oldalt: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Kérem a 'b' oldalt: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Kérem a 'c' oldalt: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine((a * a) + (b * b) == (c * c) ?  "derékszögű":"nem az");

        }
        /// <summary>
        /// Derékszögű háromszög megállapítása paraméterekkel
        /// </summary>
        /// <param name="a">a oldala</param>
        /// <param name="b">b oldala</param>
        /// <param name="c">c oldala</param>
        public static void getHaromszog(double a, double b, double c)
        {

            Console.WriteLine((a * a) + (b * b) == (c * c) ? "derékszögű" : "nem az");

        }

        static void Main(string[] args)
        {
            getHaromszog();
            getHaromszog(3, 4, 5);

            Console.ReadKey();
        }
    }
}
