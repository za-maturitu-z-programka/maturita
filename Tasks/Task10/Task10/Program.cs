using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal: ");
            var decS = Console.ReadLine();
            Console.Write("Enter number of places: ");
            var places = Console.ReadLine();
            var dec = new Decimal();

            try
            {
                dec = Decimal.Parse(decS);
                Int32.Parse(places);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format error");
            }

            Console.WriteLine(dec.ToString("N" + places));

            Console.ReadKey();
        }
    }
}
