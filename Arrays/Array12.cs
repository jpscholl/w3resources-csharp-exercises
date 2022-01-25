/*
//  Author: Jonathan Scholl
//  Date: 1/24/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Linq;

namespace Array12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = CreateArray();
            Console.WriteLine();

            //Linq sort then reversed
            Array.Sort(userArray);
            foreach (var item in userArray.Reverse())
            {
                Console.WriteLine(item);
            }
        }
        public static int[] descendingOrder(int[] num)
        {
            int[] sortArray = new int[num.Length];
            int temp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] < num[i])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            return num;
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
