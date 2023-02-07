using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KarakterGeneralas
{
    internal class Program
    {
        public static Random r = new Random();

        public static string nagyobb(string szoveg1, string szoveg2)
        {
            int ered = szoveg1.CompareTo(szoveg2);

            string output = "";

            if (ered == 1)
            {
                output = $"A {szoveg1} a nagyobb!";
            }
            else if (ered == 0)
            {
                output = $"A két szöveg egyenlő!";
            }
            else
            {
                output = $"A {szoveg2} a nagyobb!";
            }

            return output;
        }

        static void Main(string[] args)
        {
            /*Készítsenek egy programot amely két sztringet hoz létre véletlenszám generálással.

                szoveg1 nevű változó 5 db 100-300 intervallumból előállított véletlenszámból tevődik össze.
                szoveg2 nevű változó 3 db 12213-34217 intervallumból előállított véletlenszámból tevődik össze.
                A képernyőre írják ki a nagyobb szoveget!

            */
            string szoveg1 = "";
            string szoveg2 = "";

            for (int i = 0; i < 5; i++)
            {
                szoveg1 += r.Next(100, 300);
            }
            for (int j = 0; j < 3; j++)
            {
                szoveg2 += r.Next(12213, 34217);
            }
            Console.WriteLine($"szoveg1: {szoveg1}");
            Console.WriteLine($"szoveg2: {szoveg2}");

            Console.WriteLine(nagyobb(szoveg1, szoveg2));



            Console.ReadKey();

        }
    }
}
