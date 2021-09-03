/*
//  Author: w3resource (with minor changes and comments by Jonathan Scholl)
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 45
//  Description: Write a C# program to count a specified number in a given array of integers.
//  Beginning Comment: I believe I can do this one without looking it up or minimal help.
//  Closing Comment: Ended up misunderstanding what the exercise needed. Change variable names and studied solution to understand
//  Can't take credit for original code. Gives me an idea for another exercise.
*/
using System;
using System.Linq;

namespace BasicExercise45
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user and copied input into int variable
            Console.WriteLine("\nInput an integer:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //created int array to compare input to
            int[] intArray = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            //shows what integer the user entered
            Console.WriteLine("Number of " + userInput + " present in the said array:");

            //uses count function to tally how many instances of the integer is inside the premade array.
            Console.WriteLine(intArray.Count(x => x == userInput));

        }
    }
}
