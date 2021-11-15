/*
//  Author: Jonathan Scholl
//  Date: 11/15/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop21
//  Description:  Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
*/
using System;

namespace ForLoops21
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables, prompt user, and store input
            int sumOfTerms = 0;
            string numberAsString = null;
            Console.Write("Input the number of terms: ");
            var userNumberTerms = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //loop for summation and print each term. 
            for (int x = 0; x < userNumberTerms; x++)
            {
                numberAsString += "9";
                Console.Write($"{numberAsString} ");
                sumOfTerms += Convert.ToInt32(numberAsString);
            }

            //output results
            Console.WriteLine($"\nSum of {userNumberTerms} terms: {sumOfTerms}");
        }
    }
}
