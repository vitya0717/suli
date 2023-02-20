using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoSorsolas
{
    internal class Program
    {
        public static Random r = new Random();

        public static void sorsolas(HashSet<int> szamok)
        {
            switch (szamok.Count)
            {
                case 5:
                    szamok.Clear();
                    while (szamok.Count != 5)
                    {
                        szamok.Add(r.Next(1,91));
                    }
                    break;
                case 6:
                    szamok.Clear();
                    while (szamok.Count != 6)
                    {
                        szamok.Add(r.Next(1, 46));
                    }
                    break;
                case 7:
                    szamok.Clear();
                    while (szamok.Count != 7)
                    {
                        szamok.Add(r.Next(1, 36));
                    }
                    break;
                default:
                    szamok.Clear();
                    Console.WriteLine("Nem létezik ilyen lottó!");
                    break;
            }
        }
        public static void Kiiras(HashSet<int> szamok)
        {
            if(szamok.Count > 0)
            {
                foreach (int szam in szamok)
                {
                    Console.WriteLine(szam);
                }
            }
        }

        static void Main(string[] args)
        {
            /*1. hozzanak létre egy eljárást amely paraméteréül egy halmazt kap 
             * (a paraméterben kapott halmaz a főprogramban definiálják, amely lehet 5,6 illetve 7 elemű kezdőérétkek nélkül). 
             * Az eljárásban switch-case szerkezettel oldják meg, hogy ötöslottó esetén 1-90, hatoslottó esetén 1-45, 
             * továbbá heteslottó esetén 1-35 közötti véletlen számokkal töltse fel a  paraméterben kapott halmazt.

            2 Hozzanak létre egy eljárást, amely kiírja a paraméterében kapott halmaz tartalmát.

            3. főprogramban hívják meg a sorsolás végző eljárást, majd a kiírást végzőt.*/
            HashSet<int> szamok = new HashSet<int>();
            Console.Write("Milyen lottót szeretnél? ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                szamok.Add(i);
            }
            sorsolas(szamok);
            Kiiras(szamok);
            Console.ReadKey();
        }
    }
}
