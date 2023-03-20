using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaListabanTarolva
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Diak diak1 = new Diak("Ó", "É", "tEGNAP", "ÁGYBA", "komlóskai.maj..", 123456789, 886867696, 12234566, false, 'n', 1.4);
            Diak diak2 = new Diak("HDHD", "ÉDDD", "Ma", "Földön", "Miskolci.cig..", 7772345789, 884867696, 16534566, false, 'n', 1.4);

            List<Diak> diakok = new List<Diak>();
            diakok.Add(diak1);
            diakok.Add(diak2);

            foreach (Diak egyDiak in diakok)
            {
                Console.WriteLine(egyDiak);
            }
            //vector
            //halmaz
            //verem
            //sor
            //szotar

            //halmaz
            HashSet<Diak> diakok_hashset = new HashSet<Diak>();
            diakok_hashset.Add(diak1);
            diakok_hashset.Add(diak2);
            //verem
            Stack<Diak> diakok_stack = new Stack<Diak>();
            diakok_stack.Push(diak1);
            diakok_stack.Push(diak2);
            //queue
            Queue<Diak> diakok_queue = new Queue<Diak>();
            diakok_queue.Enqueue(diak1);
            diakok_queue.Enqueue(diak2);
            //dicksönöri
            Dictionary<int, Diak> diakok_dict = new Dictionary<int, Diak>();
            diakok_dict.Add(1, diak1);
            diakok_dict.Add(2, diak2);
            //vector 2d
            Diak[,] diakok_vector = new Diak[2, 1];
            diakok_vector[0, 0] = diak1;
            diakok_vector[1, 0] = diak2;
            //vector 1d
            Diak[] diakok_vector2 = new Diak[2];
            diakok_vector2[0] = diak1;
            diakok_vector2[1] = diak2;
            //tupple
            Tuple<Diak>[] diakok_tupple = { new Tuple<Diak>(diak1), new Tuple<Diak>(diak2) };
            //array
            ArrayList diakokArray = new ArrayList();
            diakokArray.Add(diak1);
            diakokArray.Add(diak2);
            diakokArray.Add("Ez egy szöveg!");

            foreach (var item in diakokArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
