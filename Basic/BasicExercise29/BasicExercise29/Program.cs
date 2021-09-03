/*
//  Author: Jonathan Scholl
//  Date: 3/3/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 29
//  Description: Write a C# program to find the size of a specified file in bytes.
//  Comment: Not too familiar with FileInfo, so I decided to explore more in depth
//  Many interesting and useful properties available.
*/
using System;
using System.IO;

namespace BasicExercise29
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter file path: ");
            var filePath = Console.ReadLine();

            FileInfo file = new FileInfo(filePath);
            Console.WriteLine("Selected file: " + file.Name);
            Console.WriteLine("Size of a file: " + file.Length.ToString() + " bytes");
            Console.WriteLine("Last accesssed: " + file.LastAccessTime);
            Console.WriteLine("Last write time: " + file.LastWriteTime);
            Console.WriteLine("Creation date: " + file.CreationTime);
            Console.WriteLine("Does this file exist: " + file.Exists);

        }
    }
}
