/*
//  Author: Jonathan Scholl
//  Date: 9/10/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic-algo/index.php exercise 50
//  Description: Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
//  Note: I also added a way to find if the first digits are the same
*/
using System;

namespace BasicAlgorithm50
{
    class Program
    {
        //method calculates the first digit of a number from passed integer
        public static int calcFirstDigit(int arrElement)
        {
            int firstDigit;

            if (arrElement >= 10)
            {
                firstDigit = arrElement /= 10;
            }
            else
            {
                firstDigit = arrElement;
            }      
            return firstDigit;
        }
        //checks to see if input integer have same first digit
        public static bool sameFirstDigit(int[] num)
        {
            //stores results after integer first digit is calculated
            int x = calcFirstDigit(num[0]);
            int y = calcFirstDigit(num[1]);
            int z = calcFirstDigit(num[2]);

            //returns true if any of these match (at least 2), false if no match
            return x  == y  || x  == z || y  == z;
        }
        //method to check last digits integers in an array
        public static bool sameLastDigit(int[] num)
        {
            //(number modulus 10) calculates the right most digit of the number
            return num[0] % 10 == num[1] % 10 || num[0] % 10 == num[2] % 10 || num[1] % 10 == num[2] % 10;
        }

        static void Main(string[] args)
        {
            // varaiables
            int[] numArray = new int[3];
            int counter = 0;

            //prompt user for input
            Console.WriteLine("Enter 3 Integers:");

            // makes sure only three integers are input based on counter
            while (counter < 3)
            {
                //if the the user input is an integer, then stored into element inside numArray then counter incremented
                if (int.TryParse(Console.ReadLine(), out numArray[counter]))
                    counter++;
                //else...let user know they didn't enter proper number
                else
                    Console.WriteLine("You didn't enter a number! Please enter again!");
            }

            //prints results based on user input data
            Console.WriteLine("2 or more integers have same last digit: " + sameLastDigit(numArray));
            Console.WriteLine("2 or more integers have same first digit: " + sameFirstDigit(numArray));
        }
    }
}
