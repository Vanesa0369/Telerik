//Write a program that converts a hexadecimal number N to its decimal representation.

//Input

//On the only line you will receive a hexadecimal number - N
//There will not be leading zeros
//Letters will be uppercase
//Output

//Print the decimal representation of N on a single line
//There should not be leading zeros
//Input	Output
//13	19




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = HexToDe(number);
            Console.WriteLine(result);
    }
    static string HexToDe(string number)
    {
        int fromBase = 16;
        int toBase = 10;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
        }
    }

