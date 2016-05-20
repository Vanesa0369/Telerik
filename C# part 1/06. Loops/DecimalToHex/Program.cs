/* 13. Decimal to Hexadecimal Number
   Using loops write a program that converts an integer number to its hexadecimal representation.
   The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.
   Input: On the first and only line you will receive an integer in the decimal numeral system.
   Output: On the only output line write the hexadecimal representation of the read number.
   Constraints: All numbers will always be valid 64-bit integers.                                      */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            long decimalNum = long.Parse(Console.ReadLine());

            string hexNum = "";
        while (decimalNum != 0)
            {
            long remain = decimalNum % 16;
            
            switch (remain)
            {
                 case 10: hexNum = "A" + hexNum; break;
                case 11: hexNum = "B" + hexNum; break;
                case 12: hexNum = "C" + hexNum; break;
                case 13: hexNum = "D" + hexNum; break;
                case 14: hexNum = "E" + hexNum; break;
                case 15: hexNum = "F" + hexNum; break;
                default: hexNum = remain + hexNum; break;
            }
            decimalNum /= 16;
        }
        Console.WriteLine(hexNum);
    }
}

        }
    

