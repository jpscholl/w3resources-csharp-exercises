/*
//  Author: Jonathan Scholl
//  Date: 3/28/2022
//  Project: https://www.w3resource.com/csharp-exercises/string/index.php
//  String2.cs
*/
int count = 0;
Console.Write("Input a string: ");
string userInput = Console.ReadLine();

//counts length without using libary
for (int i = 0; i < userInput.Length; i++)
{
    count++;
}

Console.WriteLine($"Length of the string: {count}");
