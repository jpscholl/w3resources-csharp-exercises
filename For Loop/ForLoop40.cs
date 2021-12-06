/*
//  Author: Jonathan Scholl
//  Date: 12/6/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop40
//  Description:  Write a C# Sharp Program to display the following pattern using the alphabet.
*/
using System;

namespace ForLoop40
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            char letter = 'A';
            int ctr = 1;

            //prompt user and store input
            Console.Write("Input the number of letters: \n");
            int userInputNum = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= userInputNum; i++)
            {
                //loop for first range of letters stops at input number letter
                for (int j = 0; j <= (ctr / 2); j++)
                {
                    Console.Write("{0} ", letter++);
                }
                letter--;
                letter--;

                //loop for after top reaches the final letter based on input (reverse the letters)
                for (int j = 0; j < (ctr / 2); j++)
                {
                    Console.Write("{0} ", letter--);
                }
                ctr = ctr + 2;
                //resets letter to A and creates space
                letter = 'A';
                Console.WriteLine();
            }
        }
    }
}
