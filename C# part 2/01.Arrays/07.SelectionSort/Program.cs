//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the sorted array
//Each number should be on a new line



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int minNumber = int.MaxValue;
        int minIndex = 0;
        int currentNumber = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < n; j++)
        {
            for (int k = j; k < n; k++)
            {
                if (minNumber > arr[k])
                {
                    minNumber = arr[k];
                    minIndex = k;
                }
            }
            if (arr[j] > minNumber)
            {
                currentNumber = arr[j];
                arr[j] = minNumber;
                arr[minIndex] = currentNumber;

            }
            minNumber = int.MaxValue;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
            
        }
    