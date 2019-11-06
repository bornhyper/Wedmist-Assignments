using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn13
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 13. Write program to print the digit immediately after the last even digit.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int digitNextLastEven = -1;
            while (numInput != 0)
            {
                if ((numInput % 10) % 2 == 0)
                {
                    if (digitNextLastEven != -1)
                    {
                        Console.WriteLine("The digit after the last even digit is : {0}", digitNextLastEven);
                        digitNextLastEven = -2;
                    }
                    else
                    {
                        Console.WriteLine("Last digit is even. No digit available after last digit");
                    }
                    break;
                }
                digitNextLastEven = numInput % 10;
                numInput = numInput / 10;
            }
            if (digitNextLastEven > -1)
            {
                Console.WriteLine("No even digits are present in the number");
            }
        }
    }
}
