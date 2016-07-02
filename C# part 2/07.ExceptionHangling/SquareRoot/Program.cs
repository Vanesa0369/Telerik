
/* 01. Square root
Description
Write a program that reads a number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye. Use try-catch-finally block.
Input
On the only line you will receive a real number
Output
Print the square root of the number or Invalid number on the first line
Use 3 digits of precision
Print Good bye on the second line
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
      
             static void Main(string[] args)
        {
            string number = Console.ReadLine();
            TryGetSquareRoot(number);
        }

        private static void TryGetSquareRoot(string n)
        {
            try
            {
                double number = double.Parse(n);
                if (number < 0)
                {
                    throw new FormatException("Integer must not be negative");
                }
                double square = Math.Sqrt(number);
                Console.WriteLine("{0:F3}", Math.Round(square,3));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
        }

   
