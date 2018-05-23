using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16___C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int i, length, max = int.MinValue, min = int.MaxValue, sum = 0;
            int[] nums;
            double avg, med;

            Console.WriteLine("Kolikarozměrné pole si přejete vygenerovat?");

            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Zadal(a) jste neplatnou délku pole. Opakujte prosím akci");
            }

            nums = new int[length];

            Console.Write("Vygenerovaná číslá jsou:");

            for (i = 0; i < length; i++)
            {
                nums[i] = r.Next(100);
                Console.Write(" " + nums[i]);

                if (i != length - 1)
                {
                    Console.Write(",");
                }

                if (nums[i] < min)
                {
                    min = nums[i];
                }

                if (nums[i] > max)
                {
                    max = nums[i];
                }

                sum += nums[i];
            }

            Array.Sort(nums);

            avg = (float)sum / length;

            if ((length % 2) == 0)
            {
                med = (float)(nums[length / 2 - 1] + nums[length / 2]) / 2;
            }
            else
            {
                med = nums[(length + 1) / 2 - 1];
            }

            Console.WriteLine(String.Format(@"
Minimum: {0}
Maximum: {1}
Průměr: {2:0.00}
Medián: {3:0.00}", min, max, avg, med));

            Console.WriteLine("Program ukončíte stiskem libovolné klávesy.");
            Console.ReadKey();
        }
    }
}
