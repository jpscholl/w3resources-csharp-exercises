/*
//  Author: Jonathan Scholl
//  Date: 3/31/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 43
//  Description: Write a C# program to check if a given string starts with "w" and immediately followed by two "ww"
//  Comments: Attempting first without lookihng at solution. Prefer to have user enter input string. **Update**
//  Had to lookup answer to refresh myself on certain string functions. The solution given doesn't work properly. It
//  still states true even if doesn't start with 'w' and has to follow with more than 2 'W's.
*/
using System;

namespace BasicExercise43
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user to input string and stores in string variable
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(testW(userInput));
        }
        //string to alter and check for W's
        public static bool testW(string input)
        {
            var ctr = 0;    //counter
            for (var x = 0; x < input.Length - 1; x++)
            {
                if (input[x].Equals('w')) ctr++;
                if(input.Substring(x, 2).Equals("ww") && ctr > 2) 
                return true;
            }
            return false;
        }
    }
}
