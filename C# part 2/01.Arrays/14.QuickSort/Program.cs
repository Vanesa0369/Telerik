//Write a program that sorts an array of integers using the Quick sort algorithm.

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

namespace _14.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        QuickSort(arr, 0, arr.Length - 1);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public static void QuickSort(int[] input, int left, int right)
    {
        if (left < right)
        {
            int q = Partition(input, left, right);
            QuickSort(input, left, q - 1);
            QuickSort(input, q + 1, right);
        }
    }

    private static int Partition(int[] input, int left, int right)
    {
        int pivot = input[right];
        int temp;

        int i = left;
        for (int j = left; j < right; j++)
        {
            if (input[j] <= pivot)
            {
                temp = input[j];
                input[j] = input[i];
                input[i] = temp;
                i++;
            }
        }

        input[right] = input[i];
        input[i] = pivot;

        return i;
    }
}
        }
    
