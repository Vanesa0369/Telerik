
/*Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            long f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                result = result + f / Math.Pow(x, i);
            }
            result = result + 1;
            Console.WriteLine("{0:F5}", result);
        }
        }
    }

