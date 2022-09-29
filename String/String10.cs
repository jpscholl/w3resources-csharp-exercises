/*
//  Author: Jonathan Scholl
//  Date: 9/29/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String10.cs
*/
using System;

namespace String10
{
    public class Program
    {
        //function for checking max occuring characters
        static char getMaxOccuringString(string inputString)
        {
            //variables
            int[] count = new int[256];  //array to count all individual characters
            int max = -1;                // Initialize max count
            char result = ' ';           // Initialize result

            //count based on length of input string passed to function
            int length = inputString.Length;
            for (int i = 0; i < length; i++)
            {
                count[inputString[i]]++;
            }

            // Traversing through the string and
            // maintaining the count of each character
            for (int i = 0; i < length; i++)
            {
                if (max < count[inputString[i]])
                {
                    max = count[inputString[i]];
                    result = inputString[i];
                }
            }
            //return char with most occurences
            return result;
        }

        //main function
        static void Main(string[] args)
        {
            Console.Write("Please input string: ");
            string userInputString = Console.ReadLine();

            Console.WriteLine($"Max occuring character in the string is: {getMaxOccuringString(userInputString)}");
        }
        
    }
}
