/* 10. Unicode characters
Description
Write a program that converts a string to a sequence of C# Unicode character literals.
Input
On the only input line you will receive a string
Output
Print the string in C# Unicode character literals on a single line
Constraints
Time limit: 0.1s
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                answer.AppendFormat("\\u{0:X4}", (int)input[i]);
            }

            Console.WriteLine(answer.ToString());
        }
    }

}