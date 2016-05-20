using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        double a;
        double answer = 0;
        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            answer = answer + a;
        }
        Console.WriteLine(answer);
    }
        }
    }

