using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsoportTanuloiNevStaisztika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[2, 16];

            matrix[0, 0] = "Tóth";
            matrix[0, 1] = "Kiss";
            matrix[0, 2] = "Kutasi";
            matrix[0, 3] = "Szabó";
            matrix[0, 4] = "Kelemen";
            matrix[0, 5] = "Kovács";
            matrix[0, 6] = "Juhász";
            matrix[0, 7] = "Novák";
            matrix[0, 8] = "Dimény";
            matrix[0, 9] = "Lengyel";
            matrix[0, 10] = "Balázs";
            matrix[0, 11] = "Fekete";
            matrix[0, 12] = "Váradi";
            matrix[0, 13] = "Pejkó";
            matrix[0, 14] = "Sándor";
            matrix[0, 15] = "Héjjas";
            //
            matrix[1, 0] = "Viktor";
            matrix[1, 1] = "Gergő";
            matrix[1, 2] = "Erzsébet";
            matrix[1, 3] = "Judit";
            matrix[1, 4] = "Ádám";
            matrix[1, 5] = "Dániel";
            matrix[1, 6] = "Balázs";
            matrix[1, 7] = "Dominik";
            matrix[1, 8] = "Soma";
            matrix[1, 9] = "Bálint";
            matrix[1, 10] = "Máté";
            matrix[1, 11] = "Dániel";
            matrix[1, 12] = "Balázs";
            matrix[1, 13] = "Bálint";
            matrix[1, 14] = "Kristóf";
            matrix[1, 15] = "Gyula";

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[0, j]} {matrix[1, j]}");
                Console.WriteLine();
            }

            Dictionary<String, int> nevekCount = new Dictionary<String, int>();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (nevekCount.ContainsKey(matrix[1,j]))
                {
                    nevekCount[matrix[1, j]]++;
                } else
                {
                    nevekCount.Add(matrix[1, j], 1);
                }
            }
            
            foreach (var keresztnev in nevekCount)
            {
                Console.WriteLine($"{keresztnev.Key}: {keresztnev.Value}");
            }

            Console.ReadKey();
        }
    }
}
