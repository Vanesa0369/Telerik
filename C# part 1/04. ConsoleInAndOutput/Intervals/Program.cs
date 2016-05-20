using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a+1; i <b; i++)

            {
                if (i % 5 ==0)
                {
                    
                    counter++;
                }
                
            }
            Console.WriteLine(counter);
        }
    }
}

//Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them such that the reminder of the division by 5 is 0.