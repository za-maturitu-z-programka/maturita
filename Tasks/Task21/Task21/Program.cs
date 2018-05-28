using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string path, line, parsed;

            Console.WriteLine("Zadejte cestu k HTML souboru, který si přejete parsovat:");

            while (!File.Exists(path = Console.ReadLine()))
            {
                Console.WriteLine("Zadal jste cestu k neexistujícímu souboru, opakujte prosím akci.");
            }

            Console.WriteLine("Vyparsované HTML: \n");

            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(Regex.Replace(line, "<[^>]*>", ""));
                }
            }

            Console.WriteLine("\n\n Program ukončíte stiskem libovolné klávesy.");
            Console.ReadKey();
        }
    }
}
