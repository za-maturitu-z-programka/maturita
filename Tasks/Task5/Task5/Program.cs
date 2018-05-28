using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Year: ");
            var year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Oh, yeah!");
            }
            else
            {
                Console.WriteLine("Nope, don't think so");
            }

            Console.ReadKey();
        }
    }
}
