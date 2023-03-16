using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Drawing;
using SnakeServer;

namespace SnakeServer
{
    internal class ClientCom
    {
        StreamReader r = null;
        StreamWriter w = null;
        Random rnd = new Random();

        public ClientCom(TcpClient clinet)
        {
            r = new StreamReader(clinet.GetStream(), Encoding.UTF8);
            w = new StreamWriter(clinet.GetStream(), Encoding.UTF8);
        }

        public void ComStart()
        {
            w.WriteLine("Start");
            w.WriteLine("Szerver neve: SnakeServer 0.0.1");
            w.WriteLine($"Kliens száma: {SnakeServer.Program.cn}");
            w.WriteLine(SnakeServer.Program.cn);
            w.WriteLine("Stop");
            w.Flush();
            bool end = false;
            while (!end)
            {
                lock (Program.almak)
                {
                    if (Program.almak.Count == 0)
                    {
                        for (int i = 0; i < 5 + Program.level; i++)
                        {
                            Point almaKoordi = new Point(rnd.Next(1, Console.WindowWidth), rnd.Next(1, Console.WindowHeight - 1));
                        }
                        Program.level++;
                    }
                }
                try
                {
                    string command = r.ReadLine();
                    if (command != null)
                    {
                        string[] parameters = command.Split('|');
                        switch (parameters[0])
                        {
                            case "Test":
                                {
                                    w.WriteLine("Teszt");
                                    break;
                                }
                            case "Exit":
                                {
                                    //end = true;
                                    w.WriteLine("Exit....");
                                    Program.kigyok.Remove(int.Parse(parameters[1]));
                                    ///Disconnect();
                                    break;
                                }
                            case "KigyoAdat":
                                {
                                    List<Point> egyKigyo = new List<Point>();
                                    string[] adatok = parameters[1].Split(';');
                                    int egyKigyoSzama = int.Parse(adatok[0]);
                                    for (int i = 1; i < adatok.Length; i++)
                                    {
                                        string[] koordinatak = adatok[i].Split('-');
                                        Point koordinata = new Point(int.Parse(koordinatak[0]), int.Parse(koordinatak[1]));
                                        egyKigyo.Add(koordinata);
                                        Program.almak.Add(koordinata);
                                    }
                                    Program.kigyok[egyKigyoSzama] = egyKigyo;
                                    foreach (var item in Program.kigyok)
                                    {
                                        Console.WriteLine(item.Key);
                                    }
                                    break;

                                }
                            case "send":
                                {
                                    int kigyoSzama = int.Parse(parameters[1]);
                                    w.WriteLine("Start");
                                    foreach (var item in Program.kigyok)
                                    {
                                        if (item.Key != kigyoSzama)
                                        {
                                            string kigyoAdatai = $"{item.Key};{item.Value}";
                                            w.WriteLine(kigyoAdatai);
                                            foreach (var koordinatak in item.Value)
                                            {
                                                kigyoAdatai += $";{koordinatak.X};{koordinatak.Y}";
                                            }
                                        }
                                    }
                                    w.WriteLine("Stop");
                                    break;
                                }
                            case "almak":
                                {
                                    string almak = "";
                                    foreach (var item in Program.almak)
                                    {
                                        almak += $";{item.X}-{item.Y};";
                                    }
                                    w.WriteLine(almak);
                                    break;
                                }
                            case "almaEves":
                                {
                                    string[] koordinatak = parameters[1].Split('-');
                                    Point koordi = new Point(int.Parse(koordinatak[0]), int.Parse(koordinatak[1]));
                                    lock (Program.almak)
                                    {
                                        Program.almak.Remove(koordi);
                                    }
                                    break;
                                }

                            default:
                                {
                                    w.WriteLine("Error. Hibás utasítás!");
                                    break;
                                }
                        }
                        w.Flush();
                    }
                }
                catch (Exception ex)
                {
                    //SnakeServer.Program.thread1.Abort();
                }
            }
        }

        void Disconnect()
        {
            Console.WriteLine("Kliens lecsatlakozott...");
        }
    }
}
