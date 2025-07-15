using System;
using System.Collections;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Practical5
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Info On Matrix");

            Console.Write("How many rows for matrix 1:");
            string input = Console.ReadLine();
            int r1, c1, c2;
            r1 = c1 = c2 = 0;
            int.TryParse(input, out r1);

            Console.Write("How many columns for matrix 1:");
            input = Console.ReadLine();
            int.TryParse(input, out c1);

            Console.WriteLine("rows of matrix 2 will be same as columns of matrix 1");
            Console.Write("How many columns for matrix 2:");
            input = Console.ReadLine();
            int.TryParse(input, out c2);

            int[,] m1 = createMatrix(r1, c1);
            int[,] m2 = createMatrix(c1, c2);

            Console.WriteLine("Multiplication result is:");
            printMatrix(MatrixMultiplication(m1, m2));

            Console.WriteLine();
            Console.WriteLine($"Largest number is:{LargestNumber(m1)}");
            Console.WriteLine($"Sum of Corners:{SumOfCornerMatrix(m1)}");
            Console.WriteLine($"Difference of Sum of Diagonal:{DifferenceOfDiagonal(m1)}");
        }

        static int[,] createMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int temp = 0;
                    Console.Write($"Enter Value for position {i + 1},{j + 1}:");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out temp))
                    {
                        matrix[i, j] = int.Parse(input);
                    }
                }
            }

            Console.WriteLine("The Matrix is:");
            printMatrix(matrix);
            return matrix;
        }

        static void printMatrix(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
                
            {
                Console.Write('[');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}, ");
                }
                Console.WriteLine("]");
            }
        }

         //Matrix Multiplication
        static int[,] MatrixMultiplication(int[,] m1, int[,] m2)
        {
            int[,] res = new int[m1.GetLength(0), m2.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    for (int k = 0; k < m1.GetLength(1); k++)
                    {
                        res[i, j] = res[i, j] + (m1[i, k] * m2[k, j]);
                    }
                }

            }
            return res;
        }

        // largest number in matrix
        static int LargestNumber(int[,] matrix) 
        {
            int max = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j=0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        //Sum of Corners
        static int SumOfCornerMatrix(int[,] matrix) {
            int sum = matrix[0, 0]
                + matrix[0, matrix.GetLength(1)-1]
                + matrix[matrix.GetLength(0)- 1, 0]
                + matrix[matrix.GetLength(0) - 1, matrix.GetLength(1)-1];
            return sum;
        }

        //difference of sum of diagonal
        static int DifferenceOfDiagonal(int[,] matrix) 
        {
            int res,d1,d2;
            res = d1 = d2 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        d1 += matrix[i, j];
                    }

                    if (2 - i - j == 0)
                    {
                        d2 += matrix[i, j];
                    }
                }
            }
            res = d2 - d1;
            return res;
        }
    }

}