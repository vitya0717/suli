using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Hozzanak létre egy programot amely bekéri a menüpontot (1 karakter) addig amíg "k" betűt nem nyomunk.
            a-téglalap kerülete a és b oldalt kérjék be
            b-téglalap területe a és b oldalt kérjék be
            c-kör kerülete az átmérőt kérjék be
            d-kör területe a sugarat kérjék be
            k-kilépés
         */
            bool exit = true;
            while (exit)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.Write("Add meg a téglalap a oldalát: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Add meg a téglalap b oldalát: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(2 * (a + b));
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        Console.Write("Add meg a téglalap a oldalát: ");
                        int a2 = int.Parse(Console.ReadLine());
                        Console.Write("Add meg a téglalap b oldalát: ");
                        int b2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(a2 * b2);
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.Write("Add meg az átmérőt: ");
                        int c = 2 ^ int.Parse(Console.ReadLine());
                        Console.WriteLine(c * Math.PI);
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.Write("Add meg a kör sugarát: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.WriteLine(2 * r * Math.PI);
                        break;
                    case ConsoleKey.K:
                        Console.Clear();
                        Console.WriteLine("Kilépés.....");
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Hibás menüpont");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
