using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Verem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Diakok = new Stack<string>();

            Diakok.Push("Viktor");
            Diakok.Push("Gergő");
            Diakok.Push("Erzsébet");
            Diakok.Push("Judit");
            Diakok.Push("Ádám");
            Diakok.Push("Szöszke");
            Diakok.Push("Dani");
            Diakok.Push("Dominik");

            foreach (var item in Diakok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Diakok.Count);
            Console.WriteLine(Diakok.Peek());
            int count = Diakok.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Diakok.Pop());
            }
            Console.WriteLine(Diakok.Count);
            Console.ReadKey();

        }
    }
}
