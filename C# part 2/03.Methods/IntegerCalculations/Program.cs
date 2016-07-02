//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.

//Input

//On the first line you will receive 5 numbers separated by spaces
//Output

//Print their minimum, maximum, average, sum and product
//Each on a new line
//The average value should be printed with two digits of precision



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minimum = minimumOfNumbers(array);
            int maximum = maximumOFnumbers(array);
            double average = averageOfNumbers(array);
            int sum = sumOfNumbers(array);
            long product = productOfNumbers(array);
            Console.WriteLine(minimum);
            Console.WriteLine(maximum);
            Console.WriteLine("{0:F2}", average);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
        static int minimumOfNumbers(int[] array)
        {
            int minimum = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (minimum > array[i])
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }
        static int maximumOFnumbers(int[] array)
        {
            int maximum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (maximum < array[i])
                {
                    maximum = array[i];
                }
            }
            return maximum;
        }
        static double averageOfNumbers(int[] array)
        {
            double sum = sumOfNumbers(array);
            double avarage = sum / array.Length;
            return avarage;
        }
        static int sumOfNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static long productOfNumbers(int[] array)
        {
            long product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
        }
    
