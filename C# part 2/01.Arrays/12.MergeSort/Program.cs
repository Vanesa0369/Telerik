﻿//Write a program that sorts an array of integers using the Merge sort algorithm.
//https://en.wikipedia.org/wiki/Merge_sort
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

namespace _13.MergeSort
{
    class Program
    {
        
        
            static public void MainMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, eol, num, pos;

        eol = (mid - 1);
        pos = left;
        num = (right - left + 1);

        while ((left <= eol) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[pos++] = numbers[left++];
            else
                temp[pos++] = numbers[mid++];
        }

        while (left <= eol)
            temp[pos++] = numbers[left++];

        while (mid <= right)
            temp[pos++] = numbers[mid++];

        for (i = 0; i < num; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void SortMerge(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            SortMerge(numbers, left, mid);
            SortMerge(numbers, (mid + 1), right);

            MainMerge(numbers, left, (mid + 1), right);
        }
    }

    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        SortMerge(arr, 0, length - 1);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

        }
    }



