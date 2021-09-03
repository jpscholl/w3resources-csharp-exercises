/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 46
//  Description: Write a C# program to check if a number appears as either the first or 
//  last element of an array of integers and the length is 1 or more.
//  Comments: All original code. A bit lengthier and different from the given solution. Doesn't include bools.
//  
*/
using System;

namespace BasicExercise46
{
    class Program
    {
        static void Main(string[] args)
        {

            //prompt user and store input
            Console.Write("Enter an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //premade array to check int
            int[] numArray = { 1,2,3,4,5,6,7,8,9};

            //checks the first and last integer of the array
            if (userInput == numArray[0] || userInput == numArray.Length)
            {
                //tells user that the integer is present
                Console.WriteLine("\nThe integer shows up in the first or last element");
            }
            else
            {
                //tells user that integer isn't present
                Console.WriteLine("\nThe integer doesn't show up in the first or last element");
            }

            //convert to string to check length, checks if length is greater than 1, then outputs if it is 1 or more.
            string lengthCheck = Convert.ToString(userInput);
            if (lengthCheck.Length >= 1)
            {
                Console.WriteLine("\nInput length is equal to 1 or more");
            }
        }
    }
}

/*
 * Given solution from website:
 * Console.WriteLine("\nInput an integer:");  
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.WriteLine( (nums[0] == x) || (nums[nums.Length - 1] == x));
 */