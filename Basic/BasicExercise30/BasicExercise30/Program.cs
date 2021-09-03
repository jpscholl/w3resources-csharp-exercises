/*
//  Author: Jonathan Scholl
//  Date: 3/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 30
//  Description: Write a C# program to convert a hexadecimal number to decimal number.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
public class Exercise30
{
    public static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hexNum = Console.ReadLine();

        Console.WriteLine("Hexadecimal number: " + hexNum);
        int decValue = int.Parse(hexNum, NumberStyles.HexNumber);
        Console.WriteLine("Converted to-");
        Console.WriteLine("Decimal number: " + decValue);

    }
}
