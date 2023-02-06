using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuggvenyekIsmetles
{
    internal class Program
    {
        /// <summary>
        /// random osztály példányosítás!!!Elég egy a programba!!!
        /// </summary>
        public static Random random = new Random();

        /// <summary>
        /// Két string összehasonlítása
        /// </summary>
        /// <param name="nev1">első név</param>
        /// <param name="nev2">második név</param>
        public static int compare(string nev1, string nev2)
        {
            int eredmeny = nev1.CompareTo(nev2);
            //-1 - nev1 van előrébb
            // 0 - a két név azonos
            //+1 - nev2 van előrébb
            return eredmeny;
        }

        /// <summary>
        /// Teljes név létrehozása
        /// </summary>
        /// <param name="nev1">Vezetéknév</param>
        /// <param name="nev2">Keresztnév</param>
        public static string osszeAdas(string nev1, string nev2)
        {
            string eredmeny = $"{nev1} {nev2}";//konkatenálás
            return eredmeny;
        }

        /// <summary>
        /// Betű keresése(index)
        /// </summary>
        /// <param name="text">Szöveg</param>
        /// <param name="keresett">Keresett karakter</param>
        public static int search(string text, char keresett)
        {
            int index = text.IndexOf(keresett);
            return index;
        }

        /// <summary>
        /// Karakter kiíratás index alapján a kapott szövegből
        /// </summary>
        /// <param name="text">szöveg érték</param>
        /// <param name="index">index érték</param>
        public static char charAt(string text, int index)
        {
            return text[index];
        }

        /// <summary>
        /// Szövegrészlet kiírása
        /// </summary>
        /// <param name="text">Bemeneti szöveg</param>
        /// <param name="startIndex">Kezdő pozíció</param>
        /// <param name="length">Hány betű hosszan</param>
        public static string subWrite(string text, int startIndex, int length)
        {
            if (length == 0)
            {
                return text.Substring(startIndex);

            }
            else
            {
                return text.Substring(startIndex, length);
            }
        }

        /// <summary>
        /// Véletlenszám gelerálás
        /// </summary>
        /// <param name="db"></param>
        public static int rand(int db)
        {
            int num = random.Next(db);
            return num;

        }
        static void Main(string[] args)
        {
            int f1 = compare("magyar", "magyar");
            Console.WriteLine(f1);
            string f2 = osszeAdas("Tóth", "Viktor");
            Console.WriteLine(f2);
            int f3 = search("Kiss Gery", 's');
            Console.WriteLine(f3);
            char f4 = charAt("Kelemen Ádám", 8);
            Console.WriteLine(f4);
            string f5 = subWrite("xdddddd12 hallo", 7, 2);
            Console.WriteLine(f5);
            string f6 = subWrite("xdddddd12 hallo", 7, 0);
            Console.WriteLine(f6);
            int f7 = rand(100);
            Console.WriteLine(f7);

            Console.ReadKey();
        }
    }
}
