/*
//  Author: Jonathan Scholl
//  Date: 2/9/2022
//  Project: https://www.w3resource.com/csharp-exercises/array/index.php Array23
*/

//variables
int sumOfRightDiag = 0;

//input square matrix size
Console.Write("Size of the square matrix: ");
int matrixSize = Convert.ToInt32(Console.ReadLine());

//variables
int[,] squareMatrix = new int[matrixSize , matrixSize];

//input elements of square matrix
for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        Console.Write("Input element: ");
        squareMatrix[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

//output square matrix
Console.WriteLine("\nOrginal Matrix:");
for (int i = 0; i < squareMatrix.GetLength(0); i++)
{
    for (int j = 0; j < squareMatrix.GetLength(1); j++)
    {
        Console.Write($"{squareMatrix[i, j]} " );
    }
    Console.WriteLine();
}

//calculation of summation of right diagonal elements
for (int i = 0, j = squareMatrix.GetLength(0) - 1; i < squareMatrix.GetLength(0); i++, j--)
{
    sumOfRightDiag += squareMatrix[i, j];
}

//output answer
Console.WriteLine($"Sum of right diagonal: {sumOfRightDiag}");
