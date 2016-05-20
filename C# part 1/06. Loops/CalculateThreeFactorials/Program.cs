/*In combinatorics, the number of ways to choose N different members out of a group of N 
different elements (also known as the number of combinations) is calculated by the following 
formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard 
deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for 
given N and K.
Try to use only two loops.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace CalculateThreeFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            BigInteger kFact = 1;
            
            
            for (int i = K + 1; i <= N; i++)
            {
                kFact = kFact * i;
            }
            for (int j = 2; j <= (N - K); j++)
            {
                nFact = nFact * j;
            }
            BigInteger result = kFact / nFact;
            Console.WriteLine(result);
        }
    }
}
