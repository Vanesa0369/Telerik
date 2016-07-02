//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist). Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

//Input

//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the array
//Output

//Print how many numbers in the array are larger than their neighbours



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(z => int.Parse(z))
                .ToArray();
            int result = CheckNeighbours(array, length);
            Console.WriteLine(result);
        }
        static int CheckNeighbours(int[] array, int length)
        {
            int result = 0;
            for (int i = 1; i < length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    result++;
                }
            }
            return result;
        }
    }
}
