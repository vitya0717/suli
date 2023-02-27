using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtosLotto
{
    internal class Program
    {
        public static Random random = new Random();
        public static void Sorsolas(int[] szamok)
        {

            for (int i = 0; i < szamok.Length;)
            {   
                int num = random.Next(1,91);
                while (szamok.Contains(num))
                {
                    num = random.Next(1, 91);
                }
                szamok[i] = random.Next(1, 91);
                i++;
            }
        }
        public static void KiIras(int[] szamok)
        {
            foreach (int szam in szamok)
            {
                Console.Write(szam + " ");
            }
        }
        static void Main(string[] args)
        {
            /*Feladat: Ötöslottó sorsolás

                Definiáljanak a főprogramban egy 5 elemű egész számokat tartalmazó tömböt GepiSzamok nevvel.
                Hozzanak létre egy eljárást Sorsolas névvel, amely a főprogramban definiált tömböt kapja paraméterkén.
                Ebbe a tömbbe generáljanak 5 különböző számot 1-90-ig
                Hozzanak létre egy KiIras eljaras amely paraméterében a sorsolt számokat tartalmazó tömböt kapja és a képernyőre kiírja a benne lévő elemeket.
                főprogramban:
                Hívják meg a Sorsolás eljárást
                Hívják meg a KiIras eljárást*/
            int[] gepiSzamok = new int[5];
            Sorsolas(gepiSzamok);
            KiIras(gepiSzamok);
            Console.ReadKey();
        }
    }
}
