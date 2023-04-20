using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars2
{
    public class Tanitvany : Erohasznalo
    {
        private double tincsHossza;
        private int kepzettsegiSzint;

        public Tanitvany(string nev, Random rnd) : base(nev, rnd)
        {
            Nev = "Ifjú "+nev;
            TincsHossza = rnd.NextDouble() * 14.5 + 0.5;
            KepzettsegiSzint = rnd.Next(101);
        }

        public Tanitvany(string nev, Random rnd, double tincsHossza, int kepzettsegiSzint) : base(nev, rnd)
        {
            Nev += "Ifjú " + nev;
            TincsHossza = rnd.NextDouble() * 14.5 + 0.5;
            KepzettsegiSzint = rnd.Next(101);
        }

        public double TincsHossza { get => tincsHossza; private set => tincsHossza = value; }
        public int KepzettsegiSzint
        {
            get => kepzettsegiSzint; set
            {
                if (value > 0 && value <= 100)
                {
                    kepzettsegiSzint = value;
                }
                else
                {
                    Console.WriteLine("Hibás képzettségi szint érték!");
                }

            }
        }


    }
}
