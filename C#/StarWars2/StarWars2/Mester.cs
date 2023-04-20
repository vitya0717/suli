using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars2
{

    public enum kopeny
    {
        kapucnis_barna, kapucni_szürke, lenge_vászon
    }

    public class Mester : Erohasznalo
    {
        private bool tanacstag;
        private kopeny kopeny1;
        private int korabbi_tanitvanyok;

        public void Kopenycsere(kopeny kopeny)
        {
            Kopeny = kopeny;
        }

        public Mester(string neve, Random rnd) : base(neve, rnd)
        {
            Nev = neve+" Mester";
            if(!Oldal)
            {
                Tanacstag = false;

            } else
            {
                if(rnd.Next(2) == 0)
                {
                    Tanacstag = false;
                } else
                {
                    Tanacstag = true;
                }
            }
            Kopeny = (kopeny)rnd.Next(0, 3);
            Korabbi_tanitvanyok = rnd.Next(21);
        }

        public override string ToString()
        {
            return $"Név: {Nev}" +
                $"\nMidiklorián: {Midiklorianok}" +
                $"\nKard színe: {Kard_Szine}" +
                $"\nOldal: {(Oldal ? "Jó oldal" : "Gonosz")}" +
                $"\nTanácstag: {(Tanacstag ? "Igen" : "Nem")}" +
                $"\nKöpeny: {Kopeny}" +
                $"\nKorábbi tanítványok: {Korabbi_tanitvanyok}" +
                $"\n";
        }


        public bool Tanacstag
        {
            get => tanacstag;
            private set
            {
                if (!tanacstag || tanacstag.Equals(null))
                {
                    tanacstag = value;
                }
            }
        }
        public kopeny Kopeny { get => kopeny1; private set => kopeny1 = value; }
        public int Korabbi_tanitvanyok
        {
            get => korabbi_tanitvanyok;
            private set
            {
                if (value >= 0 && value <= 20)
                {
                    korabbi_tanitvanyok = value;
                }
                else
                {
                    Console.WriteLine("Hibás érték!");
                }
            }
        }
    }
}
