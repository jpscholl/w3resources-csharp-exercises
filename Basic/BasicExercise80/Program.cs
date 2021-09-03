/*
//  Author: Jonathan Scholl
//  Date: 5/12/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 80
//  Description: Write a C# Sharp program to convert all the values of a given array of mixed values to string values
//  Notes: Not familiar with object arrays
*/
using System;

namespace BasicExercise80
{
    class Program
    {
        //
        public static string[] test(object[] nums)
        {
            return Array.ConvertAll(nums, x => x.ToString());
        }
        static void Main(string[] args)
        {
            //declare object array and give different values for each element
            object[] mixedArray = new object[5];
            mixedArray[0] = 33;
            mixedArray[1] = "Jon";
            mixedArray[2] = false;
            mixedArray[3] = System.DateTime.Now;
            mixedArray[4] = 112.22;

            //print each element of array and show data type(GetType method)
            Console.WriteLine("Pring original array elements and their types:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine("Value-> " + mixedArray[i] + " :: Type-> " + mixedArray[i].GetType());
            }

            string[] new_nums = test(mixedArray);
            Console.WriteLine("\nPrinting array elements and their types:");
            for (int i = 0; i < new_nums.Length; i++)
            {
                Console.WriteLine("Value-> " + new_nums[i] + " :: Type-> " + new_nums[i].GetType());
            }
        }
    }
}
