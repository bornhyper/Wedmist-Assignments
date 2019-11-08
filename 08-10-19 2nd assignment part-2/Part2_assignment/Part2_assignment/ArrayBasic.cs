using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
   static class ArrayBasic
    {
        public static void Display(int []arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
        }

        public static void create(int []arr)
        {
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[{0}] :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
