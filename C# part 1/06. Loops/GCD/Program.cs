/* 15.* GCD
   Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
   Use the Euclidean algorithm (find it in Internet).
   On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.
   Output a single number - the GCD of the numbers A and B.
   Constraints: The numbers A and B will always be valid integers in the range [2, 500].                 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int firstNum = Math.Abs(int.Parse(input[0]));
            int secondNum = Math.Abs(int.Parse(input[1])); ;

            while (firstNum != 0 && secondNum != 0)
            {
                if (firstNum > secondNum)
                    firstNum %= secondNum;
                else
                    secondNum %= firstNum;
            }

            if (firstNum == 0)
                Console.WriteLine(secondNum);
            else
                Console.WriteLine(firstNum);
        }
    }
}
        
       
    



        
  

