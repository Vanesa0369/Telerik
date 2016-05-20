using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double coefA = double.Parse(Console.ReadLine());
            double coefB = double.Parse(Console.ReadLine());
            double coefC = double.Parse(Console.ReadLine());
            double discriminant = (coefB * coefB) - (4 * (coefA * coefC));


            double x1 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
            double x2 = (- coefB - Math.Sqrt(discriminant)) / (2 * coefA);
     
            if (discriminant > 0 )
            {
                if (x1 < x2 )
                {

                    Console.WriteLine("{0:0.00}" , x1);
                    Console.WriteLine("{0:0.00}",x2);




                }
                else
                {
         
                    Console.WriteLine("{0:0.00}", x2);
                    Console.WriteLine("{0:0.00}", x1);
                }

             

            }
            else if (discriminant == 0 )
            {
                Console.WriteLine("{0:0.00}", (-coefB /( 2 * coefA)));
            }
            else 
            {
                Console.WriteLine("no real roots");
            }

        }
    }
}
