using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseXD
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
                Console.Write("Adj meg egy számot: ");
                adatMegadasSikeres = int.TryParse(Console.ReadLine(), out bekertSzam);

            } while (!adatMegadasSikeres);
            
            Console.WriteLine($"A bekért szám: {bekertSzam}");

               
            
            

            Console.ReadKey();
        }
    }
}
