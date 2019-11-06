using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn18
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 18.Find sum of numbers formed by exchanging consecutive digits.In 2415 output 42+14+51=107.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int finalResult = 0;
            while (numInput >= 10)
            {
                int remainder = numInput % 100;

                //inverting the remainder
                int tempRemainder = remainder % 10;
                remainder = remainder - tempRemainder;
                remainder = tempRemainder * 10 + (remainder % 100)/10;
            
                finalResult = finalResult + remainder;
                numInput = numInput / 10;
            }
            if (finalResult == 0)
                Console.WriteLine("Number is one digited");
            else
                Console.WriteLine("Final Result : {0}", finalResult);
        }
    }
}
