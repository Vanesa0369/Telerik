using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckIfPrime
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                int primeCount = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        primeCount++;
                    }
                }

             

                if (primeCount < 2)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }

              
            }
        }
    }
}

//using System;
//class PrimeCheck
//{
//    static void Main()
//    {
//        string input = Console.ReadLine();
//        int number = int.Parse(input);
//        if (number < 0 || number == 0 || number == 1)
//        {
//            Console.WriteLine("false");
//        }
//        else
//        {
//            for (int i = 2; i <= number / 2; i++)
//            {
//                if (number % i == 0)
//                {
//                    Console.WriteLine("false");
//                    return;
//                }
//            }
//            Console.WriteLine("true");
//        }
//    }
//}
