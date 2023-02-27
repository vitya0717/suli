using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kektura
{
    internal class Program
    {
        static bool HianyosNev(string vegpontNev, char pecseteloHely)
        {
            if(pecseteloHely == 'i' && !vegpontNev.Contains("pecsetelohely"))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("kektura.csv");
            Queue<string> queue = new Queue<string>();
            int sorokSzama = 0;
            string egysor = "";
            while (!sr.EndOfStream)
            {
                egysor = sr.ReadLine();
                queue.Enqueue(egysor);
                sorokSzama++;
            }
            sr.Close();
            string[] mezok = egysor.Split(';');
            Console.WriteLine($"Sorok száma {sorokSzama}, oszlopok száma: {mezok.Length}");
            string[,] adatok = new string[sorokSzama, mezok.Length];

            for (int i = 0; i < sorokSzama; i++)
            {
                mezok = queue.Dequeue().Split(';');
                adatok[i, 0] = mezok[0];
                adatok[i, 1] = mezok[1];
                adatok[i, 2] = mezok[2];
                adatok[i, 3] = mezok[3];
                adatok[i, 4] = mezok[4];
                adatok[i, 5] = mezok[5];
            }
            double max = double.Parse(adatok[0, 2]);
            int maxIndex = 0;
            double min = double.Parse(adatok[0,2]);
            int minIndex = 0;
            double teljes = 0;
            int num = 0;
            int kezdo = 192;
            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                num = int.Parse(adatok[i, 3]) - int.Parse(adatok[i, 4]);
                kezdo += num;
                if (kezdo > max)
                {
                    max = kezdo;
                    maxIndex = i;
                }
                if (kezdo < min)
                {
                    min = kezdo;
                    minIndex = i;
                }
                teljes += double.Parse(adatok[i, 2]);
                Console.WriteLine($"{i}. {kezdo}");
            }
            Console.WriteLine($"Szakaszok száma: {adatok.GetLength(0)} db");
            Console.WriteLine($"A legmagasabb pont: {adatok[maxIndex,0]}\n" +
                $"{adatok[maxIndex, 1]}\n" +
                $"{adatok[maxIndex, 2]}\n" +
                $"{adatok[maxIndex, 3]}\n" +
                $"{adatok[maxIndex, 4]}\n" +
                $"{adatok[maxIndex, 5]}");
            Console.WriteLine($"A legalacsonyabb pont: {adatok[minIndex, 0]}\n" +
               $"{adatok[minIndex, 1]}\n" +
               $"{adatok[minIndex, 2]}\n" +
               $"{adatok[minIndex, 3]}\n" +
               $"{adatok[minIndex, 4]}\n" +
               $"{adatok[minIndex, 5]}");
            Console.WriteLine($"A túra teljes hossza: {teljes}km");
            Console.WriteLine("7. feladat:");
            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                if(HianyosNev(adatok[i,1], char.Parse(adatok[i, 5])))
                {
                    Console.WriteLine($"{adatok[i,1]}");
                }
            }
            StreamWriter sw = new StreamWriter("kektura2.csv");
            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                if (HianyosNev(adatok[i, 1], char.Parse(adatok[i, 5])))
                {
                    sw.WriteLine($"{adatok[i, 0]};{adatok[i, 1] + " " + "pecsetelohely"};{adatok[i, 2]};{adatok[i, 3]};{adatok[i, 4]};{adatok[i, 5]}");
                } else
                {
                    sw.WriteLine($"{adatok[i,0]};{adatok[i, 1]};{adatok[i, 2]};{adatok[i, 3]};{adatok[i, 4]};{adatok[i, 5]}");
                }
            }
            sw.Close();


            Console.ReadKey();
        }
    }
}
