using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn8
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 8. Write program to find sum of even digits. Input 23617 output 2+6=8.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int res = 0;
            while (numInput != 0)
            {
                if ((numInput % 10) % 2 == 0)
                {
                    res = res + (numInput % 10);
                }
                numInput = numInput / 10;
            }
            Console.WriteLine("Sum of all the even digits are : {0}",res);
        }
    }
}
