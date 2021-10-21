/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 135
//  Description: Write a C# Sharp program to find the larger average value between the first and the second half of a 
//  given array of integers and minimum length is at least 2. Assume that the second half begins at index (array length)/2.
*/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm135
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            Console.WriteLine("Larger half: " + largerAverage(userArray));

            //randomly generated array
            int[] randoArray = generateRandomArray();
            Console.WriteLine($"\nRandom Array: {printArray(randoArray)}");
        }
        public static int largerAverage(int[] num)
        {
            //variables and stores values
            int size = num.Length / 2;
            int[] firstAverage = new int[size];
            Array.Copy(num, 0, firstAverage, 0, size);
            int[] secondAverage = new int[size];
            Array.Copy(num, num.Length - size, secondAverage, 0, size);

            double avg1 = Queryable.Average(firstAverage.AsQueryable());
            double avg2 = Queryable.Average(secondAverage.AsQueryable());

            return (int)(avg1 >= avg2 ? avg1 : avg2);

        }

        //create a unique array based on how many elements
        public static int[] initializeArray()
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
        //generate random test array
        private static int[] generateRandomArray()
        {
            var rand = new Random();
            int length = rand.Next(1, 10);

            int[] numArray = new int[length];

            for (int x = 0; x < numArray.Length; x++)
            {
                numArray[x] = rand.Next(0, 20);
            }

            return numArray;

        }
        //print the contents of an array
        public static string printArray(int[] numArray)
        {
            return "{ " + String.Join(", ", numArray) + " }";
        }
    }
}
