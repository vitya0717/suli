using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 mátrixban eltárolnak 4 adosavot mátrix mérete(4,2)
            //mátrix felépítése 1oszlop adósáv neve(ABCD)
            //mátrix neve adosavok                  2oszlop % (0%, 10%, 15%, 27%)
            //adatokat bekérni
            //Adósáv neve karakter típusú bekéréskor
            //Adósáv mértéke int tipusú
            //számláló(valamilyen) ciklussal bekerik a 4 adósáv adatait a megadott tipusokkal
            //és eltárolják az AdoSavok mátrixban
            //kontrollált adatbevitellel (try-catch)

            string[,] AdoSavok = new string[2, 4];

            int i = 0;
            int j = 0;
            char bekertSav;
            int bekertAdoErtek;
            int count = 0;

            do
            {
                try
                {
                    Console.Write("Add meg az adósávot: ");
                    bekertSav = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Add meg az adósávhoz a %-ot: ");
                    bekertAdoErtek = int.Parse(Console.ReadLine());

                    AdoSavok[0, i] = bekertSav.ToString();
                    i++;
                    AdoSavok[1, j] = bekertAdoErtek.ToString();
                    j++;
                    count++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (count != 4);


            for (int k = 0; k < AdoSavok.GetLength(0); k++)
            {
                for (int l = 0; l < AdoSavok.GetLength(1); l++)
                {
                    Console.Write(AdoSavok[k, l]+" ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
