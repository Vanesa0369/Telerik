//Write a method that returns the last digit of given integer as an English word. Write a program that reads a number and prints the result of the method.

//Input

//On the first line you will receive a number
//Output

//Print the last digit of the number as an English word


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        
            
    {
        int number = int.Parse(Console.ReadLine());
        int lastDigit = number % 10;
        Console.WriteLine(DigitToWord(lastDigit));
    }


    static string DigitToWord(int lastDigit)
    {
        string[] digitsInWords =
        {
            "zero","one","two","three","four","five","six","seven","eight","nine"
        };
        return digitsInWords[lastDigit];
    }
        }
    }
