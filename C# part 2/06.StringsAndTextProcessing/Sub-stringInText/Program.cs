
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

//Input

//On the first line you will receive a string - the pattern
//On the second line you will receive a string - the text
//Output

//Print a number on a single line
//The number of occurrences
//Input	Output 9 
//in
//We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.	


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
       
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();

        int counter = 0;
        for (int i = 0; i < text.Length - pattern.Length + 1; i++)
        {
            if (text.Substring(i, pattern.Length).Equals(pattern, StringComparison.OrdinalIgnoreCase))
                counter++;
        }
        Console.WriteLine(counter);

    }
}
        }
    
