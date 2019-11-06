using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn3
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 3. Write program to print the second digit.e.g.input 23516 the output is 3.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);

            while (numInput > 99)
            {
                numInput = numInput / 10;
            }
            Console.WriteLine("The Second number is : {0}", numInput%10);
        }
    }
}
