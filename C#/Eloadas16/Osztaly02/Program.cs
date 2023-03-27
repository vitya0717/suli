using Osztaly01;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<KekturaAllomas> allomasok = new List<KekturaAllomas>();
            try
            {
                string[] sorok = File.ReadAllLines("kektura.csv");
                for (int i = 1; i < sorok.Length; i++) { allomasok.Add(new KekturaAllomas(sorok[i])); }
                foreach (var item in allomasok)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }*/

            KekturaAllomas bekertAllomas;
            string indulo_allomas = "";
            string cel_allomas = "";
            double tura_hossza = 0;
            int emelkedes = 0;
            int lejtes = 0;
            char pecseteloHely = 'i';

            Console.Write("Kérem, adja meg az induló állomást: ");
            indulo_allomas = Console.ReadLine();

            Console.Write("Kérem, adja meg az végállomást: ");
            cel_allomas = Console.ReadLine();

            do
            {
                Console.Write("Kérem, adja meg a túra hosszát: ");
            } while (!double.TryParse(Console.ReadLine(), out tura_hossza));
            Console.WriteLine(tura_hossza);
            do
            {
                Console.Write("Kérem, adja meg az emelkedés: ");
            } while (!int.TryParse(Console.ReadLine(), out emelkedes));
            Console.WriteLine(emelkedes);

            do
            {
                Console.Write("Kérem, adja meg a lejtést: ");
            } while (!int.TryParse(Console.ReadLine(), out lejtes));
            Console.WriteLine(lejtes);
            do
            {
                Console.Write("Kérem, adja meg, hogy pecsételőhely-e(i/n): ");
            } while (!char.TryParse(Console.ReadLine().ToLower(), out pecseteloHely) || pecseteloHely != 'n' && pecseteloHely != 'i');
            Console.WriteLine(pecseteloHely);

            bekertAllomas = new KekturaAllomas(indulo_allomas, cel_allomas, tura_hossza, emelkedes, lejtes, boolejan(pecseteloHely));

            Console.WriteLine(bekertAllomas);

            Console.ReadKey();
        }

        private static bool boolejan(char pecseteloHely)
        {
           if(pecseteloHely == 'n')
            {
                return false;
            }
            return true;
        }
    }


}
