//Write a program that compares two char arrays lexicographically (letter by letter).
//Input

//On the first line you will receive the first char array as a string
//On the second line you will receive the second char array as a string
//Output

//Print < if the first array is lexicographically smaller
//Print > if the second array is lexicographically smaller
//Print = if the arrays are equal

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string purvi = Console.ReadLine();
            string vtori = Console.ReadLine();
            char[] purviCharArray = purvi.ToCharArray();
            char[] secondCharArray = vtori.ToCharArray();
            int n = Math.Min(purvi.Length, secondCharArray.Length);
            string result = "=";
            for (int i = 0; i < n; i++)
            {
                if (purvi[i] > secondCharArray[i])
                {
                    result = ">";
                    break;
                }
                if (purvi[i] < secondCharArray[i])
                {
                    result = "<";
                    break;
                }
            }
            if (result == "=")
            {
                if (purviCharArray.Length > secondCharArray.Length)
                {
                    result = ">";
                }
                if (purviCharArray.Length < secondCharArray.Length)
                {
                    result = "<";
                }
            }
            Console.WriteLine(result);

        }
    }
}
