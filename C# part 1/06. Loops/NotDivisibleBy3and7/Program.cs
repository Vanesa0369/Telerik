﻿
/* 2. Not Divisible Numbers by 3 and 7
   Write a program that reads from the console a positive integer N (1 < N < 1500). 
   and prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space. */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotDivisibleBy3and7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && ( i % 7 != 0 ))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
