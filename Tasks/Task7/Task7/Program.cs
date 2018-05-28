using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose size of matrix: ");
            var size = int.Parse(Console.ReadLine());
            var matrix0 = new int[size, size];
            var matrix1 = new int[size, size];
            var rnd = new Random();

            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    matrix0[x, y] = rnd.Next(1, 9);
                }
            }

            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    Console.Write(matrix0[x, y].ToString() + ", ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    matrix1[x, y] = rnd.Next(1, 9);
                }
            }

            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    Console.Write(matrix1[x, y].ToString() + ", ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    Console.Write((matrix0[x, y] + matrix1[x, y]).ToString() + ", ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
