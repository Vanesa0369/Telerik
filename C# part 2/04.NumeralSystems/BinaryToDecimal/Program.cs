
//Write a program that converts a binary number N to its decimal representation.

//Input

//On the only line you will receive a binary number - N
//There will not be leading zeros
//Output

//Print the decimal representation of N on a single line
//There should not be leading zeros
//Input	Output
//10011	19




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BiToDe(number));
    }

       static long BiToDe(string number)
      {
        long result = 0;
        int pow = number.Length - 1;
        for (int i = 0; i < number.Length; i++)
        {
            int temp = number[i] - 48;
            result += temp * (long)Math.Pow(2, pow);
            pow--;
        }
        return result;
    }
        }
    }

