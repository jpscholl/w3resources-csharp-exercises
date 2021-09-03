/*
//  Author: Jonathan Scholl
//  Date: 4/20/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 61
//  Description:  Write a C# program to sort the integers in ascending order without moving the number -5
*/
using System;
using System.Linq;
using System.Collections;

namespace BasicExercise61
{
    class Program
    {
        public static int[] numberSort(int[] intArray)
        {
            int[] num = intArray.Where(x => x != -5).OrderBy(x => x).ToArray();
            int counter = 0;

            return intArray.Select(x => x >= 0 ? num[counter++] : -5).ToArray();
        }
        public static void Main(string[] args)
        {

            int[] x = numberSort(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
            foreach (var item in x)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
