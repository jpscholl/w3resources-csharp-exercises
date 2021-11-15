/*
//  Author: Jonathan Scholl
//  Date: 11/15/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop20
//  Description: Write a program in C# Sharp to display the pattern like pyramid using an asterisk 
//  and each row contain an odd number of an asterisks.
*/
using System;

namespace ForLoop20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user and store input
            Console.Write("Number of rows: ");
            int userRows = int.Parse(Console.ReadLine());

            //print asterisk pyramid based on input
            Console.WriteLine("Building Pyramid");

            for (int x = 0; x <= userRows - 1; x++)
            {
                for (int space = 1; space <= userRows - x; space++) //loop for spaces
                Console.Write(" ");

                for (int y = 1; y <= x * 2 - 1; y++)                //asterisks per row
                    Console.Write("*");
                
                Console.WriteLine();                                //new row
            }
        }
    }
}
