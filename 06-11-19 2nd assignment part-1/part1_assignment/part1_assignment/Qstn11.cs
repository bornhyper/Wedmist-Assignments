using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn11
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 11. Write program to print the last even digit. e.g.input 23613 output 6.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int evenDigitLast = -1;
            while (numInput != 0)
            {
                if ((numInput % 10) % 2 == 0)
                {
                    evenDigitLast = numInput % 10;
                    break;
                }
                numInput = numInput / 10;
            }
            if (evenDigitLast == -1)
                Console.WriteLine("There are no even digits present in this number");
            else
                Console.WriteLine("The last even digit is :{0}",evenDigitLast);
        }
    }
}
