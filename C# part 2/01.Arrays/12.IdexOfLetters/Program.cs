//Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.

//Input

//On the first line you will receive the word
//Output

//Print the index of each of the word's letters in the array
//Each index should be on a new line

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.IdexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[122 - 96];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (char)(97 + i);
        }
        string word = Console.ReadLine();
        foreach (var ch in word)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (ch == arr[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
        }
    }

