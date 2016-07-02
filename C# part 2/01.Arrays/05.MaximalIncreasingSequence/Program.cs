//Write a program that finds the length of the maximal increasing sequence in an array of N integers.
//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the length of the maximal increasing sequence
//Constraints

//1 <= N <= 1024



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
 
            int[] array = new int[N];
 
            int seq = 1;
            int maxSeq = 1;
 
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
 
            for (int i = 1; i < N; i++)
            {
                if(array[i] > array[i - 1])
                {
                    seq++;
                    if(seq > maxSeq)
                    {
                        maxSeq = seq;
                    }
                }
                else
                {
                    seq = 1;
                }
            }
            Console.WriteLine(maxSeq);
        }
    }
}
