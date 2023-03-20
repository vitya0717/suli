using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList lista = new ArrayList();

            lista.Add((byte)1);
            lista.Add("2");
            lista.Add(true);
            lista.Add(3.45);
            lista.Add('C');
            lista.Add(13300033333300000033333333333m);
            lista.Add(13300033333300000033333333333.0);

            foreach (var item in lista)
            {
                Console.WriteLine($"Tárolt adat tipusa: {item.GetType()}, Adat: {item}");
            }

            Console.ReadKey();
        }
    }
}
