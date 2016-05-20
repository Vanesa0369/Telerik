﻿/* 11. Binary to Decimal Number
   Using loops write a program that converts a binary integer number to its decimal form.
   The input is entered as string. The output should be a variable of type long.
   Do not use the built-in .NET functionality.
   Input: You will receive exactly one line containing an integer number representation in binary
   Output: On the only output line write the decimal representation of the number
   Constraints: All input numbers will be valid 32-bit integers                         */

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
            string binaryNum = Console.ReadLine();
            long decimalNum = 0;

            for (int i = 0; i < binaryNum.Length; i++)
        {
            if (binaryNum[binaryNum.Length - i - 1] == '1')
            {
                decimalNum += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decimalNum);
    }
}
        }
    

