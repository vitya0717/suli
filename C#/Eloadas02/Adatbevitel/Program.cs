using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbevitel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Add meg a neved testrész: "); 
            string nev = Console.ReadLine();
            Console.WriteLine("A megadott név: {0}",nev);
            Console.WriteLine();
            Console.Write("Hány éves vagy? ");
            string input = Console.ReadLine();
            int eletkor;
            while(!int.TryParse(input, out eletkor))
            {
                Console.Write("\nSzámot adj meg! ");
                input = Console.ReadLine();
            }
            Console.WriteLine("A megadott életkor: {0}",eletkor);

            Console.Write("\nFélévi átlagod: ");
            double atlag = double.Parse(Console.ReadLine());
            Console.WriteLine("A félévi átlagod: {0}", atlag);

            Console.Write("\n2. félévet megkezdhetem: (true/false)");
            bool xd = bool.Parse(Console.ReadLine());
            Console.WriteLine(xd ? "ügyes vagy" : "béna");

            Console.Write("\nSzereted a túróstésztát (i/n)?: ");
            char turos = char.Parse(Console.ReadLine());
            if (turos == 'i')
            {
                int teszta = 20;//20kg
                Console.WriteLine("A tészta súlya: {0}kg",teszta);
            }
            

            Console.ReadKey();
        }
    }
}
