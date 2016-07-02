//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the length of the maximal sequence


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
		int[] array = new int[n];

		//Input
		for (int i = 0; i < n; i++)
		{
			array[i] = int.Parse(Console.ReadLine());
		}

		int current = 1, max = 0;

		for (int i = 1; i < n; i++)
		{
			if (array[i] == array[i - 1])
			{
				current++;
				if (current > max)
				{
					max = current;
				}
			}
			else
			{
				current = 1;
			}
		}

		Console.WriteLine(max);
	}
}

        }
 