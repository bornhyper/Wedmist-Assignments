using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
   static class Qstn17
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 17. Write program, which finds the sum of numbers formed by consecutive digits ");
            Console.WriteLine("Input 2415 output 24+41+15=80.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int finalResult = 0;
            while (numInput >= 10)
            {
                int remainder = numInput % 100;
                finalResult = finalResult + remainder;
                numInput = numInput / 10;
            }
            if (finalResult == 0)
                Console.WriteLine("Number is one digited");
            else
                Console.WriteLine("Final Result : {0}",finalResult);
        }
    }
}
