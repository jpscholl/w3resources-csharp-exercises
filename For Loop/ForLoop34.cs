//  Author: Jonathan Scholl
//  Date: 11/26/2021
//  Project: https://www.w3resource.com/csharp-exercises/for-loop/index.php ForLoop34
//  Description: Write a program in C# Sharp to find the prime numbers within a range of numbers
*/
using System;

namespace ForLoop34
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store input variables
            Console.Write("Input start range: ");
            int startRange = int.Parse(Console.ReadLine());

            Console.Write("Input end range: ");
            int endRange = int.Parse(Console.ReadLine());

            //output range
            Console.Write("Prime numbers in range: ");
            printPrimeRange(startRange, endRange);
        }

        //method to print out prime numbers within range
        public static void printPrimeRange(int startNum, int endNum)
        {
            int currentNum;

            for (currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                int counter = 0;

                for (int x = 2; x <= currentNum / 2; x++)
                {
                    if(currentNum % x == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && currentNum != 1) Console.Write($"{currentNum} ");
            }  
        }
    }
}
