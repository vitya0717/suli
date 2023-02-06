using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Operatorok.CustomObject;

namespace Operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte szam1 = 13;
            byte szam2 = 23;
            byte szam3 = (byte)(szam1+szam2);
            Console.WriteLine(szam3);
            // = - értékadó
            szam1 = 32;
            // + - műveleti operátor összeadás
            int asd = 10;
            int asd2 = 30;
            Console.WriteLine(asd+asd2);
            // - - műveleti operátor kivonás
            Console.WriteLine(asd - asd2);
            // / - műveleti operátor osztás
            Console.WriteLine(asd / asd2);
            // * - műveleti operátor szorzás
            Console.WriteLine(asd * asd2);
            // // - div képzés (python // operátor) egész osztással érhető el
            // % - mod maradék képzés
            Console.WriteLine(asd % asd2);

            //összehasonlító operátorok
            //<,>,<=,>=, ==, !=
            //
            if (szam1 > 0) // egyszerű elágazás
            {
                Console.WriteLine("Nagyobb a {0} a 0-nál! ", szam1);
            }
            //logikai operátorok
            //&&  - és (and) /\
            if(asd > 0 && asd2 > 0)
            {
                Console.WriteLine("Mind a két szám nagyobb 0-nál");
            }
            //|| - vagy (or) \/
            if (asd > 0 || asd2 > 0)
            {
                Console.WriteLine("Legalább az egyik nagyobb 0-nál!");
            }

            //tagadás ! (not)
            bool igaz = true;
            Console.WriteLine(!igaz);

            // érték változtató operátorok
            // ++ - +1
            int a = 0;
            a++;
            Console.WriteLine(a);

            // -- - -1
            a--;
            Console.WriteLine(a);

            //+=
            a += 4;
            Console.WriteLine(a);

            //-=
            a -= 2;
            Console.WriteLine(a);

            //bitműveleti operátorok
            int sz1 = 128;
            int sz2 = 1;
            //bitenkénti és &
            Console.WriteLine(sz1&sz2);
            //bitenkénti vagy |
            Console.WriteLine(sz1 | sz2);
            // ^ bitenkénti kizáró vagy XOR
            Console.WriteLine(sz1 ^ sz2);
            //<< short left(balra eltolás)
            Console.WriteLine(sz2 << 2);
            //<< short right(jobbra eltolás)
            Console.WriteLine(sz1 >> 2);



            List<CustomObject> players = new List<CustomObject>();
            List<CustomObject> enemyObjs = new List<CustomObject>();

            CustomObject obj = new CustomObject(1, "jatekos", ObjType.PLAYER);
            players.Add(obj);
            Console.WriteLine(obj.getName());

            CustomObject obj2 = new CustomObject(2, "SZÖRNY", ObjType.ENEMY);
            enemyObjs.Add(obj2);
            Console.WriteLine(obj2.getName());




            Console.ReadKey();

        }
    }

}
