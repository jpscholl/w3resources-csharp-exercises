/*
//  Author: Jonathan Scholl
//  Date: 4/19/2021
//  Exercise: https://www.w3resource.com/csharp-exercises/basic/index.php exercise 58
//  Description: Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range
*/
using System;

namespace BasicExercise58
{
    class Program
    {
        public static int consecutive_array(int[] input_Array)
        {
            Array.Sort(input_Array);
            int ctr = 0;
            for (int i = 0; i < input_Array.Length - 1; i++)
            {
                ctr += input_Array[i + 1] - input_Array[i] - 1;
            }
            return ctr;
        }

        public static void Main()
        {
            Console.WriteLine(consecutive_array(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(consecutive_array(new int[] { 0, 10 }));
        }
    }
}
