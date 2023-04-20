using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StarWars2
{
    internal class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Rend rend = new Rend(100, 20);
            foreach (var item in rend.erohasznalok)
            {
                Console.WriteLine(item);
                
            }
            

            Console.WriteLine("Tanácstagok száma: {0}", rend.Tanacstagok());
           

            Console.ReadKey();
        }
    }
}
