using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloadas03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a hónap számát: ");
            byte honapSzama = byte.Parse(Console.ReadLine());
            string honap;
            if (honapSzama == 1)
            {
                honap = "január";
            }
            else
            {
                if (honapSzama == 2)
                {
                    honap = "február";
                }
                else
                {
                    if (honapSzama == 3)
                    {
                        honap = "március";
                    }
                    else
                    {
                        if (honapSzama == 4)
                        {
                            honap = "április";
                        }
                        else
                        {
                            if (honapSzama == 5)
                            {
                                honap = "május";
                            }
                            else
                            {
                                if (honapSzama == 6)
                                {
                                    honap = "június";
                                }
                                else
                                {
                                    if (honapSzama == 7)
                                    {
                                        honap = "július";
                                    }
                                    else
                                    {
                                        if (honapSzama == 8)
                                        {
                                            honap = "augusztus";
                                        }
                                        else
                                        {
                                            if (honapSzama == 9)
                                            {
                                                honap = "szeptember";
                                            }
                                            else
                                            {
                                                if (honapSzama == 10)
                                                {
                                                    honap = "október";
                                                }
                                                else
                                                {
                                                    if (honapSzama == 11)
                                                    {
                                                        honap = "november";
                                                    }
                                                    else
                                                    {
                                                        if (honapSzama == 12)
                                                        {
                                                            honap = "december";
                                                        }
                                                        else
                                                        {
                                                            honap = "Hibás hónapszámot adtál meg!";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(honap);


            switch (honapSzama)
            {
                case 1:
                    Console.WriteLine("Január");
                    break;
                case 2:
                    Console.WriteLine("Február");
                    break;
                case 3:
                    Console.WriteLine("Március");
                    break;
                case 4:
                    Console.WriteLine("Április");
                    break;
                case 5:
                    Console.WriteLine("Május");
                    break;
                case 6:
                    Console.WriteLine("Június");
                    break;
                case 7:
                    Console.WriteLine("Július");
                    break;
                case 8:
                    Console.WriteLine("Augusztus");
                    break;
                case 9:
                    Console.WriteLine("Szeptember");
                    break;
                case 10:
                    Console.WriteLine("Október");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Hibás a hónap száma(1-12)");
                    break;
            }



            Console.ReadKey();
        }
    }
}
