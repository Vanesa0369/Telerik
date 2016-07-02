//Write a program that allocates array of N integers, initializes each element by its index multiplied by 5
//and the prints the obtained array on the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.AllocateArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
