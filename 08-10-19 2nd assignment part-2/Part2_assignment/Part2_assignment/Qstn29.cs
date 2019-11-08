using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    class Qstn29
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the number of elements of the array you want to create :");
            String input = Console.ReadLine();
            Console.WriteLine();
            int arrayLength = Convert.ToInt32(input);
            int[] arr = new int[arrayLength];

            ArrayBasic.create(arr);

            Console.WriteLine("Before Sorting :");
            ArrayBasic.Display(arr);

            Bubble(arr);

            Console.WriteLine("\nAfter Sorting :");
            ArrayBasic.Display(arr);
        }

        public static void Bubble(int[] arr)
        {

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int k = 0; k <= arr.Length - 2; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        int temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }

        }
    }
}
