using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn4
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 4. Write program to find sum of all digits.Input 23617 output 2+3+6+1+7=19.");
            Console.WriteLine("Enter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int sum = 0;

            while (numInput != 0)
            {
                sum = sum + numInput % 10;
                numInput = numInput / 10;
            }
            Console.WriteLine("Sum of the digits is : {0}",sum);
        }
    }
}
