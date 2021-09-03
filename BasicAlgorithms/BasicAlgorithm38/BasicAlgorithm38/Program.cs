/*
//  Author: Jonathan Scholl
//  Date: 8/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 38
//  Description: Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. 
//  Also count the situation where the second 5 is actually a 6
*/
using System;

namespace BasicAlgorithm38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = {5, 5, 2, 4, 1, 6 };
            int[] intArray2 = {1, 5, 5, 6, 5, 5, 8 };
            int[] intArray3 = {5, 5, 3, 4, 5, 6, 7 };

            Console.WriteLine("Number of instances: " + twoConsecutiveFives(intArray1));
            Console.WriteLine("Number of instances: " + twoConsecutiveFives(intArray2));
            Console.WriteLine("Number of instances: " + twoConsecutiveFives(intArray3));
        }

        public static int twoConsecutiveFives(int[] num)
        {
            int counter = 0;
            for (int i = 0; i < num.Length; i++)
            {
                //if the element equals 5 and the next element equals 5 or if the element equals 5 and next element equals 6
                if (num[i].Equals(5) && num[i + 1].Equals(5) || num[i].Equals(5) && num[i + 1].Equals(6))
                {
                    //counter is incremented
                    counter++;
                }
            }
            //returns how many times condition was found in the array
            return counter;
        }
    }
}
