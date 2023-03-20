using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista01
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            List<string> Tanulok = new List<string>() 
            {"Viktor", "Gergő", "Erzsébet", "Judit", "Ádám", "JBalázs", "Dani", "Dominik", "Soma", "LBálint","Máté", "FDani", "VBalázs", "PBálint", "Gyula", "Gergő", "Gergő", "Gergő", "Gergő"};
            List<byte> Jegyek = new List<byte>();

            Tanulok.Remove("Gergő");
            Tanulok.RemoveAll(gergoRemove);
            Tanulok.RemoveAt(5);
            Tanulok.RemoveAt(5);
            Tanulok.Insert(5, "Dominik");

            for (int i = 0; i < Tanulok.Count; i++)
            {
                Jegyek.Add((byte)rnd.Next(1, 6));
                Console.WriteLine($"{Tanulok[i]} - {Jegyek[i]}");
                
            }
            Tanulok.Clear();
            Jegyek.Clear();
            Console.WriteLine($"{Tanulok.Count} - {Jegyek.Count}");

            

            Console.ReadKey();
        }

        private static bool gergoRemove(string v)
        {
            return v.StartsWith("Ger");
        }
    }
}
