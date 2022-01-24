/*
//  Author: Jonathan Scholl
//  Date: 1/22/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Collections.Generic;

namespace Array5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of elements: ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());

            int[] numArray = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Number of dupes: {checkDupes(numArray, sizeArray)}");
        }

        static int checkDupes(int[] arr, int size)
        {
            //hashset can't contain duplicate values
            HashSet<int> notDupes = new HashSet<int>();

            //adds all of the elements of the array to the hashset that isn't the same number
            for(int i = 0;i < size; i++)
            {
                notDupes.Add(arr[i]);
            }

            //the size of the array minus subtracted by the amount of values inside the hashset will 
            //give number of duplicates
            return size - notDupes.Count;
        }
    }
}
