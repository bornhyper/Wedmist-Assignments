using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn1
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 1. Write program to print the kth digit from last.e.g.input 23617 and k = 4 output 3.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            Console.WriteLine("enter the position of the digit you want to display from last digit of the number : ");
            String positionString = Console.ReadLine();
            int position = Convert.ToInt32(positionString);

            while (position > 1)
            {
                numInput = numInput / 10;
                position--;
            }

            if (numInput == 0)
            {
                Console.WriteLine("position is more than number size");
            }
            else
            {
                Console.WriteLine("The digit in the given position is :{0}",numInput%10);
            }
        }
    }
}
