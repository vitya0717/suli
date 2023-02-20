using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVerem
{
    internal class Program
    {
        public static Random r = new Random();
        static void Main(string[] args)
        {
            
            Stack<int> stack = new Stack<int>();
            Stack<int> stac2 = (Stack<int>)stack.Reverse();

            for (int i = 0; i < 20; i++)
            {
                stack.Push(r.Next(20, 36));
            }

            Console.Write("Nem reverse: ");
            foreach (var item in stack)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine(); //semmi

            Console.Write("Reverse:     ");
            foreach (var item in stack.Reverse())
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
