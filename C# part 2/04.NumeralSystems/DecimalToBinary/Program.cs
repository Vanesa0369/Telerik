//Write a program that converts a decimal number N to its binary representation.

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the binary representation of N on a single line
//There should not be leading zeros        example:      19	10011





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
       
    {
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine(DeToBi(number));
    }


    static string DeToBi(long number)
    {
        long remainder = 0;
        string Binary = null;
        while (number > 0)
        {
            remainder = number % 2;
            number /= 2;
            Binary = remainder + Binary;
        }
        return Binary;
    }

        }
    }

