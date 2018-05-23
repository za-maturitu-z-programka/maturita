using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] analphabet = { 'a', 'á', 'b', 'c', 'č', 'd', 'ď', 'e', 'é', 'ě', 'f', 'g', 'h', 'i', 'í', 'j', 'k', 'l', 'm', 'n', 'ň', 'o', 'ó', 'p', 'q', 'r', 'ř', 's', 'š', 't', 'ť', 'u', 'ú', 'ů', 'v', 'w', 'x', 'y', 'ý', 'z', 'ž'};
            string input, output = "";
            int choice = 0, mod;
            bool shouldConvertCase = false;

            Console.WriteLine("Přejete si šifrovat či dešifrovat text?");
            Console.WriteLine("1 - šifrování\n2 - dešifrování");

            while (choice != 1 && choice != 2)
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Zadal(a) jste neplatný vstup. Opakujte prosím akci.");
            }

            Console.WriteLine("Zadejte požadovaý text:");
            input = Console.ReadLine();

            Console.WriteLine("O kolik jednotek si přejete daný text " + (choice == 1 ? "šifrovat" : "dešifrovat") + "?");

            while (!int.TryParse(Console.ReadLine(), out mod))
            {
                Console.WriteLine("Zadal(a) jste neplatný vstup. Opakujte prosím akci");
            }

            int index;
            char tmp;

            foreach (char c in input)
            {
                tmp = c;

                if (char.IsUpper(c))
                {
                    shouldConvertCase = true;
                    tmp = char.ToLower(c);
                }

                index = Array.IndexOf(analphabet, tmp);

                if (index == -1)
                {
                    output += c;
                    continue;
                }

                tmp = analphabet[choice == 1 ? index + mod : index - mod];

                if (shouldConvertCase)
                {
                    tmp = char.ToUpper(tmp);
                    shouldConvertCase = false;
                }

                output += tmp;

            }

            Console.WriteLine((choice == 1 ? "Šifrovaný" : "Dešifrovaný") + "text: " + output);

            Console.WriteLine("\n\nUkončete program stiskem libovolné klávesy.");
            Console.ReadKey();
        }
    }
}
