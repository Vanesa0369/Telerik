//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.
//Input

//On the first line you will receive the number N
//On the second line you will receive the number K
//On the next N lines the numbers of the array will be given
//Output

//Print the maximal sum of K elements in the array


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int result = 0;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = n - 1; i >= n - k; i--)
        {
            result += arr[i];
        }
        Console.WriteLine(result);
    }
        }
    }

