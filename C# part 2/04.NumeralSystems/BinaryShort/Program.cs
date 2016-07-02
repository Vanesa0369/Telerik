//Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

//Input

//On the only line you will receive a decimal number - N
//Output

//Print the its binary representation on a single line
//There should be exactly 16 digits of output
//Input	Output
//11	0000000000001011
//-11	1111111111110101





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(ShortBinary(number));
    }
    static string ShortBinary(short number)
    {
        char[] result = new char[16];
        for (int i = 0, pos = 15; i < 16; i++, pos--)
        {
            if ((number & (1 << i)) != 0)
            {
                result[pos] = '1';
            }
            else
            {
                result[pos] = '0';
            }
        }
        return new string(result);
    }
        }
    }

