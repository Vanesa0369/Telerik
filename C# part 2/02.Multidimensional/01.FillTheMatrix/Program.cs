//Write a program that fills and prints a matrix of size (n, n) as shown below.

//Input

//On the first line you will receive the number N
//On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix
//Output

//Print the matrix
//Numbers on a row must be separated by a single spacebar
//Each row must be on a new line




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inputChar = Console.ReadLine();
            Fill(n, inputChar[0]);
        }

        private static void Fill(int n, char c)
        {
            int[,] matrix = new int[n, n];
            switch (c)
            {
                case 'a':
                    int counterA = 1;
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            matrix[col, row] = counterA++;
                        }
                    }
                    Print(matrix);
                    break;
                case 'b':
                    int counterB = 1;
                    bool isOdd = true;
                    for (int row = 0; row < n; row++)
                    {
                        if (isOdd)
                        {
                            for (int col = 0; col < n; col++)
                            {
                                matrix[col, row] = counterB++;
                            }
                        }
                        else
                        {
                            for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
                            {
                                matrix[col, row] = counterB++;
                            }
                        }

                        isOdd = !isOdd;
                    }
                    Print(matrix);
                    break;
                case 'c':
                    int counter = 1;

                    // Print lower left side

                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        for (int col = 0; col < matrix.GetLength(0) - row; col++)
                        {
                            matrix[row + col, col] = counter++;
                        }
                    }

                    // Print upper right side

                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        for (int col = 1; col < matrix.GetLength(1) - row; col++)
                        {
                            matrix[col - 1, col + row] = counter++;
                        }
                    }

                    Print(matrix);
                    break;
                    // TODO : d
                case 'd':
                    int counterD = 1;

                    // Add left side to down

                    for (int bottomRow = 0; bottomRow < 1; bottomRow++)
                    {
                        for (int bottomCol = 0; bottomCol < matrix.GetLength(1); bottomCol++)
                        {
                            matrix[bottomCol, bottomRow] = counterD++;
                        }
                    }

                    // Add bottom side to right

                    for (int bottomRow = 0; bottomRow < 1; bottomRow++)
                    {
                        for (int bottomCol = 0; bottomCol < matrix.GetLength(1) - 1; bottomCol++)
                        {
                            matrix[matrix.GetLength(0) - 1, bottomCol + 1] = counterD++;
                        }
                    }

                    // Add right side to up


                    // TODO : add d point
                    //Add top side to left

                    Print(matrix);
                    break;
                default:
                    break;
            }
        }

        private static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col + 1 != matrix.GetLength(0))
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
//using System;

//class Fill_the_matrix
//{
//    static void Main()
//    {
//        int length = int.Parse(Console.ReadLine());
//        char typeOfMatrix = char.Parse(Console.ReadLine());
//        int[,] matrix = new int[length, length];
//        int count = 1;
//        int col = 0;
//        int row = 0;
//        switch (typeOfMatrix)
//        {
//            case 'a':
//                for (int i = 0; i < length; i++)
//                {
//                    for (int j = 0; j < length; j++)
//                    {
//                        matrix[j, i] = count;
//                        count++;
//                    }
//                }
//                break;
//            case 'b':
//                for (int i = 0; i < length; i++)
//                {
//                    if (i % 2 == 0)
//                    {
//                        for (int j = 0; j < length; j++)
//                        {
//                            matrix[j, i] = count;
//                            count++;
//                        }
//                    }
//                    else
//                    {
//                        for (int j = length - 1; j >= 0; j--)
//                        {
//                            matrix[j, i] = count;
//                            count++;
//                        }
//                    }

//                }
//                break;
//            case 'c':
//                int r = length - 1;
//                int c = 0;
//                int mod = 1;

//                for (int i = 0; i < length * length; i++)
//                {
//                    if (r == length && c < length)
//                    {
//                        mod++;
//                        r = length - mod;
//                        c = 0;
//                    }
//                    else if (c == length && c <= length)
//                    {
//                        mod--;
//                        r = 0;
//                        c = length - mod;
//                    }

//                    matrix[r, c] = i + 1;
//                    r++;
//                    c++;
//                }
//                    break;
//            case 'd':
//                int switcher = length - 1;
//                int counter = 1;

//                row = 0;
//                col = 0;
//                while (switcher > 0)
//                {
//                    for (int x = row; x < switcher + row; x++)
//                    {
//                        matrix[x, row] = counter++;
//                    }

//                    for (int y = row; y < switcher + row; y++)
//                    {
//                        matrix[row + switcher, y] = counter++;
//                    }

//                    for (int bottomRow = length - 1 - row; bottomRow > col; bottomRow--)
//                    {
//                        matrix[bottomRow, switcher + row] = counter++;
//                    }

//                    for (int l = switcher + row; l > row; l--)
//                    {
//                        matrix[col, l] = counter++;
//                    }

//                    row += 1;
//                    col += 1;
//                    switcher -= 2;
//                }
//                break;
//        }
//        for (int i = 0; i < length; i++)
//        {
//            for (int j = 0; j < length; j++)
//            {
//                if (j == 0)
//                {
//                    Console.Write(matrix[i, j]);
//                }
//                else
//                {
//                    Console.Write(" " + matrix[i, j]);
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}