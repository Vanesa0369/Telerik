//Write a program to check if in a given expression the ( and ) brackets are put correctly.

//Input

//On the only line you will receive an expression
//Output

//Print Correct if the brackets are correct
//Incorrect otherwise
//Input	Output
//((a+b)/5-d)	Correct
//)(a+b))	Incorrect





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorrectBrackets
{
    class Program
    {
        public static string BracketsArePutCorrectly(string word)
    {
        int countOpenBreackets = 0;
        int countCloseBreackets = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == '(')
            {
                countOpenBreackets++;
            }

            if (word[i] == ')')
            {
                countCloseBreackets++;

                if (countCloseBreackets > countOpenBreackets)
                {
                    return "Incorrect";
                }
            }
        }
        if (countOpenBreackets > countCloseBreackets)
        {
            return "Incorrect";
        }
        else
        {
            return "Correct";
        }
    }


    static void Main()
    {
        string word = Console.ReadLine();

        Console.WriteLine(BracketsArePutCorrectly(word));


    }
}
    }

