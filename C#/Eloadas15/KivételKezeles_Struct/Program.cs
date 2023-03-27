using KivételKezeles_Struct.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivételKezeles_Struct
{

    internal class Program
    {
        public class
            Labda
        {
            private int pottyokSzama;
            private int meret;
            private string szin;
            private string fajta;
            private bool lapose;

            public int PottyokSzama
            {
                get { return pottyokSzama; }
                set
                {
                    if (value < 0 || value > 40)
                    {
                        throw new PottyokSzamaException(value, fajta);
                    }
                    else
                    {
                        pottyokSzama = value;
                    }
                }
            }

            public Labda(int pottyokSzama, int meret, string szin, string fajta, bool lapose)
            {
                this.meret = meret;
                this.szin = szin;
                this.fajta = fajta;
                this.lapose = lapose;
                PottyokSzama = pottyokSzama;

            }

            public override string ToString()
            {
                return $"Fajta: {fajta}| Szín: {szin}| Méret: {meret}| Pöttyök száma: {pottyokSzama}| Lapos-e? {(lapose ? "Igen" : "Nem")}";
            }
        }

        static void Main(string[] args)
        {

            try
            {
                Labda labda = new Labda(10, 5, "Piros", "Kínai", false);
                Console.WriteLine(labda);
                labda.PottyokSzama = 42;
                Console.WriteLine(labda);
            }
            catch (PottyokSzamaException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Hibás fajta! " + e.HibasFajta);
            }



            Console.ReadKey();
        }
    }
}
