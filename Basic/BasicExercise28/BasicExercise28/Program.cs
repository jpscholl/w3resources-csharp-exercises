/*
//  Author: Jonathan Scholl
//  Date: 3/1/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 28
//  Description: Write a C# program to reverse the words of a sentence.
//  Comments: breaking down answers to learn how the code works
*/
using System;
using System.Collections.Generic;
public class Exercise28
{
    public static void Main()
    {
        //prompt user
        Console.Write("Enter a string: ");
        //store user input
        string userInput = Console.ReadLine();

        //prints original string
        Console.WriteLine("\nOriginal String: " + userInput);
        //
        string result = "";
        List<string> wordsList = new List<string>();
        string[] words = userInput.Split(new[] {" "}, StringSplitOptions.None);
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i] + " ";
        }
        wordsList.Add(result);
        foreach (String s in wordsList)
        {
            Console.WriteLine("\nReverse String: " + s);
        }
    }
}

