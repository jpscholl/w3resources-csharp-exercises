/*
//  Author: Jonathan Scholl
//  Date: 3/28/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String3.cs
*/
Console.Write("Input a string: ");
string userInput = Console.ReadLine();

for (int i = 0; i < userInput.Length; i++)
{
    Console.Write($"{userInput[i]} ");
}
