/*
//  Author: Jonathan Scholl
//  Date: 4/27/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 64
//  Description: Write a C# Sharp program to get the file name (including extension) from a given path.
*/
using System;
using System.Linq;
using System.IO;


namespace BasicExercise64
{
 
    class Program
    {public static string test(string file_path)
    {
           return Path.GetFileName(file_path);
    }
        static void Main(string[] args)
        {
            string file_path;
            file_path = "J:/Action!/";
            Console.WriteLine(test(file_path));
        }
    }
}
