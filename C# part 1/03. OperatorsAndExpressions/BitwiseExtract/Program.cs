using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseExtract
{
    class Program
    {
        static void Main(string[] args)
        {



            string number = Console.ReadLine();
            int intNumber = int.Parse(number);
            intNumber = intNumber / 8;
            int bit = intNumber % 2;
            Console.WriteLine("{0}", bit);
        }
    }
}


        //        int number = int.Parse(Console.ReadLine());
 
//        int fakeBit = 1 << 3;
//        int foundBit = number & fakeBit;
 
//        if (foundBit == 0)
//        {
//            Console.WriteLine(" '0' " + Convert.ToString(number, 2).PadLeft(16, '0'));
//        }
//        else
//        {
//            Console.WriteLine("Third bit is '1' " + Convert.ToString(number, 2).PadLeft(16, '0'));
//        }
//    }
//}
//        }
  