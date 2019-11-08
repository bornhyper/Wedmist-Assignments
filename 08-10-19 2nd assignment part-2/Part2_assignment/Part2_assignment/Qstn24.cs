using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn24
    {
        public static void Answer()
        {
            Console.WriteLine("Enter the number of elements of the first array you want to create :");
            String input1 = Console.ReadLine();
            Console.WriteLine();
            int arrayLength1 = Convert.ToInt32(input1);
            int[] arr1 = new int[arrayLength1];

            ArrayBasic.create(arr1);

            Console.WriteLine("Enter the number of elements of the second array you want to create :");
            String input2 = Console.ReadLine();
            Console.WriteLine();
            int arrayLength2 = Convert.ToInt32(input2);
            int[] arr2 = new int[arrayLength2];

            ArrayBasic.create(arr2);

            Qstn30.selection(arr1);
            Qstn30.selection(arr2);

            Console.WriteLine("\n\nMerging..........");
            int [] arrMerged = new int [arrayLength1 + arrayLength2];
            int temp1=0, temp2=0;
            for (int i = 0; i < arrayLength1 + arrayLength2; i++)
            {
                if (temp1 < arrayLength1 && temp2 < arrayLength2)
                {
                    if (arr1[temp1] <= arr2[temp2])
                    {
                        arrMerged[i] = arr1[temp1++];
                    }
                    else
                    {
                        arrMerged[i] = arr2[temp2++];
                    }
                }

                else
                {
                    if (temp1 < arrayLength1)
                    {
                        arrMerged[i] = arr1[temp1++];
                    }
                    else
                    {
                        arrMerged[i] = arr2[temp2++];
                    }
                }
            }

        
            Console.WriteLine("The merged array is :");
            ArrayBasic.Display(arrMerged);
        }
    }
}
