using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DTomb
{
    internal class Program
    {
        public static Random r = new Random();
        public static int randomJegy()
        {
            return r.Next(0,5);
        }
       
       

        static void Main(string[] args)
        {
            string[,,] naplo = new string[6, 16, 5];//1-tantárgy kód,//2-tanuló kód,//3-havi értékelés
            string[] tantargyak = new string[6] {"Porg.A", "Háló I.", "Háló II", "Munk v.", "Angol", "IKT"};
            string[] tanulok = {"Tóth V.", "Kiss G.", "Kutasi E.", "Szabó J.", "Kelemen Á.", "Kovács D.", "Juhász B.", "Novák D.",
                "Dimény S.", "Lengyel B.", "Balázs M.", "Fekete D.", "Várdai B.", "Pejkó B.", "Sándor K.", "Héjjas GY."};
            string[] szovegesErtekeles = { "Jeles", "Jó", "Közepes", "Elégs", "Elégt" };
            int ossz = 0;
            for (int i = 0; i < tanulok.Length; i++)
            {
                Console.WriteLine(tanulok[i]);
                for (int j = 0; j < tantargyak.Length; j++)
                {
                    
                    Console.Write(tantargyak[j]+"\t\t");
                    for (int k = 0; k < szovegesErtekeles.Length; k++)
                    {
                        Console.Write(szovegesErtekeles[randomJegy()]+"\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
         


            Console.ReadKey();
        }
    }
}
