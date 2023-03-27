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
        string indulo_allomas;
        string cel_allomas;
        double tura_hossza;
        int emelkedes;
        int lejtes;
        bool pecseteloHely;

        public string Indulo_allomas
        {
            get { return indulo_allomas; }
            set { indulo_allomas = value; }
        }
        public string Cel_allomas
        {
            get { return cel_allomas; }
            set 
            { 
                if(PecseteloHely)
                {
                    if (!value.Contains("pecsetelohely"))
                    {
                        value += " pecsetelohely";
                    }
                    cel_allomas = value;
                } 
                else {
                    cel_allomas = value;
                }
            }
        }

        public double Tura_hossza
        {
            get { return tura_hossza; }
            set { tura_hossza = value; }
        }
        public int Emelkedes
        {
            get { return emelkedes; }
            set { emelkedes = value; }
        }

        public int Lejtes
        {
            get { return lejtes; }
            set { lejtes = value; }
        }

        public bool PecseteloHely
        {
            get { return pecseteloHely; }
            set { pecseteloHely = value; }
        }

        public KekturaAllomas(string sor)
        {
            string[] split = sor.Split(';');
            PecseteloHely = char.Parse(split[5]) == 'n' ? false : true;
            Indulo_allomas = split[0];
            Cel_allomas = split[1];
            Tura_hossza = double.Parse(split[2]);
            Emelkedes = int.Parse(split[3]);
            Lejtes = int.Parse(split[4]);
        }


        public KekturaAllomas(string indulo_allomas, string cel_allomas, double tura_hossza, int emelkedes, int lejtes, bool pecseteloHely)
        {
            this.PecseteloHely = pecseteloHely;
            this.Indulo_allomas = indulo_allomas;
            this.Cel_allomas = cel_allomas;
            this.Tura_hossza = tura_hossza;
            this.Emelkedes = emelkedes;
            this.Lejtes = lejtes;
            
        }

        public override string ToString()
        {
            return $"{indulo_allomas}|{cel_allomas}|{tura_hossza}|{emelkedes}|{lejtes}|{pecseteloHely}";
        }
    }
}
