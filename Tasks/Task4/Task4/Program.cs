using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Range from: ");
            var from = Convert.ToInt32(Console.ReadLine());
            Console.Write("Range to: ");
            var to = Convert.ToInt32(Console.ReadLine());

            for (var i = from; i <= to; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();

            var j = from;
            while (j <= to)
            {
                if (j % 2 == 0)
                    Console.Write(j.ToString() + " ");
                j++;
            }
            Console.WriteLine();

            var k = from;
            do
            {
                if (k % 2 == 0)
                    Console.Write(k.ToString() + " ");
                k++;
            } while (k <= to);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
