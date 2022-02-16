/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array 36
*/

int[] givenArray1 = {1, 2, 3, 4, 5};
int[] givenArray2 = {2, 3, 4, 5, 7};


Console.WriteLine("Given array1: ");
foreach (int i in givenArray1)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\nGiven array2: ");
foreach (int i in givenArray2)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

Console.WriteLine($"Consecutive numbers: {isConsecutive(givenArray1)}");
Console.WriteLine($"Consecutive numbers: {isConsecutive(givenArray2)}");

static bool isConsecutive(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] + 1 != arr[i + 1]) return false;
    }
    return true;
}
