/*
//  Author: Jonathan Scholl
//  Date: 10/7/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 107
//  Description: Write a C# Sharp program to find the largest value from first, last, 
//  and middle elements of a given array of integers of odd length (at least 1)
*/

using System;

namespace BasicAlgorithm107
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            printArray(userArray);

            Console.WriteLine("Largest element of 3 middle elements: "+ largestMiddleElement(userArray));
            
        }

        //create a unique array based on how many elements
        public static int[] createNewArray()
        {
            Console.Write("How many elements: ");
            var length = int.Parse(Console.ReadLine());

            int[] numArray = new int[length];

            for (int x = 0; x < numArray.Length; x++)
            {
                numArray[x] = int.Parse(Console.ReadLine());
            }

            return numArray;
        }

        //print the contents of an array
        public static void printArray(int[] numArray)
        {
            foreach (var item in numArray)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }

        public static int largestMiddleElement(int[] num)
        {
            int firstElement, midElement, lastElement, maxElement;

            firstElement = num[0];
            midElement = num[num.Length / 2];
            lastElement = num[num.Length - 1];
            maxElement = firstElement;

            if (midElement > maxElement)
            {
                maxElement = midElement;
            }
            if (lastElement > maxElement)
            {
                maxElement = lastElement;
            }
            return maxElement;
        }
    }
}
