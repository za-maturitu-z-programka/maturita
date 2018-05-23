using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts;
            string[] prettyMonths = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
            int day, month, year;

            while (true)
            {
                Console.WriteLine("Zadejte datum ve formátu dd/mm/rr popř. dd/mm/rrrr: ");
                parts = Console.ReadLine().Split('/');

                if (parts.Length != 3)
                {
                    Console.WriteLine("\nDatum není v platném formátu!");
                    continue;
                }

                day = Int32.Parse(parts[0]);
                month = Int32.Parse(parts[1]);
                year = Int32.Parse(parts[2]);

                if (year < 100)
                { 
                    if (year <= DateTime.Now.Year % 100)
                    {
                        year += 2000;
                    }
                    else
                    {
                        year += 1900;
                    }
                }

                if ((day > 32 || day < 1 || month > 12 || month < 1 || year < 1)
                    || (day == 31 && (month % 2) == 0)
                    || (month == 2 && day > 28 && (year % 4) != 0)
                    )
                {
                    Console.WriteLine("\nDatum není v platném formátu!");
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine("Output: " + day + ". " + prettyMonths[month - 1] + " " + year);

            Console.WriteLine("\n\nUkončete program stiskem libovolné klávesy.");
            Console.ReadKey();
        }
    }
}
