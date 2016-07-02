//Write program that calculates the surface of a triangle by given a side and an altitude to it.

//Input

//On the first line you will receive the length of a side of the triangle
//On the second line you will receive the altitude to that side
//Output

//Print the surface of the rectangle with two digits of precision
//Input	Output
//23.2
//5	    58.00





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleSurfaceBySideAndAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideLength = double.Parse(Console.ReadLine());
            double altitudeLegth = double.Parse(Console.ReadLine());
            double surface = (sideLength * altitudeLegth) / 2;
            Console.WriteLine("{0:F2}", surface);
        }
    }
}
