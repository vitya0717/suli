using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly01
{

    class Program
    {
        static void Main(string[] args)
        {
            
            KekturaAllomas tesztRecord = new KekturaAllomas();
            tesztRecord.indulo_allomas = "Kezdő";
            tesztRecord.cel_allomas = "Vég";
            tesztRecord.tura_hossza = 1.30323;
            tesztRecord.emelkedes = 300;
            tesztRecord.lejtes = 200;
            tesztRecord.pecseteloHely = false;
            Console.WriteLine(tesztRecord);

            List<KekturaAllomas> allomasok = new List<KekturaAllomas>();

            string[] sorok = null;
            int kezdoMagassag = 0;
            try
            {
                
                sorok = File.ReadAllLines("kektura.csv");
                kezdoMagassag = int.Parse(sorok[0]);
                for (int i = 1; i < sorok.Length; i++)
                {
                    string[] split = sorok[i].Split(';');
                    allomasok.Add(new KekturaAllomas(split[0], split[1], double.Parse(split[2]), int.Parse(split[3]), int.Parse(split[4]), (char.Parse(split[5]) == 'n' ? false : true)));
                }

                foreach (var item in allomasok)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

            Console.ReadKey();
        }
    }
}
