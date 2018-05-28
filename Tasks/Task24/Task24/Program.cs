using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath, outputPath, line;

            Console.WriteLine("Zadejte cestu csv souboru k parsování: ");

            while (!File.Exists(inputPath = Console.ReadLine()))
            {
                Console.WriteLine("Zadal jste cestu k neexistujícímu souboru. Opakujte prosím akci.");
            }

            Console.WriteLine("Zadejte cestu, kam má být uložen vyparsovaný soubor: ");

            outputPath = Console.ReadLine();

            using (StreamReader sr = new StreamReader(inputPath))
            {
                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    sw.Flush();
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line.Replace(";", "\r\n"));
                        sw.WriteLine();
                    }
                }
            }

            Console.WriteLine("Program ukončíte stiskem libovolné klávesy.");
            Console.ReadLine();
        }
    }
}
