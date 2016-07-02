//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.

//Input

//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M numbers separated with spaces - the elements of the matrix
//Output

//Print the maximal sum of 3 x 3 square



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO : 80/100 fix :(
            // Read input
            int[] nAndM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nAndM[0];
            int m = nAndM[1];
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] currentLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < currentLine.Length; i++)
                {
                    matrix[row, i] = currentLine[i];
                }
            }

            // Find sum
            int maxSum = int.MinValue;
            int currentSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = matrix[row, col]
                                + matrix[row, col + 1]
                                + matrix[row, col + 2]
                                + matrix[row + 1, col]
                                + matrix[row + 1, col + 1]
                                + matrix[row + 1, col + 2]
                                + matrix[row + 2, col]
                                + matrix[row + 2, col + 1]
                                + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
        
