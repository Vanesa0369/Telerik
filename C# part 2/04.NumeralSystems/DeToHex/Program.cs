//Write a program that converts a decimal number N to its hexadecimal representation.

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the hexadecimal representation of N on a single line
//There should not be leading zeros
//Use uppercase letters
//Input	Output
//19	13



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = DecToHex(number);
            Console.WriteLine(result);
    }
        static string DecToHex(string number)
    {
        int fromBase = 10;
        int toBase = 16;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
        }
    }

