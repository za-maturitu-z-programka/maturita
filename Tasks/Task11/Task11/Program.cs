using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            var number = Convert.ToInt64(Console.ReadLine());

            var tmp = 2;
            while (number != tmp)
            {
                if (number % tmp == 0)
                {
                    number /= tmp;
                    Console.Write(tmp.ToString() + " ");
                }
                else
                {
                    tmp++;
                }
            }

            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
