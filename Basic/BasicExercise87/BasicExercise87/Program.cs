/*
//  Author: Jonathan Scholl
//  Date: 6/24/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 87
//  Description: Write a C# Sharp program to reverse a boolean value.
*/
using System;

namespace BasicExercise87
{
    class Program
    {
        public static bool reverseBool(bool boolean)
        {
            /*
            if (boolean == true)
            {
                boolean = false;
            }
            else
            {
                boolean = true;
            }
            return boolean;
            */

            //same thing just one line
            return !boolean;
        }
        static void Main(string[] args)
        {
            bool cat = true;
            bool dog = false;

            Console.WriteLine("You have a kitty: " + cat);

            Console.WriteLine("I take kitty away from you...");

            Console.WriteLine("You have a kitty: " + reverseBool(cat));

            Console.WriteLine("You have a doggy: " + dog);

            Console.WriteLine("I give you a doggy...");

            Console.WriteLine("You have a doggy: " + reverseBool(dog));
        }
    }
}
