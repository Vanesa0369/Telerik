using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double  radius = double.Parse(Console.ReadLine());
            
            double perimeter = Math.PI * 2 * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("{0:0.00} {1:0.00}", perimeter,area);
        }
    }
}
