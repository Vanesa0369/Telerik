using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideBy7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if ((number % 5 == 0  ) && (number % 7 == 0 ))

            {
                Console.WriteLine("true " +  number);
            }

                else
                {
                    Console.WriteLine("false " + number);
                }


            }
        }
    }

