using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn5
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 5. Write program, which will find sum of product to consecutive digits.e.g.when the input");
            Console.WriteLine("is 23145 the output is 2x3 + 3x1 + 1x4 + 4x5 = 33");                   
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int finalResult = 0;
            while (numInput >= 10)
            {
                int remainder = numInput % 100;
                int tempRemainder = remainder % 10;
                remainder = remainder - tempRemainder;
                int consecutiveMul = tempRemainder * ((remainder % 100) / 10);
                finalResult = finalResult + consecutiveMul;
                numInput = numInput / 10;
            }
            if (finalResult == 0)
                Console.WriteLine("Number is one digited");
            else
                Console.WriteLine("Final Result : {0}", finalResult);
        }
    }
}
