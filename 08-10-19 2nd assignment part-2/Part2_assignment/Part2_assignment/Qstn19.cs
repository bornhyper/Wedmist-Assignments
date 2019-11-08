using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn19
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the number of elements of the array you want to create :");
            String input = Console.ReadLine();
            Console.WriteLine();
            int  arrayLength= Convert.ToInt32(input);
            int[] arr = new int[arrayLength];
            int smallestNum=99999999;
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] :",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] < smallestNum)
                    smallestNum = arr[i];
            }

            if (arrayLength == 0)
            {
                Console.WriteLine("There are no elements in the Array.");
            }
            else
            {
                Console.WriteLine("The smallest number is : {0}",smallestNum);
            }
        }
    }
}
