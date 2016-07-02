//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the maximal sum of consecutive numbers




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int totalMax = arr[0];
            int currentMax = arr[0];
            for (int j = 1; j < n; j++)
            {

                currentMax = Math.Max(arr[j], currentMax + arr[j]);
                totalMax = Math.Max(currentMax, totalMax);
            }
            Console.WriteLine(totalMax);
        }
    }
}
