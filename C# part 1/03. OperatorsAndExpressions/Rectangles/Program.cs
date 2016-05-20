using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal weight = decimal.Parse(Console.ReadLine());
           decimal height = decimal.Parse(Console.ReadLine());
            decimal area = (weight * height);
            decimal perimeter = (2* weight) + (2 * height);
            Console.WriteLine("{0 : 0.00}{1 : 0.00}", area, perimeter);
        }

    }
}
