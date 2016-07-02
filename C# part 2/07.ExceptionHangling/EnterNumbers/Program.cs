//Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).

//If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100

//Input

//You will receive 10 lines of input, each consisted of an integer number
//a1
//a2
//...
//a10
//Output

//Print 1 < a1 < ... < a10 < 100
//Or Exception if the above inequality is not true
//Input	
//5
//7
//15
//29
//46
//47
//60
//70
//89
//98	Output 1 < 5 < 7 < 15 < 29 < 46 < 47 < 60 < 70 < 89 < 98 < 100


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
       
            static void Main()
        {
            int[] arr = new int[12];

            arr[0] = 1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            arr[11] = 100;

            for (int i = 0; i < 9; i++)
            {   
                if (ReadNumber(arr[i], arr[i + 1]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Exception");
                    return;
                }
            }
            
            Console.WriteLine(string.Join(" < ", arr));
        }

        static bool ReadNumber(int start, int end)
        {
            if (start < end)
            {
                return true;
            }

            return false;
        }
    }
        }
    