using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn31
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

            Insertion(arr);

            Console.WriteLine("After Sorting :");
            ArrayBasic.Display(arr);
        }

        public static void Insertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int val = arr[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
        }
    }
}
