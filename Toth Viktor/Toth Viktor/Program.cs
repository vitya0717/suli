using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Toth_Viktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short asd = 10;
            uint asd2 = 50;
            long osszeg = asd + asd2;
            Console.WriteLine(osszeg);
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i += 2;
            }
            int xxx = 16;
            Console.WriteLine(xxx << 4);



            string yooo = "Kandó Kálmán";
            Console.WriteLine(yooo.Split(' ')[0]);
            sbyte xddd = -100;
            ushort xd3 = 100;
            int yd3 = xddd * xd3;
            Console.WriteLine(yd3);
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }


            char a = 'a';
            float f = 1.0f;
            short szam2 = 22;
            int szam1 = 10;
            Console.WriteLine((double)szam2 / szam1);
            int szaz = 100;
            do
            {
                if (szaz % 5 == 0)
                {
                    Console.WriteLine(szaz);
                }
                szaz -= 5;

            } while (szaz >= 0);


            bool vane = false;
            while (!vane)
            {
                Console.WriteLine("Ez a while törzse!");
                vane = true;
            }


            double szam = 0;
            while (szam <= 1)
            {
                Console.WriteLine(szam);
                szam += 0.1;
            }
            string ffffff = "MITISZK";
            Console.WriteLine(ffffff.Substring(2, 2));
            Console.WriteLine(ffffff.ToLower());


            uint sz = 256;
            uint sz2 = sz >> 2;
            Console.WriteLine(sz2);
            bool vane2 = true;
            int szs = 10;
            do
            {
                Console.WriteLine(szs);
                if (szs == 20)
                {
                    vane2 = !vane2;
                }
                szs += 1;
            } while (vane2);


            ulong xddas = 12345678;
            decimal ysd = 1234567890.43233m;
            decimal dddd = ysd / xddas;
            Console.WriteLine(dddd);
            string valami = "Informatikai Technikum";
            for (int l = 0; l < valami.Length; l += 2)
            {
                Console.WriteLine(valami[l]);
            }
            bool igaz = true;
            bool hamis = false;
            if (igaz && !hamis)
            {
                Console.WriteLine("Hello World");
            }


            Int64 xd = 20;
            ushort xs = 7;
            double ys = (double)xd / (double)xs;
            Console.WriteLine(ys);
            string szov = "géza kék az ég";
            for (int l = szov.Length - 1; l >= 0; l--)
            {
                Console.Write(szov[l]);
            }


            byte szlm = 128;
            Console.WriteLine(szlm << 2);
            int index = 100;
            while (index != 200)
            {
                if (index % 7 == 0)
                {
                    Console.WriteLine(index);
                }
                index++;
            }
            string semmi = "istván";
            Console.WriteLine(semmi.ToUpper());


            double ex = 5.35;
            short ex2 = 15;
            bool vane3 = false;
            do
            {
                Console.WriteLine(ex2);
                if (ex2 == 30)
                {
                    vane3 = true;
                }
                ex2++;

            } while (!vane3);



            int sd = int.MinValue;
            ushort sd2 = ushort.MaxValue;
            Console.WriteLine((double)sd2/sd);
            string sd3 = "Andrássy Gyula";
            int db = 0;
            for (int x = 0; x < sd3.Length; x++)
            {
                if (sd3[x] == 's')
                {
                    db++;
                }
            }
            Console.WriteLine(db);
            Console.WriteLine(sd3.Contains("Gyula"));


            Int64 szaz50 = 150;
            int hetven = 70;
            long szam3 = szaz50 % hetven;
            Console.WriteLine(szam3);
            for (int c = 100; c <= 200; c++)
            {
                if (c % 9 != 0)
                {
                    Console.WriteLine(c);
                }
            }
            string szovegd = "terem";
            Console.WriteLine("{0}{1}",szovegd[0], szovegd[szovegd.Length-1]);




            sbyte szove = -5;
            uint harminc5 = 35;
            char z = 'z';
            double szam4 = harminc5 / szove;
            decimal tizen5 = 15.5m;
            int szamol = 10;
            while (szamol <= 30)
            {
                if (szamol % 2 == 0)
                {
                    Console.WriteLine(szamol);
                }
                szamol++;
            }



            string sziveg = "ez egy szöveges változó értéke";
            char chare = 'e';
            foreach (char item in sziveg)
            {
                if (item == chare)
                {
                    Console.WriteLine("tanáltam egy {0} betűt", chare);
                };
            }
            bool nincs = false;
            uint gye = 129;
            uint gyes = 1;
            Console.WriteLine(gye&gyes);


            int gye2 = 89;
            ushort gyed = 55;
            bool hamiska = false;
            decimal szamot = 15.87m;
            for (int b = 60; b <= 80; b++)
            {
                if (b % 2 != 0)
                {
                    Console.WriteLine(b);
                }
            }



            

            Console.ReadKey();
        }
    }
}
