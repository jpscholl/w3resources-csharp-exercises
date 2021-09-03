/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 24
//  Description: Write a C# program to find the longest word in a string.
*/
using System;

namespace BasicExercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user for input and stores into string variable
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();

            //splits the string into separate elements based on spaces and stores into string arrray
            string[] words = userInput.Split(new[] { " " }, StringSplitOptions.None);
                string word = "";   //stores future words
                int ctr = 0;        //counter
            foreach (string s in words)     //loops through each separated word inside words array
            {
                if (s.Length > ctr)         //checks to see if current array element is greater than counter (auto stores first word)
                {
                    word = s;               //if the element is greater than previous, it's stored here
                    ctr = s.Length;         //the ctr is updated to equal the length of the new longest word
                }
            }

            //outputs the longest word that was last stored
            Console.WriteLine(word);

        }
    }
}
