using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EljarasokIsmetles
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
        public static void compare(string nev1, string nev2)
        {
            int eredmeny = nev1.CompareTo(nev2);
            Console.WriteLine(eredmeny);
            //-1 - nev1 van előrébb
            // 0 - a két név azonos
            //+1 - nev2 van előrébb
        }

        /// <summary>
        /// Teljes név létrehozása
        /// </summary>
        /// <param name="nev1">Vezetéknév</param>
        /// <param name="nev2">Keresztnév</param>
        public static void osszeAdas(string nev1, string nev2)
        {
            string eredmeny = $"{nev1} {nev2}";//konkatenálás
            Console.WriteLine(eredmeny);
        }

        /// <summary>
        /// Betű keresése(index)
        /// </summary>
        /// <param name="text">Szöveg</param>
        /// <param name="keresett">Keresett karakter</param>
        public static void search(string text, char keresett)
        {
            int index = text.IndexOf(keresett);
            Console.WriteLine($"A keresett karakter a(z) {index} index van.");
        }

        /// <summary>
        /// Karakter kiíratás index alapján a kapott szövegből
        /// </summary>
        /// <param name="text">szöveg érték</param>
        /// <param name="index">index érték</param>
        public static void charAt(string text, int index)
        {
            Console.WriteLine(text[index]);
        }

        /// <summary>
        /// Szövegrészlet kiírása
        /// </summary>
        /// <param name="text">Bemeneti szöveg</param>
        /// <param name="startIndex">Kezdő pozíció</param>
        /// <param name="length">Hány betű hosszan</param>
        public static void subWrite(string text, int startIndex, int length)
        {
            if (length == 0)
            {
                Console.WriteLine(text.Substring(startIndex));

            } else
            {
                Console.WriteLine(text.Substring(startIndex, length));
            }
        }

        /// <summary>
        /// Véletlenszám gelerálás
        /// </summary>
        /// <param name="db"></param>
        public static void rand(int db)
        {
            int num = random.Next(101);
            Console.WriteLine(num);
            
        }



        static void Main(string[] args)
        {
            compare("magyar", "magyar");
            osszeAdas("Tóth", "Viktor");
            search("Kiss Gery", 's');
            charAt("Kelemen Ádám", 8);
            subWrite("xdddddd12 hallo", 7, 2);
            subWrite("xdddddd12 hallo", 7, 0);
            rand(100);


            Console.ReadKey();
        }
    }
}
