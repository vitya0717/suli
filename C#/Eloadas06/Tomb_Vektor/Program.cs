using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_Vektor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow};
            int[] szamok = new int[16];
            Random r = new Random();
            foreach (int num in szamok)
            {
                Console.WriteLine(num);
            
            }
            Console.WriteLine("----------");
            foreach (int num in szamok)
            {
                int numer = r.Next(1, 6);
                szamok.Append(numer);
                //Color cc = Color.FromArgb(r.Next(0,256), r.Next(0, 256), r.Next(0, 256));
                //Console.ForegroundColor = Console.BackgroundColor;
                Console.WriteLine(numer);
            }
            Console.WriteLine("----------");
            Console.WriteLine();
            string[] osztalyTanulok = new string[30];
            osztalyTanulok[0] = "Tóth Viktor";
            osztalyTanulok[osztalyTanulok.Length - 1] = "Kiss Gergő";
            osztalyTanulok[osztalyTanulok.Length/2] = "Csitári Ádám János";
            osztalyTanulok[osztalyTanulok.Length/2+1] = "Héjjas Gyula";
            int index = 1;
            foreach (string egyTanulo in osztalyTanulok)
            {
                Console.ForegroundColor = colors[r.Next(0, colors.Length - 1)];
                Console.WriteLine($"{index} {egyTanulo}");
                index++;
            }
            Console.WriteLine();
            string[] tanulok = new string[30];
            string chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 30; i++)
            {
                string name = "";
                for (int j = 0; j < 15; j++)
                {
                    name += chars[r.Next(0, chars.Length - 1)];
                }
                tanulok[i] += name; 
            }
            //bool[] alapVizsgaEredmenyek = new bool[osztalyTanulok.Length];
            Dictionary<int, Dictionary<string, int>> alapvizsgaEredmeny = new Dictionary<int, Dictionary<string, int>>();
            Dictionary<string, int> alapvizsgaEredmeny2 = new Dictionary<string, int>();
            for (int i = 1; i < 30; i++)
            {
                int eredmeny = r.Next(0, 101);
                alapvizsgaEredmeny2.Add(tanulok[i], eredmeny);
                if (eredmeny < 45)
                {
                    alapvizsgaEredmeny.Add(i, alapvizsgaEredmeny2);
                } else
                {
                    alapvizsgaEredmeny.Add(i, alapvizsgaEredmeny2);
                }
            }
            //mysql adatok
            string data = "server=localhost;user=username;database=agazati;port=3306;password=12345;Allow User Variables=true";

            MySqlConnection connect = new MySqlConnection(data);
            try
            {
                //mysql kapcsolat létrehozása
                connect.Open();
                string query;
                int k = 0;
                
                foreach (var item in alapvizsgaEredmeny)
                {
                    Console.WriteLine($"ID:{item.Key}, Neve: {item.Value.ToArray()[k].Key}, Eredmény: {item.Value.ToArray()[k].Value}%");
                    //query = $"INSERT INTO agatazi.tanulok(id,neve,eredmeny) VALUES ({item.Key},{item.Value.ToArray()[k].Key},{item.Value.ToArray()[k].Value});";
                    query = "INSERT INTO tanulok(id,neve,eredmeny) VALUES (@id,@neve,@eredmeny);";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@id", item.Key);
                    cmd.Parameters.AddWithValue("@neve", item.Value.ToArray()[k].Key);
                    cmd.Parameters.AddWithValue("@eredmeny", item.Value.ToArray()[k].Value);
                    cmd.ExecuteNonQuery();
                    k++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            connect.Close();

            Console.ReadKey();

        }
    }
}
