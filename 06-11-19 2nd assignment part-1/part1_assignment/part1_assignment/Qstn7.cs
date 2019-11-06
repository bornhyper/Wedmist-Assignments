using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn7
    {
        
       public static void Answer()
        {
            Console.WriteLine("Question no 7. Write program to print positional values of digits. Input 21463 output 3, 60, 400, 1000 and 20000.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            Console.WriteLine("The positional values are :");
            int temp = 1;
            while (numInput != 0)
            {
                Console.WriteLine((numInput%10)*temp);
                numInput = numInput / 10;
                temp = temp * 10;
            }
        }
    }
}
