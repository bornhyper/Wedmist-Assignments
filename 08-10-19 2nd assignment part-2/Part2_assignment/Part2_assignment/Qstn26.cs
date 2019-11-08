using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    class Qstn26
    {
        public static void Answer()
        {
            int i, j, rows, cols;
            Console.WriteLine("Enter the Number of Rows and Columns : ");
            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[rows, cols];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            int[,] matrix2 = new int[rows, cols];
            Console.WriteLine("Enter the Second Matrix");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("First matrix is:");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is :");
            int[,] matrix3 = new int[rows, cols];
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(matrix3[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
