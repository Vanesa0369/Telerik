using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintFibonacciNumbers
{
    class Program
    {
   
        static void Main(string[] args)

        {

           long n = int.Parse(Console.ReadLine());
            long A = 0;
           long B = 1;

            if (n >= 1 && n <= 50)
            Console.Write(A);
            for (long i = 1; i < n; i++)
            {
                long temp = A;
                A = B;
                B = temp + B;
                Console.Write(", " + A);
            }
            Console.WriteLine();
        }
    }
}
              
               



 


 