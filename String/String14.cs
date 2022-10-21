/*
//  Author: Jonathan Scholl
//  Date: 10/20/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String14.cs
*/
Console.WriteLine("Input string: ");
string userInputString = Console.ReadLine();

Console.WriteLine("\nSearch for string: ");
string searchString = Console.ReadLine();

if (userInputString.Contains(searchString))
    Console.WriteLine($"\n{userInputString} contains {searchString} as a substring.");
else
    Console.WriteLine($"\n{userInputString} doesn't contain {searchString} as a substring.");
