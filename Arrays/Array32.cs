/*
//  Author: Jonathan Scholl
//  Date: 2/15/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php
*/

Console.Write("Input size of square matrix: ");
int matrixSize = Convert.ToInt32(Console.ReadLine());
int[,] squareMatrix = new int[matrixSize, matrixSize];
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write("Input element: ");
        squareMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("\nOdd numbers");
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        if (squareMatrix[i, j] % 2 == 1)
        {
            Console.WriteLine($"{squareMatrix[i, j]}");
        }    
    }
}
