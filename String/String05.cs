/*
//  Author: Jonathan Scholl
//  Date: 3/28/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String5.cs
*/

//variables
int wordCount = 1;

//prompt user and store input
Console.Write("Input a string: ");
string userInput = Console.ReadLine();

//calculate word count
for(int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] == ' ')
    {
        wordCount++;
    }
}

//output word count
Console.WriteLine($"The word count is {wordCount}");
