using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
   static class Qstn9
    {
        public static void Answer()
        {
            Console.WriteLine("Quedtion no 9. Write program to find number of digits.Input 423 output 3. Input 21151 output 5.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int digitCount = 0;
            while (numInput != 0)
            {
                numInput = numInput / 10;
                digitCount++;
            }
            Console.WriteLine("Number of digits : {0}",digitCount);
        }
    }
}
