*
//  Author: Jonathan Scholl
//  Date: 10/13/2021
//  Project: https://www.w3resource.com/csharp-exercises/basic-algo/index.php 119
//  Description: Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both. 
*/
using System;

namespace BasicAlgorithm119
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new array and print it's contents
            int[] userArray = createNewArray();
            Console.WriteLine("\nOriginal Array: ");
            printArray(userArray);

            Console.WriteLine("\nContains consecutive 3's or 5's: " + checkArray(userArray));
        }
        public static bool checkArray(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                if ((nums[i] == 3 && nums[i + 1] == 3) || (nums[i] == 5 && nums[i] == 5))
                {
                    return true;
                }
            return false;
        }

        //create a unique array based on how many elements
        public static int[] createNewArray()
        {
            Console.Write("How many elements: ");
            int length = int.Parse(Console.ReadLine());

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
            Console.WriteLine( "{ "+ String.Join(", ", numArray) + " }");
        }
    }
}
