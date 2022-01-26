/*
//  Author: Jonathan Scholl
//  Date: 1/26/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;

namespace Array15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create custom int array
            int[] userNumArray = CreateArray();

            //print contents of custom array after removing element
            foreach (int i in deleteElement(userNumArray))
            {
                Console.WriteLine(i);
            }

        }
        //method to remove
        public static int[] deleteElement(int[] num)
        {
            Console.Write("Delete element at position: ");
            int position = Convert.ToInt32(Console.ReadLine());
            //create new
            int[] outputArray = new int[num.Length - 1];

            //copy first elements before the removed element into the array
            for (int i = 0; i < position - 1; i++)
            {
                outputArray[i] = num[i];
            }

            //copy the elements after the removed element
            for (int i = position; i < num.Length; i++)
            {
                outputArray[i - 1] = num[i];
            }

            //return the new array without the element chosen
            return outputArray;

        }
        public static int[] CreateArray()
        {
            Console.Write("Array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Input element: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numArray;
        }
    }
}
