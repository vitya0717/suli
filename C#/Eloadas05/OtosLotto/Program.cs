using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtosLotto
{
    internal class Program
    {
        public static Random r = new Random();
        static void Main(string[] args)
        {
            int db = 0;
            int sorsolasok = 0;
            do
            {
                db = 0;
                int sajatSzam1 = 14;
                int sajatSzam2 = 29;
                int sajatSzam3 = 37;
                int sajatSzam4 = 43;
                int sajatSzam5 = 52;
                string sajat = $"{sajatSzam1},{sajatSzam2},{sajatSzam3},{sajatSzam4},{sajatSzam5}";
                int gepiSzam1 = r.Next(90) + 1;
                int gepiSzam2 = r.Next(90) + 1;
                int gepiSzam3 = r.Next(90) + 1;
                int gepiSzam4 = r.Next(90) + 1;
                int gepiSzam5 = r.Next(90) + 1;
                string gep = $"{gepiSzam1},{gepiSzam2},{gepiSzam3},{gepiSzam4},{gepiSzam5}";

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (sajat.Split(',')[i] == gep.Split(',')[j])
                        {
                            db++;
                        }
                    }
                }
                if (db == 5)
                {
                    Console.WriteLine($"{sajatSzam1},{sajatSzam2},{sajatSzam3},{sajatSzam4},{sajatSzam5}");
                    Console.WriteLine($"{gepiSzam1},{gepiSzam2},{gepiSzam3},{gepiSzam4},{gepiSzam5}");
                    Console.WriteLine($"Találatok száma {db}");
                    Console.WriteLine($"Találatok száma {sorsolasok}");
                }
                sorsolasok++;

            } while (db != 5);

                
         
            //Console.WriteLine(((decimal)90*89*88*87*86)/(1*2*3*4*5));

     


            Console.ReadKey();

        }
    }
}
