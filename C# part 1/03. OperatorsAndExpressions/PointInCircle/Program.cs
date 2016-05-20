using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double number = Math.Sqrt((x * x + y * y));
            double radius = 2;
            if (number <= radius)
            {
                Console.WriteLine("yes {0:0.00}", number);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", number);
            }

        }
    }
}

             
                 
             
             
           
              

            
             


                


