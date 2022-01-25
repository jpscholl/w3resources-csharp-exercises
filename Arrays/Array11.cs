/*
//  Author: Jonathan Scholl
//  Date: 1/24/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/
using System;
using System.Diagnostics;
using System.Linq;

namespace Array11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = CreateArray();

            Console.WriteLine("\nOG array: ");
            foreach (int i in userArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nBubble sorted array: ");
            foreach (int i in bubbleSort(userArray))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nBuilt in LINQ sort: ");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Array.Sort(userArray);
            stopwatch.Stop();
            Console.WriteLine("Ticks: {0}",stopwatch.ElapsedTicks.ToString());

            foreach (int i in userArray) 
            {
                Console.WriteLine(i);
            }
            



        }
        public static int[] bubbleSort(int[] num)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

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
            stopwatch.Stop();
            Console.WriteLine("Ticks: {0}", stopwatch.ElapsedTicks.ToString());

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
