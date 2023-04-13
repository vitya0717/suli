using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitestek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bolygo foldHoldja = new Bolygo();
            foldHoldja.Nev = "Hold";
            foldHoldja.BolygoType = BolygoType.Törpebolygó;
            foldHoldja.Gravitacio = 1.625;
            foldHoldja.Atmero = 3474;
            //foldHoldja.HoldjainakSzama = 0;
            foldHoldja.Atmoszfera = "He, Ne, H, Ar, CH4";

            Bolygo fold = new Bolygo();
            fold.Nev = "Föld";
            fold.BolygoType = BolygoType.Kőzetbolygó;
            fold.Gravitacio = 9.807;
            fold.Atmero = 12742;
            fold.Atmoszfera = "N2,O2";
            fold.HoldjainakSzama = 1;
            //fold.Holdak.Add(foldHoldja);
            fold.Holdak.Add(foldHoldja);


            Bolygo pluto = new Bolygo("Plútó", BolygoType.Törpebolygó, 0.62, 2376.6, "N");
            Console.WriteLine(pluto);
            Console.WriteLine();
            Console.WriteLine(fold);
            Console.WriteLine();

            BarnaTorpe barna = new BarnaTorpe();
            barna.Nev = "Gliese 229B";
            barna.Fenyesseg = Math.Pow(10, -4);
            barna.Homerseklet = 1800;
            barna.Tomeg = 0.3;

            Console.WriteLine(barna);
           
            Console.ReadKey();
        }
    }
}
