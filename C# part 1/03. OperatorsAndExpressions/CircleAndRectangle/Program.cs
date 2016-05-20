using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleAndRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool check = false;
            double X, Y;
            bool Xcheck = double.TryParse(Console.ReadLine(), out X);
            bool Ycheck = double.TryParse(Console.ReadLine(), out Y);
            if (Xcheck && Ycheck)
            {
                if ((X >= 1 && Y >= 1 ) && (X <= 5 && Y <= 1))
                {
                
                }
                else
                {
                    double displacedX = X - 1;
                    double displacedY = Y - 1;
                    if ((displacedX * displacedX + displacedY * displacedY) <= 9)
                    {
                        check = true;
                    }
                }
                Console.WriteLine("inside circle inside rectangle", X, Y, check);
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle", X, Y, check);
            }
             
        }
    }
}

//using System;
//class PointCircleRectangle
//{
//    static void Main()
//    {
//        string xAsString = Console.ReadLine();
//        double x = double.Parse(xAsString);
//        string yAsString = Console.ReadLine();
//        double y = double.Parse(yAsString);

//        double distance = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
//        string isInRectangle = "outside rectangle";
//        if ((x >= -1 & x <= 5) & (y >= -1 & y <= 1))
//        {
//            isInRectangle = "inside rectangle";
//        }

//        if (distance > 1.5)
//        {
//            Console.WriteLine("outside circle " + isInRectangle);
//        }
//        else
//        {
//            Console.WriteLine("inside circle " + isInRectangle);
//        }

//    }
//}
