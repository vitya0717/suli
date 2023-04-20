using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars2
{
    public class Rend
    {
        public List<Erohasznalo> erohasznalok = new List<Erohasznalo>();
        private Random rnd = new Random();
        public Rend(int mesterekSzama, int tanitvanyokSzama)
        {
            for (int i = 0; i < mesterekSzama; i++)
            {
                Mester m = new Mester($"Erőhasználó {i+1}", rnd);
                this.erohasznalok.Add(m);
            }
            for (int i = 0; i < tanitvanyokSzama; i++)
            {
                Tanitvany m = new Tanitvany($"Erőhasználó {i + 1}", rnd);
                erohasznalok.Add(m);
            }
        }

        public int Tanacstagok()
        {
            int count = 0;
            foreach (var hasznalo in this.erohasznalok)
            {
                if(hasznalo is Mester && hasznalo.Oldal)
                {
                    Mester mester = hasznalo as Mester;
                    if(mester.Tanacstag)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public List<Tanitvany> TanitvanyKard(kard_szine szin)
        {
            List<Tanitvany> list = new List<Tanitvany>();
            for (int i = 0; i < this.erohasznalok.Count; i++)
            {
                if (erohasznalok[i] is Tanitvany && erohasznalok[i].Oldal) 
                {
                    Tanitvany tanitvany = erohasznalok[i] as Tanitvany;
                    if(tanitvany.Kard_Szine == szin)
                    {
                        list.Add(tanitvany);
                    }
                }
            }
            return list;
        }
    }
}
