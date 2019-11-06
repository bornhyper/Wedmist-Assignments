using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
   static class Qstn10
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 10. Write program to find number of even digits. eg. Input 423 output 2.");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int evenNumCount = 0;
            while (numInput != 0)
            {
                if ((numInput % 10) % 2 == 0)
                {
                    evenNumCount++;
                }
                numInput = numInput / 10;
            }
            Console.WriteLine("Number of even digits : {0}",evenNumCount);
        }
    }
}
