
//Write a program that reads a year from the console and checks whether it is a leap one.

//Hint: Use System.DateTime.

//Input

//On the only line you will receive a number - the year
//Output

//Print "Leap" or "Common" on a single line depending on the year
//Input	Output
//2016	Leap
//1996	Leap
//1900	Common
//2000	Leap
//681	    Common
//3400	Common


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
        string result = null;
        result = IsYearLeap(year);
        Console.WriteLine(result);
    }
    static string IsYearLeap(int year)
    {
        string result = null;

        if (year % 100 == 0 && year % 400 == 0)
        {
            result = "Leap";
        }
        else if (year % 4 == 0 && year % 100 != 0)
        {
            result = "Leap";
        }
        else
        {
            result = "Common";
        }
        return result;
    }
        }
    }

