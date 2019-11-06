using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn12
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 12. Program to print the digit immediately before the last even digit.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int digitBeforeLastEven = -1;
            while (numInput != 0)
            {                
                if ((numInput%10) % 2 == 0)
                {
                    break;
                }
                numInput = numInput / 10;
            }

            if (numInput == 0)
            {
                Console.WriteLine("No even digits present in the number");

            }
            else
            {
                numInput = numInput / 10;
                digitBeforeLastEven = numInput % 10;
                if (numInput==0)
                {
                    Console.WriteLine("First digit is even. No digit available before first digit");
                }
            
            else
                Console.WriteLine("The digit before the last even number is {0}", digitBeforeLastEven);
            }

        }
    }
}
