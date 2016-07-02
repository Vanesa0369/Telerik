
//Write program that calculates the surface of a triangle by given two sides and an angle between them.

//Input

//On the first line you will receive the length of the first side of the triangle
//On the second line you will receive the length of the second side of the triangle
//On the third line you will receive the angle between the given sides
//Angle is given in degrees
//Output

//Print the surface of the rectangle with two digits of precision
//Input	Output
//10
//7
//25	   14.79




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleSurfaceByTwoSidesAndAndAngle
{
    class Program
    {
        static void Main(string[] args)
        {
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());
        double area = AreaOfTriangle(side1, side2, angle);
        Console.WriteLine("{0:F2}", area);
    }
    static double AreaOfTriangle(double side1, double side2, double angle)
    {
        double result = 0;
        double rads = (angle * Math.PI) / 180;
        result = (side1 * side2 * Math.Sin(rads)) / 2;
        return result;
    }
        }
    }

