using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars2
{

    public enum kard_szine { KÉK, ZÖLD, SÁRGA, LILA, PIROS }

    public abstract class Erohasznalo
    {

        private string nev;
        private int midiklorianok;
        private kard_szine kard_Szine;
        private bool oldal;
        private byte oldalValtoztatasokSzama = 0;

        protected Erohasznalo(string nev, Random rnd)
        {
            Nev = nev;
            Midiklorianok = rnd.Next(3000, 20001);
            Kard_Szine = randomKard(rnd);
            Oldal = oldal;
        }

        private kard_szine randomKard(Random rnd)
        {
            oldal = true;
            switch (rnd.Next(0, 5))
            {
                case 0:
                   kard_Szine = kard_szine.KÉK;
                   break;
                case 1:
                    kard_Szine = kard_szine.ZÖLD;
                    break;
                case 2:
                    kard_Szine = kard_szine.SÁRGA;
                    break;
                case 3:
                    kard_Szine = kard_szine.LILA;
                    break;
                case 4:
                    kard_Szine = kard_szine.PIROS;
                    oldal = false;
                    break;
            }
            return Kard_Szine;
        }

        public string Nev
        {
            get { return nev; }
            protected set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentOutOfRangeException("A név túl rövid!");
                }
                nev = value;
            }
        }
        public int Midiklorianok
        {
            get { return midiklorianok; }
            private set
            {
                if (value <= 3000 || value > 20000)
                {
                    throw new ArgumentOutOfRangeException("Hibás érték");
                }
                midiklorianok = value;
            }
        }
        public kard_szine Kard_Szine
        {
            get { return kard_Szine; }
            private set { kard_Szine = value; }
        }
        public bool Oldal
        {
            get { return oldal; }
            set
            {
                if (this.oldalValtoztatasokSzama > 2)
                {
                    throw new ArgumentOutOfRangeException("Csak kétszer lehet oldalt változtatni!");
                }
                oldal = value;
                this.oldalValtoztatasokSzama++;
            }
        }
        public override string ToString()
        {
            return $"Név: {nev}\n" +
                $"Midrovalami: {Midiklorianok}\n" +
                $"Kard szine: {Kard_Szine}\n" +
                $"Oldal: {Oldal}";
        }
    }
}
