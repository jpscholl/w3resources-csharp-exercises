/*
//  Author: Jonathan Scholl
//  Date: 5/11/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 79
//  Description: Write a C# Sharp program to convert an integer to string and a string to an integer.
*/
using System;
using System.Linq;

namespace BasicExercise79
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for integer and store value in integer variable
            Console.WriteLine("Please enter a number: ");
            int userInt = Convert.ToInt32(Console.ReadLine());
            //show value and type of the integer variable
            Console.WriteLine("Original value and type of userInt: {0} is " + userInt.GetType(), userInt );
            //conversion of int to string
            string convertInt = Convert.ToString(userInt);
            //output converted stuff
            //show value and type of the string variable
            Console.WriteLine("Original value and type of convertInt: {0} is " + convertInt.GetType(), convertInt);

            Console.WriteLine();

            //prompt user for integer and store value in string variable
            Console.WriteLine("Please enter a number: ");
            string userString = Console.ReadLine();
            //show value and type of the string variable
            Console.WriteLine("Original value and type of userInt: {0} is " + userString.GetType(), userString);
            //conversion of int to string
            int convertString = Convert.ToInt32(userString);
            //output converted stuff
            //show value and type of the string variable
            Console.WriteLine("Original value and type of convertInt: {0} is " + convertString.GetType(), convertString);
        }
    }
}
