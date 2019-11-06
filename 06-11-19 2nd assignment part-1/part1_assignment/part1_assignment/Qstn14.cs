using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn14
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 14. Write program to print the last digit, which is multiple of 3. e.g.input 23617 output 6.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int divdigitLast = -1;
            while (numInput != 0)
            {
                if ((numInput % 10) % 3 == 0)
                {
                    divdigitLast = numInput % 10;
                    break;
                }
                numInput = numInput / 10;
            }
            if (divdigitLast == -1)
                Console.WriteLine("There are no even digits present in this number");
            else
                Console.WriteLine("The last digit divisible by 3 is :{0}", divdigitLast);
        }
    }
}
