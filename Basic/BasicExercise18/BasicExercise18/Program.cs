/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 18
//  Description:  Write a C# program to check two given integers and return true if one is negative and one is positive
*/
using System;

namespace BasicExercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: \n");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: \n");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCheck if one is negative and one is positive:");

            //I didn't realize it would calculate the results within the console.writeline but that's an 
            //easier way
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            testString(x, y);  //uses first function
            testBool(x, y);


        }
        //I created a function to check and output the answer. Couldn't figure out how to return true or false with boolean function
        public static void testString(int x, int y)
        {
            if (y < 0 && x > 0 || x < 0 && y > 0)
            {
                bool test = true;
                Console.WriteLine(Convert.ToString(test));
            }
            else
            {
                bool test = false;
                Console.WriteLine(Convert.ToString(test));
            }
        }
        //different way to doing the first method
        public static bool testBool(int x, int y)
        {
            return (x < 0 && y > 0) || (x > 0 && y < 0);
        }
    }
}
