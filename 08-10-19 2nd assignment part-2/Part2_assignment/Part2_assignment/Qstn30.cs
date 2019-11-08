using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn30
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the number of elements of the array you want to create :");
            String input = Console.ReadLine();
            Console.WriteLine();
            int arrayLength = Convert.ToInt32(input);
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting :");
            ArrayBasic. Display(arr);

            selection(arr);

            Console.WriteLine("\nAfter Sorting :");
            ArrayBasic.Display(arr);
        }

        public static void selection(int[] arr)
        {
            int temp, smallest;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
