/*
//  Author: Jonathan Scholl
//  Date: 2/17/2021
//  https://www.w3resource.com/csharp-exercises/basic/index.php
*/
using System;

namespace BasicExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //after seeing some examples I realized that Console.writeline will automatically do math within the parenthesis

            Console.WriteLine(-1 + 4 * 6);                  //23
            Console.WriteLine((35 + 5) % 7);                //5
            Console.WriteLine(14 + -4 * 6 / 11);            //12
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);      //3

            //automatically uses the proper order of operation and outputs proper results
        }
    }
}
