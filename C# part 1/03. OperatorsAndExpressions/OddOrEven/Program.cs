using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Please enter a number to see if it is odd or even.");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even " + number);
            }
            else
            {
                Console.WriteLine("odd " + number);
            }
        }
    }
}
