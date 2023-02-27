using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombIsmetles
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[,] szamok = new int[20, 30];
            Random r = new Random();

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    int num = r.Next(800,2501);

                    while(num % 13 != 0)
                    {
                        num = r.Next(800, 2501);
                    }

                    szamok[i, j] = num;
                    Console.Write(num + "\t");
                }
            }

            Dictionary<String, int> numCount = new Dictionary<String, int>();
            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    if (numCount.ContainsKey("Ezer alatti") || numCount.ContainsKey("Közötti") || numCount.ContainsKey("Feletti"))
                    {
                        if (szamok[i,j] < 1000)
                        {
                            numCount["Ezer alatti"]++;
                        } else if (szamok[i,j] > 1000 && szamok[i,j] < 2000)
                        {
                            numCount["Közötti"]++;
                        } else
                        {
                            numCount["Feletti"]++;
                        }
                    }
                    else
                    {
                        if(!numCount.ContainsKey("Ezer alatti"))
                        {
                            numCount.Add("Ezer alatti", 0);
                        }
                        if (!numCount.ContainsKey("Közötti"))
                        {
                            numCount.Add("Közötti", 0);
                        }
                        if (!numCount.ContainsKey("Feletti"))
                        {
                            numCount.Add("Feletti", 0);
                        }
                            
                    }
                }
            }
            Console.WriteLine();

            foreach (var keresztnev in numCount)
            {
                Console.WriteLine($"{keresztnev.Key}: {keresztnev.Value}");
            }

            Console.ReadKey();

        }
    }
}
