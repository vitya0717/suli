using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    internal class Program
    {
        public const int x = 10;
        public const int y = 10;
        public const int hajokSzama = 5;
        public static Random random = new Random();

        public static bool kornyezetVizsgalasa(int[,] csatater, int x, int y)
        {
            int koordinata_x;
            int koordinata_y;

            for (int i = 0; i < 3; i++)
            {
                koordinata_y = y + i - 1;

                for (int j = 0; j < 3; j++)
                {
                    koordinata_x = x+j-1;

                    if(koordinata_x >= 0 && koordinata_y >= 0 && koordinata_x < Program.x && koordinata_y < Program.y)
                    {
                        if (csatater[koordinata_x,koordinata_y] != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[,] csataTer = new int[x,y];
            int[,] csataTerTemp = csataTer.Clone() as int[,];

            for (int i = hajokSzama; i > 0;)
            {
                int X = random.Next(0,x);
                int Y = random.Next(0,y);
                if (kornyezetVizsgalasa(csataTer, X, Y))
                {
                    csataTer[X, Y] = i;
                    i--;
                }


            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    
                    Console.Write(csataTer[i, j] + " ");
                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
