/*
//  Author: Jonathan Scholl
//  Date: 4/20/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 59
//  Description: Write a C# program to check whether it is possible to create a strictly 
//  increasing sequence from a given sequence of integers as an array
*/
using System;

namespace BasicExercise59
{
    class Program
    {
        public static bool checkSequenceIncrease(int[] sequence)
        {
            int x = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                    x++;
                if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
                    x++;
            }
            return x <= 2;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of array: ");
            int arraySize = Convert.ToInt32(Console.In.ReadLine());

            Console.WriteLine("\nInput number for int array: ");
            int[] userInput = new int[arraySize];

            

            for (int i = 0; i < userInput.Length; i++)
            {
                userInput[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            Console.WriteLine("\nUser input array: [{0}]", string.Join(", ",userInput));

            Console.WriteLine("Is the array in sequence: " + checkSequenceIncrease(userInput));

        }
    }
}
