/* 9. Matrix of Numbers
   Write a program that reads from the console a positive integer number N 
   and prints a matrix like in the examples below. Use two nested loops.
   Challenge: achieve the same effect without nested loops.
   Constraints: 1 <= N <= 20. N will always be a valid integer number.
   Examples:
    n = 2   matrix      n = 3   matrix      n = 4   matrix
            1 2                 1 2 3               1 2 3 4
            2 3                 2 3 4               2 3 4 5
                                3 4 5               3 4 5 6
                                                    4 5 6 7                //i=row;j = num; */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                for (int j = i; j < i + n; j++)
                {
                    Console.Write("{0} " , j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
