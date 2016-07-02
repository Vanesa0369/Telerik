

////Write a program that finds the most frequent number in an array of N elements.

////Input

////On the first line you will receive the number N
////On the next N lines the numbers of the array will be given
////Output

////Print the most frequent number and how many time it is repeated
////Output should be REPEATING_NUMBER (REPEATED_TIMES times)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxNum = 0;
            int maxCount = 1;
            int currentCount = 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                int currentNumber = arr[j];
                for (int k = j + 1; k < n; k++)
                {
                    if (arr[j] == arr[k])
                    {
                        currentCount++;
                    }
                }
                if (currentCount > maxCount)
                {
                    maxNum = arr[j];
                    maxCount = currentCount;

                }
                currentCount = 1;
            }
            Console.WriteLine("{0} ({1} times)", maxNum, maxCount);
        }
    }
}
