/*
//  Author: Jonathan Scholl
//  Date: 11/10/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php For Loop 13
//  Description: Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1.
*/
using System;

namespace ForLoop13
{
    class Program
    {
        static void Main(string[] args)
        {   
            int Space, Number, userInputNumber;
            int k = 1;

            Console.Write("Input Number: ");
            userInputNumber = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Print paramid");
            for (int i = 1; i <= userInputNumber; i++) // Total number of layer for pramid  
            {
                for (Space = 1; Space <= (userInputNumber - i); Space++) // Loop For Space  
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value  
                {
                    Console.Write($"{k} ");
                    k++;    //increment inside this for loop increases output number individually
                }
                //k++ //increment here increases number per row
                Console.WriteLine();
            }
        }
    }
}
