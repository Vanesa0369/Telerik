/*In combinatorics, the Catalan numbers are calculated by the following formula: 
catalan-formula (2n)!/((n+1)!*n!)
Write a program to calculate the Nth Catalan number by given N*/
 /*Constraints: N will always be a valid integer number in the range [0, 100]. Hint: overflow is possible. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace CalatanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            
            if (1 <= n && n <= 100)
            {
                BigInteger firstNum = 1; //(2 * n)!


                for (int i = 1; i <= (2 * n); i++)
                {

                    firstNum *= i;
                }
                BigInteger secondNum = 1; // (n +1)!
                for (int i = 1; i <= (n + 1); i++)
                {
                    secondNum *= i;

                }

                for (int i = 1; i <= n; i++)
                {
                    secondNum *= i;  //n!
                }

                Console.WriteLine(firstNum / secondNum);
            }
            else
            // n==0
            {
                Console.WriteLine(1);
            }
        }
    }
}

   
    
