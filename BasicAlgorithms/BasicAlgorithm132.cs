/*
//  Author: Jonathan Scholl
//  Date: 10/21/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 132
//  Description: Write a C# Sharp program to create new array from a given array of integers 
//  shifting all even numbers before all odd numbers. 
*/
using System;

namespace BasicAlgorithm132
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = initializeArray();
            Console.WriteLine($"\nOriginal Array: {printArray(userArray)}");

            int[] sortByEvenArray = createNewArray(userArray);
            Console.WriteLine($"\nSorted by Even Array: {printArray(sortByEvenArray)}");


        }

        //idea is to loop through all the numbers of an array and check for even numbers. If the number is even, it needs to be shifted
        //Store in temp variable to store the number that needs to be shifted. Index variable is to help shift to first position (then
        //incremented once so next even number will be shifted to next position). That index position becomes new number and current 
        public static int[] createNewArray(int[] num)
        {
            int index = 0;
            
            for(int x = 0; x < num.Length; x++)
            {
                if (num[x] % 2 == 0)
                {
                    int temp = num[index];
                    num[index] = num[x];
                    num[x] = temp;

                    index++;
                }
            }
            return num;
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

        //print the contents of an array
        public static string printArray(int[] numArray)
        {
            return "{ " + String.Join(", ", numArray) + " }";
        }
    }
}
