using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivetelKezeles_TryCatch01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool joEletkor = false;
            int szamlalo = 0;
            while (!joEletkor)
            {
                Console.Write("Kérem az életkorát: ");
                try
                {
                    int eletkor = int.Parse(Console.ReadLine());
                    joEletkor = true;
                }
                catch (Exception ex)
                {
                    if(szamlalo < 5)
                    {
                        Console.WriteLine("Adatbeviteli hiba!");
                    } else
                    {
                        Console.WriteLine("Ennyire egy ember se lehet hüJe!");
                    }
                    szamlalo++;
                } finally
                {
                    Console.WriteLine("YÁÁÁÁJJ");
                }
            }
            Console.WriteLine(szamlalo < 5 ? "Ügyes vagy, sikerült 5 vagy kevesebb próbálkozásból megadni az életkorodat " : $"Na csak sikerült {szamlalo} próbálkozásból megdni az adatodat XD");
            
            Console.ReadKey();
        }
    }
}
