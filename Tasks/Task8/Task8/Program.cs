using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter birth ID: ");
            var id = Console.ReadLine();
            var female = false;
            var number = Int64.Parse(id.Replace("/", ""));
            var before = id.Split('/')[0];
            var after = id.Split('/')[1];
            var year = int.Parse(before.Substring(0, 2));
            var month = int.Parse(before.Substring(2, 2));
            var day = int.Parse(before.Substring(4, 2));

            if (number % 11 != 0)
            {
                Console.WriteLine("Should be divided by 11");
                Console.ReadKey();
                return;
            }

            if (before.Length != 6 || after.Length != 4)
            {
                Console.WriteLine("Wrong length");
                Console.ReadKey();
                return;
            }

            if (month > 50)
            {
                month -= 50;
                female = true;
            }

            var date = new DateTime(year > 18 ? 1900 + year : 2000 + year, month, day);

            Console.WriteLine("Birth date: " + date.ToLocalTime());
            Console.WriteLine("Gender: " + (female ? "female" : "male"));
            Console.ReadKey();
        }
    }
}
