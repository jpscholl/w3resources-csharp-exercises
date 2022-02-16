/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/

int[] num1 = {3, 2, 6, 7, 2, 1 };

foreach (int num in num1)
{
    Console.Write($"{num} ");
}

Console.WriteLine();
Array.Sort(num1);

foreach (int num in num1)
{
    Console.Write($"{num} ");
}

Console.WriteLine($"\nSum of lowest integers: {num1[0] + num1[1]}");
