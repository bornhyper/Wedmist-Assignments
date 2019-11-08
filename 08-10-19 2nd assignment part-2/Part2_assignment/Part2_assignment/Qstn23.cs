using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn23
    {
        public static void Answer()
        {
            int numberInput, remainder, sum = 0, compareValue;
            Console.Write("Enter the Number: ");
            numberInput = int.Parse(Console.ReadLine());
            compareValue = numberInput;
            while (numberInput > 0)
            {
                remainder = numberInput % 10;
                sum = (sum * 10) + remainder;
                numberInput = numberInput / 10;
            }
            if (compareValue == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }
}
