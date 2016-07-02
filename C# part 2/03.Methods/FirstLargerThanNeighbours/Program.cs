
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.

//Input

//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers sepated by spaces - the array
//Output

//Print the index of the first element that is larger than its neighbours or -1 if none are




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
             int length = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(z => int.Parse(z))
                .ToArray();
            int result = CheckNeighbours(array, length);
            Console.WriteLine(result);
        }
        static int CheckNeighbours(int[] array, int length)
        {
            int result = -1;
            for (int i = 1; i < length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
        }
    

