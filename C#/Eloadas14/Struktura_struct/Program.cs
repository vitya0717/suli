using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktura_struct
{
    
    internal class Program
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
            public int adoSzam {get; set; }
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
                $"Félévi átlag: {feleviAtlag}";
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
        }

        static void Main(string[] args)
        {
            Diak diak1 = new Diak();
            diak1.vezetekNev = "Tök";
            diak1.keresztNev = "Ödön";
            diak1.szuletesiHely = "Lyukó";
            diak1.szuletesiIdo = "2024.04.05";
            diak1.anyjaNeve = "Szűz Mária";
            diak1.oktatasiAzonosito = 77261884847;
            diak1.tajSzam = 123456789;
            diak1.adoSzam = 1234567899;
            diak1.nem = false;
            diak1.tankoteles = 'n';
            diak1.feleviAtlag = 4.83;

            diak1.KiIras();

            Console.WriteLine("-----------------");

            Diak diak2;
            while (false)
            {
                diak2.keresztNev = "asdasdadsdasad";
            }
            diak2 = new Diak();
            diak2.vezetekNev = "Basz";
            diak2.keresztNev = "Tamás";
            diak2.szuletesiHely = "Avas";
            diak2.szuletesiIdo = "2025.09.05";
            diak2.anyjaNeve = "Szűz Mária";
            diak2.oktatasiAzonosito = 77289824847;
            diak2.tajSzam = 923456789;
            diak2.adoSzam = 1234367899;
            diak2.nem = true;
            diak2.tankoteles = 'i';
            diak2.feleviAtlag = 2.00;

            diak2.KiIras();
            Console.WriteLine("-----------------");
            Console.WriteLine(diak1);
            Console.WriteLine("-----------------");
            diak2.keresztNev = "asdaksbfdkjsdfhsdkhjf";
            Console.WriteLine(diak2);
            Console.WriteLine("-----------------");

            Diak diak3 = new Diak("Ó", "É", "tEGNAP", "ÁGYBA", "komlóska", 123456789, 886867696, 12234566, false, 'n', 1.4);

            Console.WriteLine(diak3);



            Console.ReadKey();
           
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
