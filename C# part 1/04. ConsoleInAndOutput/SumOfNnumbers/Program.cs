using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfNnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = int.Parse(Console.ReadLine());
            decimal sum = 0;


            for (decimal i = 0; i < n; i++)
            {
                decimal nums = decimal.Parse(Console.ReadLine());
                sum += nums;
            }
            Console.WriteLine(sum);
            
            
        }
    }
}
