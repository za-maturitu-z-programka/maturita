using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15___C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v programu pro řešení kvadratické rovnice\nve tvaru ax^2 + bx +c = 0");

            int a, b, c, shouldContinue;
            double out1, out2, det;

            while (true)
            {
                Console.WriteLine("Zadejte koeficient a: ");
                a = parseInteger();

                Console.WriteLine("Zadejte koeficient b: ");
                b = parseInteger();

                Console.WriteLine("Zadejte koeficient c: ");
                c = parseInteger();

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Řešením jsou všechna reálná čísla");
                        }
                        else
                        {
                            Console.WriteLine("Řešením je prázdná množina");
                        }
                    }
                    else if (c == 0)
                    {
                        Console.WriteLine("Řešením je 0");
                    }
                    else
                    {
                        out1 = -(c / b);
                        Console.WriteLine(String.Format("Řešením je {0:0.00}", out1));
                    }
                }
                else if (c == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Řešením je 0");
                    }
                    else
                    {
                        out1 = -(b / a);
                        Console.WriteLine(String.Format("Řešením je 0 a {0:0.00}", out1));
                    }
                }
                else if (b == 0)
                {
                    out1 = -(c / a);

                    if (out1 < 0)
                    {
                        Console.WriteLine("Řešení se nachází v oboru komplexních čísel");
                    }
                    else
                    {
                        out1 = Math.Sqrt(out1);
                        Console.WriteLine(String.Format("Řešením je {0:0.00} a {1:0.00}", out1, -out1));
                    }
                }
                else
                {
                    det = b * b - 4 * a * c;
                    if (det < 0)
                    {
                        Console.WriteLine("Řešení se nachází v oboru komplexních číšel");
                    }
                    else if (det == 0)
                    {
                        out1 = -(b / (2 * a));
                        Console.WriteLine(String.Format("Řešením je dvojnásobný kořen {0:0.00}", out1));
                    }
                    else
                    {
                        out1 = (-b + Math.Sqrt(det)) / (2 * a);
                        out2 = (-b - Math.Sqrt(det)) / (2 * a);

                        Console.WriteLine(String.Format("Řešením je {0:0.00} a {1:0.00}", out1, out2));
                    }
                }

                Console.WriteLine("\n\nPřejete si zadat nové koeficienty? (1 - ano, 0 - ne)");

                shouldContinue = parseInteger();

                if (shouldContinue != 1)
                {
                    break;
                }
            }

            Console.WriteLine("Ukončete program stiskem libovolné klávesy.");
            Console.ReadKey();
        }

        static int parseInteger()
        {
            int output;

            while (!int.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Zadal(a) jste neplatné číslo\nOpakujte prosím akci: ");
            }

            return output;
        }
    }
}
