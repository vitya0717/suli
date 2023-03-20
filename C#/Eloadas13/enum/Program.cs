using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum Allatok { Kutya, Macska, Zsiráf, Oroszlán }
        enum Etelek {Csirkecomb = 10, KecskeTej = 8, Májkrém = 15, KinaiKutaAmiCike = 11 }

        enum Napok {Vasárnap, Hétfő, Kedd, Szerda, Csütörtök, Péntek, Szombat}

        enum Honapok { Január=1, Február=2, Március=3, Április=4, Május=5, Június=6, Július=7, Augusztus=8, Szeptember=9, Október=10, November=11, December=12}
        static void Main(string[] args)
        {
            Allatok kutya = Allatok.Macska;
            Console.WriteLine(kutya);
            Etelek csikerComb = Etelek.Csirkecomb;
            Console.WriteLine(csikerComb);
            Console.WriteLine((Etelek)15);
            Console.WriteLine(csikerComb);
            Console.WriteLine();
            Honapok aktHonap = Honapok.Március;
            Console.WriteLine(aktHonap);
            Napok aktNap = Napok.Csütörtök;
            Console.WriteLine((int)aktNap);
            Napok kovNap = (Napok)5;
            Console.WriteLine(kovNap);
            Console.WriteLine();
            Console.WriteLine((Etelek)11);
            Console.WriteLine();

            foreach (var item in Enum.GetNames(typeof(Napok)))
            {
                Console.WriteLine(item);
            }

            
            Console.ReadKey();
        }
    }
}
