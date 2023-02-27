using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtosLottoHalmazzal
{
    internal class Program
    {
        public static Random random = new Random();
        public static void Sorsolas(HashSet<int> szamok)
        {

            for (int i = 0; i < 5; i++)
            {
                szamok.Add(random.Next(1,91));
            }
        }
        public static void KiIras(HashSet<int> szamok)
        {
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok.ToArray()[i]);
                Console.WriteLine(szamok.ElementAt(i));
            }
        }

        static void Main(string[] args)
        {
            HashSet<int> gepiSzamok = new HashSet<int>();
            
            Sorsolas(gepiSzamok);
            KiIras(gepiSzamok);

            Console.ReadKey();
        }
    }
}
