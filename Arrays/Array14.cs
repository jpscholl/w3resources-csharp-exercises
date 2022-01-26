/*
//  Author: Jonathan Scholl
//  Date: 1/26/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;

namespace Array14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumArray = CreateArray();

            foreach (var item in addElement(userNumArray))
            {
                Console.WriteLine(item);
            }
        }
        public static int[] addElement(int[] num)
        {
            int element, position;
            int[] outputArray = new int[num.Length + 1];

            Console.Write("Input element to add: ");
            element = Convert.ToInt32(Console.ReadLine());

            Console.Write("What position inside array: ");
            position = Convert.ToInt32(Console.ReadLine());

            /* Move all data at right side of the array */
            for (int i = num.Length; i >= position; i--)
                outputArray[i] = num[i - 1];
            /* insert value at given position */
            outputArray[position - 1] = element;

            //copy first part into array
            Array.Copy(num, outputArray, position - 1);
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
