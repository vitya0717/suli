
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KivetelKezeles_TryCatch02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("input.txt");

                reader.Close();
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine(e.Message);
            } finally
            {
                Console.WriteLine("A program hiba nélkül lefutott KAPPA");
            }
            

            Console.ReadKey();
        }

    }
}
