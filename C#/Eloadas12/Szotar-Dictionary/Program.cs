using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szotar_Dictionary
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<string> Tanulok = new List<string>()
            {"Viktor", "Gergő", "Erzsébet", "Judit", "Ádám", "JBalázs", "Dani", "Dominik", "Soma", "LBálint","Máté", "FDani", "VBalázs", "PBálint", "Gyula"};

            Dictionary<string, double> feleviErtekeles = new Dictionary<string, double>();
            int[,] jegyek = new int[Tanulok.Count, 5];

            double atlag = 0;
            int count = 0;
            foreach (var tanulo in Tanulok)
            {
                for (int i = 0; i < jegyek.GetLength(0); i++)
                {
                    for (int j = 0; j < jegyek.GetLength(1); j++)
                    {
                        jegyek[i, j] = rnd.Next(0, 6);
                        atlag += jegyek[i, j];
                        if (jegyek[i, j] > 0)
                        {
                            count++;
                        }
                    }
                    if (!feleviErtekeles.ContainsKey(tanulo))
                    {
                        feleviErtekeles.Add(tanulo, Math.Ceiling(atlag / count));
                    }
                    atlag = 0;
                    count = 0;
                }
            }

            foreach (var item in feleviErtekeles)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }



            Console.ReadKey();
        }
    }
}
