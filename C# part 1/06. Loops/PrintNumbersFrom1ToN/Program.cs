/* 1. Numbers from 1 to N
   Write a program that enters from the console a positive integer n. N will be a valid positive 32-bit integer. 
   and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintNumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
