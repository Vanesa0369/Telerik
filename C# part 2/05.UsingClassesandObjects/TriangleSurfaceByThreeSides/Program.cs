
//Write program that calculates the surface of a triangle by given its three sides.

//Input

//On the first line you will receive the length of the first side of the triangle
//On the second line you will receive the length of the second side of the triangle
//On the third line you will receive the length of the third side of the triangle
//Output

//Print the surface of the rectangle with two digits of precision
//Input	Output
//11
//12
//13	61.48


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleSurfaceByThreeSides
{
    class Program
    {
        static void Main(string[] args)
        

    {
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        double area = AreaOfTriangle(side1, side2, side3);
        Console.WriteLine("{0:F2}", area);
    }
    static double AreaOfTriangle(double side1, double side2, double side3)
    {
        double result = 0;
        double SemiPerimeter = (side1 + side2 + side3) / 2;
        result = Math.Sqrt(SemiPerimeter * (SemiPerimeter - side1) * (SemiPerimeter - side2) * (SemiPerimeter - side3));
        return result;
    }
        }
    }

