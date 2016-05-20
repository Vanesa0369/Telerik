/*Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
    Your program should work well for very big numbers, e.g. N = 100000.
*/
//a *= b;
//a = a * b


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace TrailingZeroesInNFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());
                  
            int zerosCounter = 0;
            int divider = 5;
            while (n / divider >= 1)
            {
                zerosCounter += n / divider;
                divider *= 5;// divider = divider * 5
            }

            Console.WriteLine(zerosCounter);
    }
}
    }

        
