using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombEljaras
{
    internal class Program
    {
        public static void adatokKiirasa(string[] _1darray)
        {
            foreach (var item in _1darray)
            {
                Console.WriteLine(item);
            }
        }
        public static void removeValue(string[] _1darray)
        {
            for (int i = 0; i < _1darray.Length; i++)
            {
                if (_1darray[i].StartsWith("m"))
                {
                    _1darray[i] = "";
                }
            }
            adatokKiirasa(_1darray);
        }
        static void Main(string[] args)
        {
            string[] allatok = new string[6] { "macska", "kutya", "zebra", "tigris", "róka", "farkas" };
            string[] novenyek = new string[7] { "fű", "pipacs", "fikusz", "napraforgó", "marihujána", "repce", "tulipán" };
            string[] disznovenyek = novenyek;
            adatokKiirasa(disznovenyek);
            Console.WriteLine();
            removeValue(novenyek);
            Console.WriteLine();

            
            Console.ReadKey();
        }
    }
}
