using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprogramming
{
    internal class FibbonacciSeries
    {
        public void DisplayFibbonacci()
        {
            int firstNumber = 0, secondNumber = 1, thirdNumber = 2, nextNumber, numberOfElements;
            Console.WriteLine("Enter the number of elements: ");
            numberOfElements = int.Parse(Console.ReadLine());
            if(numberOfElements < 0)
            {
                Console.WriteLine("Enter a number greater than zero");
            }
            else
            {
                Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber + " ");

                for (int i =0; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber + thirdNumber;
                    Console.WriteLine(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = nextNumber;

                }
            }







        }
    }
}
