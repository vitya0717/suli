using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kisdolgozat_TothViktor01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1.feladat
             * Generáljon 100 db véletlen számot [1-300] intervallumban
            Számolja meg hogy hány darab 7-tel osztható számot "dobott" a gép.*/
            int db = 0;
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = r.Next(1, 300);
                if(num % 7 == 0)
                {
                    Console.WriteLine(num);
                    db++;
                }

            }
            Console.WriteLine($"{db} darab 7-tel osztható szám lett generálva!");

            /*2.feladat
             Generáljon addig véletlen számokat az [1500-9765] intervallumból, amig  olyan szám nem generálódik amely 3-mal, 7-tel és 39 is osztható.
            Ezt a számot jelenítse csak meg.*/
            int num2 = r.Next(1500,  9765);

            while (!(num2 % 3 == 0 && num2 % 7 == 0 && num2 % 39 == 0))
            {
                num2 = r.Next(1500, 9765);

            }
            Console.WriteLine($"A megfelelő szám: {num2}");


            Console.ReadKey();

        }
    }
}
