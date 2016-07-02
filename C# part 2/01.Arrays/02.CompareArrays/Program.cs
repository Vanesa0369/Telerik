//Write a program that reads two integer arrays of size N from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int[] arr1 = new int[n];
            bool isEqual = true;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                 if (arr[i] != arr1[i])
                {
                    isEqual = false;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}

