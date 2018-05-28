using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path, line;
            int words, lines, chars;

            words = chars = lines = 0;

            Console.WriteLine("Zadejte cestu k souboru: ");
            while (!File.Exists(path = Console.ReadLine()))
            {
                Console.WriteLine("Zadal(a) jste cestu k neexistujícímu souboru. Opakujte prosím akci.");
            }

            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    chars += line.Length;

                    line = Regex.Replace(line, @"\s+", " ");
                    words += line.Count(f => f == ' ') + 1;
                    lines++;
                }
            }

            Console.WriteLine(String.Format(@"
Soubor: {0}
Počet řádek: {1}
Počet slov: {2}
Počet znaků: {3}", path, lines, words, chars));

            Console.WriteLine("\nProgram ukončíte stiskem libovolné klávesy");
            Console.ReadKey();
        }
    }
}
