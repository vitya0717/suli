using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly01
{
    public class KekturaAllomas
    {
        //Sumeg, vasutallomas;Sumeg, buszpalyaudvar;1,208;16;6;n
        public string indulo_allomas;
        public string cel_allomas;
        public double tura_hossza;
        public int emelkedes;
        public int lejtes;
        public bool pecseteloHely;

        public KekturaAllomas(string indulo_allomas, string cel_allomas, double tura_hossza, int emelkedes, int lejtes, bool pecseteloHely)
        {
            this.indulo_allomas = indulo_allomas;
            this.cel_allomas = cel_allomas;
            this.tura_hossza = tura_hossza;
            this.emelkedes = emelkedes;
            this.lejtes = lejtes;
            this.pecseteloHely = pecseteloHely;
        }

        public KekturaAllomas()
        {

        }

        public override string ToString()
        {
            return $"{indulo_allomas}|{cel_allomas}|{tura_hossza}|{emelkedes}|{lejtes}|{pecseteloHely}";
        }
    }
}
