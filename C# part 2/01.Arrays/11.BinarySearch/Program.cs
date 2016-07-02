
//Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//On the last line you will receive the number X
//Output

//Print the index where X is in the array
//If there is more than one occurence print the first one
//If there are no occurences print -1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.BinarySearch
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
        int x = int.Parse(Console.ReadLine());

        int high = arr.Length - 1;
        int low = 0;
        int mid;
        int result = -1;

        if (arr[0] == x)
            result = low;
        else if (arr[high] == x)
            result = high;
        else
        {
            while (low <= high)
            {
                mid = (high + low) / 2;
                if (arr[mid] == x)
                {
                    result = mid;
                    break;
                }
                else
                {
                    if (arr[mid] > x)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }

            }
            
        }

       
        Console.WriteLine(result);
    }
        }
    }

