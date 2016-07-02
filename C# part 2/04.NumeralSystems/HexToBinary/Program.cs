//Write a program to convert hexadecimal numbers to binary numbers (directly).

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Letters will be uppercase
//Output

//Print the its binary representation on a single line
//There should not be leading zeros
//Input	Output
//13	10011



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HexToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
        string result = HexToBi(number);
        Console.WriteLine(result);
    }
    static string HexToBi(string number)
    {
        int fromBase = 16;
        int toBase = 2;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
        }
    }

