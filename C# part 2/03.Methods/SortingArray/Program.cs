
//Write a method that returns the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

//Input

//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the array
//Output

//Print the sorted array
//Elements must be separated by spaces


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
