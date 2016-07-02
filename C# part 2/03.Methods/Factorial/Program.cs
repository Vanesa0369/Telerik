//Write a method that multiplies a number represented as an array of digits by a given integer number. Write a program to calculate N!.

//Input

//On the first line you will receive the number N
//Output

//Print N!



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Console.WriteLine(NFactorial(array));
    }
    static BigInteger NFactorial(int[] array)
    {
        BigInteger result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }

        return result;
    }
        }
    }

