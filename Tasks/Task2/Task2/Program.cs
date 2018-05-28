using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Note: ");
            var note = Console.ReadLine();

            if (note == "1")
                Console.WriteLine("Excellent");
            else if (note == "2")
                Console.WriteLine("Commendable");
            else if (note == "3")
                Console.WriteLine("Good");
            else if (note == "4")
                Console.WriteLine("Still good");
            else if (note == "5")
                Console.WriteLine("Very bad, you idiot");
            else
                Console.WriteLine("Hey, buddy, wrong input!");

            switch (note)
            {
                case "1":
                    Console.WriteLine("Excellent");
                    break;
                case "2":
                    Console.WriteLine("Commendable");
                    break;
                case "3":
                    Console.WriteLine("Good");
                    break;
                case "4":
                    Console.WriteLine("Still good");
                    break;
                case "5":
                    Console.WriteLine("Very bad, you idiot");
                    break;
                default:
                    Console.WriteLine("Hey, buddy, wrong input!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
