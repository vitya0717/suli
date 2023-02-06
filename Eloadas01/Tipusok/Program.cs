using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipusok
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Egész számok típusai
            byte szam1 = 0;//8 bites - 1 byte előjel nélküli 0-255
            byte szam2;
            sbyte szam3 = 127;//8 bites - 1 byte előjeles -128-+127
            short szam4 = 32600;//16 bites - 2 byte előjeles -32768-32767
            ushort szam42 = 030;//16 bites - 2 byte előjel nélküli 0-65535
            int szam5 = 500000;//32 bites -  4 byte előjeles
            uint szam52 = 1000;//32 bites - 4 byte eljel nélküli
            long szam6 = 300000000;//64 bites - 8 byte előjeles
            ulong szam62 = 3000000000000000000;//64 bites - 8 byte előjel nélkül
            //valós
            float yd = (float)3.4; //32 bites valós szám (előjeles)
            double xd = 31231231232266666.66666; // 64 bites valós szám (előjeles)
            decimal szam333 = 3200000000000000000.44444444444444m; //128 bites
            //karakteres változók - kötelezően 1 karakter hosszú
            char karakter = 'a';
            //szöveges
            string szoveg;
            string szoveg2 = "pussykil$ler2000";
            //logikai
            bool vane1;
            bool vane = false;
            bool vane2 = true;










            Console.ReadKey();
        }
    }
}
