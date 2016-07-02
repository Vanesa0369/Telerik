//Write a program to convert binary numbers to hexadecimal numbers (directly).

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the its binary representation on a single line
//There should not be leading zeros
//Use uppercase letters
//Input	Output
//10011	13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToHeximal
{
    class Program
    {
        static void Main(string[] args)
        
    {
        string number = Console.ReadLine();
        string result = BiToHex(number);
        Console.WriteLine(result);
    }
    static string BiToHex(string number)
    {
        int fromBase = 2;
        int toBase = 16;
        String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
        return result;
    }
        }
    }

