using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            var number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(string.Format("{0:n0}", number));
            Console.ReadKey();
        }
    }
}
