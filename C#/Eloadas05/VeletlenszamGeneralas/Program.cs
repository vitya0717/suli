using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeletlenszamGeneralas {
    internal class Program {

        public static Random r = new Random();
        public static Random r2 = new Random();//nincs értelme...!4!
        static void Main(string[] args) {

            /*for (int i = 1; i < 21; i++){
                Console.WriteLine($"{i}.{r.Next(200, 301)}, {r2.Next(200,301)}");
            }*/

            int xd = r.Next(100,1001);

            while (xd < 975)
            {
                xd = r.Next(1001);
                Console.WriteLine(xd);
            }

            Console.ReadKey();

        }
    }
}
