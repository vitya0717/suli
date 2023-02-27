using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalmazMuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>() { 5, 7, 9, 11, 15 };
            HashSet<int> B = new HashSet<int>() { 2, 7, 8, 11, 13 };

            var metszet = A.Intersect(B);
            var unio = A.Union(B);
            var exce = A.Except(B);
            var exce2 = B.Except(A);

            Console.WriteLine($"Metszet: {string.Join(",", metszet)}");
            Console.WriteLine($"Unió: {string.Join(",", unio)}");
            Console.WriteLine($"Except A: {string.Join(",", exce)}");
            Console.WriteLine($"Except B: {string.Join(",", exce2)}");

            Console.ReadKey();

        }
    }
}
