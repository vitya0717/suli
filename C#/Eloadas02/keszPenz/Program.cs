using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keszPenz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A kerekített összeg 5 vagy 10 Ft-tal osztható.
             Ha az összeg 1 vagy 2 Ft-ra végződő, akkor lefelé kerekítjük (pl. 32 Ft helyett 30 Ft lesz).
             Ha az összeg 3 vagy 4 Ft-ra végződő, akkor 5-ösre kerekítjük (pl. 43 Ft helyett 45 Ft lesz).
             Ha az összeg 6 vagy 7 Ft-ra végződő, akkor lefelé kerekítjük 5-ösre (76 Ft helyett 75 Ft lesz).
             Ha az összeg 8 vagy 9 Ft-ra végződő, akkor felfelé kerekítjük (pl. 38 Ft helyett 40 Ft lesz).
             Ha az összeg 0 vagy 5 Ft-ra végződő, akkor nem kell kerekíteni.*/

            Console.Write("Kérem, adjon meg egy 10 és 90 Ft közötti összeget: ");

            string pez = Console.ReadLine();

            if (pez.EndsWith("1") || pez.EndsWith("2"))
            {
                pez = pez.Replace(pez[1], '0');
            }
            else if (pez.EndsWith("3") || pez.EndsWith("4"))
            {
                pez = pez.Replace(pez[1], '5');
            }
            else if (pez.EndsWith("6") || pez.EndsWith("7"))
            {
                pez = pez.Replace(pez[1], '5');
            }
            else if (pez.EndsWith("8") || pez.EndsWith("9"))
            {
                pez = int.Parse(pez[0].ToString()) + 1 + "0";
            }

            Console.WriteLine("Készpénzben ez az összeg: {0} Ft", pez);


            Console.ReadKey();
        }
    }
}
