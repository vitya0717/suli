using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitestek
{
    internal class BarnaTorpe : Egitest
    {
        private double fenyesseg;
        private int homerseklet;
        private double tomeg;

        public BarnaTorpe(string nev, double fenyesseg, int homerseklet, double tomeg) : base(nev)
        {
            this.fenyesseg = fenyesseg;
            this.homerseklet = homerseklet;
            this.tomeg = tomeg;
        }

        public BarnaTorpe()
        {

        }

        public override string ToString()
        {
            return $"Név: {Nev}\nFényesség: {Fenyesseg}\nHőmérséklet: {Homerseklet}\nTömeg: {Tomeg}";
        }


        public double Fenyesseg { get => fenyesseg; set => fenyesseg = value; }
        public int Homerseklet { get => homerseklet; set => homerseklet = value; }
        public double Tomeg { get => tomeg; set => tomeg = value; }
    }
}
