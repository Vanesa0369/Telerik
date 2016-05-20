/*  Write a program that calculates N! / K! for given N and K.
    Use only one loop.1 < K < N < 100 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CalculateAgainF_
{
    class Program
    {
        
             static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            BigInteger division = 1;

            for (int i = K + 1 ; i <= N; i++)
            {
                division = division * i;
            }
            Console.WriteLine(division);
        }
        }
    }



