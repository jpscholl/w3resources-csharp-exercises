/*
//  Author: Jonathan Scholl
//  Date: 1/22/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array 2
*/
using System;

namespace Array2
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
                Console.Write("Input element: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }


            //method 1
            Console.Write("Contents reversed: ");
            for (int i = numArray.Length - 1;i >= 0; i--)
            {
                Console.Write($"{numArray[i]} ");
            }


            //method 2
            Console.Write("Contents reversed: ");
            Array.Reverse(numArray);
            foreach (int i in numArray)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
