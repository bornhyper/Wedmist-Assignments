using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn15
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 15. Write program to print the second last even digit.e.g.input 23863 output 8. Input 325145761 output 4.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int evenDigitSecondLast = -1;
            while (numInput != 0)
            {
                int remainder = numInput % 10;
                numInput = numInput / 10;
                if (remainder  % 2 == 0)
                {
                    break;
                }
                
            }

            while (numInput != 0)
            {
                if ((numInput % 10) % 2 == 0)
                {
                    evenDigitSecondLast = numInput % 10;
                    Console.WriteLine("Second last even digit is : {0}", evenDigitSecondLast);
                    break;
                }
                numInput = numInput / 10;
            }

            if (evenDigitSecondLast == -1)
                Console.WriteLine("Second last even digit is not present");
        }
    }
}
