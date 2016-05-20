using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double side1 = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (height * (side + side1) / 2);
            Console.WriteLine("{0:0.0000000}", area);
        }
    }
}
