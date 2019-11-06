using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn2
    {
        public static void Answer()
        {
            Console.WriteLine("Question No 2. Write a program to print first digit.e.g.input 23516 output 2.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int firstInt = 0;
            while (numInput != 0)
            {
                firstInt = numInput % 10;
                numInput = numInput / 10;
            }
            Console.WriteLine("The first number is : {0}",firstInt);
        }
    }
}
