//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Write a program that reads a string of positive integers separated by spaces and prints their sum.

//Input

//On the only line you will receive a string consisted of positive integers
//Output

//Print the sum of the integers
//Input	Output
//43 68 9 23 318	461





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sum = sumOfNumbers(array);
        Console.WriteLine(sum);
    }
    static int sumOfNumbers(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
        }
    }

