using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var authenticated = false;
            string authLogin = "bathory";
            string authPassword = "12345";
            var fails = 0;

            while (fails < 3 && !authenticated)
            {
                Console.Write("Login: ");
                var login = Console.ReadLine();
                Console.Write("Password: ");
                var password = Console.ReadLine();

                if (login != authLogin || password != authPassword)
                {
                    fails++;
                    Console.WriteLine("Wrong!");
                }
                else
                {
                    authenticated = true;
                    Console.WriteLine("You are in!");
                }
            }

            if (fails == 3)
                Console.WriteLine("Too many attempts!");

            Console.ReadKey();
        }
    }
}
