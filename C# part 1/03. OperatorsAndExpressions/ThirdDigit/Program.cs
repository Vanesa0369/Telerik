using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int restnumber = number / 100;
            int thirdDigit = restnumber % 10;
            if (thirdDigit ==  7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}",restnumber);
            }
           

            }
        }
    }

//using System;
//class ThirdBit
//{
//    static void Main()
//    {
//        string number = Console.ReadLine();
//        int intNumber = int.Parse(number);
//        intNumber = intNumber / 8;
//        int bit = intNumber % 2;
//        Console.WriteLine("{0}", bit);
//    }
//}

