using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprogramming
{
    internal class PerfectNumber
    {
        public static void DisplayPerfectnumber()
        {
            int num, sum = 0, n;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            n = num;

            for (int i = 1; i < num; i++)
            { 
                if (num % i == 0)
                {
                    sum = sum + i;
                }
                if (sum == n)
                {
                    Console.WriteLine("\n Enter a number is perfect number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n Enter a number is not  perfect number");
                    Console.ReadLine();
                }
            }

        }
    }
}
