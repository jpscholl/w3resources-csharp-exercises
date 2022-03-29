/*
//  Author: Jonathan Scholl
//  Date: 3/28/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String4.cs
*/
Console.Write("Input a string: ");
string userInput = Console.ReadLine();

//method 1
foreach (char letter in userInput.Reverse())
{
    Console.Write($"{letter} ");
}

//method 2
Console.WriteLine();
for (int i = userInput.Length - 1; i >= 0; i--)
{
    Console.Write($"{userInput[i]} ");
}
