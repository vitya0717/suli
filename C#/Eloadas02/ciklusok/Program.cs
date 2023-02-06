using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //számláló ciklus
            /*
             - ismert a futásainak a száma
             - lehet, h egyszer sem fut le
             */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            //elöltesztelő ciklus
            //futtatásainak a száma ismeretlen
            //lehet, hogy egyszer sem fut
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("---------------------");
            //hátul tesztelős ciklus
            //futásainak száma sismeretlen,
            //de egyszer legalább lefut
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;

            } while (k < 10);
            Console.WriteLine("---------------------");
            string szoveg = "Ez itt egy szöveg";
            foreach (var item in szoveg)
            {
                Console.WriteLine(item);
            }
            //for
            Console.WriteLine("---------------------");
            for (int l = 0; l < szoveg.Length; l++)
            {
                Console.WriteLine(szoveg[l]);
            }
            //do while
            Console.WriteLine("---------------------");
            int m = 0;
            do
            {
                Console.WriteLine(szoveg[m]);
                m++;

            } while (m != szoveg.Length);
            //while
            Console.WriteLine("---------------------");
            int n = 0;
            while (n != szoveg.Length)
            {
                Console.WriteLine(szoveg[n]);
                n++;
            }
            Console.WriteLine("---------------------");

            Console.ReadKey();

            Console.Beep();

            
        }
    }
}
