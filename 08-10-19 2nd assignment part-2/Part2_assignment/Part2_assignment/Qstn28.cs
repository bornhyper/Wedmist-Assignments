using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    class Qstn28
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the number of elements of the array you want to create :");
            String input = Console.ReadLine();
            Console.WriteLine();
            int arrayLength = Convert.ToInt32(input);
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter the elements in sorted order:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the number you want to search in the Array : ");
            int searchNum = Convert.ToInt32(Console.ReadLine());

            int position = BinarySearchDisplay(arr, searchNum);

            if (position == -1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine("Found at position Number : {0}",position);
        }

        public static int BinarySearchDisplay(int[] arr, int key)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return -1;
        }
    }
}
