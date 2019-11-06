using System;
using System.Collections.Generic;
using System.Text;

namespace part1_assignment
{
    static class Qstn16
    {
        public static void Answer()
        {
            Console.WriteLine("Question no 16. Read a number.Do half of number after last odd digit. Input 3 times.");
            Console.WriteLine("Input 61389426 output 184167639 (61389213*3). Input 87 output 261. Input 78 output 222 (74*3).");
            Console.WriteLine("\nEnter a number");
            String numInputString = Console.ReadLine();
            int numInput = Convert.ToInt32(numInputString);
            int compareVar;
            int temp = compareVar = numInput;
            int tempMul = 1;
            while (temp != 0)
            {
                int remainder = temp % 10;
                if ((remainder % 2)!=0)
                {
                    break;
                }
                numInput = numInput - ((remainder * tempMul)/2);
                tempMul *= 10;
                temp = temp / 10;
            }
            if (numInput == compareVar / 2)
            {
                Console.WriteLine("No odd numbers are present");
            }
            else
            {
                Console.WriteLine("Final Result : {0}",numInput*3);
            }
        }
    }
}
