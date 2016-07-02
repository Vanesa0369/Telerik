//Write a method that counts how many times given number appears in a given array. Write a test program to check if the method is working correctly.

//Input

//On the first line you will receive a number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the numbers in the array
//On the third line you will receive a number X
//Output

//Print how many times the number X appears in the array




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppearanceCount
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
            int X = int.Parse(Console.ReadLine());
            int result = AppearanceSearcher(array, X, length);
            Console.WriteLine(result);
        }


        static int AppearanceSearcher(int[] array, int X, int length)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] == X)
                {
                    count++;
                }
            }
            return count;
        }
    }
        }
    
