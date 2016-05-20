using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double greater = Math.Max(num1, num2);
            Console.WriteLine(greater);
        }
    }
}
