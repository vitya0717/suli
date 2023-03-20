using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryKeccs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bekertSzam;
            //bekertSzam = int.Parse(Console.ReadLine());
            bool adatMegadasSikeres = false;
            do
            {
                try
                {
                    Console.Write("Adj meg egy számot: ");
                    bekertSzam = int.Parse(Console.ReadLine());
                    adatMegadasSikeres = true;
                }
                catch (Exception e)
                {   
                    Console.WriteLine(e.Message);
                   bekertSzam=0;
                }
                finally
                {
                    Console.WriteLine("Lefutott a progi");
                }
               

            } while (!adatMegadasSikeres);

            Console.WriteLine($"A bekért szám: {bekertSzam}");

            Console.ReadKey();
        }
    }
}
