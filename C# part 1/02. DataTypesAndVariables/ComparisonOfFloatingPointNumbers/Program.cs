using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparisonOfFloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = number1 - number2;
            number3 = Math.Abs(number3);
           
            if (number3 > 0.000001)
            {
                Console.WriteLine("false");
               
            }
            else 
            {
                Console.WriteLine("true");
            }


        }
    }
}
