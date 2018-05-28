using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");

            var number = Console.ReadLine();

            Console.WriteLine("From decimal to custom: 1\nFrom custom to decimal: 2");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.Write("To: ");
                    var to = Console.ReadLine();

                    Console.WriteLine(ConvertToBase(int.Parse(to), int.Parse(number)));
                    break;

                case "2":
                    Console.Write("From: ");
                    var from = Console.ReadLine();

                    Console.WriteLine(ConvertFromBase(int.Parse(from), number));
                    break;
            }

            Console.ReadKey();
        }

        static string ConvertToBase(int numberOfBase, int value)
        {
            Stack<char> result = new Stack<char>();

            while (value > 0)
            {
                int rest = value % numberOfBase;
                result.Push(rest > 9 ? Convert.ToChar(rest + 55) : rest.ToString()[0]);
                value = (value - rest) / numberOfBase;
            }

            return new string(result.ToArray());
        }

        static int ConvertFromBase(int numberOfBase, string value)
        {
            int result = 0;

            foreach (char rough in value.Substring(0, value.Length - 1))
                result = (result + GetNumber(rough)) * numberOfBase;

            return result + GetNumber(value[value.Length - 1]);
        }

        static int GetNumber(char val)
        {
            try
            {
                return int.Parse(val.ToString());
            }
            catch
            {
                return (int)val - 55;
            }
        }
    }
}
