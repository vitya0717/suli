using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelkezeles
{
    internal class Program
    {

        public static int result; 
        public static void doWhile()
        {   
            do
            {
                Console.Write("Adj meg egy számot: ");

            } while (!int.TryParse(Console.ReadLine(), out result)); 
            Console.WriteLine(result);
        }

        public static void While()
        {
            Console.Write("Adj meg egy számot: ");            
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Adj meg egy számot: ");
            }
            Console.WriteLine(result);
        }

        public static void Eletkor()
        {
            int eletkor = 18;
            bool vane = false;
            byte darab = 0;
            while (!vane)
            {
                try
                {
                    Console.Write("Kérem az életkorát: ");
                    eletkor = int.Parse(Console.ReadLine());
                    vane = true;

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    darab++;
                }
                catch (OverflowException e)
                {
                    darab++;
                    Console.WriteLine(e.Message);

                }
                finally
                {
                    Console.WriteLine($"Elcseszések száma: {darab}");
                }
            }
            Console.WriteLine(eletkor);
        }

        static void Main(string[] args)
        {

            While();
            doWhile();
            Eletkor();




            Console.ReadKey();
        }
    }
}
