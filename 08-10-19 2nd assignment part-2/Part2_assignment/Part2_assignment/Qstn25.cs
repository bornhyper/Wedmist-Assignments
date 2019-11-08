using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_assignment
{
    static class Qstn25
    {
        public static void Answer()
        {
            int rows, cols;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            rows = Convert.ToInt16(Console.ReadLine());
            cols = Convert.ToInt16(Console.ReadLine());
            int[,] matrix1 = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] matrix2 = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix B: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int[,] C = new int[10, 10];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    C[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.Write("\nSum Matrix : \n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
