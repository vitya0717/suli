using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SorbaRendezes
{
    internal class Program
    {
        public static Random r = new Random();
        static void Main(string[] args)
        {
            Queue<string> sor = new Queue<string>();
            Dictionary<string, int> vegsoParok = new Dictionary<string, int>();
            Stack<string> diakok = new Stack<string>();
            HashSet<int> visited = new HashSet<int>();
            int index = 0;

            //csoport 2. fele legyen eltárolva egy veremben!
            //egy "halmazban"-ban ua. elemszámú mint a verem
            diakok.Push("Soma");
            diakok.Push("L.Bálint");
            diakok.Push("Máté");
            diakok.Push("Dániel");
            diakok.Push("Balázs");
            diakok.Push("P.Bálint");
            diakok.Push("Kristóf");
            diakok.Push("Gyula");

            while (visited.Count != 8) { visited.Add(r.Next(1,9)); }
            
            foreach (var diak in diakok)
            {
                sor.Enqueue($"{diak}:{visited.ElementAt(index)}");
                index++;
            }

            foreach (var item in sor)
            {
                string[] splitSor = item.Split(':');
                vegsoParok.Add(splitSor[0], int.Parse(splitSor[1]));
            }
            foreach (var item in vegsoParok.OrderBy(it => it.Value)) { Console.WriteLine(item); }
            

            Console.ReadKey();
        }
    }
}
