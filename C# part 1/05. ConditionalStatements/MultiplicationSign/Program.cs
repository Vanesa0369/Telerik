﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace MultiplicationSign
//{
//    class Program
//    {
       
//         static void Main(string[] args)
//        {
//            double a = double.Parse(Console.ReadLine());
//            double b = double.Parse(Console.ReadLine());
//            double c = double.Parse(Console.ReadLine());

            
//           if (a > 0 & b > 0 & c > 0)
//           {
//               Console.WriteLine("+");
//           }
//           else if (a < 0 & b > 0 & c > 0 )
//           {
//               Console.WriteLine("-");
//           }
//           else if (a > 0 & b > 0 & c > 0)
//           {
//               Console.WriteLine("-");
//           }
//           else if  (a > 0 & b < 0 & c > 0)
//           {
//               Console.WriteLine("-");
//           }
//           else if (a < 0 & b < 0 & c > 0)
//           {
//               Console.WriteLine("0");
//           }
//           else 
           
//        }
//    }
using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = a * b * c;
        if (d > 0)
        {
            Console.WriteLine("+");
        }
        else if (d == 0)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}



            

            
  
