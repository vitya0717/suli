using Kivetelkezeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_KivetelKezeles
{

    internal class Program
    {
        public static string getSorozesUtaniErzes(int db)
        {
            string message = "";

            switch (db)
            {
                case int n when (db >=1 && db <= 3):
                    message = $"Jól éreztem magam({n})";
                    break;
                case int n when (db >= 4 && db <= 6):
                    message = $"Táncoltam is, de nem tudom kivel!({n})";
                    break;
                case int n when (db >= 7 && db <= 9):
                    message = $"Mit keresek most itt? Hogy a ge.. jutok haza({n})";
                    break;
                case 10:
                    message = "Élek még?";
                    break;
            }
            return message;
        }
        public static void TryCatchSorozes()
        {
            int db = 0;
            bool hibas = true;
            int elcsesz = 0;
            while (hibas)
            {
                try
                {
                    Console.Write("Hány sört ittam meg a hétvégén: ");
                    db = int.Parse(Console.ReadLine());
                    if (db < 1 || db > 10)
                    {
                        throw new EgyTizKozottException(db);
                    }
                    hibas = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    elcsesz++;
                }
                catch (EgyTizKozottException e)
                {
                    Console.WriteLine(e.Message);
                    elcsesz++;
                } finally
                {
                    Console.WriteLine($"Ittass állapot miatt nem jól megadott érték: {elcsesz}");
                }
            }
            Console.WriteLine("Megivott sörök száma: {0}", db);
            Console.WriteLine(getSorozesUtaniErzes(db));
        }

        public static void TryParseSorozes()
        {

            int result;
            do
            {
                Console.Write("Hány sört ittam meg a hétvégén: ");
            } while (!int.TryParse(Console.ReadLine(), out result) || result < 1 || result > 10);

            Console.WriteLine("Megivott sörök száma: {0}", result);
            Console.WriteLine(getSorozesUtaniErzes(result));
        }


        static void Main(string[] args)
        {
			TryCatchSorozes();
            TryParseSorozes();

            Console.ReadKey();
        }
    }
}
