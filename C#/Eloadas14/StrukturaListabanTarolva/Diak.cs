using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaListabanTarolva
{
    struct Diak
    {
        public string vezetekNev { get; set; }
        public string keresztNev { get; set; }
        public string szuletesiIdo { get; set; }
        public string szuletesiHely { get; set; }
        public string anyjaNeve { get; set; }
        public long oktatasiAzonosito { get; set; }
        public int tajSzam { get; set; }
        public int adoSzam { get; set; }
        public bool nem { get; set; }//false=fiú, true=jány
        public char tankoteles { get; set; }
        public double feleviAtlag { get; set; }

        public Diak(string vezetekNev, string keresztNev, string szuletesiIdo, string szuletesiHely, string anyjaNeve, long oktatasiAzonosito, int tajSzam, int adoSzam, bool nem, char tankoteles, double feleviAtlag)
        {
            this.vezetekNev = vezetekNev;
            this.keresztNev = keresztNev;
            this.szuletesiIdo = szuletesiIdo;
            this.szuletesiHely = szuletesiHely;
            this.anyjaNeve = anyjaNeve;
            this.oktatasiAzonosito = oktatasiAzonosito;
            this.tajSzam = tajSzam;
            this.adoSzam = adoSzam;
            this.nem = nem;
            this.tankoteles = tankoteles;
            this.feleviAtlag = feleviAtlag;
        }

        public override string ToString()
        {
            return $"Vezetéknév: {vezetekNev}\n" +
            $"Keresztnév: {keresztNev}\n" +
            $"Születési hely: {szuletesiHely}\n" +
            $"Suületési idő: {szuletesiIdo}\n" +
            $"Anyja neve: {anyjaNeve}\n" +
            $"Oktatási azonosító: {oktatasiAzonosito}\n" +
            $"TAJ: {format(tajSzam)}\n" +
            $"Adószám: {adoSzam}\n" +
            $"Neme: {(nem ? "Nő" : "Férfi")}\n" +
            $"Tanköteles: {((tankoteles == 'i') ? "Igen" : "Nem")}\n" +
            $"Félévi átlag: {feleviAtlag}\n";
        }
        public void KiIras()
        {
            Console.WriteLine(
            $"Vezetéknév: {vezetekNev}\n" +
            $"Keresztnév: {keresztNev}\n" +
            $"Születési hely: {szuletesiHely}\n" +
            $"Suületési idő: {szuletesiIdo}\n" +
            $"Anyja neve: {anyjaNeve}\n" +
            $"Oktatási azonosító: {oktatasiAzonosito}\n" +
            $"TAJ: {format(tajSzam)}\n" +
            $"Adószám: {adoSzam}\n" +
            $"Neme: {(nem ? "Nő" : "Férfi")}\n" +
            $"Tanköteles: {((tankoteles == 'i') ? "Igen" : "Nem")}\n" +
            $"Félévi átlag: {feleviAtlag}");
        }
        private static string format(int tajSzam)
        {
            string tajFormat = "";
            int count = 0;
            foreach (var item in tajSzam.ToString())
            {
                tajFormat += item;
                if (count != 3)
                {
                    count++;
                    if (count == 3)
                    {
                        tajFormat += '-';
                        count = 0;
                    }
                }
            }
            tajFormat = tajFormat.Trim('-');

            return tajFormat;
        }

    }
}
