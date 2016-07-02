//Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

//Input

//On the first line you will receive 3 integers separated by spaces
//Output

//Print the largest of them




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] array = input.Split(' ')
            .Select(z => int.Parse(z))
            .ToArray();
            int larger = GetLarger(array[0], array[1]);
        larger = GetLarger(larger, array[2]);
        Console.WriteLine(larger);

        }

        static int GetLarger(int fNumber, int secNumber)
        {
            int larger = Math.Max(fNumber, secNumber);
            return larger;

        }


    }
}
