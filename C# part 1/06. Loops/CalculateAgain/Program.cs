/*  Write a program that calculates N! / K! for given N and K.
    Use only one loop.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            double division = 1;

            for (int i = K + 1 ; i <= N; i++)
            {
                division = division * i;
            }
            Console.WriteLine(division);
        }
    }
}
