using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn27
    {
        public static void Answer()
        {
            int rows, cols, i, j;
            Console.Write("Enter the Order of the Matrix : ");
            rows = Convert.ToInt16(Console.ReadLine());
            cols = Convert.ToInt16(Console.ReadLine());
            int[,] matrix = new int[10, 10];
            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix You entered : ");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose Matrix : ");

            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(matrix[j, i] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
