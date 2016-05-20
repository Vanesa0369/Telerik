
/* 12. Decimal to Binary Number
   Using loops write a program that converts an integer number to its binary representation.
   The input is entered as long. The output should be a variable of type string.
   Do not use the built-in .NET functionality.
   Input: On the only input line you will receive the decimal integer number.
   Output a single string - the representation of the input decimal number in it's binary representation.
   Constraints: All numbers will always be valid 32-bit integers.                     */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long decimalNum = long.Parse(Console.ReadLine());
            if (decimalNum == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
                 string binaryNum = "";          

            while (decimalNum > 0)
            {
                int remainder = (int)decimalNum % 2;
                binaryNum = remainder + binaryNum;
                decimalNum /= 2;
            }

            Console.WriteLine(binaryNum);
        }

    }
}
        }
    

