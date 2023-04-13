using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitestek
{
    enum BolygoType
    {
        Óriásbolygó, Kőzetbolygó, Törpebolygó
    }
    internal class Bolygo : Egitest
    {
        public BolygoType BolygoType;
        private double _gravitacio;
        private double _atmero;
        private string _atmoszfera;
        private int _holdjainakSzama;
        private List<Bolygo> _holdak = new List<Bolygo>();
        
        public Bolygo()
        {

        }

        public Bolygo(string nev, BolygoType bolygoType, double gravitacio, double atmero, string atmoszfera, int holdjainakSzama, List<Bolygo> holdak) : base (nev)
        {
            BolygoType = bolygoType;
            _gravitacio = gravitacio;
            _atmero = atmero;
            _atmoszfera = atmoszfera;
            _holdjainakSzama = holdjainakSzama;
            _holdak = holdak;
        }

        public Bolygo(string nev, BolygoType bolygoType, double gravitacio, double atmero, string atmoszfera) : base (nev)
        {
            BolygoType = bolygoType;
            _gravitacio = gravitacio;
            _atmero = atmero;
            _atmoszfera = atmoszfera;
        }

        public override string ToString()
        {
            string holdak = "";
            if(Holdak.Count > 0)
            {
                foreach (Bolygo item in Holdak)
                {
                    holdak += "\n" + item.ToString();
                }
            } else
            {
                holdak = "Nincs holdja";
            }
            return $"Neve: {Nev}" +
                   $"\nCsoportja: {BolygoType}" +
                   $"\nGravitációja: {Gravitacio}N/kg" +
                   $"\nÁtmérő: {Atmero} Km" +
                   $"\nAtmoszféra: {Atmoszfera}" +
                   $"\nHoldak száma: {HoldjainakSzama}" +
                   $"\nHoldjai: " + holdak;
        }


        public double Gravitacio { get => _gravitacio; set => _gravitacio = value; }
        public double Atmero { get => _atmero; set => _atmero = value; }
        public string Atmoszfera { get => _atmoszfera; set => _atmoszfera = value; }
        public int HoldjainakSzama { get => _holdjainakSzama; set => _holdjainakSzama = value; }
        internal List<Bolygo> Holdak { get => _holdak; set => _holdak = value; }
    }
}
