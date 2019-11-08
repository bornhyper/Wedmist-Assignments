using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn22
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the number of elements of the array you want to create :");
            String input = Console.ReadLine();
            Console.WriteLine();
            int arrayLength = Convert.ToInt32(input);
            int[] arr = new int[arrayLength];

            ArrayBasic.create(arr);

            Console.Write("Enter the number you want to search in the Array : ");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            int occurence = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                if (searchNum == arr[i])
                    occurence++;
            }
            if (arrayLength == 0)
            {
                Console.WriteLine("There are no elements in the Array.");
            }
            else
            {
                Console.WriteLine("Number of Occurence : {0}", occurence);
            }
        }
    }
}
