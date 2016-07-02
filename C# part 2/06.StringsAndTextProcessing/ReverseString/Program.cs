//Write a program that reads a string, reverses it and prints the result on the console.
//Input

//On the only line you will receive a string
//Output

//Print the string in reverse on a single line
//Input	Output
//sample	elpmas
//somestring	gnirtsemos




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class Program
    {

        static void Main()
        {
            string text = Console.ReadLine();
            string reversedString = stringReverser(text);
            Console.WriteLine(reversedString);
        } 

        static string stringReverser(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

       
    }
}
