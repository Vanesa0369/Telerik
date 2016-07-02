//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.

//Input

//On the only line you will receive a string
//Output

//Output a string with length 20
//Input	Output
//hello	hello***************




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(@"\", string.Empty);
            string result = input.PadRight(20, '*');
            Console.WriteLine(result);
        }
    }
}
