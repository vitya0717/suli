using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dtomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            // string[,] matrix = new string[5, chars.Length / 4];
            string[] orvosi = new string[chars.Length];
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < chars.Length-1; i++)
            {
                orvosi[i] = chars[i].ToString();
                Console.Write(orvosi[i]+" ");
                if (chars[i] == 't')
                {
                    orvosi[i+1] = "Viktor";
                    Console.Write(" Viktor");
                }
                if(count == 4) {
                    Console.WriteLine();
                    count = 0;
                } else
                {
                    count++;
                }
            }
            /*
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (count != 4)
                    {
                        matrix[i, j] = chars[j].ToString();

                        Console.Write(matrix[i, j]);
                        if (chars[j].ToString() == "t")
                        {
                            matrix[i, j] = "Tóth Viktor";
                            Console.Write(matrix[i, j]);
                        }
                    }
                    count++;
                    j++;
                }
                    
                count = 0;
                Console.WriteLine();
            }
            */

            /*
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }*/
            Console.ReadKey();
        }
    }
}
