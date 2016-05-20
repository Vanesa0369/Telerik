using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            if(A > B)
            {
                Console.WriteLine(B + " " + A);
            }
            else
            {
                Console.WriteLine(A + " " + B);
            }
        }
    }
}
