//Write a method that adds two polynomials. Represent them as arrays of their coefficients. Write a program that reads two polynomials and prints their sum.

//Input

//On the first line you will receive the number N
//On the second line you will receive the first polynomial as coefficients separated by spaces
//On the third line you will receive the second polynomial as coefficients separated by spaces
//Output

//Print the sum of the polynomials





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddingPolynomials
{
    class Program
    {
        public static int[] Addition(int[] longerPoly, int[] shorterPoly)
        {
            if (longerPoly.Length < shorterPoly.Length)
            {
                return Addition(shorterPoly, longerPoly);
            }

            int[] sumOfPoly = new int[longerPoly.Length];

            for (int i = 0; i < shorterPoly.Length; i++)
            {
                sumOfPoly[i] = longerPoly[i] + shorterPoly[i];
            }

            for (int i = shorterPoly.Length; i < longerPoly.Length; i++)
            {
                sumOfPoly[i] = longerPoly[i];
            }

            return sumOfPoly;
        }

        static void Main()
        {
            Console.ReadLine();
            int[] firstCoef = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondCoef = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = Addition(firstCoef, secondCoef);
            var list = new List<int>();
            for (int i = 0; i < sum.Length; i++)
            {
                list.Add(sum[i]);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
