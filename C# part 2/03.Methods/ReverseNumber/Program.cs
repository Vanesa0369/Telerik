
//Write a method that reverses the digits of a given decimal number.

//Input

//On the first line you will receive a number
//Output

//Print the given number with reversed digits



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            numberString = Reverse(numberString);
            Console.WriteLine(numberString);
    }


        static string Reverse(string numberString)
        {
        char[] charArray = numberString.ToCharArray();
        numberString = null;
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            numberString += charArray[i];
        }
        return numberString;
    }
        }
    }

